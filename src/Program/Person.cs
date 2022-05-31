namespace AdrianBibliotek
{
    public class Person
    {
        public string navn { get; init; }
        public string mail { get; set; }
        public Person(string navn, string mail)
        {
            this.mail = mail;
            this.navn = navn;
        }
    }
}