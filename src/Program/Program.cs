using System;
namespace AdrianBibliotek
{
    class Program
    {
        static void Main()
        {
            Bibliotek bibObj = new Bibliotek("Sønderborg bibliotek");
            Console.WriteLine(bibObj.HentBibliotek());
        }
    }
}