using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectOdev
{
    class DogrulamaManager : IDogrulamaService
    {
        public bool Dogrulama(Oyuncu oyuncu)
        {
            if (oyuncu.Adi == "Memduh" && oyuncu.Soyadi == "Gümen" && oyuncu.DogumYili == 1980 && oyuncu.TCNo == 12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
