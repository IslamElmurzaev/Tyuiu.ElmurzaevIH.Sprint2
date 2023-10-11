using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ElmurzaevIH.Sprint2.Task4.V19.Lib
{
    public class DataService : ISprint2Task4V19
    {
        public double Calculate(double x, double y)
        {         
            double firstExpressionValue = Math.Pow((6 + (4 / Math.Pow(y, 2))), x);

            double secondExpressionNumerator =  Math.Pow(x, 2) - Math.Cos(Math.Pow(y, 2)) + 10;
            double secondExpressionDenominator = Math.Pow(y, 2) - Math.Sin(Math.Pow(y, 2)) + 12;
            double secondExpressionValue = secondExpressionNumerator / secondExpressionDenominator;

            double result = x / 2 < y - 6 ? firstExpressionValue : secondExpressionValue;

            return Math.Round(result, 3);
        }
    }
}
