using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // bu işleme inharetans - miras --> tüzelmüşteri bir müşteridir anlamına gelir
    class TuzelMusteri : Musteri
    {      
        public string SirketAdi { get; set; }

        public string VergiNo { get; set; }
    }
}
