using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class PaintingRobot
    {
        public virtual double GetPaintedLength(double time)
        {
            return time;
        }

        public override string ToString()
        {
            return "basic robot";
        }
    }


}
