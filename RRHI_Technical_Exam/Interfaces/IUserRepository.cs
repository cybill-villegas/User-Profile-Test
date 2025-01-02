using RRHI_Technical_Exam.Models;
using System.Net.Http.Headers;

namespace RRHI_Technical_Exam.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(int id);
        Task AddUserAsyng(User user);
        Task UpdateUserAsyngAsync(User user);
        Task DeleteUserAsyngAsync(int id);
    }
}
