using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cylinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the radius:");
            string userRadius = Console.ReadLine();
            float radius = Convert.ToSingle(userRadius);

            Console.WriteLine("Please enter the height:");
            string userHeight = Console.ReadLine();
            float height = Convert.ToSingle(userHeight);

            float pi = 3.1415926f;
            float volume = pi * radius * radius * height;
            float surfaceArea = 2 * pi * radius * (radius + height);


            Console.WriteLine("Volume:" + volume);
            Console.WriteLine("Surface Area:" + surfaceArea);

            Console.ReadKey();
            
        }
    }
}
