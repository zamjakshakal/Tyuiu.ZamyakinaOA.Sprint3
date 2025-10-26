using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZamyakinaOA.Sprint3.Task5.V24.Lib
{
    public class Class1 : ISprint3Task5V24
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double SumSeries = 0;
            double SumSumSeries = 0;
            for (int i = startValue1; i <= stopValue1; i++)
            {
                SumSumSeries += SumSeries;
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    SumSeries += (Math.Pow(x, k) + 2) * (Math.Sin(k));
                }
            }
            return Math.Round(SumSumSeries, 3);
        }
    }
}
