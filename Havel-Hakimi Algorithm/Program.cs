using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

            integers.Sor
            WriteSequence(ComposeSequenceString(integers));
            WriteSequence(ComposeSequenceString(RemoveZeroes(integers)), true);
            Console.ReadLine();
        }

        static public List<int> RemoveZeroes(List<int> input)
        {
            while (input.IndexOf(0) > -1){ input.Remove(0);}
            return input;
        }
          
        static public string ComposeSequenceString (List<int> sequences)
        {
            string writeString = "";
            int i = 0;
            foreach (int integer in sequences)
            {
                if (i < sequences.Count -1 )
                {
                    writeString += integer + ", ";
                }
                else
                {
                    writeString += integer;
                }
                i++;
             }

            return writeString;
        }
        
        static public void WriteSequence(string sequence, bool isProcessed = false)
        {
            if (isProcessed)
            {
                Console.WriteLine("Sequence with 0s removed: ");
                Console.WriteLine("{ " + sequence + " }");
            }
            else
            {
                Console.WriteLine("Original sequence: ");
                Console.WriteLine("{ " + sequence + " }");
                Console.WriteLine("\n");
            }
        }
    }
}
