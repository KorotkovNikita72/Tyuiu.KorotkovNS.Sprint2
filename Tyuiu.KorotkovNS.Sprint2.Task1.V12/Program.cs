using Tyuiu.KorotkovNS.Sprint2.Task1.V12.Lib;
namespace Tyuiu.KorotkovNS.Sprint2.Task1.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a = 152;
            int b = 116;
            int c = 887;
            int d = 556;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            Console.Title = "Спринт #2 | Выполнил: Коротков Н. С. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Коротков Никита Сергеевич | ИСТНб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений                                *");
            Console.WriteLine("* и арифметических выражений, которая вернет логическую последовательность*");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);

            }
            Console.ReadKey();
        }
    }
}
