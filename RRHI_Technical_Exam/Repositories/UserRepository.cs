using Microsoft.EntityFrameworkCore;
using RRHI_Technical_Exam.Interfaces;
using RRHI_Technical_Exam.Models;

namespace RRHI_Technical_Exam.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DbContext _context;

        public UserRepository(DbContext context)
        {
            _context = context;
        }

        public Task AddUserAsyng(User user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUserAsyngAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _context.User.ToListAsync();
        }

        public Task<User> GetUserByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserAsyngAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
