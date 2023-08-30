using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToUpper__
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. if you want to make the alphabets of the string as all capital, using ToUpper() method
            string alphabet = "abcdef";
            string upperResult = alphabet.ToUpper();

            Console.WriteLine($"upperResult : {upperResult}");

            // 2. if you want to make the alphabets of the string as all lower case , using ToLower() method
            string alphabet2 = "ABCDEF";
            string lowerResult = alphabet2.ToLower();

            Console.WriteLine($"lowerResult : {lowerResult}");

            // 3. 
        }
    }
}
