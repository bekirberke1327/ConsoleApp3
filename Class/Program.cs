class Program
{
    static void Main(string[] args)
    {

        string adi = "Bekir";
        int yas = 22;

        Kurs kurs1 = new Kurs();

        kurs1.KursAdı = "C#";
        kurs1.Eğitmen = "Engin Demiroğ";
        kurs1.İzlenmeOranı = 68;

        Kurs kurs2 = new Kurs();

        kurs2.KursAdı = "Java";
        kurs2.Eğitmen = "Ali Hocaoğlu";
        kurs2.İzlenmeOranı = 64;

        Kurs kurs3 = new Kurs();

        kurs3.KursAdı = "Python";
        kurs3.Eğitmen = "Burakcan Durgut";
        kurs3.İzlenmeOranı = 55;

        Kurs kurs4 = new Kurs();

        kurs4.KursAdı = "Javascript";
        kurs4.Eğitmen = "Buğrahan Yeke";
        kurs4.İzlenmeOranı = 3;


        //Console.WriteLine(kurs1.KursAdı + " : " + kurs1.Eğitmen);


        Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };


        foreach (Kurs kurs in kurslar)
        {
            Console.WriteLine(kurs.KursAdı + " : " + kurs.Eğitmen);
        }

    }
}









class Kurs
{
    public string KursAdı { get; set; }
    public string Eğitmen { get; set; }
    public int İzlenmeOranı { get; set; }

}








//class Kurs
//{
//    public string KursAdı { get; set; }
//    public string Eğitmen { get; set; }
//    public string İzlenmeOranı { get; set; }
//}


