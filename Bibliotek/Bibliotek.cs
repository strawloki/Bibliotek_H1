using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotek
{
    class Bibliotek
    {
        string biblioteksNavn;
        List<Laaner> laanerList = new List<Laaner>();

        public Bibliotek(string navn)
        {
            biblioteksNavn = navn;       
        }

        public void HentBibliotek()
        {
            Console.WriteLine($"Velkommen til {biblioteksNavn} - datoen idag er {DateTime.Now}");
        }

        public void OpretLaaner(int number, string name)
        {
            laanerList.Add(new Laaner(number, name));
        }
        public string HentLaaner(int number)
        {
            string result = "Ikke fundet";
            foreach(Laaner lan in laanerList)
            {
                if (lan.LaanerNummer == number)
                    result = String.Format($"Laanenummer: {lan.LaanerNummer} - Navn: {lan.LaanerNavn} er laner hos {biblioteksNavn}.");
            }
            return result;
        }
    }
}
