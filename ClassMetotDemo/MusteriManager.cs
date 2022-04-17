using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        

        public void Ekle(Musteri musteri)
        {

            Console.WriteLine(" Eklendi :" + musteri.Ad);
        }
        
        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler) 
            {
                Console.WriteLine(musteri.Ad + musteri.Soyad + "- " + musteri.Yas );
            }

        }

        public void Sil(Musteri musteri) 
        {
            Console.WriteLine(musteri.Ad +  " Silindi");
        }
                    

        
        
    }
}
