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
        private Color color;
        private int timesThrown;

        public Ball(int size, float radius, Color color, int timesThrown)
        {
            this.size = size;
            this.radius = radius;
            this.color = color;
            this.timesThrown = timesThrown;
        }

        public void Pop()
        {
            this.size = 0;
        }

        public void Throw()
        {
            if(this.size != 0)
            {
                this.timesThrown++;
            }

        }

        public int GetTimesThrown()
        {
            return timesThrown;
        }

    }
}
