using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.Classes
{
    class FixedMonthlyCostPaidService : PaidService
    {
       

        public FixedMonthlyCostPaidService(string id, string name, double costs)
        {
            base.id = id;
            base.name = name;
            base.costs = costs;
        }

        public override double calculateAverageMonthlyCosts()
        {
            return costs;
        }
    }
}
