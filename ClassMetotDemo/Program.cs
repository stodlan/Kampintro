// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Yas = 28;
            musteri1.Ad = "Ahmet";
            musteri1.Soyad = "Adalı";

            Musteri musteri2 = new Musteri();
            musteri2.Yas = 26;
            musteri2.Ad = "Ali Hasret";
            musteri2.Soyad = "Gurer";

            Musteri musteri3 = new Musteri();
            musteri3.Yas = 24;
            musteri3.Ad = "Sinan";
            musteri3.Soyad = "Egilmez";

            //Musteri musteri = new Musteri();

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri2);

            musteriManager.Listele(musteriler);

            musteriManager.Sil(musteri3);



           
        }
    }
}

