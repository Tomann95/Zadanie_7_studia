using Internal;

enum Rzadkosc
{
    Powszechny,
    Rzadki,
    Unikalny,
    Epicki
}

enum TypPrzedmiotu
{
    Bron,
    Zbroja,
    Amulet,
    Pierscien,
    Helm,
    Tarcza,
    Buty
}

struct Przedmiot
{
    public float Waga;
    public int Wartosc;
    public Rzadkosc Rzadkosc;
    public TypPrzedmiotu Typ;
    public string NazwaWlasna;
}


Przedmiot miecz;
miecz.Waga = 3.5f;
miecz.Wartosc = 100;
miecz.Rzadkosc = Rzadkosc.Rzadki;
miecz.Typ = TypPrzedmiotu.Bron;
miecz.NazwaWlasna = "Miecz Świetlny";

Console.WriteLine("Przedmiot: " + miecz.NazwaWlasna);
Console.WriteLine("Typ: " + miecz.Typ);
Console.WriteLine("Rzadkosc: " + miecz.Rzadkosc);
Console.WriteLine("Waga: " + miecz.Waga);
Console.WriteLine("Wartosc: " + miecz.Wartosc);
