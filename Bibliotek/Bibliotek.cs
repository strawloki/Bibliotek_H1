using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotek
{
    class Bibliotek
    {
        string biblioteksNavn;
        List<Laaner> laanerList = new List<Laaner>();
        List<Book> books = new List<Book>();

        public Bibliotek(string navn)
        {
            biblioteksNavn = navn;       
        }

        public string HentBibliotek()
        {
            return String.Format($"Velkommen til {biblioteksNavn} - datoen idag er {DateTime.Now}");
        }

        public string OpretLaaner(int number, string name, string email)
        {
            laanerList.Add(new Laaner(number, name, email));

            return String.Format($"Oprettet en ny laaner med navnet {name}, email adresse som {email} og nummer {number}.");
        }
        public string HentLaaner(int number)
        {
            string result = "Ikke fundet";
            foreach(Laaner lan in laanerList)
            {
                if (lan.LaanerNummer == number)
                    result = String.Format($"Laanenummer: {lan.LaanerNummer} - Navn: {lan.Navn} er laner hos {biblioteksNavn} og har lant {lan.BooksLoaned()} boger.");
            }
            return result;
        }

        public string HentAlleLaanere()
        {
            string result = "";
            foreach(Laaner lan in laanerList)
            {
                result += String.Format($"Navn: {lan.LaanerNavn} Nummer: {lan.LaanerNummer}, Bibliotek: {biblioteksNavn}\nBoger Lant: {lan.BooksLoaned()}\n");
            }
            return result;
        }

        public string UdskrivBoger()
        {
            string result = "";
            foreach(Book book in books)
            {
                result += String.Format($"Titel: {book.Title}\tForfatter: {book.AuthorName}\tISBN: {book.ISBN}\n");
            }
            return result;
        }
        public void TilfojBog(string title, string auth, string isbn)
        {
            books.Add(new Book(title, auth, isbn));
        }

    }
}
