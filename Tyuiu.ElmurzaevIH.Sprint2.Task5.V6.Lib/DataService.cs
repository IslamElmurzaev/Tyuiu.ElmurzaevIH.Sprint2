using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ElmurzaevIH.Sprint2.Task5.V6.Lib
{
    public class DataService : ISprint2Task5V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            string res, cardSuit, cardValue;

            switch (value1)
            {
                case 1:
                    cardSuit = "пик";
                    break;
                case 2:
                    cardSuit = "треф";
                    break;
                case 3:
                    cardSuit = "бубен";
                    break;
                case 4:
                    cardSuit = "черв";
                    break;
                default:
                    throw new ArgumentException($"Масть карты должна быть от 1 до 4. Значение {value1}");

            }

            switch (value2)
            {
                case 6:
                    cardValue = "Шестерка";
                    break;
                case 7:
                    cardValue = "Семерка";
                    break;
                case 8:
                    cardValue = "Восьмерка";
                    break;
                case 9:
                    cardValue = "Девятка";
                    break;
                case 10:
                    cardValue = "Десятка";
                    break;
                case 11:
                    cardValue = "Валет";
                    break;
                case 12:
                    cardValue = "Дама";
                    break;
                case 13:
                    cardValue = "Король";
                    break;
                case 14:
                    cardValue = "Туз";
                    break;
                default:
                    throw new ArgumentException($"Достоинство картдолжно быть от 6 до 14. Значение {value2}");
            }

            return cardValue + ' ' + cardSuit;
        }
    }
}
