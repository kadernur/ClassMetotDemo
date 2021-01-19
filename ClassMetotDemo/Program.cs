using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Kader";
            musteri1.Soyad = "Tekin";
            musteri1.HesapNo = 12345678;
            musteri1.Bakiye = 5000;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Helin";
            musteri2.Soyad = "Tekin";
            musteri2.HesapNo = 1237895;
            musteri2.Bakiye = 25000;


            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Havva";
            musteri3.Soyad = "Tekin";
            musteri3.HesapNo = 1562441;
            musteri3.Bakiye = 15000;

            //Müşterileri array'a koyalım
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };


            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri Id : " +musteri.Id);
                Console.WriteLine("Müşteri Adı: "+musteri.Ad);
                Console.WriteLine("Müşteri Soyad: " +musteri.Soyad);
                Console.WriteLine("Müşteri Hesap No : "+musteri.HesapNo);
                Console.WriteLine("Müşteri Bakiye: " +musteri.Bakiye);
                Console.WriteLine("**************************");



            }

            MusteriManager musteriManager = new MusteriManager();
            foreach (var musteri in  musteriler)
            {
                musteriManager.Ekle(musteri);
                
            }

            Console.WriteLine(" ");
            Console.WriteLine("Bütün Müşteriler");
            foreach (var v in musteriler)
            {
                musteriManager.Listele(v);

            }
            Console.WriteLine("----------------------- ");

            foreach (var v in musteriler)
            {
                musteriManager.Sil(v);
                musteriManager.MusteriGuncelle(v);

            }
            Console.WriteLine("----------------------- ");

        start: Console.WriteLine("Enter an ID Code:");

            int Number = new int();
            Number = Convert.ToInt32(Console.ReadLine());

            bool foundIt = new bool();

            for (int i = 0; i < musteriler.Length; i++)
            {
                if (Number == musteriler[i].Id)
                {
                    foundIt = true;
                    musteriManager.Sil(musteriler[i]);
                    goto start;
                }
                foundIt = false;

            }
            if (foundIt == false)
            {
                Console.WriteLine("Invalid ID Code.");
                Console.WriteLine(" ");
                goto start;
            }







        }
    }
}
