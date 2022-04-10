using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Metotlar
{
     class Program
    {
        static void Main(string[] args)
    
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyatı = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyatı= 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyatı); 
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------");


            }


            Console.WriteLine("-------Metotlar-----");

            // instance
            // encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "Yesil armut", 12, 10);
            sepetManager.Ekle2("elma", "Yes,l elma", 12, 15);
            sepetManager.Ekle2("karpuz", "yasil larpuz", 12, 18);
            



        }
    }
}