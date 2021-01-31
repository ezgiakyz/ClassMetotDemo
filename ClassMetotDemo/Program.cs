using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAd = "EZGİ";
            musteri1.Soyadı = "AKYÜZ";
            musteri1.Yas = 28;
            musteri1.Adres = "İSTANBUL";

            Musteri musteri2= new Musteri();
            musteri2.MusteriAd = "CANER";
            musteri2.Soyadı = "AKYÜZ";
            musteri2.Yas = 34;
            musteri2.Adres = "İSTANBUL";

            Musteri musteri3= new Musteri();
            musteri3.MusteriAd = "EZGİ1";
            musteri3.Soyadı = "AKYÜZ";
            musteri3.Yas = 28;
            musteri3.Adres = "İSTANBUL";

            Musteri musteri4= new Musteri();
            musteri4.MusteriAd = "CANER1";
            musteri4.Soyadı = "AKYÜZ";
            musteri4.Yas = 34;
            musteri4.Adres = "İSTANBUL";

            Musteri[] Musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };
            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("*************Sisteme Eklenen Müşteriler***************");
            foreach (var item in Musteriler)
            {
                musteriManager.Ekle(item);
            }
            Console.WriteLine("*************Sistemde kayıtlı müşeriler****************");
            foreach (var item in Musteriler)
            {
                musteriManager.Listele(item);
            }
            Console.WriteLine("**************************");
            musteriManager.Silme(musteri2);
        }
    }
}
