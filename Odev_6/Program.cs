using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_6
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            ConsoleKey secim;
            do
            {
                Console.Clear();
                Console.WriteLine("Tehber v4.2");
                Console.WriteLine("------------------------");
                Console.WriteLine("1-Kişi Ekle");
                Console.WriteLine("2-Kişi Sil");
                Console.WriteLine("3-Kişi Ara");
                Console.WriteLine("4-Kişileri Listele");
                Console.WriteLine("5-Hızlı Arama Ekle");
                Console.WriteLine("6-Hızlı Arama Listesi");
                Console.WriteLine("7-Kişiyi Engelle");
                Console.WriteLine("8-Engelli Listesi");
                Console.WriteLine("9-Favorilere Ekle");
                Console.WriteLine("0-Favori Listesi");
                Console.WriteLine("E-Programdan Çıkış");
                Console.WriteLine("------------------------");
                Console.Write("Hangi İşlemi Yapmak istersiniz: ");
                secim = Console.ReadKey().Key;
                Menu.Proccesses(secim);

            } while (secim != ConsoleKey.E);
        }
    }
}
