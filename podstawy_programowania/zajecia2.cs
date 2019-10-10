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
            /*int x = 5;
            if (x > 3)
            {
                Console.WriteLine("prawda");
            }
            else
            {
                Console.WriteLine("falsz");
            }*/
            string x = Console.ReadLine();
            double x1;
            string y = Console.ReadLine();
            double y1;
            if (double.TryParse(x, out x1) == true && double.TryParse(y, out y1)==true)
            {
                Console.WriteLine("Oblicz pole trójkąta");
            }

            Console.WriteLine("Podaj podstawę trójkąta");
            string podstawa = Console.ReadLine();
            Console.WriteLine("Podaj wysokość trójkąta");
            string wysokosc
                = Console.ReadLine();
            double podstawa1, wysokosc1;
            if (double.TryParse(podstawa, out podstawa1) == true && double.TryParse(wysokosc, out wysokosc1)==true)
            {
                Console.WriteLine("Pole wynosi:" + podstawa1 * wysokosc1 / 2);
            }
            else
            {
                Console.WriteLine("Zły format");
            }
            Console.ReadKey();
        }
    }
}
