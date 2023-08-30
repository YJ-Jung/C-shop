using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOf__
{
    class Program
    {
        static void Main(string[] args)
        {
            string case1 = "This is the first case";

            // Case 1 : string name.IndexOf("string to find", starting index, last index); 
            Console.WriteLine(case1.IndexOf("first", 0, case1.Length));

            // Case 2 : string name.IndexOf("string/character to find", starting index, last index, StringComparison); 
            // stringComparison : Searching specific string regardless of uppercase or lowercase letters
            Console.WriteLine(case1.IndexOf("first", 0, case1.Length, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(case1.IndexOf("f", 0, case1.Length, StringComparison.OrdinalIgnoreCase));

            // Case 3 : string name.IndexOf("character to find", starting index, last index); 
            Console.WriteLine(case1.IndexOf("f", 0, case1.Length));

            // Case 4 : string name.IndexOf("character or string to find");
            // -> Find the string or character to be found up to the last number of the index.
            Console.WriteLine(case1.IndexOf("f"));
            Console.WriteLine(case1.IndexOf("first"));
        }
    }
}
