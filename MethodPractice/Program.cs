using MethodPractice;

namespace MethodPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Bardak";
            urun1.Adet = 5;
            urun1.Fiyat = 25;


            Urun urun2 = new Urun();
            urun2.Adi = "Kaşık";
            urun2.Adet = 3;
            urun2.Fiyat = 15;


            Urun urun3 = new Urun();
            urun3.Adi = "Çatal";
            urun3.Adet = 6;
            urun3.Fiyat = 24;


            Urun urun4 = new Urun();
            urun4.Adi = "Vazo";
            urun4.Adet = 5;
            urun4.Fiyat = 325;



            Urun[] urunler = new Urun[] {urun1, urun2, urun3, urun4};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Adet);
                Console.WriteLine(urun.Fiyat); 
                Console.WriteLine("----------------");
            }
            
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);
            sepetManager.Ekle(urun4);

        }
    }

}