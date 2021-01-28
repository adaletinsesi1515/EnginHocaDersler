using System;
using System.Collections.Generic;
using System.Text;

namespace OdevGame
{
    class OyuncuManager : IOyuncuArayuz
    {
        MernisKontrol _mernisKontrol;
        public void Ekle(Oyuncu oyuncu)
        {
           
            Console.WriteLine("Oyuncu Eklendi");
        }
        public void Duzeltme(Oyuncu oyuncu)
        {
            Console.WriteLine("Oyuncu Düzeltildi");
        }      

        public void Silme(Oyuncu oyuncu)
        {
            Console.WriteLine("Oyuncu Silindi");
        }
    }
}
