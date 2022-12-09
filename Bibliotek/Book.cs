using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotekProjekt
{
    public class Book
    {
        string title, authName, isbn;
        DateTime loanDate;

        public string Title { get { return title; } set { title = value; } }
        public string AuthorName { get { return authName; } set { authName = value; } }
        public string ISBN { get { return isbn; } set { isbn = value; } }
        public DateTime LoanDate { get { return loanDate; } set { loanDate = value; } }

        public Book(string title, string authName, string isbn)
        {
            this.title = title;
            this.authName = authName;
            this.isbn = isbn;

        }
    }
}
