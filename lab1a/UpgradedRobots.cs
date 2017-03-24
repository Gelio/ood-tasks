using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Robots
{
    class SingleAddivitvePaintingRobot : AddivtivePaintingRobot
    {
        public SingleAddivitvePaintingRobot(PaintingRobot baseRobot) : base(baseRobot, 1)
        {   
        }
    }

    class AddivtivePaintingRobot : PaintingRobot
    {
        protected PaintingRobot _baseRobot;
        private double _amount;

        public AddivtivePaintingRobot(PaintingRobot baseRobot, double amount)
        {
            _baseRobot = baseRobot;
            _amount = amount;
        }

        public override double GetPaintedLength(double time)
        {
            return _baseRobot.GetPaintedLength(time) + _amount;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("+{0} version of {1}", _amount, _baseRobot);
            return sb.ToString();
        }
    }

    class DoublePaintingRobot : MultiplicativePaintingRobot
    {
        public DoublePaintingRobot(PaintingRobot baseRobot) : base(baseRobot, 2)
        {
        }
    }

    class MultiplicativePaintingRobot : PaintingRobot
    {
        protected PaintingRobot _baseRobot;
        private double _multiplier;

        public MultiplicativePaintingRobot(PaintingRobot baseRobot, double multiplier)
        {
            _baseRobot = baseRobot;
            _multiplier = multiplier;
        }

        public override double GetPaintedLength(double time)
        {
            return _baseRobot.GetPaintedLength(time) * _multiplier;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("times {0} version of {1}", _multiplier, _baseRobot);
            return sb.ToString();
        }
    }

    class LogarithmicPaintingRobot : PaintingRobot
    {
        protected PaintingRobot _baseRobot;

        public LogarithmicPaintingRobot(PaintingRobot baseRobot)
        {
            _baseRobot = baseRobot;
        }

        public override double GetPaintedLength(double time)
        {
            double beforeUpgrade = _baseRobot.GetPaintedLength(time);
            return beforeUpgrade * Math.Log(beforeUpgrade);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("N log N version of {0}", _baseRobot);
            return sb.ToString();
        }
    }
}
