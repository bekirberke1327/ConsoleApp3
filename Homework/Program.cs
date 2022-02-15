class Program
{
    static void Main(string[] args)
    {

        Kurs kurs1 = new Kurs();
        kurs1.KursAdi = "Temel Matematik";
        kurs1.Eğitmen = "Bekir Aslan";
        kurs1.İzlenmeOranı = 80;

        Kurs kurs2 = new Kurs();
        kurs2.KursAdi = "Fizik";
        kurs2.Eğitmen = "Nilüfer Aslan";
        kurs2.İzlenmeOranı = 95;

        Kurs kurs3 = new Kurs();
        kurs3.KursAdi = "Biyoloji";
        kurs3.Eğitmen = "Buğrahan Yeke";
        kurs3.İzlenmeOranı = 75;

        Kurs kurs4 = new Kurs();
        kurs4.KursAdi = "C#";
        kurs4.Eğitmen = "Furkan Yeke";
        kurs4.İzlenmeOranı = 100;

        Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

        foreach (Kurs kurs in kurslar)
        {
            Console.WriteLine(kurs.KursAdi + " : " + kurs.Eğitmen + " % " + kurs.İzlenmeOranı);
        }
    }
}



class Kurs
{
    public string KursAdi { get; set; }
    public string Eğitmen { get; set; }
    public int İzlenmeOranı { get; set; }
}



//string kullaniciAdi = "", sifre = "";

//Console.WriteLine("Kullanici Adini Girin: ");

//kullaniciAdi = Console.ReadLine();
//Console.WriteLine("Sifreyi Girin");

//sifre = Console.ReadLine();

//string durum = (kullaniciAdi == "admin" && sifre == "12345") ? "Giris Basarili" : "Kullanici adi ve ya sifre hatali";

//Console.WriteLine(durum);

//string kullanıcıAdi = "", sifre = "";
//Console.WriteLine("Kullanıcı adını giriniz");
//kullanıcıAdi = Console.ReadLine();
//Console.WriteLine("Şifreyi giriniz");
//sifre = Console.ReadLine();
//string durum = (kullanıcıAdi == "admin" && sifre == "12345") ? "Giriş Başarılı" : "Giriş Başarısız";
//Console.WriteLine(durum);


