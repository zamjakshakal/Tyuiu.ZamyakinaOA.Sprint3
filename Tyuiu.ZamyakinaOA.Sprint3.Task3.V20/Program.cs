using Tyuiu.ZamyakinaOA.Sprint3.Task3.V20.Lib;

namespace Tyuiu.ZamyakinaOA.Sprint3.Task3.V20
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнила: Замякина Олеся Андреевна | ПКТб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach подсчитать количество букв “f” в строке:         *");
            Console.WriteLine("* gfft ntf f opf                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "gfft ntf f opf";
            char item = 'f';

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.GetCharCount(value, item));

            Console.ReadKey();
        }
    }
}