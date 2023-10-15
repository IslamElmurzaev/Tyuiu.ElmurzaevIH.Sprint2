using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ElmurzaevIH.Sprint2.Task7.V11.Lib
{
    public class DataService : ISprint2Task7V11
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) && ((x < 0) && (x >= -1) && ((y <= 1) && (y >= -1))))
            {
                res = true;
            }
            else if (x >= 0 && y >= x && x*x + y*y <= 1)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
