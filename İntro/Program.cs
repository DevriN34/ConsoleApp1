using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi = "ozan";
            int yas = 36;


            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmeni = "Ozan";
            kurs1.İzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java#";
            kurs2.Egitmeni = "kerem";
            kurs2.İzlenmeOrani = 33;
           
            
            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python#";
            kurs3.Egitmeni = "berke";
            kurs3.İzlenmeOrani = 81;

            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3 };

            Console.ReadKey();

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : "+ kurs.Egitmeni );
            }

            Console.ReadKey();
        }
    }
    class Kurs
    {

        public string KursAdi { get; set; }
        public string Egitmeni { get; set; }
        public int İzlenmeOrani { get; set; }
    }








   
}
