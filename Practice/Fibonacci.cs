using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(10));
            Console.ReadKey();
        }

        public static int Fibonacci(int sequenceNumber)
        {
            if (sequenceNumber == 1 || sequenceNumber == 2)
            {
                return 1;
            }

            return Fibonacci(sequenceNumber - 1) + Fibonacci(sequenceNumber - 2);

        }
    }
}
