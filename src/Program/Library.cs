using System;
using System.Linq;

public class Bibliotek
{
    string _biblioteksNavn;
    public Bibliotek(string name)
    {
        this._biblioteksNavn; = name;
    }
    public string HentBibliotek()
    {
        return string.Format("velkommen til {0} - datoen i dag er: {1}", this._biblioteksNavn, DateTime.Today.ToString());
    }
}