using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проверка_простого_числа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool simple = true;
            int number;
            int a = 2;
            Console.WriteLine("Введите число: ");
            number = int.Parse(Console.ReadLine());

            while (a <= number - 1)
            {
                if (number % a == 0)
                {
                    simple = false;
                }
                a++;
            }
            if (simple)
            {
                Console.WriteLine("Данное число является простым");
            }
            else
            {
                Console.WriteLine("Данное число не является простым");
            }
            Console.ReadKey();
        }
    }
}
