using System;

namespace DictionaryGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(35, "Memduh");
            Console.WriteLine(myDictionary.Count);

        }
    }

    class MyDictionary<Sayi, Karakter>
    {
        Sayi[] _sayi;
        Karakter[] _karakter;

        Sayi[] _TempSayi;
        Karakter[] _TempKarakter;

        public MyDictionary()
        {
            _sayi = new Sayi[0];
            _karakter = new Karakter[0];
        }

        public void Add(Sayi item, Karakter item1)
        {
            _TempSayi = _sayi;
            _TempKarakter = _karakter;
            _sayi = new Sayi[_sayi.Length + 1];
            _karakter = new Karakter[_karakter.Length + 1];
            for (int i = 0; i < _TempSayi.Length; i++)
            {
                _sayi[i] = _TempSayi[i];
            }
            for (int x = 0; x < _TempKarakter.Length; x++)
            {
                _karakter[x] = _TempKarakter[x];
            }

            _sayi[_sayi.Length - 1] = item;
            _karakter[_karakter.Length - 1] = item1;
        }

        public int Count
        {
            get { return _sayi.Length; }
            
        }
    }
}
