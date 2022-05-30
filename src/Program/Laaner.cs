using System;
class Laaner
{
    int nummer;
    public string navn { get; init; }
    public Laaner(int nummer, string navn)
    {
        this.nummer = nummer;
        this.navn = navn;
    }
}