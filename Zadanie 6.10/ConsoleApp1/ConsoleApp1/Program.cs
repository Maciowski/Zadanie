using System;

struct KandydatNaStudia
{
    public string nazwisko;
    public double punktyMatematyka;
    public double punktyInformatyka;
    public double punktyJezykObcy;

    public double ObliczLacznaLiczbePunktow()
    {
        return punktyMatematyka * 0.6 + punktyInformatyka * 0.5 + punktyJezykObcy * 0.2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        KandydatNaStudia[] kandydaci = new KandydatNaStudia[3];

        kandydaci[0].nazwisko = "Kowalski";
        kandydaci[0].punktyMatematyka = 75;
        kandydaci[0].punktyInformatyka = 80;
        kandydaci[0].punktyJezykObcy = 90;

        kandydaci[1].nazwisko = "Nowak";
        kandydaci[1].punktyMatematyka = 60;
        kandydaci[1].punktyInformatyka = 70;
        kandydaci[1].punktyJezykObcy = 80;

        kandydaci[2].nazwisko = "Wójcik";
        kandydaci[2].punktyMatematyka = 80;
        kandydaci[2].punktyInformatyka = 90;
        kandydaci[2].punktyJezykObcy = 70;

        Console.WriteLine("Lista kandydatów:");

        foreach (KandydatNaStudia kandydat in kandydaci)
        {
            double lacznaLiczbaPunktow = kandydat.ObliczLacznaLiczbePunktow();
            Console.WriteLine("{0}: {1} punktów", kandydat.nazwisko, lacznaLiczbaPunktow);
        }
    }
}
