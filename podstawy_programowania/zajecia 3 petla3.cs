using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("tabliczka mnozenia");
            int n = 10, row, col;
            row = 1;
            do
            {
                col = 1;
                do
                {
                    //Console.Write(row * col + "\t");
                    Console.Write("{0}\t", row * col);
                    col++;

                } while (col <= n);
                row++;
                Console.WriteLine();
            } while (row <= n);*/

            /*
             * Napisz program, który wyświetli duże litery alfabetu
             * od A do Z i od Z do A z wykorzystaniem pętli for
             * np. A, B, C, ..., Z.
             * np. Z, Y, X, ..., A.
             * */

            //continue
            int j = 1;
            for (; j <= 10; j++)
            {
                if (j == 2 || j == 5 || j == 7)
                    continue;
                else
                    Console.Write("{0}", j);
            }
            Console.WriteLine();
                    

           
        }
    }
}
