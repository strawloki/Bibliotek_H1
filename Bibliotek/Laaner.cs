using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotekProjekt
{
    class Laaner : Person
    {
        private int laanerNummer;
        //private string laanerNavn;

        public string LaanerNavn { get { return base.Navn; } }
        public int LaanerNummer { get { return laanerNummer; } }

        public Laaner(int nummer, string navn, string email) : base(navn, email)
        {
            laanerNummer = nummer;
           
        }
    }
}
