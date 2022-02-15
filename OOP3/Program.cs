namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            ICreditManager tasitKrediManager=new TasitKrediManager();
            ICreditManager konutKrediManager =new KonutKrediManager();
            
            ILoggerService databaseloggerService = new DatabaseLoggerService();
            ILoggerService fileloggerService = new FileLoggerService();
             

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKrediManager(), new SmsLoggerService());
             
            List<ICreditManager> credits = new List<ICreditManager>() { ıhtiyacKrediManager,tasitKrediManager};
            //basvuruManager.KrediOnBilgilendirmesiYap(credits);

        }
    }



}