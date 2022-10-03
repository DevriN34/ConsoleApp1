using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım";
            string kurs2 = "donanım";
            string kurs3 = "java";
            string kurs4 = "python";


            string[] kurslar = new string[] { "yazılım","donanım","java","python", "C#"};


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("sayfa sonu");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }








            Console.ReadKey();
        }
    }
}
