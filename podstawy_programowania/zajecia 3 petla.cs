using System;

namespace zajecia3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisz program, który za pomocą instrukcji do while 
             * dla danych wartości zmieniających się w przedziale od 0 do 15
             * oblicza wartość funkcji y = 4x
             */
            int x = 0, y = 0;
            do
            {
                Console.WriteLine("x: {0} y: {1}", x, y);
                x++;
                y = 4 * x;
            } while (x <= 15);
            /* napisz program znajdujący się powyżej za pomocą pętli while
             */
            int a = 0, b = 0;
            while (a <= 15)
            {
                b = 4 * a;
                Console.WriteLine("a={0} b={1}", a, b);
            }
        }
    }
}
