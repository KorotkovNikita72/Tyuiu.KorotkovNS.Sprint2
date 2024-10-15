﻿using Tyuiu.KorotkovNS.Sprint2.Task6.V9.Lib;
namespace Tyuiu.KorotkovNS.Sprint2.Task6.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Коротков Н. С. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результатов из switch                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Коротков Никита Сергеевич | ИСТНб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
            Console.WriteLine("* оператора switch и вычисляет требуемое значение                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Введите значение переменной m: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение переменной n: ");
            int m = Convert.ToInt32(Console.ReadLine());


            string res;

            if ((m < 1) || (m > 12) || (n < 1) || (n > 31))
            {
                res = "Введенно неверное значение!";
            }
            else
            {
                res = "Дата следующего дня: " + ds.FindDateOfNextDay(m, n);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
