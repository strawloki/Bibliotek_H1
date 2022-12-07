using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotek
{
    class Bibliotek
    {
        string biblioteksNavn;

        public Bibliotek(string navn)
        {
            biblioteksNavn = navn;       
        }

        public void HentBibliotek()
        {
            Console.WriteLine($"Velkommen til {biblioteksNavn} - datoen idag er {DateTime.Now}");
        }
    }
}
