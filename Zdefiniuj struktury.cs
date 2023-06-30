struct Student
{
    public string Imie;
    public string Nazwisko;
    public int NumerIndeksu;
    public string Kierunek;
}


struct Przedmiot
{
    public string Nazwa;
    public string Kod;
    public int ECTS;
    public int Semestr;
}


struct NauczycielAkademicki
{
    public string Imie;
    public string Nazwisko;
    public string TytulNaukowy;
    public string Katedra;
}


Student student1 = new Student();
student1.Imie = "Adam";
student1.Nazwisko = "Jelon";
student1.NumerIndeksu = 12;
student1.Kierunek = "Informatyka";

Przedmiot przedmiot1 = new Przedmiot();
przedmiot1.Nazwa = "Programowanie";
przedmiot1.Kod = "INF191";
przedmiot1.ECTS = 7;
przedmiot1.Semestr = 8;

NauczycielAkademicki nauczyciel1 = new NauczycielAkademicki();
nauczyciel1.Imie = "Katarzyna";
nauczyciel1.Nazwisko = "Olbrys";
nauczyciel1.TytulNaukowy = "mgr";
nauczyciel1.Katedra = "Informatyki";
