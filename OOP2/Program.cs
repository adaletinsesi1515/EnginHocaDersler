using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Soyutlama

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "565";
            musteri1.Adi = "Memduh";
            musteri1.Soyadi = "Gümen";
            musteri1.TCNo = "376300";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "999";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "987456";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(musteri1);
            customerManager.Ekle(musteri2);
            customerManager.Ekle(musteri3);
            customerManager.Ekle(musteri4);






        }
    }
}
