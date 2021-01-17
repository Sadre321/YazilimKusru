using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad = "Haydar";
            int yas = 17;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmeni = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 100;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmeni = "Berkin";
            kurs2.IzlenmeOrani = 10;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmeni = "Erem Demir";
            kurs3.IzlenmeOrani = 54;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmeni = "Murat Kurt";
            kurs4.IzlenmeOrani = 84;

            Console.WriteLine(kurs1.KursAdi + " :" + kurs1.Egitmeni);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmeni);
            }

            Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
    

