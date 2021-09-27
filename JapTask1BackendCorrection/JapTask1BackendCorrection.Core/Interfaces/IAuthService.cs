using JapTask1BackendCorrection.Core.DTO.User;
using JapTask1BackendCorrection.Core.Entities;
using JapTask1BackendCorrection.Core.Response;
using System.Threading.Tasks;

namespace JapTask1BackendCorrection.Core.Interfaces.AuthService
{
    public interface IAuthService
    {
        Task<ServiceResponse<int>> Register(User user, string password);
        Task<ServiceResponse<GetUserDTO>> Login(string email, string password);

    }
}
