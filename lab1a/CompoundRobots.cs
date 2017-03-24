using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Robots
{

    class CompoundMaxPaintingRobot : PaintingRobot
    {
        private List<PaintingRobot> childRobots = new List<PaintingRobot>();

        public CompoundMaxPaintingRobot(List<PaintingRobot> _childRobots = null)
        {
            if (_childRobots != null)
                foreach (PaintingRobot childRobot in _childRobots)
                    childRobots.Add(childRobot);
        }

        public override double GetPaintedLength(double time)
        {
            double initialLength = 0;
            foreach (PaintingRobot childRobot in childRobots)
                initialLength = Math.Max(initialLength, childRobot.GetPaintedLength(time));

            return initialLength;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("compound robot, max of:");
            foreach (PaintingRobot childRobot in childRobots)
            {
                sb.AppendLine(childRobot.ToString());
            }

            return sb.ToString();
        }
    }

    class CompoundSumPaintingRobot : PaintingRobot
    {
        private List<PaintingRobot> childRobots = new List<PaintingRobot>();

        public CompoundSumPaintingRobot(List<PaintingRobot> _childRobots = null)
        {
            if (_childRobots != null)
                foreach (PaintingRobot childRobot in _childRobots)
                    childRobots.Add(childRobot);
        }

        public override double GetPaintedLength(double time)
        {
            double initialLength = 0;
            foreach (PaintingRobot childRobot in childRobots)
                initialLength += childRobot.GetPaintedLength(time);

            return initialLength;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("compound robot, sum of:");
            foreach (PaintingRobot childRobot in childRobots)
            {
                sb.AppendLine(childRobot.ToString());
            }

            return sb.ToString();
        }
    }
}
