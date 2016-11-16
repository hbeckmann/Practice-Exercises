using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = CreateArray(10);
            ReverseArray(numbers);
            PrintArray(numbers);
        }

        public static int[] CreateArray(int length)
        {
            int[] array = new int[length];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }
            return array;
        }

        public static void ReverseArray(int[] array)
        {
            for(int i = 0; i < array.Length/2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp;
            }
        }

        public static void PrintArray(int[] array)
        {
            foreach(int cell in array)
            {
                Console.Write(cell + " ");
            }
            Console.ReadKey();
        }

    }
}
