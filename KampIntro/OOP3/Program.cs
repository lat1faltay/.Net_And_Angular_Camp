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
            
            //IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            // //ihtiyacKrediManager.Hesapla();


            //IKrediManager tasitKrediManager = new TasitKrediManager();
            TasitKrediManager tasitKrediManager = new TasitKrediManager(); 
            // //tasitKrediManager.Hesapla();

            //IKrediManager konutKrediManager = new KonutKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();
            // //konutKrediManager.Hesapla();

            EsnafKrediManager esnafKrediManager = new EsnafKrediManager();

            // Loglama işlemleri aşağıdaki kodlarla sağlanmaktadır
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            List<ILoggerService> loggers = new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService() };

            basvuruManager.BasvuruYap(esnafKrediManager, loggers );
            // new List<ILoggerService> {new FileLoggerService(), new SmsLoggerService() }

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);



            Console.ReadKey();
        }
    }
}
