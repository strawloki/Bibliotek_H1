using System;

namespace BibliotekProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Bibliotek bibliotek = new Bibliotek("Sonderborg Bibliotek"); //Opret bibliotek objekt
            

            bibliotek.OpretLaaner(1, "Steven", "steven@shitmail.com");
            bibliotek.OpretLaaner(2, "Stewart", "stewart@shitmail.com"); //Opret flere laanere ind i bibliotek objektet
            bibliotek.OpretLaaner(3, "Ian", "ian@shitmail.com");

            bibliotek.TilfojBog("To kill a mockingbird","Can't remember","1000");
            bibliotek.TilfojBog("Programming for dummies", "A lesser dummy", "2000"); //Opret flere boger ind i bibliotek objektet
            bibliotek.TilfojBog("McDonald's Sonderborg menu", "Old McDonald", "3000");
            //Console.WriteLine(bibliotek.HentAlleLaanere());

            while (true)
            {
                int valg = BibliotekPrompt(); //Returnere en int som er brugerens valg fra opstart menuen

                switch (valg)
                {
                    case 1:
                        OutputMessage(bibliotek.HentBibliotek());
                        break;

                    case 2:
                        OpretNyLaanerPrompt(bibliotek);
                        break;

                    case 3:
                        Console.WriteLine("Laanere i biblioteket:");
                        OutputMessage(bibliotek.HentAlleLaanere());
                        break;
                    case 4:
                        OutputMessage(bibliotek.UdskrivBoger());
                        break;
                    case 5:
                        LoanBookPrompt(bibliotek);
                        break;

                    case 6:
                        Environment.Exit(0);
                        break;
                }
            }

        }

        private static void LoanBookPrompt(Bibliotek bib) //Prompt brugt for at laan en bog
        {
          
            Console.Write(bib.UdskrivBoger());

            Console.WriteLine("Indast ISBN af bogen du vil gerne lan: ");
            string isbnStr = Console.ReadLine();

            Book toLoan = bib.FindBook(isbnStr); //returnerer null hvis bogen med valgt isbn nummer kunne ikke findes i bibliotek objektet,
            if (toLoan == null)                  //ellers returnerer den bogen fra bibliotekens liste som matcher isbn nummeret
                Console.WriteLine("\nBogen med dette ISBN kunne ikke findes.\n");
            else //hvis bogen findes
            {
                bool lan = false;
                while (!lan) //prompt som kores indtil brugeren har indastet en int
                {
                    Console.WriteLine("Indast en laaner nr.: ");
                    string lanStr = Console.ReadLine();
                    int lanId;

                    if(Int32.TryParse(lanStr, out lanId))
                    {
                        lan = true;
                        if(bib.HentLaaner(lanId) != "Ikke fundet") //tjekker hvis dette laaner id findes i biblioteket
                        {
                            string msg = bib.LoanBook(toLoan, lanId) is true ? "Successfully loaned the book" : "failed to loan the book.";
                            Console.WriteLine(msg); //en sidst redundant tjek, LoanBook() returnerer true hvis en laan er udford sucessfuld
                        }
                    }
                }
            }
        }

        static int BibliotekPrompt() //Opstart prompt med menuen
        {
            //Console.Clear();
            int valg = -1;
            bool choice = false;
            while (!choice) //kores indtil brugeren har indtastet en mulighed(int) som passer
            {
                Console.Write("---------------------------------------------------\n");
                Console.Write("Velkommen til bibliotekens program. Du kan vaelge folgende:\n");
                Console.Write("1. Vis bibliotekens navn og dato\n");
                Console.Write("2. Opret en ny laaner\n");
                Console.Write("3. Udskriv laanere\n");
                Console.Write("4. Udskriv boger der ligger ind i biblioteket\n");
                Console.Write("5. Lan en bog\n");
                Console.Write("6. Afsult programmet\n");
                Console.Write("---------------------------------------------------\n");
                Console.Write("Indtast din valg: ");

                string strValg = Console.ReadLine();


                if (Int32.TryParse(strValg, out valg))
                {
                    if (valg < 1 || valg > 6)
                    {
                        Console.Clear();
                        Console.WriteLine("Uglydig mulighed. Prov igen.");
                    }

                    else
                        choice = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Uglydig mulighed. Prov igen.");
                }
            }
            return valg;
        }

        static void OpretNyLaanerPrompt(Bibliotek bib) //Propmt for at tilfoj en ny laaner i biblioteket
        {
            bool valueInputted = false;

            while (!valueInputted)
            {
                Console.Write("Indast laaners navn: ");
                string navn = Console.ReadLine();

                Console.Write("Indast laaners email addresse: ");
                string email = Console.ReadLine();

                Console.Write("Indast laaners nummer: ");
                string numStr = Console.ReadLine();

                int num = -1;
                if (Int32.TryParse(numStr, out num))
                {
                    OutputMessage(bib.OpretLaaner(num, navn, email)); //Opret laaner returnerer en string med en besked
                    valueInputted = true;
                }
                else Console.WriteLine("Ugyldig mulighed. Du skal indtaste kun en tal.");
            }
        }
        static void OutputMessage(string message)
        {
            Console.Clear();
            Console.Write("\n");
            Console.WriteLine(message);
            Console.Write("\n");

        }
    }
}
