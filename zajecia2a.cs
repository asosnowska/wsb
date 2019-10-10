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
            Console.WriteLine("1 - pole kwadratu\n2 - pole koła");
            Console.Write("\npodaj wartość:");
            string x;
            string a;
            double b;
            x = Console.ReadLine();
            switch (x)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Pole kwadratu\n");
                    Console.Write("Podaj bok kwadratu");
                    a = Console.ReadLine();
                    if (double.TryParse(a, out b)==true) 
                    {
                        Console.WriteLine("Pole kwadratu wynosi:" + b * b);
                    }
                    break;
                case "2":
                    Console.WriteLine("2");
                    break;

                default:
                    Console.WriteLine("błąd");
                        break;
            }

            Console.ReadKey();
        }
    }
}
