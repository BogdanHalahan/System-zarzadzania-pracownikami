using System;

class Pracownik
{
    private decimal wynagrodzenie;
    protected string imie;
    internal string dzial;
    public Pracownik(decimal wynagrodzenie, string imie, string dzial)
    {
        this.wynagrodzenie = wynagrodzenie;
        this.imie = imie;
        this.dzial = dzial;
    }
    public void PokazDane()
    {
        //wynagrodzenie = 100; - działa
        Console.WriteLine($"Pracownik: {imie} | Dzial: {dzial} | Wynagrodzenie: {wynagrodzenie} zł");
    }
    public void ZmienWynagrodzenie(decimal kwota)
    {
        if (kwota <= 0)
        {
            Console.WriteLine("Wynagrodzenie musi być większe od zera");
            return;
        } else
            wynagrodzenie = kwota;
            Console.WriteLine($"Zmieniono wynagrodzenie dla {imie} na {wynagrodzenie} zł");
    }
}

class Kierownik : Pracownik
{
    public Kierownik(decimal wynagrodzenie, string imie, string dzial) 
    : base(wynagrodzenie, imie, dzial) { }

    public void PrzedstawSie()
    {
        //wynagrodzenie = 100; - nie działa, nie można zmienić ze względu na private
        Console.WriteLine($"Nazywam się {imie}");
    }
}

class Program
{
    static void Main()
    {
        Pracownik pracownik1 = new Pracownik(4400, "Adam", "IT");
        Kierownik kierownik1 = new Kierownik(5100, "Mateusz", "IT");

        //pracownik1.wynagrodzenie = 100; - też nie działa
        pracownik1.PokazDane();
        kierownik1.PrzedstawSie();
        pracownik1.ZmienWynagrodzenie(4700);
        pracownik1.PokazDane();
    }
}
