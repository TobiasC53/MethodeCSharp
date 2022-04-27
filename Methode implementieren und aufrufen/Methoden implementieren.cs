using System;

namespace Methode_implementieren_und_aufrufen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tobias Cremer und Sergey Zavadovskiy zusammen bearbeitet

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
                   var data = GetData(eingabe_short, zimmernummer, vorname, nachname, übernachtung, rechnungsbetrag);
                }
                else
                {
                    var data = GetData(eingabe_string, zimmernummer, vorname, nachname, übernachtung, rechnungsbetrag);
                }




            } while (true);






        }

        static (bool, short, string, string, short, double) GetData(short diff, short[] zimmernummer, string [] vorname, string[] nachname, short[] übernachtung, double[] rechnungsbetrag)
        {

            bool EI = false;
            int index = 0;


            for (int i = 0; i < zimmernummer.Length; i++)
            {
                if (diff==zimmernummer[i])
                {
                    index = i;
                    EI = true;
             
                }
            }

            return (EI, zimmernummer[index], vorname[index], nachname[index], übernachtung[index], rechnungsbetrag[index]);

        }

        static (bool, short, string, string, short, double) GetData(string diff, short[] zimmernummer, string[] vorname, string[] nachname, short[] übernachtung, double[] rechnungsbetrag)
        {
            bool EI = false;
            int index = 0;

            for (int i = 0; i < nachname.Length; i++)
            {
                if (diff == nachname[i])
                {
                    index = i;
                    EI = true;
                }
            }




            return (EI, zimmernummer[index], vorname[index], nachname[index], übernachtung[index], rechnungsbetrag[index]);
        }
    }
}
