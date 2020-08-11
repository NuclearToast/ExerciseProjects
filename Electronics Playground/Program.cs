using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Electronics_Playground
{
    class Program
    {
        public static Components.Bit bit1 = new Components.Bit(true);
        static void Main(string[] args)
        {
            //bit1 = 2;
            //Console.WriteLine(bit1);
            Console.WriteLine(0b01);
            Console.ReadLine();
        }

    }


}
