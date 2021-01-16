using System;

namespace UrunListeleme
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Asus Notebook";
            urun1.UrunFiyati = 5000;
            urun1.IndirimOrani = 11;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Lenova Notebook";
            urun2.UrunFiyati = 7000;
            urun2.IndirimOrani = 20;

            Urun urun3 = new Urun();
            urun3.UrunAdi = "Toshiba Notebook";
            urun3.UrunFiyati = 8500;
            urun3.IndirimOrani = 15;

            Urun[] urunler = new Urun[] {urun1,urun2,urun3};

            Console.WriteLine("For ile listeleme");
            Console.WriteLine("---------------------");
            for (int i = 0; i <urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].UrunAdi+" - "+urunler[i].UrunFiyati+" - "+urunler[i].IndirimOrani);
            }

            Console.WriteLine("------------------------------------------");

            Console.WriteLine("foreach ile listeleme");
            Console.WriteLine("---------------------");
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi + " - " + urun.UrunFiyati + " - " + urun.IndirimOrani);
            }

            Console.WriteLine("------------------------------------------");

            Console.WriteLine("while ile listeleme");
            Console.WriteLine("---------------------");
            int j = 0;
            while (j<urunler.Length)
            {
                Console.WriteLine(urunler[j].UrunAdi + " - " + urunler[j].UrunFiyati + " - " + urunler[j].IndirimOrani);
                j++;
            }

            Console.ReadKey();
        }
    }
    class Urun
    {
        public string UrunAdi { get; set; }
        public int UrunFiyati { get; set; }
        public int IndirimOrani { get; set; }
    }
}
