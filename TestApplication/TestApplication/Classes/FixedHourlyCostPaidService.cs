using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.Classes
{
    public class FixedHourlyCostPaidService : PaidService
    {
        private const int HOURS = 24;
        private const int DAYS = 30;




        public FixedHourlyCostPaidService(string id, string name, double costs)
        {
            base.id = id;
            base.name = name;
            base.costs = costs;
        }

        public override double calculateAverageMonthlyCosts()
        {
            return Math.Round(DAYS * HOURS * costs);
        }
    }
}
