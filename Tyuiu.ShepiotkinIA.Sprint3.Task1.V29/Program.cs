﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShepiotkinIA.Sprint3.Task1.V29.Lib;

namespace Tyuiu.ShepiotkinIA.Sprint3.Task1.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService service1 = new DataService();
            double x = 0.25;
            int q = 1;
            int w = 11;
            Console.Title = "Спринт #3 | Выполнил: Щепёткин И.А. | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема:Оператор цикла while                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Щепёткин И.А. | ИИПб-23-2                                    * ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу используя цикл while, которая вычисляет произведение  *");
            Console.WriteLine("*ряда по формуле, при х=0,25                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("x=0,25");
            Console.WriteLine("Начало =" + q);
            Console.WriteLine("Конец =" + w);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведение ряда=" + service1.GetMultiplySeries(x, q, w));
            Console.ReadKey();
        }
    }
}
