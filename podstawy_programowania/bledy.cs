using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //wyswietlanie bledow
            uint number;
            while (true)
            {
                Console.Write("Wprowadź liczbę całkowitą:");
                string x = Console.ReadLine();
                //blok instrukcji
                try
                {
                    number = uint.Parse(x);
                    break;
                }
                catch (SystemException e)
                {
                    //Console.WriteLine("Error");
                    Console.WriteLine(e.Message);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Podałeś błędne dane: {0}\n", x);
                    Console.ResetColor();
                   
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Prawidłowe dane: {0}", number);
            Console.ResetColor();




            Console.ReadKey();
        }
    }
}
