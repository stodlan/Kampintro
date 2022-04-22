using Oop2;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Tayfun";
            musteri1.Soyadi = "Mutlu";
            musteri1.TcNo = "123445678";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "56789";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "123245666666";


            // Gerçek müşteri- Tüzel müşteri -- birbirlerine benziyor diye birbirleri yerine kullanılamaz
            //SOLID

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            // yukarıya instancee oluşşturma denir. kullanmak için oluşturulmak zorundadır
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);


            
        }
    }
}