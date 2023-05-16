using System;

class Program
{
    static void Main(string[] args)
    {
        KandydatNaStudia[] kandydaci = new KandydatNaStudia[3];

        kandydaci[0].nazwisko = "Kowalski";
        kandydaci[0].punktyMatematyka = 82;
        kandydaci[0].punktyInformatyka = 70;
        kandydaci[0].punktyJezykObcy = 95;

        kandydaci[1].nazwisko = "Nowak";
        kandydaci[1].punktyMatematyka = 60;
        kandydaci[1].punktyInformatyka = 77;
        kandydaci[1].punktyJezykObcy = 92;

        kandydaci[2].nazwisko = "Wójcik";
        kandydaci[2].punktyMatematyka = 60;
        kandydaci[2].punktyInformatyka = 97;
        kandydaci[2].punktyJezykObcy = 80;


        Console.WriteLine("Lista kandydatów: ");

        foreach (KandydatNaStudia kandydat in kandydaci)
        {
            double lacznaLiczbaPunktow = kandydat.ObliczLacznaLiczbePunktow();

            Console.WriteLine("{0}: {1} punktów", kandydat.nazwisko, lacznaLiczbaPunktow);
        }
    }
}

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
