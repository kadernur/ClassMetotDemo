using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi " + musteri.Ad +" " +musteri.Soyad + " " + musteri.Id + " " + musteri.HesapNo + " " + musteri.Bakiye);

        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi "+musteri.Ad+" " + musteri.Soyad);


        }
        public void MusteriGuncelle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " Müşterisinin bilgileri güncellendi.");
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + musteri.Ad + " " + musteri.Soyad+" "+ musteri.Bakiye);
        }
    }
}
