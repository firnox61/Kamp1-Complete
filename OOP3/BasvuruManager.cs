using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {//herkrezin bilgilerini referans tutabilen
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices)/* ILoggerService loggerService*///birden fazla loglama kullanıcaksam list yaparım
        {
            krediManager.Hesapla();
            foreach(var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
        //birden fazla kredinin hesabını yapmak için List
        public void KrediOnBilgilendirmesi(List<IKrediManager> krediler) 
        {
            foreach(var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
