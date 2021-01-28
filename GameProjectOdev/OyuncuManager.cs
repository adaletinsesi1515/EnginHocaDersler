using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectOdev
{
    class OyuncuManager : IOyuncuService
    {
        DogrulamaManager _dogrulamaManager;

        public OyuncuManager(DogrulamaManager dogrulamaManager)
        {
            _dogrulamaManager = dogrulamaManager;
        }

        public void Duzeltme(Oyuncu oyuncu)
        {
            Console.WriteLine("Oyuncu kaydı düzeltildi");
        }

        public void Ekle(Oyuncu oyuncu)
        {
            if (_dogrulamaManager.Dogrulama(oyuncu) == true)
            {
                Console.WriteLine("Oyuncu sisteme eklendi");
            }
            else
            {
                Console.WriteLine("Kişi bilgileri doğrulanamadı");
            }
            
        }

        public void Silme(Oyuncu oyuncu)
        {
            Console.WriteLine("Oyuncu sistemden silindi");
        }
    }
}
