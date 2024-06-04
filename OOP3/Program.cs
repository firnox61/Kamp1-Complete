using OOP3;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
        TasitKrediManager tasitKrediManager= new TasitKrediManager();
        KonutKrediManager konutKrediManager=new KonutKrediManager();
        BasvuruManager basvuruManager = new BasvuruManager();
        EsnafKrediManager esnafKrediManager=new EsnafKrediManager();

        ILoggerService databaseLoggerService= new DatabaseLoggerService();
        ILoggerService fileLoggerService = new FileLoggerService();
        List<ILoggerService> loggers = new List<ILoggerService> { new FileLoggerService(), new DatabaseLoggerService() };






        basvuruManager.BasvuruYap(esnafKrediManager, loggers);


        List<IKrediManager> krediler = new List<IKrediManager>()
        {
            ihtiyacKrediManager, tasitKrediManager
        };
       // basvuruManager.KrediOnBilgilendirmesi(krediler);



        //IKrediManager deneme = new IhtiyacKrediManager();//böyle de oluyor interfacelrede sıkıntı yok


    }
}