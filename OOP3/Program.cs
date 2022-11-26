using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager krediManager = new IhtiyacKrediManager();
            krediManager.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();
            tasitKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();
            
            ILoggerService databaseloggerservice = new DatebaseLoggerService();
            ILoggerService fileloggerservis = new FileLoggerService();
            ILoggerService smsloggerservice = new SmsLoggerService();
            List<ILoggerService> loggers = new List<ILoggerService>()
            { new SmsLoggerService(),new FileLoggerService() };

            EsnafKrediManager esnafKrediManager = new EsnafKrediManager();
            BasvuruManager basvuruManager = new BasvuruManager();

            basvuruManager.BasvuruYap(esnafKrediManager,new List<ILoggerService> 
            {databaseloggerservice,smsloggerservice,fileloggerservis });

            List<IKrediManager> krediler = new List<IKrediManager>( ) { esnafKrediManager ,tasitKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);



            Console.Read();

        }
    }
}
