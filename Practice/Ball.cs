using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorBall
{
    class Ball
    {

        private int size;
        private float radius;
        public Color color;

        public Ball(int size, float radius, Color color, int timesThrown)
        {
            this.size = size;
            this.radius = radius;
            this.color = color;
            this.TimesThrown = timesThrown;
        }

        public void Pop()
        {
            this.size = 0;
        }

        public void Throw()
        {
            if(this.size != 0)
            {
                this.TimesThrown++;
            }

        }

        public int TimesThrown
        {
            get;
            set;
        }

    }
}
