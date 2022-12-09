using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotekProjekt
{
    class Person
    {
        string navn, email;

        public string Navn { get { return navn; } }
        public string Email { get { return email; } }

        List<Book> bookList = new List<Book>();

        public Person(string name, string email)
        {
            navn = name;
            this.email = email;
        }

        public void LoanBook(Book book) //metode som har direkt adgang til en persons liste af lant boger
        {
            book.LoanDate = DateTime.Now;
            bookList.Add(book);
            Console.WriteLine($"Bogen {book.Title} er lant til {navn} pa den {book.LoanDate}.");
        }

        public int BooksLoaned()
        {
            return bookList.Count;
        }

    }
}
