using JapTask1BackendCorrection.DTO.User;
using JapTask1BackendCorrection.Entities;
using System.Threading.Tasks;

namespace JapTask1BackendCorrection.Services.AuthService
{
    public interface IAuthService
    {
        Task<ServiceResponse<int>> Register(User user, string password);
        Task<ServiceResponse<GetUserDTO>> Login(string email, string password);

    }
}
