using System;
using System.IO;

namespace Generation
{
    class Program
    {
        static void Generation(string nameFile, string addressFile, string phoneFile, int countGeneration)
        {
            string[] name = File.ReadAllLines(nameFile);
            string[] address = File.ReadAllLines(addressFile);
            string[] phone = File.ReadAllLines(phoneFile);
            Random rnd = new Random();

            for (int i = 0; i < countGeneration; i++)
            {
                int indexName = rnd.Next(0, name.Length);
                int indexAddress = rnd.Next(0, address.Length);
                int indexPhone = rnd.Next(0, phone.Length);

                PrintGeneration(name[indexName], address[indexAddress], phone[indexPhone]);
            }
        }

        static void PrintGeneration(string name, string address, string phone)
        {
            Console.WriteLine(name + ", " + address + ", " + phone + ",");
        }

        static void Main(string[] args)
        {
            int countGeneration = int.Parse(args[0]);
            string localization = args[1];

            switch (localization)
            {
                case ("ru-RU"):
                    {
                        Generation(@"D:\Generation\Generation\Generation\bin\Debug\Rus\Name.txt", @"D:\Generation\Generation\Generation\bin\Debug\Rus\Phone.txt", @"D:\Generation\Generation\Generation\bin\Debug\Rus\Address.txt", countGeneration);
                        break;
                    }

                case ("by-BY"):
                    {
                        Generation(@"D:\Generation\Generation\Generation\bin\Debug\RB\Name.txt", @"D:\Generation\Generation\Generation\bin\Debug\RB\Phone.txt", @"D:\Generation\Generation\Generation\bin\Debug\RB\Address.txt", countGeneration);
                        break;
                    }
                case ("us-US"):
                    {
                        Generation(@"D:\Generation\Generation\Generation\bin\Debug\US\Name.txt", @"D:\Generation\Generation\Generation\bin\Debug\US\Phone.txt", @"D:\Generation\Generation\Generation\bin\Debug\US\Address.txt", countGeneration);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Значение введено не верно");
                        break;
                    }
            }
        }
    }
}
