using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem.Models
{
    public class Operator : User
    {
        public override string WelcomeMessage()
        {
            return $"Velkommen til {Name}! Din rolle er operatør, du har derfor adgang til at starte ordrer.";
        }
        public override bool CanCreateOrders() => false;
        public override bool CanHandleOrders() => true;
        public override bool CanPlanSchedule() => false;
    }
}
