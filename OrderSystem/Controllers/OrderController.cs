using OrderSystem.Data;
using OrderSystem.Models;

namespace OrderSystem.Controllers
{
    public class OrderController
    {
        private readonly OrderSystemContext _context;

        public OrderController(OrderSystemContext context)
        {
            _context = context;
        }

        public IEnumerable<object> GetAllOrders()
        {
            if(_context.Orders == null)
            {
                return null;
            }
            else
            {
                return _context.Orders.ToList();
            }
        }

        public void CreateOrder(string name, string description, int createdByUserId)
        {
            var order = new Order
            {
                Name = name,
                Description = description,
                CreatedAt = DateTime.Now,
                CreatedBy = createdByUserId,
                Status = "Ny"
            };

            _context.Orders.Add(order);
            _context.SaveChanges();
        }
    }
}
