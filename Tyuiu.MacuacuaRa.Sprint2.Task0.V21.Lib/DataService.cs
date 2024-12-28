using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MacuacuaRa.Sprint2.Task0.V21.Lib
{
    public class DataService : ISprint2Task0V21
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x + 1000 == y;  // 1705 + 1000 == 775 => false
            res[1] = x + 1000 == y;  // 1705 + 1000 != 775 => true
            res[2] = x - 500 < y;    // 1705 - 500 < 775 => false
            res[3] = x - 500 >= y;    // 1705 - 500 > 775 => true
            res[4] = x - 500 <= y;   // 1705 - 500 <= 775 => false
            res[5] = x - 500 <= y;   // 1705 - 500 >= 775 => true

            return res;
        }
    }
}
