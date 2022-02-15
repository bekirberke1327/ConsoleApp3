using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Baki";
            musteri1.SoyAd = "Aslan";
            musteri1.Bakiye = 100000;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Bekir";
            musteri2.SoyAd = "Aslan";
            musteri2.Bakiye = 850;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Nilüfer";
            musteri3.SoyAd = "Aslan";
            musteri3.Bakiye = 10;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Adi = "Hülya";
            musteri4.SoyAd = "Aslan";
            musteri4.Bakiye = 20000;


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };
            


             
            Musteri[] Musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };
            MusteriManager Musteri = new MusteriManager();
            Musteri.Ekle(Musteriler);
            Musteri.Listele(Musteriler);
            Musteri.Sil(musteri1.Id,musteri1.Adi, musteri1.SoyAd,musteri1.Bakiye);
            Musteri.Guncelle(Musteriler);
              

        }
    }
}
