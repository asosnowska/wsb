using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0;
            while (x<=15)
            {
                y = 4 * x;
                Console.WriteLine("x=" + x + "y=" + y);
                x++;
            }
        }
    }
}
