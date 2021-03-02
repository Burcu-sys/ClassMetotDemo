using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Ayşe";
            musteri1.Soyadi = "Ay";
            musteri1.Id = 1;
            musteri1.Telefon = "123456";

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Ali";
            musteri2.Soyadi = "Bak";
            musteri2.Id = 2;
            musteri2.Telefon = "654789";

           

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            Console.WriteLine("-------------------------");
            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Sil(musteri2);
        }
    }
}
