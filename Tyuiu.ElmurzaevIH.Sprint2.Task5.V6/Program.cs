using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ElmurzaevIH.Sprint2.Task5.V6.Lib;

namespace Tyuiu.ElmurzaevIH.Sprint2.Task5.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Ельмурзаев И.Х. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Ельмурзаев Ислам Хаважевич | ИИПб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Мастям игральных карт условно присвоены следующие порядковые номера:    *");
            Console.WriteLine("* масти «пики» — 1, масти «трефы» — 2, масти «бубны» — 3,масти «червы»—4, *");
            Console.WriteLine("* а достоинству карт: «валету» — 11, «даме» — 12, «королю» — 13,«тузу»—14 *");
            Console.WriteLine("* а достоинству карт: «валету» — 11, «даме» — 12, «королю» — 13,«тузу»—14 *");
            Console.WriteLine("* (порядковые номера карт остальных достоинств соответствуют их названиям:*");
            Console.WriteLine("* «шестерка», «девятка» и т. п.). По заданным номеру масти m (1 <= m <= 4)*");
            Console.WriteLine("* и номеру достоинства карты k (6 <= k <= 14) определить полное название  *");
            Console.WriteLine("* (масть и достоинство) соответствующей карты в виде «Дама пик»,          *");
            Console.WriteLine("* Шестерка бубен» и т. п.                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int cardSuitValue, cardValue;

            Console.WriteLine("Введите номер масти карты:");
            cardSuitValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер достоинства карты:");
            cardValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res;
            if ( ((cardSuitValue < 1) || (cardSuitValue > 4)) || ((cardValue < 6) || (cardValue > 14)) )
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = ds.FindCardNameAndValue(cardSuitValue, cardValue);
            }

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
