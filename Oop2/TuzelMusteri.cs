using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{
    // entity bunlar - varlık sınıfı
    // Coorporate
    // miras - inheritance --> asagı yazılan musteri inheritance'dır
    class TuzelMusteri :Musteri 
    {
        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }

    }
}
