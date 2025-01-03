using RRHI_Technical_Exam.Models;
using System.Net.Http.Headers;

namespace RRHI_Technical_Exam.Interfaces
{
    public interface IUserRepository
    {
        Task<PaginatedUsers> GetAllUsersAsync(int pageNumber, int pageSize);
        Task<User> GetUserByIdAsync(int id);
        Task AddUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task DeleteUserAsync(int id);
    }
}
