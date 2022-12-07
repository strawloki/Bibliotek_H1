using System;

namespace Bibliotek
{
    class Program
    {
        static void Main(string[] args)
        {
            Bibliotek bibliotek = new Bibliotek("Sonderborg Bibliotek");
            bibliotek.HentBibliotek();

            bibliotek.OpretLaaner(1, "Steven", "steven@shitmail.com");
            bibliotek.OpretLaaner(2, "Stewart", "stewart@shitmail.com");
            bibliotek.OpretLaaner(3, "Ian", "ian@shitmail.com");
            //Console.WriteLine(bibliotek.HentAlleLaanere());

            while (true)
            {
                int valg = BibliotekPrompt();

                switch (valg)
                {
                    case 1:
                        bibliotek.HentBibliotek();
                        break;

                    case 2:
                        OpretNyLaanerPrompt(bibliotek);
                        break;

                    case 3:
                        Console.WriteLine("Laanere i biblioteket:");
                        Console.WriteLine(bibliotek.HentAlleLaanere());
                        break;

                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }

        }

        static int BibliotekPrompt()
        {
            //Console.Clear();
            int valg = -1;
            bool choice = false;
            while (!choice)
            {

                Console.Write("---------------------------------------------------\n");
                Console.Write("Velkommen til bibliotekens program. Du kan vaelge folgende:\n");
                Console.Write("1. Vis bibliotekens navn og dato\n");
                Console.Write("2. Opret en ny laaner\n");
                Console.Write("3. Udskriv laanere\n");
                Console.Write("4. Afsult programmet\n");
                Console.Write("---------------------------------------------------\n");
                Console.Write("Indtast din valg: ");

                string strValg = Console.ReadLine();


                if (Int32.TryParse(strValg, out valg))
                {
                    if (valg < 1 || valg > 4)
                        Console.WriteLine("Uglydig mulighed. Prov igen.");

                    else
                        choice = true;

                }
                else
                    Console.WriteLine("Uglydig mulighed. Prov igen.");
            }
            return valg;
        }

        static void OpretNyLaanerPrompt(Bibliotek bib)
        {
            bool valueInputted = false;

            while (!valueInputted)
            {
                Console.Write("Indast laaners navn: ");
                string navn = Console.ReadLine();

                Console.Write("Indast laaners email addresse: ");
                string email = Console.ReadLine();

                Console.Write("\nIndast laaners nummer: ");
                string numStr = Console.ReadLine();

                int num = -1;
                if (Int32.TryParse(numStr, out num))
                {
                    Console.WriteLine(bib.OpretLaaner(num, navn, email));
                    valueInputted = true;

                }
                else Console.WriteLine("Ugyldig mulighed. Du skal indtaste kun en tal.");

            }
        }
    }
}
