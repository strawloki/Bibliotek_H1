using System;
using Xunit;
using BibliotekProjekt;


namespace UnitTest_Bibliotek1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            Bibliotek bib = new Bibliotek("Test");
            bib.OpretLaaner(1, "Jerry", "jerry@mail.com");

            string expected = "Laanenummer: 1 - Navn: Jerry er laner hos Test og har lant 0 boger.";

            // Act
            string actual = bib.HentLaaner(1);

            // Assert

            Assert.Equal(expected, actual);


        }
    }
}
