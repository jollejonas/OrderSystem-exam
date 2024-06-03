using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem.Models
{
    public class Planner : User
    {
        public override string WelcomeMessage()
        {
            return $"Velkommen til {Name}! Din rolle er planlægger, du har derfor adgang til at redigere ordrer.";
        }
        public override bool CanCreateOrders() => false;
        public override bool CanHandleOrders() => false;
        public override bool CanPlanSchedule() => true;
    }
}
