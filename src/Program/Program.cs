using System;
namespace AdrianBibliotek
{
    class Program
    {
        static void Main()
        {
            Bibliotek bibObj = new Bibliotek("sønderborg bibliotek");
            Console.WriteLine(bibObj.HentBibliotek());
            bibObj.OpretLaaner(57, "Adrian");
        }
    }
}