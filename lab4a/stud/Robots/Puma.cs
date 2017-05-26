using System;
using System.Text;

namespace Robotics
{
	/**
	 * @brief Robot puma
	 * Puma potrafi wyprodukować każdy element gumowy o rozmiarze nie przekraczającym 1.5 m
	 * Robot potrafi produkować części zarówno standardowe jak i dedykowane do specyficznych modeli aut.
	 * Sam robot jest metalowy i waży 3000 kg.
	 */
	public class Puma : Robot
	{
		public override string GetName ()
		{
			return "puma";
		}

		public override double GetWeight()
		{
			return 3000;
		}

        public override bool CanProducePart(MetalPart part)
        {
            return false;
        }

        public override bool CanProducePart(RubberPart part)
        {
            if (part.GetSize() > 1.5)
                return false;

            return true;
        }
    }
}
