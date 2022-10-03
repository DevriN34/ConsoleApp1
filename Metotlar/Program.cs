using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Urunadi = "Elma";
            double Urunfiyat = 15;
            string Aciklama = "amasya elmasi";

            string[] meyveler = new string[] { "Elma", "Karpuz" };


            Urun Urun1 = new Urun();

            Urun1.Adi = "Elma";
            Urun1.Fiyati = 15;
            Urun1.Aciklama = "amasya elmasi";


            Urun Urun2 = new Urun { };
            
            Urun2.Adi = "karpuz";
            Urun2.Fiyati = 80;
            Urun2.Aciklama = "Diyarbakır karpuz";

            Urun[] Urunler = new Urun[] { Urun1,Urun2};
            
            foreach (Urun Urun in Urunler)
            {
                Console.WriteLine(Urun.Adi);
                Console.WriteLine(Urun.Fiyati);
                Console.WriteLine(Urun.Aciklama);
                Console.WriteLine("---------------");
            }

            Console.WriteLine("----------------Metotlar----------------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(Urun1);
            sepetManager.Ekle(Urun2);

            sepetManager.Ekle2("Armut", "yesil armut" ,12,10);
            sepetManager.Ekle2("Elma", "yesil elma",12,9);
            sepetManager.Ekle2("karmuz","D karpuz",12,8);






            Console.ReadLine();
       
        }
    }

  
}
