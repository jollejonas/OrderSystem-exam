using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem.Models
{
    public class Customer : User
    {
        public override string WelcomeMessage()
        {
            return $"Velkommen til {Name}! Din rolle er kunde, du har derfor adgang til at oprette ordrer.";
        }

        public override bool CanCreateOrders() => true;
        public override bool CanHandleOrders() => false;
        public override bool CanPlanSchedule() => false;
    }
}
