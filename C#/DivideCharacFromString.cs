using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintCharacFromString
{
    class Program
    {
        static void Main(string[] args)
        {
            String s;
            s = Console.ReadLine();
            //Option 1 : using foreach() method : foreach (declare variable in data type to iterate over)
            // Generally, array, list, or ArrayList are used as data type about foreach loop
            // * index can not be used in foreach loop
            foreach (char c in s)
                Console.WriteLine(c);

            //Option 2 : using for loop

            for ( int i=0; i< s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
        }
    }
}
