using ClockDB.Data;
using ClockDB.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace ClockDB.Repository
{
    public class LoginRepository
    {
        private readonly ClockDBContext _context;
        public LoginRepository(ClockDBContext context) {
            
            _context = context;
        }
        public User getUser(string username, string password)
        {
            
            IQueryable<User> queryResult = _context.UserTable
                .Where(u => u.UserName == username && u.Password == password)
                .Join(_context.Role, u => u.id, r => r.id, (u, r) => new User { FullName = u.FullName, roleName = r.roleName });

            
            User userWithRole = queryResult.FirstOrDefault();

            return userWithRole;
        }
    }


}
