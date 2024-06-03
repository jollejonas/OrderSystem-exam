using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem.Models
{
    public class Admin : User
    {
        public override string WelcomeMessage()
        {
            return $"Velkommen til {Name}! Din rolle er admin, du har derfor adgang til det hele.";
        }

        public override bool CanCreateOrders() => true;
        public override bool CanHandleOrders() => true;
        public override bool CanPlanSchedule() => true;
    }
}
