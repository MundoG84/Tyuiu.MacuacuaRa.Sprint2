using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MacuacuaRa.Sprint2.Task7.V2.Lib
{
    public class DataService : ISprint2Task7V2
    {
        public bool CheckDotInShadedArea(double x, double y)
        {

            bool result;

            if (x >= -1 && x <= 1 && y >= x/2 && y <= Math.Exp(x) && y <= Math.Exp(-x))
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
