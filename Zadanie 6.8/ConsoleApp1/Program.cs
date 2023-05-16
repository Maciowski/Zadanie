using System;

public class Prostopadloscian
{
    private double dlugosc;
    private double szerokosc;
    private double wysokosc;


    public Prostopadloscian(double dlugosc, double szerokosc, double wysokosc)
    {
        this.dlugosc = dlugosc;
        this.szerokosc = szerokosc;
        this.wysokosc = wysokosc;
    }

    public double ObliczObjetosc()
    {
        return dlugosc * szerokosc * wysokosc;
    }

    public int PorownajObjetosci(Prostopadloscian p)
    {
        double objetosc1 = this.ObliczObjetosc();
        double objetosc2 = p.ObliczObjetosc();

        if (objetosc1 > objetosc2)
        {
            return 1;
        }
        else if (objetosc1 < objetosc2)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
}
public class Program
{
    public static void Main()
    {

        Prostopadloscian p1 = new Prostopadloscian(2, 3, 4);
        Prostopadloscian p2 = new Prostopadloscian(3, 4, 5);


        Console.WriteLine("Objetosc p1: " + p1.ObliczObjetosc());
        Console.ReadKey();

        Console.WriteLine("Objetosc p2: " + p2.ObliczObjetosc());
        Console.ReadKey();

        int wynikPorownania =  p1.PorownajObjetosci(p2);
        if (wynikPorownania == 1)
        {
            Console.WriteLine("Prostopadloscian p1 ma wieksza objetosc niz p2.");
            Console.ReadKey();
        }
        else if (wynikPorownania == -1)
        {
            Console.WriteLine("Prostopadloscian p2 ma wieksza objetosc niz p1");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Oba prostopadlosciany maja taka sama objetosc");
            Console.ReadKey();
        }
    }
}
