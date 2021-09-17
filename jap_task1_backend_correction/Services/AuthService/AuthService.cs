using JapTask1BackendCorrection.Data;
using JapTask1BackendCorrection.DTO.User;
using JapTask1BackendCorrection.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace JapTask1BackendCorrection.Services.AuthService
{
    public class AuthService: IAuthService
    {
        private readonly DataContext _context;
        private readonly IConfiguration _configuration;

        public AuthService(DataContext context, IConfiguration configuration)
        {
            _configuration = configuration;
            _context = context;
        }

        public async Task<ServiceResponse<GetUserDTO>> Login(string email, string password)
        {
            ServiceResponse<GetUserDTO> response = new();
            User user = await _context.Users.FirstOrDefaultAsync(x => x.Email.ToUpper().Equals(email.ToUpper())); 
              
            if (user == null)
            {
                throw new Exception("User not found.");
            }
            else if (!VerifyPasswordHash(password, user.Hash, user.Salt))
            {
                throw new Exception("Wrong password");
            }
            else
            {
                GetUserDTO userLogin = new();
                userLogin.Token = CreateToken(user);
                userLogin.FirstName = user.FirstName;
                userLogin.LastName = user.LastName;

                response.Success = true;
                response.Data = userLogin;
                response.Message = "Login successful!";
            }

            return response;

        }

        public async Task<ServiceResponse<int>> Register(User user, string password)
        {
            if (await UserExists(user.Email))
                throw new Exception("User already exists.");
                
            CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);

            user.Hash = passwordHash;
            user.Salt = passwordSalt;

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            
            return new ServiceResponse<int> { Data = user.Id, Message = "Registered successfully!", Success = true };
        }

        public async Task<bool> UserExists(string email) => await _context.Users.AnyAsync(x => x.Email.ToUpper() == email.ToUpper());

        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using var hmac = new System.Security.Cryptography.HMACSHA512();
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        }

        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt);
            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            
            for (int i = 0; i < computedHash.Length; i++)
                 if(computedHash[i] != passwordHash[i]) return false;
            
            return true;
        }

        private string CreateToken(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Email)
            };

            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:Token").Value)
            );

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
