using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectOdev
{
    interface IOyuncuService
    {
        void Ekle(Oyuncu oyuncu);
        void Duzeltme(Oyuncu oyuncu);
        void Silme(Oyuncu oyuncu);

    }
}
