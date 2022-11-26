using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            GercekMusteri gercekMusteri1 = new GercekMusteri();
            gercekMusteri1.Id = 1;
            gercekMusteri1.MusteriNo = "12345";
            gercekMusteri1.Adi = "Ozan";
            gercekMusteri1.Soyadi = "Devrin";
            gercekMusteri1.TcNo = "12345678911";


            TuzelMusteri tuzelMusteri = new TuzelMusteri();

            tuzelMusteri.Id= 2;
            tuzelMusteri.MusteriNo="12345";
            tuzelMusteri.SirketAdi = "Kodlama.io";
            tuzelMusteri.VergiNo = "123456";

            Musteri musteri1 = new GercekMusteri();
            Musteri musteri2 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);


        }
    }
}
