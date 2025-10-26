using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZamyakinaOA.Sprint3.Task4.V28.Lib
{
    public class Class1 : ISprint3Task4V28
    {
        public double Calculate(int startValue, int stopValue)
        {
            double s = 0;
            double y;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    continue;
                }
                else
                {
                    y = (Math.Cos(x) + Math.Sin(x)) / x;
                    s += y;
                }
            }
            return s;
        }
    }
}
