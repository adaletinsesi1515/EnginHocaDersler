using System;
using System.Collections.Generic;
using System.Text;

namespace OdevGame
{
    interface IOyuncuArayuz
    {
        void Ekle(Oyuncu oyuncu);
        void Duzeltme(Oyuncu oyuncu);
        void Silme(Oyuncu oyuncu);
    }
}
