using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            // Substring () method: It is used to cut text to any length you want in the string 
            // Form: string value.Substring(starting index number, last index number in the length);


            // case 1: The starting index number is "0"
            string text = "abcdefghi";
            string cutTextResult = text.Substring(0, 4);

            Console.WriteLine(cutTextResult);

            // case 2: starting index number is not "0"
            string cutTextResult2 = text.Substring(2, 5);
            Console.WriteLine(cutTextResult2);

            //The last index number in the length can be omitted 
            string cutTextResult3 = text.Substring(3);
            Console.WriteLine(cutTextResult3);

        }
    }
}
