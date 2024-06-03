using OrderSystem.Data;
using OrderSystem.Models;

namespace OrderSystem.Controllers
{
    public class UserController
    {
        private readonly OrderSystemContext _context;

        public UserController(OrderSystemContext context)
        {
            _context = context;
        }

        public User ValidateUser(string username, string password)
        {
            return _context.Users.SingleOrDefault(u => u.Username == username && u.Password == password);
        }
    }
}
