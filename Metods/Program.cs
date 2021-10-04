using System;

namespace Metods
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2; int b = 3; int c = 4;
            //Console.Write(Treug(2, 3, 4));
            if (Treug(a, b, c))
                Console.WriteLine($"Перметр треугольника {PeriTreug(a, b, c)}");
            Console.WriteLine($"Площадь треугольника {SquaTreug(a, b, c)}");
        }
        static bool Treug(int a, int b, int c)
        {
            if ((a + b > c) & (a + c > b) & (c + b > a))
                return true;
            else
                return false;
        }
        static int PeriTreug(int a, int b, int c)
        {
            return a + b + c;
        }
        static Double SquaTreug(int a, int b, int c)
        {
            int ppp = PeriTreug(a, b, c);
                return (int)(Math.Sqrt(ppp - a) * (ppp - b) * (ppp - c))/4;
        }
    }
}
