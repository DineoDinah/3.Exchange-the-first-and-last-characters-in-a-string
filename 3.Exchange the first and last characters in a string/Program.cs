using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Exchange_the_first_and_last_characters_in_a_string
{
    internal class Program
    {
        public static string test(string str)
        {
            return str.Length > 1
                ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1) : str;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(test("abcd"));
            Console.WriteLine(test("a"));
            Console.WriteLine(test("xy"));
            Console.ReadLine();
        }
    }
}
