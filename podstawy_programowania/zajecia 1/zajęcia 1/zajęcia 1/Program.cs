using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajęcia_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //komentarz
            /*
            *
            *
            *
            *
            */
            Console.WriteLine("Janusz");
            

            //zmienne i typy danych
            int x=10;
            Console.WriteLine(x);
            int x1, y = 10, z = 15;
            //konkantenacja
            //nowa linia
            Console.WriteLine("y= " + y + "\nz= " + z);
            int a = 10;
            int b = a;
            b = 15;
            Console.WriteLine(a + " " + b);
           

            //alternatywny sposób deklaracji zmiennej
            int c = new int();//wartość domyślna ==> null (brak preferencji)

            Console.WriteLine("wartość zmiennej c;" + c);
            Console.Write("Podaj swoje imię");
            string name = Console.ReadLine();
            Console.WriteLine("twoje imię" + name);
            float f = 10.55F;
            Console.WriteLine("float" + f);

            double y2 = 15.95;
            Console.WriteLine("zmienna double" + y2);

            //program co oblicza pole prostokąta
            Console.Write("Podaj bok a");
            string a1 = Console.ReadLine();
            double a2 = double.Parse(a1);
            Console.Write("Podaj bok b");
            double a3 = double.Parse(Console.ReadLine());

            double result = a2 * a3;
            Console.Write("wynik:" + result);

            //drugi sposób
            a2 *= a3;
            Console.Write("wynik" + a2 * a3);

            Console.ReadKey();
        }
    }
}
