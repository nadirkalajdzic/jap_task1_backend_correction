using jap_task1_backend_correction.DTO.User;
using jap_task1_backend_correction.Entities;
using System.Threading.Tasks;

namespace jap_task1_backend_correction.Services.AuthService
{
    public interface IAuthService
    {
        Task<ServiceResponse<int>> Register(User user, string password);
        Task<ServiceResponse<UserLoginDTO>> Login(string email, string password);

    }
}
