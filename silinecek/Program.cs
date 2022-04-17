
Bolum bolum1 = new Bolum();
bolum1.ders = "EMAT";
bolum1.ogretmen = "Erkan mese";
bolum1.ogrenci = 30;

Bolum bolum2 = new Bolum();
bolum2.ders = "mat";
bolum2.ogretmen = "beyso";
bolum2.ogrenci = 30;

Bolum[] bolumler = { bolum1, bolum2 };

foreach (Bolum bolum in bolumler)
{
    Console.WriteLine(bolum.ogretmen, "---- ", bolum.ders);

}

class Bolum
{
    public string ders { get; set; }
    public string ogretmen { get; set; }

    public int ogrenci { get; set; }

}