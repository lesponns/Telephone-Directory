using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Odev_6
{
    internal class InputControls
    {
        private static bool IntHaveCheck(string metin)
        {
            foreach (char item in metin)
            {
                if (char.IsDigit(item))
                {
                    return true;
                }
            }
            return false;
        }

        public static string OnlyStringCheck(string metin)
        {
            string text = string.Empty;
            bool error = true;
            do 
            {
                Console.Write(metin);
                text = Console.ReadLine();
                if (IntHaveCheck(text))
                {
                    Console.Write("\nİsim sayı içeremez.\n");
                    error = true;
                }
                else if (string.IsNullOrEmpty(text))
                {
                    Console.Write("\nLütfen isim giriniz.\n");
                    error = true;
                }
                else
                {
                    error = false;
                }
            } 
            while (error);
            return text;
        }
        public static int IntGetCheck(string metin, int min = int.MinValue, int max = int.MaxValue)
        {
            int number = 0;
            bool error = true;
            do
            {
                Console.Write(metin);
                try
                {
                    number = int.Parse(Console.ReadLine());
                    if (number >= min && number <= max) 
                    {
                        error = false;
                    }
                    else
                    { 
                        error = true;
                        Console.Write("\nGirilen sayı {0} ile {1} aralığında olmalıdır.\n", min, max);
                    }
                }
                catch (Exception e)
                {
                    Console.Write(e.Message + "\n");
                    error = true;
                }
            } 
            while (error);
            return number;
        }
        public static string PhoneLenghtCheck(string metin)
        {
            string PhoneNumber = "";
            bool error = true;
            do
            {
                Console.Write(metin);
                try
                {
                    PhoneNumber = Console.ReadLine();
                    if (PhoneNumber.Length == 10)
                    {
                        error = false;
                    }
                    else
                    {
                        error = true;
                        Console.Write("\nTelefon numarasını başında sıfır olmadan giriniz!\n");
                    }
                }
                catch (Exception e)
                {
                    Console.Write(e.Message + "\n");
                    error = true;
                }
            } 
            while (error);
            return PhoneNumber;
        }
    }
}
