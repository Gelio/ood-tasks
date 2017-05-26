using System;
using System.Text;

namespace Robotics
{
	/**
	 * @brief Robot Kuka
	 * Kuka potrafi wyprodukować każdy element metalowy o wadze mniejszej niż 2000 kg.
	 * Robot potrafi produkować części zarówno standardowe jak i dedykowane do specyficznych modeli aut.
	 * Sam robot jest metalowy i waży 1700 kg.
	 */
	public class Kuka : Robot
	{
		public override string GetName ()
		{
			return "kuka";
		}

		public override double GetWeight()
		{
			return 1700;
		}

        public override bool CanProducePart(MetalPart part)
        {
            if (part.GetWeight() >= 2000)
                return false;

            return true;
        }

        public override bool CanProducePart(RubberPart part)
        {
            return false;
        }
    }
}
