using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorBall
{
    class Color
    {
        private int red = 0;
        private int blue = 0;
        private int green = 0;
        private int alpha = 0;

        public Color(int red, int blue, int green, int alpha)
        {
            this.red = red;
            this.blue = blue;
            this.green = green;
            this.alpha = alpha;
        }

        public Color(int red, int green, int blue)
        {
            this.Red = red;
            this.Blue = blue;
            this.Green = green;
            this.Alpha = 250;
        }

        public void GetColors()
        {
            Console.WriteLine($"Red: {this.red}");
            Console.WriteLine($"Green: {this.green}");
            Console.WriteLine($"Blue: {this.blue}");
        }

        public int Red
        {
            get; set;
        }


        public int Blue
        {
            get; set;
        }


        public int Green
        {
            get;
            set;
        }


        public int Alpha
        {
            get;
            set;
        }


        public int GetGrayscale()
        {
            return (red + blue + green) / 3;
        }
    }
}
