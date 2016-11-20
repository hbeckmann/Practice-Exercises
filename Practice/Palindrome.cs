using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(checkForPalindrome("racecar"));
            Console.WriteLine(checkForPalindrome("hunter"));
            Console.WriteLine(checkForPalindrome("radar"));
            Console.ReadKey();

        }

        public static bool checkForPalindrome(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
