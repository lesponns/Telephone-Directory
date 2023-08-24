using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Odev_6
{
    internal class Menu
    {
        public static List<Contact> contacts = new List<Contact>();
        public static List<Contact> contactfast = new List<Contact>();
        public static List<Contact> contactblocks = new List<Contact>();
        public static List<Contact> contactfavorites = new List<Contact>();

        

        public static void Proccesses(ConsoleKey secim)
        {
            switch (secim)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    ContactAdd("Kişi Ekle");
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    ContactDelete("Kişi Sil");
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    ContactSearch("Kişi Ara");
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    ContactList("Kişileri Listele");
                    break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    ContactAddFastCall("Hızlı Aramaya Ekle");
                    break;
                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                    ContactListFastCall("Hızlı Aramayı Listele");
                    break;
                case ConsoleKey.D7:
                case ConsoleKey.NumPad7:
                    ContactBlock("Kişiyi Engelle");
                    break;
                case ConsoleKey.D8:
                case ConsoleKey.NumPad8:
                    ContactListBlock("Engelli Kişi Listesi");
                    break;
                case ConsoleKey.D9:
                case ConsoleKey.NumPad9:
                    ContactAddFavorite("Favorilere Ekle");
                    break;
                case ConsoleKey.D0:
                case ConsoleKey.NumPad0:
                    ContactListFavorite("Favorileri Listele");
                    break;
                case ConsoleKey.I:
                    Contact person1 = new Contact();
                    person1.name = "Ahmet";
                    person1.surname = "Burak";
                    person1.phoneNumber = "5556664865";
                    contacts.Add(person1);

                    Contact person2 = new Contact();
                    person2.name = "Mehmet";
                    person2.surname = "Emin";
                    person2.phoneNumber = "8854248432";
                    contacts.Add(person2);

                    Contact person3 = new Contact();
                    person3.name = "Mustafa";
                    person3.surname = "Uysal";
                    person3.phoneNumber = "5356087401";
                    contacts.Add(person3);

                    Contact person4 = new Contact();
                    person4.name = "Halil";
                    person4.surname = "Ay";
                    person4.phoneNumber = "5061486536";
                    contacts.Add(person4);

                    Contact person5 = new Contact();
                    person5.name = "Caner";
                    person5.surname = "Ay";
                    person5.phoneNumber = "5515990736";
                    contacts.Add(person5);
                    
                    break;
                case ConsoleKey.E:

                    break;

            }
        }
        private static void returnHome(string metin)
        {
            Console.Write("\n{0}\nAna menüye dönmek için bir tuşa basınız.",metin);
            Console.ReadKey();
        }
        private static void headerPrint(string metin)
        {
            Console.Clear();
            Console.Write("{0}\n_____________________\n",metin);
        }
        private static void ContactAdd(string metin)
        {
            headerPrint(metin);
            Contact Person = new Contact();
            Person.name = InputControls.OnlyStringCheck("Adı: ");
            Person.surname = InputControls.OnlyStringCheck("Soyadı: ");
            Person.phoneNumber = InputControls.PhoneLenghtCheck("Telefon: ");
            contacts.Add(Person);
            returnHome("Kişi kaydedildi.");
        }
        private static void ContactDelete(string metin)
        {
            headerPrint(metin);
            if (contacts.Any())
            {
                for (int i = 0; i < contacts.Count; i++) 
                {
                    contacts[i].print(i+1);
                }
                int squence = InputControls.IntGetCheck("\nSilmek istediğiniz kişinin sıra numarasını girniz: ",1,contacts.Count);
                contacts.RemoveAt(squence - 1);
                returnHome("Kişi silindi.");
            }
            else
            {
                returnHome("Kişi bulunamadı.");
            }
        }
        private static void ContactList(string metin)
        {
            headerPrint(metin);
            if (contacts.Any())
            {
                foreach (var item in contacts)
                {
                    item.print();
                    Console.Write("__________________\n");
                }
                returnHome(string.Format("Toplam Kişi sayısı: {0}",contacts.Count));
            }
            else
            {
                returnHome("Rehberinizde kimse kayıtlı değil.");
            }
        }

        private static void ContactSearch(string metin)
        {
            headerPrint(metin);
            if(contacts.Any())
            {
                string searchingcontact = InputControls.OnlyStringCheck("Kişinin Adı veya soyadı: ");
                int adet = 0;
                foreach (var item in contacts)
                {
                    if (item.longName.ToLower().Contains(searchingcontact.ToLower()))
                    {
                        adet++;
                        item.print();
                    }
                }
                returnHome(string.Format("{0} adet sonuç bulunudu.",adet));
            }
            else 
            {
                returnHome("Kişi Rehberinizde kayıtlı değil.");
            }
        }

        private static void ContactAddFastCall(string metin)
        {
            headerPrint(metin);
            if (contacts.Any())
            {
                for (int i = 0; i < contacts.Count; i++)
                {
                    contacts[i].print(i + 1);
                    Console.WriteLine("");
                }
                int squence = InputControls.IntGetCheck("Hızlı Aramaya eklemek istediğiniz kişinin sıra numarasını giriniz: ",1,contacts.Count);
                Contact fastcall = new Contact();
                fastcall.name = contacts[squence].name;
                fastcall.surname = contacts[squence].surname;
                fastcall.phoneNumber = contacts[squence].phoneNumber;
                contactfast.Add(fastcall);
                returnHome("Kişi Hızlı Aramaya Eklendi.");
            }
            else
            {
                returnHome("Rehberinizde kişi bulunamadı.");
            }

        }
        private static void ContactListFastCall(string metin)
        {
            headerPrint(metin);
            if (contactfast.Any())
            {
                foreach (var item in contactfast)
                {
                    item.print();
                    Console.Write("__________________\n");
                }
                returnHome(string.Format("Hızlı Aramaya Kayıtlı Kişi sayısı: {0}", contactfast.Count));
            }
            else
            {
                returnHome("Rehberinizde kimse kayıtlı değil.");
            }
        }
        private static void ContactBlock(string metin)
        {
            headerPrint(metin);
            if (contacts.Any())
            {
                for (int i = 0; i < contacts.Count; i++)
                {
                    contacts[i].print(i + 1);
                    Console.WriteLine("");
                }
                int squence = InputControls.IntGetCheck("Favorilere eklemek istediğiniz kişinin sıra numarasını giriniz: ",1,contacts.Count);
                Contact block = new Contact();
                block.name = contacts[squence].name;
                block.surname = contacts[squence].surname;
                block.phoneNumber = contacts[squence].phoneNumber;
                contactblocks.Add(block);
                returnHome("Kişi Favorilere Eklendi.");
            }
            else
            {
                returnHome("Kişi Favorilere Eklenmedi.");
            }
        }
        private static void ContactListBlock(string metin)
        {
            headerPrint(metin);
            if (contactblocks.Any())
            {
                foreach (var item in contactblocks)
                {
                    item.print();
                    Console.Write("__________________\n");
                }
                returnHome(string.Format("Engelli Kişi sayısı: {0}", contactfast.Count));
            }
            else
            {
                returnHome("Engelli Kişi Yok.");
            }
        }
        private static void ContactAddFavorite(string metin)
        {
            //contactfavorites
            headerPrint(metin);
            if (contacts.Any())
            {
                for (int i = 0; i < contacts.Count ; i++)
                {
                    contacts[i].print(i + 1);
                    Console.WriteLine("");
                }
                int squence = InputControls.IntGetCheck("Favorilere eklemek istediğiniz kişinin sıra numarasını giriniz: ");
                Contact favorite = new Contact();
                favorite.name = contacts[squence].name;
                favorite.surname = contacts[squence].surname;
                favorite.phoneNumber = contacts[squence].phoneNumber;
                contactfavorites.Add(favorite);
                returnHome("Kişi Favorilere Eklendi.");
            }
            else
            {
                returnHome("Kişi Favorilere Eklenemedi.");
            }
        }
        private static void ContactListFavorite(string metin)
        {
            headerPrint(metin);
            if (contactfavorites.Any())
            {
                foreach (var item in contactfavorites)
                {
                    item.print();
                    Console.Write("__________________\n");
                }
                returnHome(string.Format("Favorilere Ekli Kişi Sayısı: {0}", contactfavorites.Count));
            }
            else
            {
                returnHome("Favorilere Ekli Kişi Yok.");
            }
        }
    }
}
