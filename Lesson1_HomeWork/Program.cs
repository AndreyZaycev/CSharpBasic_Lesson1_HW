using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Урок № 1, домашнее задание");
            Console.Write("Введите Ваше имя : ");
            string sName = Console.ReadLine();
            Console.WriteLine($"Привет, {sName}, сегодня {DateTime.Now}");
            Console.ReadLine();
        }
    }
}
