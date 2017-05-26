using System;
using System.Text;

namespace Robotics
{
	public class Engine: MetalPart
	{
		private double _weight;

		public Engine (Car car, double weight) : base(car)
		{
			_weight = weight;
		}

		public override string GetName ()
		{
			return "engine";
		}

		public override double GetWeight()
		{
			return _weight;
		}
	}
}
