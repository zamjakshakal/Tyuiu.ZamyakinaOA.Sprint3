using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZamyakinaOA.Sprint3.Task2.V18.Lib
{
    public class Class1 : ISprint3Task2V18
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
             double MultiplySeries = 1;
             do
             {
                 MultiplySeries = MultiplySeries * (Math.Cos(value) + (Math.Pow((startValue / 8), 3)));
                 startValue++;
             } while (startValue <= stopValue);
            return MultiplySeries;
        }   
    }
}
