using System;
using System.Text;

namespace Robotics
{
	public enum Car
	{
		Standard,

		Bison,
		Comet,
		Mesa,
		Serrano
	}

	/**
	 * @brief Część posiada nazwę i typ samochodu do którego pasuje.
	 * Może być standardowa i pasować do dowolnego pojazdu.
	 */
	public abstract class Part
	{
		private Car _car;

		public Part (Car car)
		{
			_car = car;
		}

		public abstract string GetName ();

		public virtual Car GetCar ()
		{
			return _car;
		}

        public abstract string GetDescription();

        public abstract bool CanBeProducedByRobot(Robot robot);
	}

	/**
	 * @brief Metalowa część posiada wagę wyrażoną w kilogramach
	 */
	public abstract class MetalPart : Part
	{
		public MetalPart(Car car) : base(car) {}

		public abstract double GetWeight();

        public override string GetDescription()
        {
            return $"metalowy element o nazwie '{GetName()}' i wadze '{GetWeight()}' kg do auta '{GetCar()}'";
        }

        public override bool CanBeProducedByRobot(Robot robot)
        {
            return robot.CanProducePart(this);
        }
    }

	/**
	 * @brief Gumowa część posiada rozmiar wyrażony w metrach
	 */
	public abstract class RubberPart : Part
	{
		public RubberPart(Car car) : base(car) {}

		public abstract double GetSize();

        public override string GetDescription()
        {
            return $"gumowy element o nazwie '{GetName()}' i rozmiarze '{GetSize()}' m do auta '{GetCar()}'";
        }

        public override bool CanBeProducedByRobot(Robot robot)
        {
            return robot.CanProducePart(this);
        }
    }
}
