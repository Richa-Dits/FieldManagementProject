using FieldMgt.Core.DTOs.Request;
using FieldMgt.Core.DTOs.Response;
using System.Threading.Tasks;
namespace FieldMgt.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<UserManagerReponse> RegisterUserAsync(RegisterViewDTO model);
        Task<LoginManagerResponse> LoginUserAsync(LoginViewDTO model);
        Task<int> DeleteUser(string userName, string deletedBY);
    }
   
}
