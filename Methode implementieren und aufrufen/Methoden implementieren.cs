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
            string[] vorname = { "John", "Paul", "George", "Ringo" };
            string[] nachname = { "Lennon", "McCartney", "Harrison", "Starr" };
            short[] übernachtung = { 1, 4, 12, 3 };
            double[] rechnungsbetrag = { 82.46, 329.84, 989.52, 247.38 };



            do
            {

                Console.WriteLine("Bitte geben sie ihre Daten ein:");
                eingabe_string = Console.ReadLine();

                flag = short.TryParse(eingabe_string, out eingabe_short);

                if(flag==false)
                {
                    GetData(eingabe_short, zimmernummer, vorname, nachname, übernachtung, rechnungsbetrag);
                }
                else
                {
                    GetData(eingabe_string, zimmernummer, vorname, nachname, übernachtung, rechnungsbetrag);
                }




            } while (true);






        }

        static (bool, short, string, string, short, double) GetData(short diff, short[] zimmernummer, string [] vorname, string[] nachname, short[] übernachtung, double[] rechnungsbetrag)
        {





            return (true, 0, "", "", 0, 0.0);
        }

        static (bool, short, string, string, short, double) GetData(string diff, short[] zimmernummer, string[] vorname, string[] nachname, short[] übernachtung, double[] rechnungsbetrag)
        {





            return (true, 0, "", "", 0, 0.0);
        }
    }
}
