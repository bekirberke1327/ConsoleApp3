class HesapMakinesi
{
    static void Main(string[] args)
    {
        int sayi1, sayi2;


        double sonuc;
        string işlem;
        List<string> gecmis = new List<string>();



        while (true)
        {

            Console.WriteLine("Yapmak İstediğiniz işlemi giriniz(*,/,+,-) ");
            işlem = Console.ReadLine();
            if (işlem == "Geçmiş")
            {
                for (int i = 0; i < gecmis.Count; i++)
                {
                    Console.WriteLine(gecmis[i]);
                }

                Console.WriteLine("Yapmak İstediğiniz işlemi giriniz(*,/,+,-) ");
                işlem = Console.ReadLine();
            }

            Console.WriteLine("İlk sayiyi giriniz");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci sayiyi giriniz");
            sayi2 = Convert.ToInt32(Console.ReadLine());


            if (işlem == "*")
            {
                sonuc = sayi1 * sayi2;
                Console.WriteLine("Sonuç" + sonuc);
                gecmis.Add(sayi1 + "*" + sayi2 + "=" + sonuc);
                if (sonuc % 2 == 0)
                {
                    Console.WriteLine("Çift");
                }
                else
                {
                    Console.WriteLine("Tek");
                }
            }
            if (işlem == "+")
            {
                sonuc = sayi1 + sayi2;
                Console.WriteLine("Sonuç" + sonuc);
                gecmis.Add(sayi1 + "+" + sayi2 + "=" + sonuc);
                if (sonuc % 2 == 0)
                {
                    Console.WriteLine("Çift");
                }
                else
                {
                    Console.WriteLine("Tek");
                }
            }
            if (işlem == "/")
            {
                sonuc = sayi1 / sayi2;
                Console.WriteLine("Sonuç: " + sonuc);
                gecmis.Add(sayi1 + "/" + sayi2 + "=" + sonuc);
                if (sonuc % 2 == 0)
                {
                    Console.WriteLine("Çift");
                }
                else
                {
                    Console.WriteLine("Tek");
                }
            }
            if (işlem == "-")
            {
                sonuc = sayi1 - sayi2;
                Console.WriteLine("Sonuç" + sonuc);
                gecmis.Add(sayi1 + "-" + sayi2 + "=" + sonuc);
                if (sonuc % 2 == 0)
                {
                    Console.WriteLine("Çift");
                }
                else
                {
                    Console.WriteLine("Tek");
                }
            }
            
        }



    }






}