using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ElmurzaevIH.Sprint2.Task3.V21.Lib
{
    public class DataService : ISprint2Task3V21
    {
        public double Calculate(double x)
        {
            double res;

            if (x > 1)
            {
                res = x * Math.Pow(((x + 9) / (x - 1)), x);
            }

            else if (x == 0)
            {
                res = 10.0 / 12.0;
            }

            else if (x > -25 && x < 2)
            {
                res = Math.Pow(1 + (1/Math.Pow(x, 2)), x);
            }
            else
            {
                res = x + 10 * x - (1 / x);
            }

            return Math.Round(res, 3);
        }
    }
}
