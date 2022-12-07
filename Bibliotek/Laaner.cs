using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotek
{
    class Laaner
    {
        private int laanerNummer;
        private string laanerNavn;

        public string LaanerNavn { get { return laanerNavn; } }
        public int LaanerNummer { get { return laanerNummer; } }

        public Laaner(int nummer, string navn)
        {
            laanerNummer = nummer;
            laanerNavn = navn;
        }
    }
}
