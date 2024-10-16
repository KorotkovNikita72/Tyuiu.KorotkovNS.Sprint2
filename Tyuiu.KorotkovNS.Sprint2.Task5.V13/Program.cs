using Tyuiu.KorotkovNS.Sprint2.Task5.V13.Lib;
namespace Tyuiu.KorotkovNS.Sprint2.Task5.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Коротков Н. С. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #13                                                              *");
            Console.WriteLine("* Выполнил: Коротков Никита Сергеевич | ИСТНб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("* требуемое значение и возвращает результат                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите значение переменной n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение переменной m: ");
            int m = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Введите значение переменной g: ");
            int g = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((m < 1) || (m > 12) || (n < 1) || (n > 31))
            {
                res = "Введенно неверное значение!";
            }
            else
            {
                res = "Дата следующего дня: " + ds.FindDateOfNextDay(g, m, n);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
