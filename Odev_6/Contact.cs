using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_6
{
    internal class Contact
    {
        List<string> ContactFastCall = new List<string>();
        public string name, surname, phoneNumber;

        public string longName
        {
            get { return name + " " + surname; }
        }

        public void print()
        {
            Console.Write("Adı: {0}\nSoyadı: {1}\nTelefon: {2}\n"
            ,name,surname,phoneNumber);
        }

        public void print(int phone)
        {
            Console.Write("{0} - {1}",phone,longName);
        }
    }
}
