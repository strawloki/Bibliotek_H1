using System;

namespace Bibliotek
{
    class Program
    {
        static void Main(string[] args)
        {
            Bibliotek bibliotek = new Bibliotek("Sonderborg Bibliotek");
            bibliotek.HentBibliotek();
        }
    }
}
