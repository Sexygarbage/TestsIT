using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.Classes
{
    public abstract class PaidService
    {
        public string id { get; set; }
        public string name { get; set; }
        public double costs { get; set; }

        public abstract double calculateAverageMonthlyCosts();
        
        public override string ToString()
        {
            return id + " / " + name + " / " + calculateAverageMonthlyCosts();
        }
    }
}
