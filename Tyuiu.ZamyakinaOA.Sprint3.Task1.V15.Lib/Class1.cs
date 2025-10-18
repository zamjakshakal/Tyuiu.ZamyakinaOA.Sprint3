using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZamyakinaOA.Sprint3.Task1.V15.Lib
{
    public class Class1 : ISprint3Task1V15
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double s = 1;
            while (startValue <= stopValue)
            {
                s = s * ((value * value * startValue) + 1);
                startValue++;
            }
            return Math.Round(s, 3);
        }
    }
}
