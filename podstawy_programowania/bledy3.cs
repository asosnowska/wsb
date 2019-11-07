using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //1

            uint x = 10;
                try
            {
                Console.WriteLine("Podaj dzień tygodnia (1; 5):");
                string str = Console.ReadLine();
                x = uint.Parse(str);
            }
            catch
            {
                Console.WriteLine("Error");
            }
            finally
            {
                Console.WriteLine("x = {0}", x);
            }
            //2

            switch (x)
            {
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 6:
                    throw new SystemException("Masz już weekend, błędne dane");
                    break;
                case 7:
                    throw new SystemException("Masz już weekend, niedziela!");
                    break;
                default:
                    throw new System.ArgumentOutOfRangeException("Błędny zakres");
                    break; 


            }

        //napisz kalkulator, uwzględnij wyjątki, dodaj menu wyboru działania, użytkownik może zamknąć program wpisując x
        //wyjątki: dzielenie przez 0, liczby rzeczywiste, prawdziwe wartości, poza zakres, uwzględnić string

        
       
       
       
       


        
        

            Console.ReadKey();  
        }
        
    }
}
