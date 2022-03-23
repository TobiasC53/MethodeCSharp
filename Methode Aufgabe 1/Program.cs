using System;

namespace Methode_Aufgabe_1
{
    class Program
    {
        public static void Main()
        {
            int anzahl = 0;


            Console.WriteLine("Bitte geben sie eine Zahl ein:");
            int x = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Geben sie ihren Text ein: ");
            string text = Convert.ToString(Console.ReadLine());

            anzahl = ausgabeTextMalX(text, x);

            Console.Write("\nAnzahl der Buchstaben: {0}", anzahl);
        }

        static int ausgabeTextMalX(string text, int x)
        {

            int textgroesse = text.Length;
            int y = textgroesse * x;
            return y;
        }
    }
}
