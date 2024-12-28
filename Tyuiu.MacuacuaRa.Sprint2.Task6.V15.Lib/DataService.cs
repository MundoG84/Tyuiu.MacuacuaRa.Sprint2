using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MacuacuaRa.Sprint2.Task6.V15.Lib
{
    public class DataService : ISprint2Task6V15
    {
        public string FindDayName(int k)
        {
            int dayOfWeek = k % 7;

            // Используем сокращенную форму записи switch
            return dayOfWeek switch
            {
                1 => "Понедельник",
                2 => "Вторник",
                3 => "Среда",
                4 => "Четверг",
                5 => "Пятница",
                6 => "Суббота",
                0 => "Воскресенье",  // k % 7 = 0 будет означать воскресенье
                _ => throw new ArgumentException("Число k должно быть в диапазоне от 1 до 365")
            };
        }
    }
}
