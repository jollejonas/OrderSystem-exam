using Microsoft.EntityFrameworkCore;
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

        public List<Order> GetAllOrders()
        {
            if(_context.Orders == null)
            {
                return null;
            }
            else
            {
                return _context.Orders
                    .Include(o => o.MachineObject)
                    .Include(o => o.CreatedByUser)
                    .Include(o => o.EndedByUser)
                    .Include(o => o.LastEditByUser)
                    .ToList();
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

        public void UpdateOrder(int id, string status, int lastEditByUserId)
        {
            var order = _context.Orders.Find(id);

            if(order != null)
            {
                order.Status = status;
                order.LastEditBy = lastEditByUserId;
                order.LastEdit = DateTime.Now;

                _context.SaveChanges();
            }
        }

        public void UpdateOrder(int id, string status, int endedByUserId, int lastEditByUserId)
        {
            var order = _context.Orders.Find(id);

            if (order != null)
            {
                order.Status = status;
                order.LastEditBy = lastEditByUserId;
                order.LastEdit = DateTime.Now;
                order.EndedBy = endedByUserId;
                order.EndDate = DateTime.Now;
                _context.SaveChanges();
            }
        }
        public void UpdateOrder(int id, string name, int lastEditByUserId, string description, string status, DateTime startDate, int machineId)
        {
            var order = _context.Orders.Find(id);

            if(order != null)
            {
                order.Name = name;
                order.Description = description;
                order.LastEditBy = lastEditByUserId;
                order.LastEdit = DateTime.Now;
                order.Status = status;
                order.StartDate = startDate;
                order.Machine = machineId;

                _context.SaveChanges();
            }
        }
    }
}
