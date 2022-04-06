using System;

namespace Methode_implementieren_und_aufrufen
{
    class Program
    {
        static void Main(string[] args)
        {

            bool flag = false;
            string eingabe_string;
            short eingabe_short;



            short[] zimmernummer = { 45, 23, 3, 32 };
            string[] vorname = { "John" ,"Paul","George","Ringo" };
            string[] nachname = { "Lennon", "McCartney", "Harrison", "Starr" };
            short[] übernachtung = { 1, 4, 12, 3 };
            double[] rechnungsbetrag = { 82.46, 329.84, 989.52, 247.38 };

            Console.WriteLine("Bitte geben sie ihr Nachname ein:");
            eingabe_string = Console.ReadLine();

            flag = short.TryParse(eingabe_string out eingabe_short);





        }
    }
}
