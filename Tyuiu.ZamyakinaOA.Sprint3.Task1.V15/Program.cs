using Tyuiu.ZamyakinaOA.Sprint3.Task1.V15.Lib;

namespace Tyuiu.ZamyakinaOA.Sprint3.Task1.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 ds = new Class1();
            Console.Title = "Спринт #3 | Выполнила: Замякина О. А. | ПКТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнила: Замякина Олеся Андреевна | ПКТб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет произведение *");
            Console.WriteLine("* ряда по формуле, при х=2                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int value = 2;
            int startValue = 1;
            int stopValue = 5;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.GetMultiplySeries(value, startValue, stopValue));

            Console.ReadKey();
        }
    }
}