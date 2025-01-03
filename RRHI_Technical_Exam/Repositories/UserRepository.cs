using Microsoft.EntityFrameworkCore;
using RRHI_Technical_Exam.Data;
using RRHI_Technical_Exam.Interfaces;
using RRHI_Technical_Exam.Models;

namespace RRHI_Technical_Exam.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDbContext _context;

        public UserRepository(UserDbContext context)
        {
            _context = context;
        }

        public async Task AddUserAsync(User user)
        {
            await _context.Users.AddAsync(user); 
            await _context.SaveChangesAsync();
        }

        public async Task UpdateUserAsync(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<PaginatedUsers> GetAllUsersAsync(int pageNumber, int pageSize)
        {
            var totalCount = await _context.Users.CountAsync();  // Get the total number of users
            var totalPages = (int)Math.Ceiling(totalCount / (double)pageSize); // Calculate total pages

            var users = await _context.Users
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();  // Fetch the users for the current page

            var paginationInfo = new Pagination
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = pageNumber
            };

            return new PaginatedUsers
            {
                Users = users,
                Pagination = paginationInfo
            };
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }
    }
}
