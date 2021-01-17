using System;

namespace YazilimKusru
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                //type safety =tip güvenliği
                //Do not repaet yourtself
                string kategoriEtiketi = "Kategori :";
                int ogrenciSayisi = 32000;
                double faizOrani = 1.45;
                bool sistemeGirisYapmisMi = false;
                double dolarDun = 7.45;
                double dolarBugun = 7.45;

                if (dolarDun > dolarBugun)
                {
                    Console.WriteLine("Azalış butonu göster");
                }
                else if (dolarDun < dolarBugun)
                {
                    Console.WriteLine("Artış");
                }
                else
                {
                    Console.WriteLine("Dolar sabit");
                }

                if (sistemeGirisYapmisMi == true)
                {
                    Console.WriteLine("Ayarlar butonu");
                }
                else
                {
                    Console.WriteLine("Giriş yap butonu ");
                }

                Console.WriteLine(kategoriEtiketi);
            }
    }
}
