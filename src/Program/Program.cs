using System;
namespace AdrianBibliotek
{
    class Program
    {
        static void Main()
        {
            Bibliotek bibObj = new Bibliotek("sønderborg bibliotek");
            Console.WriteLine(bibObj.HentBibliotek());
            bibObj.OpretLaaner("Adrian");
            bibObj.OpretLaaner("Christian");
            bibObj.OpretLaaner("Nikolaj");
            Console.WriteLine(bibObj.HentAlleLaaner());
        }
    }
}