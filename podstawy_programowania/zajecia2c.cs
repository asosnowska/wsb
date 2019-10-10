using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {//pętla for wyswietl liczby z przedzialu

            for (int i = 0; i<=10;i++)
            {
                Console.Write("{0} ", i);

            }
            //wyświetl liczby parzyste z przedziału <5;20> w porządku malejącym

            for (int i = 20; i>=5; i--)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i);
                }
                /* wyświetl na ekranie:
                 * *
                 * **
                 * ***
                 * ****
                 * *****
                 * wysokość choinki użytkownik podaje z klawiatury
                 */

                //pętla - w którym wierszu wyświetlamy 
                //for (int i=1; i<=ile; i++)
                //pętla - ile gwiazdek wyświetlamy
                for (int j = 1; i <= 5; i++)
                {
                    Console.Write("*", i);
            }
            Console.ReadKey();
        }
    }
}
