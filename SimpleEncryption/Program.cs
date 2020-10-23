using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Contoh Program Enkripsi");

            List<string> userInput = new List<string>();
            List<string> resultList = new List<string>();
            string key = "@";
            string resultEnkripsi;


            Console.WriteLine("masukan karakter 1:");
            string char1 = Console.ReadLine();
            userInput.Add(char1);

            Console.WriteLine("masukan karakter 2:");
            string char2 = Console.ReadLine();
            userInput.Add(char2);

            Console.WriteLine("masukan karakter 3:");
            string char3 = Console.ReadLine();
            userInput.Add(char3);

            Console.WriteLine("masukan karakter 4:");
            string char4 = Console.ReadLine();
            userInput.Add(char4);

            Console.WriteLine("masukan karakter 5:");
            string char5 = Console.ReadLine();
            userInput.Add(char5);

            Console.WriteLine("masukan karakter 6:");
            string char6 = Console.ReadLine();
            userInput.Add(char6);

            var firstArray = userInput.Take(userInput.Count() / 2).ToArray();
            var secondArray = userInput.Skip(userInput.Count / 2).ToArray();


            StringBuilder builder = new StringBuilder();
            StringBuilder builder2 = new StringBuilder();


            foreach (string value in secondArray)
            {
                builder.Append(value);
                builder.Append("");
            }
            string firstResult = builder.ToString();


            foreach (string value2 in firstArray)
            {
                builder2.Append(value2);
                builder2.Append("");
            }
            string secondResult = builder2.ToString();

            resultEnkripsi = firstResult + key + secondResult;

            Console.WriteLine("result :" + resultEnkripsi);
            Console.ReadLine();
        }
    }
}
