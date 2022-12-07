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
            bibliotek.OpretLaaner(2, "Stewart");
            bibliotek.OpretLaaner(3, "Ian");
            Console.WriteLine(bibliotek.HentAlleLaanere());
            
        }
    }
}
