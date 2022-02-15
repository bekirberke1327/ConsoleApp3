using System;
using System.Collections.Generic;
using System.Text;


namespace Homework2
{
    class MusteriManager
    {
        public void Ekle(Musteri[] musteriler)
        {
            foreach (Musteri Musteri in musteriler)
            {
                Console.WriteLine("Id : " + Musteri.Id);
                Console.WriteLine("Adı : " + Musteri.Adi);
                Console.WriteLine("Soyadı : " + Musteri.SoyAd);
                Console.WriteLine("Bakiye : " + Musteri.Bakiye);
                Console.WriteLine("Müşteri Bilgileri Başarıyla Eklendi");
            }

        }
        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri Musteri in musteriler)
            {
                Console.WriteLine("Id : " + Musteri.Id);
                Console.WriteLine("Adı : " + Musteri.Adi);
                Console.WriteLine("Soyadı : " + Musteri.SoyAd);
                Console.WriteLine("Bakiye : " + Musteri.Bakiye);
                Console.WriteLine("Müşteri Bilgileri Başarıyla Listelendi");

            }
        }

        public void Sil(int id,string musteriAd ,string musteriSoyad,int bakiye)
        {
           
                Console.WriteLine("Id = " +id  +"  Müşteri Id li bilgiler Başarılı Şekilde Silinmiştir");
            Console.WriteLine(id);
            Console.WriteLine(musteriAd);
            Console.WriteLine(musteriSoyad);
            Console.WriteLine(bakiye);


        }
        public void Guncelle(Musteri[] musteriler)
        {
            foreach (Musteri Musteri in musteriler)
            {
                Console.WriteLine("Id : " + Musteri.Id);
                Console.WriteLine("Adı : " + Musteri.Adi);
                Console.WriteLine("Soyadı : " + Musteri.SoyAd);
                Console.WriteLine("Bakiye : " + Musteri.Bakiye);
                Console.WriteLine("Müşteri Bilgileri Başarıyla Güncellendi");
                Console.WriteLine();
            }
        }

    }
}