using System;
using System.Linq;
using System.Collections.Generic;

public class Bibliotek
{
    string _biblioteksNavn;
    List<Laaner> _laaners = new List<Laaner>();
    public Bibliotek(string bibnavn)
    {
        this._biblioteksNavn = bibnavn;
    }
    public string HentBibliotek()
    {
        return string.Format("velkommen til {0} - datoen i dag er: {1}", this._biblioteksNavn, DateTime.Now.ToString());
    }
    public void OpretLaaner(string navn)
    {
        _laaners.Add(new Laaner(navn));
    }
    public string HentLaaner(string navn, int nummer)
    {
        return string.Format("lånenummer: {0} - navn: {1} er låner hos {2}", nummer, _laaners[nummer].navn, _biblioteksNavn);
    }
    public string HentAlleLaaner()
    {
        string str = "";
        for (int i = 0; i < _laaners.Count(); i++)
        {
            str += string.Format("lånenummer: {0} - navn: {1} er låner hos {2}\n", i, _laaners[i].navn, _biblioteksNavn);
        }
        return str;
    }
}