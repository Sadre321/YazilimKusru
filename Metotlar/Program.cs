using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------");

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";
            urun1.SrokAdedi = 34;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";
            urun2.SrokAdedi = 45;

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine("Ürün adı :" + urun.Adi);
                Console.WriteLine("Fiyatı :" + urun.Fiyati);
                Console.WriteLine("Açıklama :" + urun.Aciklama);
                Console.WriteLine("------------------------------");
            }

            Console.WriteLine("------------------metotlar--------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle2("Armut", "Kırmızı armut", 5, 10);


        }
    }
}
