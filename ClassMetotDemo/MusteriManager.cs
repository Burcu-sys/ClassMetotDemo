using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi : "+musteri.Adi);
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listesi");
            Console.WriteLine("Id:" + musteri.Id);
            Console.WriteLine("Adı:" + musteri.Adi);
            Console.WriteLine("Soyadı:" + musteri.Soyadi);
            Console.WriteLine("Telefon:" + musteri.Telefon);
            Console.WriteLine("----------------------------------");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi : "+musteri.Adi);
        }
    }
}
