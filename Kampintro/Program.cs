// See https://aka.ms/new-console-template for more information
// type safety
// do not repeat yourself

string kategoriEtiketi = "Kategori";
int ogrenciSayisi = 32000;
double faizOranı = 1.45;
bool sistemeGirisYapmisMi = true;
double dolarDun = 7.55;
double dolarBugun = 7.55;

if (dolarDun > dolarBugun) 
{
    Console.WriteLine("Azalis butonu");
}
else if(dolarDun < dolarBugun)
{
    Console.WriteLine("Artış oku");
}
else
{
    Console.WriteLine("Sabit ok");
}

if (sistemeGirisYapmisMi == true )
{
    Console.WriteLine("Ayarlar butonu");
}
else
{
    Console.WriteLine("Giris yap butonu");
}

Console.WriteLine(kategoriEtiketi);


