// See https://aka.ms/new-console-template for more information

string kurs1 = "yazilim gelistirme";
string kurs2 = "programlama baslangıc";
string kurs3 = "java";

// array - dizi

string[] kurslar = new string[] {
    "yazilim gelistirme",
    "programlama baslangıc",
    "java",
    "python" };


 

for (int i = 0; i < kurslar.Length; i++)    
{
    Console.WriteLine(kurslar[i]);

}

Console.WriteLine("for bitti");

foreach (string  kurs in kurslar)
{
    Console.WriteLine(kurs);

}
 
Console.WriteLine("sayfa sonu- footer");

