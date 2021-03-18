using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Tc = 12345678911;
            musteri1.Ad = "Murat";
            musteri1.Soyad = "KAYA";
            musteri1.Cinsiyet = "Erkek";
            musteri1.Yas = 22;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Tc = 12345678912;
            musteri2.Ad = "seda";
            musteri2.Soyad = "çiçek";
            musteri2.Cinsiyet = "Kız";
            musteri2.Yas = 20;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            Console.WriteLine("---------Müşteri Listesi---------");
            foreach (var musterilers in musteriler)
            {
                musteriManager.Listele(musterilers);
            }
            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            Console.ReadLine();


        }
    }
}
