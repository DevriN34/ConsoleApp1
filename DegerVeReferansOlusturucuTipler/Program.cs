﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerVeReferansOlusturucuTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sayi1 = 10;
            int sayi2 = 35;
            sayi1 = sayi2;
            sayi2 = 65;
            
            
           int[] sayilar1  = new int[] { 10, 20,30 };
           int[] sayilar2 = new int[] { 100, 200,300 };
           sayilar1 = sayilar2;
           sayilar2[0] = 999;
            
            Console.WriteLine(sayi1);
            Console.WriteLine(sayilar1[0]);

            Console.ReadKey();  

        }
    }
}
