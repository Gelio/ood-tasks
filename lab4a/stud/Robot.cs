using System;
using System.Text;

namespace Robotics
{
	/**
	 * @brief Klasa robota, w szczególności sam jest częścią metalową którą można wyprodukować
	 */
	public abstract class Robot : MetalPart
	{
		public Robot() : base(Car.Standard) {}

        public abstract bool CanProducePart(RubberPart part);
        public abstract bool CanProducePart(MetalPart part);
    }
}
