using System;
namespace AdrianBibliotek
{
    class Program
    {
        static void Main()
        {
            Bibliotek bibObj = new Bibliotek("sønderborg bibliotek");
            Console.WriteLine(bibObj.HentBibliotek());
            bibObj.OpretLaaner("Adrian", "");
            bibObj.OpretLaaner("Christian", "");
            bibObj.OpretLaaner("Nikolaj", "");
            Console.WriteLine(bibObj.HentAlleLaaner());

            while (true)
            {
                Menu();
                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        Console.WriteLine(bibObj.HentBibliotek());
                        Console.ReadLine();
                        break;

                    case '2':
                        Console.Write("skriv mail: ");
                        string mail = Console.ReadLine();
                        Console.Write("skriv navn: ");
                        string navn = Console.ReadLine();
                        bibObj.OpretLaaner(navn, mail);
                        Console.ReadLine();
                        break;
                    
                    case '3':
                        Console.WriteLine(bibObj.HentAlleLaaner());
                        Console.ReadLine();
                        break;
                    
                    case '4':
                        System.Environment.Exit(0);
                        break;
                    
                    default:
                        Console.WriteLine("Fejl, prøv igen");
                        continue;
                        break;
                }
            }
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("forskellige valgmuligheder");
            Console.WriteLine("1: vis bibliotekets navn og dato");
            Console.WriteLine("2: opret en låner");
            Console.WriteLine("3: udksriv lånere");
            Console.WriteLine("4: slut");
            Console.WriteLine("----------------------------------");
        }
    }
}