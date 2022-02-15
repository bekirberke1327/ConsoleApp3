//namespace KampIntro
//{
//    class Program
//    {

//        static void Main(string[] args)
//        {
//            string kategoriEtiketi = "kategori";
//            int birimAdeti = 12;
//            double faizOranı = 1.45;
//            bool sistemeGirişYapmişMi = false;
//            double dolarDun = 7.35;
//            double dolarBugun = 7.45;

//            if (dolarDun > dolarBugun)
//            {
//                Console.WriteLine("Azalış butonu");
//            }
//            else if (dolarDun < dolarBugun)
//            {
//                Console.WriteLine("Artış butonu");
//            }
//            else
//            {
//                Console.WriteLine("Değişmedi Butonu");
//            }

//            if (sistemeGirişYapmişMi == true)
//            {
//                Console.WriteLine("Ayarlar butonu");
//            }
//            else
//            {
//                Console.WriteLine("Giriş yap butonu");
//            }

//            Console.WriteLine(faizOranı);

//            Console.WriteLine(birimAdeti);

//            Console.WriteLine(kategoriEtiketi);

//        }

//    }
//}

//double dolarDun = 12.75;
//double dolarBugun = 12.75;

//if (dolarDun > dolarBugun)
//{
//    Console.WriteLine("Düşüş var");
//}

//else if (dolarDun < dolarBugun)
//{
//    Console.WriteLine("Yükseliş var");
//}
//else
//{
//    Console.WriteLine("Sabit");
//}

double dolarDun = 11.50;

double dolarBugün = 12.50;

if (dolarDun>dolarBugün)
{
    Console.WriteLine("Düşüş var");
}
else if (dolarDun < dolarBugün)
{
    Console.WriteLine("Yükseliş var");
}
else
{
    Console.WriteLine("Sabit");
}





bool sistemeGirişYapmişMi = false;

if (sistemeGirişYapmişMi == true)
{
    Console.WriteLine("Giriş Başarılı");
}
else
{
    Console.WriteLine("Giriş Başarısız");
}