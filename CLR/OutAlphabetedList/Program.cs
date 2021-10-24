using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutAlphabetedList
{
    //Программа выводит отсортированный список используя алфавитную группировку
    class Program
    {

        public static List<PhoneNumber> phoneNumbers;
        private static Random rand = new Random();

        static void Main(string[] args)
        {
            //генерация листа контактов
            phoneNumbers = new List<PhoneNumber>();
            for(int i=0; i < PhoneNumber.chars.Length; i++)
            {
                int next = rand.Next(2, 5);
                for (int j = 0; j < 5; j++)
                {
                    int index = i * 5 + j;
                    phoneNumbers.Add(new PhoneNumber());
                    phoneNumbers[index].firstLetter = PhoneNumber.chars[i];
                    phoneNumbers[index].SetRandomName(PhoneNumber.chars[i]);
                    phoneNumbers[index].SetRandomNumber('8');
                }
            }
            //сортируем
            phoneNumbers.Sort();

            //выводим
            char signature = 'A';
            Console.WriteLine('A');
            for(int i=0; i< phoneNumbers.Count; i++)
            {
                if (Char.ToUpper(phoneNumbers[i].firstLetter) != signature)
                {
                    signature++;
                    Console.WriteLine(signature);
                }
                Console.WriteLine(phoneNumbers[i]);
            }

            Console.ReadLine();
        }
    }
}
