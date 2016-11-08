using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ReverseString
{
    class Program
    {

        static void Main(string[] args)
        {

            string example = "Hello";
            char[] exampleArr = example.ToCharArray();
            string reverse = "";


            for(int x = exampleArr.Length - 1; x >= 0; x--)
            {
                reverse += exampleArr[x]; 
            }

            Console.WriteLine(reverse);
            Console.ReadLine();


        }
    }
}
