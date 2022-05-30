using System;
using Xunit;
using AdrianBibliotek;
namespace UnitTest_Biblioteket;

public class UnitTest1
{
    [Fact]
    public void Bibliotek_Hent_Bibliotek_True()
    {
        Bibliotek bibnavn = new Bibliotek("sønderborg bibliotek");
        string str = string.Format("velkommen til {0} - datoen i dag er: {1}", "sønderborg bibliotek", DateTime.Now.ToString());
        Assert.Equal(bibnavn.HentBibliotek(), str);
    }
}