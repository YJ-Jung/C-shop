using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalToLowerORLowerToCapital
{
    class Program
    {
        static void Main(string[] args)
        {

            String s;
            s = Console.ReadLine();
            //Option 1 : Using ToLower()& ToUpper() method

            string result1 = string.Empty;

            foreach (char c in s)
            {
                result1 += char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c);
                // ToLower() and ToUpper() method is used by comparing "character" 
            }

            //Option 2: Using for loop & if()

            string result2 = "";

            for(int i=0; i<s.Length; i++)
            {
                char c = s[i];
                if (c >= 65 && c <= 90)
                {
                    // 65 means 'a' in ASCII
                    // 90 means 'z' in ASCII

                    result2 += (char)(c + 32);

                    // + 32 makes lower letter capital letter
                    
                }
                else if (c >= 97 && c <= 122)
                {
                    // 97 means 'A' in ASCII
                    // 122 means 'Z' in ASCII

                    result2 += (char)(c - 32);

                    // - 32 makes capital letter capital letter
                }

                Console.WriteLine(result2);

            }

        }
    }
}
