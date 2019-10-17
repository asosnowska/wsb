using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisz program, który w 10-elementowej tablicy jednowymiarowej o nazwie tab umieszcza liczby całkowite
             * z przedziału od 1 do 10
             */
            int n = 10, i;
            //deklaracja tablicy o nazwie tab typu całkowitego o rozmiarze n = 10
            int[] tab = new int[n];
            for (i=0; i< tab.Length; i++)
            {
                Console.Write("{0}", tab[i]); ;
            }
            /*Napisz program, który w 5-elementowej tablicy jednowymiarowej o nazwie colors
             * umieszcza nazwy kolorów podane z klawiatury przez użytkownika
             * wyświetl kolory w formacie(while):
             * kolor 1: red
             * kolor 2: blue
             * ...
             * kolor 5: yellow
             */
            string[] colors = new string[5];
            string color;
            for (i=0; i < colors.Length; i++)
            {
                Console.Write("Podaj kolor:");
                color = Console.ReadLine();
                colors[i] = color; 
                   
            }
        }
    }
}
