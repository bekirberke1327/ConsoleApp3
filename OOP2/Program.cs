using System;

namespace OOP2
{
    class Program
    {

        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "141300";
            musteri1.Adi = "Bekir";
            musteri1.Soyadi = "Aslan";
            musteri1.TcNo = "15049448386";
            

            TüzelMusteri musteri2 = new TüzelMusteri();
            musteri2.Id = 2;
            musteri2.SirketAdi = "MilleniumMed";
            musteri2.VergiNo = "135790";
            musteri2.MusteriNo = "141301";
            


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TüzelMusteri();


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);


        }

    }
}