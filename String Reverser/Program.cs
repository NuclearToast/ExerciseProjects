using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace String_Reverser
{
    class Program
    {

        static void Main(string[] args)
        {
            string input;

            while (true)
            {
                Console.WriteLine("String to be reversed:\n ");
                input = Console.ReadLine();
                Console.WriteLine("\n" + ReverseString(input) + "\n");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public static string ReverseString(string input)
        {
            char[] splittedInput;
            string outputString = "";
            List<char> reversedArray = new List<char>();

            splittedInput = input.ToCharArray();

            for (int i = 0; i < splittedInput.Length;i++)
            {
                reversedArray.Add(splittedInput[(splittedInput.Length - 1) - i]);
            }
            foreach (char ch in reversedArray)
            {
                outputString += ch;
            }
            
            return outputString;
        }
    }
}
