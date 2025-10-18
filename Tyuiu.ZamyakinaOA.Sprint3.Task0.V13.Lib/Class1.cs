using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZamyakinaOA.Sprint3.Task0.V13.Lib
{
    public class Class1 : ISprint3Task0V13
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double s = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                s = s + ((Math.Pow(value, i) + 0.5) * Math.Cos(i));
            }
            return s;
        }
    }
}
