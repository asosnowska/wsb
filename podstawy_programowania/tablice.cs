using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //typ wartosciowy
            int a = 10;
            int b = a;

            a--;

            Console.WriteLine("Zmienna a; (0)", a); //9
            Console.WriteLine("Zmienna b; (0)", b); //11

            //typ referencyjny

            int[] tabA = { 2, 2, 2 };
            int[] tabB = tabA;
            tabA[2] = 10;
            tabB[0] = 8;

            Console.WriteLine("Wyświetlenie tablicy A:");

            foreach (int item in tabA)
            {
                Console.Write("(0)", item);
            }

            Console.WriteLine("Wyświetlenie tablicy B:");

            foreach (int item in tabB)
            {
                Console.Write("(0)", item);
            }

            //kopiowanie tablicy 1
            int[] tab = { 1, 2, 3, 4, 5 };
            int[] tabCopy = new int[5];
            foreach (int item in tabCopy)
            {
                Console.Write("0", item);
            }
            tab.CopyTo(tabCopy, 0);
            foreach (int item in tabCopy)
            {
                Console.Write("0", item);
            }

            //kopiowanie tablicy 2
            Console.WriteLine("sdf");
            Array.Copy(tab, tabCopy, 3);
            //Array.Copy(tab, tabCopy, tab.Length);
            foreach (int item in tabCopy)
            {
                Console.Write("(0)", item);
            }

            Console.ReadKey(); 

        }
    }
}
