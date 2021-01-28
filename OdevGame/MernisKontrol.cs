using System;
using System.Collections.Generic;
using System.Text;

namespace OdevGame
{
    class MernisKontrol:Oyuncu
    {
        public void kontrol()
        {
            if (true)
            {
                Id = 1;
                Adi = "Memduh";
                Soyadi = "Gümen";
                TCNo = 12345;
            }
            else
            {
                Console.WriteLine("Kontrol başarısız");
            }
        }
    }
}
