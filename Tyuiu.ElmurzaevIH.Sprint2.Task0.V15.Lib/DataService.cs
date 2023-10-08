using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ElmurzaevIH.Sprint2.Task0.V15.Lib
{
    public class DataService : ISprint2Task0V15
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] result = new bool[6];

            result[0] = x == y;
            result[1] = x - 2830 != y;
            result[2] = y < x;
            result[3] = x > y;
            result[4] = x <= y;
            result[5] = y >= x;

            return result;
        }
    }
}
