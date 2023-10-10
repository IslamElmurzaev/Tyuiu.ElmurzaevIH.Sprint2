using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ElmurzaevIH.Sprint2.Task2.V11.Lib
{
    public class DataService : ISprint2Task2V11
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if ((x >= 3 && x <= 5) && (y >= 3 && y <= 4)) //1
            {
                res = true;
            }

            else if ((x >= 6 && x <= 9) && (y >= 5 && y <= 10)) // 2
            {
                res = true;
            }

            else if ((x >= 11 && x <= 12) && (y >= 5 && y <= 11)) // 3
            {
                res = true;
            }

            else if ((x == 9) && (y >= 3 && y <= 4)) //4
            {
                res = true;
            }

            else if ((x >= 2 && x <= 5) && (y == 7)) //5
            {
                res = true;
            }

            else if ((x >= 3 && x <= 7) && (y == 11)) //6
            {
                res = true;
            }

            else if ((x == 7 && y == 12) || (x == 13 && y == 8)) //7 8
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
