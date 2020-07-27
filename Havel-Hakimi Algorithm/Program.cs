using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Havel_Hakimi_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = new List<int>() { 1, 2, 0, 4, 2, 0, 9, 4 };
            List<int> cleanedIntegers;
            string writeString = "";

            foreach (int integer in integers)
            {
                writeString += integer + ", ";
            }
            Console.WriteLine("Original sequence: ");
            Console.WriteLine("{ " + writeString + " }");
            Console.WriteLine("\n");
            writeString = "";

            cleanedIntegers = removeZeroes(integers);
            foreach (int integer in integers)
            {
                writeString += integer + ", ";
            }
            Console.WriteLine("Sequence with 0s removed: ");
            Console.WriteLine("{ " + writeString + " }");

            Console.ReadLine();
        }

        static public List<int> removeZeroes(List<int> input)
        {
            while (input.IndexOf(0) > -1){ input.Remove(0);}
            return input;
        }
            
    }
}
