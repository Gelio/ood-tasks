using System;
using System.Text;

namespace Robotics
{
	/**
	 * @brief Robot ABB
	 * ABB potrafi wyprodukować każdy element metalowy o wadze mniejszej niż 500 kg.
	 * Robot potrafi produkować tylko elementy standardowe (tj. uniwersalne).
	 * Sam robot jest metalowy i waży 1250 kg.
	 */
	public class ABB : Robot
	{
        public override string GetName ()
		{
			return "abb";
		}

		public override double GetWeight()
		{
			return 1250;
		}

        public override bool CanProducePart(MetalPart part)
        {
            if (part.GetWeight() > 500)
                return false;

            if (part.GetCar() != Car.Standard)
                return false;

            return true;
        }

        public override bool CanProducePart(RubberPart part)
        {
            return false;
        }
    }
}
