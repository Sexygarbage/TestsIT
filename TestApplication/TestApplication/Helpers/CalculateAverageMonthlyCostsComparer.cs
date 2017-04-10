using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.Classes;

namespace TestApplication.Helpers
{
    public class CalculateAverageMonthlyCostsComparer : IEqualityComparer<PaidService>
    {
        public bool Equals(PaidService x, PaidService y)
        {
            return x.calculateAverageMonthlyCosts() == y.calculateAverageMonthlyCosts();
        }

        public int GetHashCode(PaidService x)
        {
            return x.calculateAverageMonthlyCosts().GetHashCode();
        }
    }
}
