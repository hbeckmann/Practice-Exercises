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
            this.red = red;
            this.blue = blue;
            this.green = green;
            this.alpha = 250;
        }

        public void GetColors()
        {
            Console.WriteLine($"Red: {this.red}");
            Console.WriteLine($"Green: {this.green}");
            Console.WriteLine($"Blue: {this.blue}");
        }

        public int GetRed()
        {
            return red;
        }

        public void SetRed(int red)
        {
            this.red = red;
        }

        public int GetBlue()
        {
            return blue;
        }

        public void SetBlue(int blue)
        {
            this.blue = blue;
        }

        public int GetGreen()
        {
            return green;
        }

        public void SetGreen(int green)
        {
            this.green = green;
        }

        public int GetAlpha()
        {
            return alpha;
        }

        public void SetAlpha(int alpha)
        {
            this.alpha = alpha;
        }

        public int GetGrayscale()
        {
            return (red + blue + green) / 3;
        }
    }
}
