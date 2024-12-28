using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MacuacuaRa.Sprint2.Task2.V9.Lib
{
    public class DataService : ISprint2Task2V9
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((x >= 9 && x <= 12) && (y >= 3 && y <= 11))
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
