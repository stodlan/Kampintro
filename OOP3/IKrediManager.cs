using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();

    }
    // interface'leri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız
    //kredi türlerinin hepsine bir hesaplama var - geri ödeme ortaktır ama faiz farklıdır

}
