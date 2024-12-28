using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MacuacuaRa.Sprint2.Task5.V9.Lib
{
    public class DataService : ISprint2Task5V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            int daysInMonth;

            // Определяем количество дней в текущем месяце с использованием оператора switch
            switch (m)
            {
                case 1:  // Январь
                case 3:  // Март
                case 5:  // Май
                case 7:  // Июль
                case 8:  // Август
                case 10: // Октябрь
                case 12: // Декабрь
                    daysInMonth = 31;
                    break;
                case 4:  // Апрель
                case 6:  // Июнь
                case 9:  // Сентябрь
                case 11: // Ноябрь
                    daysInMonth = 30;
                    break;
                case 2:  // Февраль
                         // Для февраля примем, что год невисокосный
                    daysInMonth = 28;
                    break;
                default:
                    return "Некорректный номер месяца";
            }

            // Переход к следующему дню
            if (n < daysInMonth)
            {
                n++;
            }
            else
            {
                n = 1; // Если день последний в месяце, начинаем с 1
                m = m == 12 ? 1 : m + 1; // Если месяц последний, переходим к январю
            }

            // Формируем результат
            string result = $"{m:00}.{n:00}";
            return result;
        }
    }
}
