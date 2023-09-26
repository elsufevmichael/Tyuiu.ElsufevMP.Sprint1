using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ElsufevMP.Sprint1.Task5.V7.Lib;

//Определить h – полное количество часов прошедших от начала суток до того момента (в первой половине дня), когда часовая стрелка повернулась на f градусов (0<f<360, f – вещественное число).

namespace Tyuiu.ElsufevMP.Sprint1.Task5.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Елсуфьев М. П. | ИИПб-23-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Елсуфьев Михаил Павлович | ИИПб-23-2                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу                     *");
            Console.WriteLine("* Определить h – полное количество часов прошедших от начала суток        *");
            Console.WriteLine("* до того момента (в первой половине дня), когда часовая стрелка          *");
            Console.WriteLine("* повернулась на f градусов (0<f<360, f – вещественное число).            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите F: ");
            double f = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = Convert.ToInt32(ds.AngleToHoursMinutes(f));
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
