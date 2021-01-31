using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAd + " isimli müşteri sisteme kayddildi.");
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAd);
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAd + " isimli müşteri sistemden silindi");
        }
    }
}
