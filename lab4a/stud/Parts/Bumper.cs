using System;
using System.Text;

namespace Robotics
{
	public class Bumper: RubberPart
	{
		private double _size;

		public Bumper (Car car, double size) : base(car)
		{
			_size = size;
		}

		public override string GetName ()
		{
			return "bumper";
		}

		public override double GetSize()
		{
			return _size;
		}
	}
}
