using OrderSystem.Data;
using OrderSystem.Models;

namespace OrderSystem.Controllers
{
    public class MachineController
    { 
        private readonly OrderSystemContext _context;
        public MachineController(OrderSystemContext context)
        {
            _context = context;
        }

        public List<Machine> GetAllMachines()
        {
            return _context.Machines.ToList();
        }
    }
}
