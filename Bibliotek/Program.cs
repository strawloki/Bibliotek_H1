using System;

namespace Bibliotek
{
    class Program
    {
        static void Main(string[] args)
        {
            Bibliotek bibliotek = new Bibliotek("Sonderborg Bibliotek");
            bibliotek.HentBibliotek();

            bibliotek.OpretLaaner(1, "Steven");
            Console.WriteLine(bibliotek.HentLaaner(1));
            
        }
    }
}
