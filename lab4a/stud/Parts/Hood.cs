using System;
using System.Text;

namespace Robotics
{
	public class Hood: MetalPart
	{
		private double _weight;

		public Hood (Car car, double weight) : base(car)
		{
			_weight = weight;
		}

		public override string GetName ()
		{
			return "hood";
		}

		public override double GetWeight()
		{
			return _weight;
		}
	}
}

