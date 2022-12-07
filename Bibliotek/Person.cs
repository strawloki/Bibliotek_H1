using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotek
{
    class Person
    {
        string navn, email;

        public string Navn { get { return navn; } }
        public string Email { get { return email; } }


        public Person(string name, string email)
        {
            navn = name;
            this.email = email;
        }

    }
}
