using System;

class Uomo
{   
    public float fTemperatura;
    public Uomo()
    {
        fTemperatura = 36.5f;
    }
}

class TestRiferimenti
{
    static void Main()
    {
        Uomo drJekill= new Uomo();
        Uomo mrHide=drJekill;
        Console.WriteLine("temperatura di drJekill: " + drJekill.fTemperatura);
        Console.WriteLine("temperatura di mrHide: "+mrHide.fTemperatura);
        drJekill.fTemperatura=39.5f;
        Console.WriteLine("temperatura di drJekill: " + drJekill.fTemperatura);
        Console.WriteLine("temperatura di mrHide: "+mrHide.fTemperatura);
    }
}