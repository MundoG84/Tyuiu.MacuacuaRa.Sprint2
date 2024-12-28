using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MacuacuaRa.Sprint2.Task7.V2.Lib
{
    public class DataService : ISprint2Task7V2
    {
        public bool CheckDotInShadedArea(double x, double y)
        {

            bool result;

            if (x >= -1 && x <= 1 && y >= x/2 && Math.Pow(x,2)+Math.Pow(y,2)<=1)
            {
                result = false;
            }
            else
            {
                result = true;
            }
            return result;
        }
    }
}
