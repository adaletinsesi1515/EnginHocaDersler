using System;

namespace GameProjectOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            OyuncuManager oyuncuManager = new OyuncuManager(new DogrulamaManager());
            oyuncuManager.Ekle(new Oyuncu 
            {
                ID = 1,
                Adi = "Memduh",
                Soyadi = "Gümen",
                DogumYili = 1980,
                TCNo = 12345            
            });
            
            
            //Oyuncu oyuncu1 = new Oyuncu();
            //oyuncu1.ID = 1;
            //oyuncu1.Adi = "Memduh";
            //oyuncu1.Soyadi = "Gümen";
            //oyuncu1.DogumYili = 1981;
            //oyuncu1.TCNo = 12345;
            //oyuncuManager.Ekle(oyuncu1); 
            

        }
    }
}
