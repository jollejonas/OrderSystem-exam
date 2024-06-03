using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem.Models
{
    public abstract class User
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public abstract string WelcomeMessage();
        public abstract bool CanCreateOrders();
        public abstract bool CanHandleOrders();
        public abstract bool CanPlanSchedule();
    }
}
