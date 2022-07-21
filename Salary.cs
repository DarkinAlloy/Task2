using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Salary
    {
        public static decimal Salary_calculate(decimal gross)
        {
            decimal net;
            if (gross > 3000)
            {
                net = gross - ((gross - 1000) / 10) - (2000 * 15 / 100);
                return net;
            }
            else if (gross > 1000 && gross < 3000)
            {
                net = gross - ((gross - 1000) / 10) - ((gross - 1000) * 15 / 100);
                return net;
            }
                
            return net = gross;
        }
    }
}
