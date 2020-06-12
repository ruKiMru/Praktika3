using System;

namespace Praktika3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = 0.5, x2 = -0.5, y1 = 1, y2 = -1, x, y;
            Console.WriteLine("Введите координату X");
                x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату Y");
                y = double.Parse(Console.ReadLine());

            if ((x < x1) && (x > x2) && (y < y1) && (y > y2))
            {
                Console.WriteLine("Точка попадает в заштрихованную область");
                Console.ReadKey(true);
                return;
            }
            else if(((x == x1) || (x == x2) && (y == y1) || (y == y2)))
            {
                Console.WriteLine("Точка лежит на границе области");
                Console.ReadKey(true);
                return;
            }
            else
            {
                Console.WriteLine("Точка не попадает в заштрихованную область");
                Console.ReadKey(true);
                return;
            }
        }
    }
}
