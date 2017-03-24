using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    class Program
    {
        static void Main(string[] args)
        {
            PaintingRobot r1 = new PaintingRobot();
           
            Console.WriteLine($"Current robot: {r1}");
            Console.WriteLine($"Painted length in 2 time units: {r1.GetPaintedLength(2)}.");
            Console.WriteLine($"Painted length in 3 time units: {r1.GetPaintedLength(3)}.");


            // Rozwiązanie
            Console.WriteLine(String.Empty);

            // Single additive
            PaintingRobot robotAdditiveSingle = new SingleAddivitvePaintingRobot(r1);
            Console.WriteLine("Upgraded robot with single additive upgrade: {0}", robotAdditiveSingle);
            Console.WriteLine($"Painted length in 2 time units: {robotAdditiveSingle.GetPaintedLength(2)}.");
            Console.WriteLine($"Painted length in 3 time units: {robotAdditiveSingle.GetPaintedLength(3)}.");
            Console.WriteLine(String.Empty);

            // Additive
            PaintingRobot robotAdditive = new AddivtivePaintingRobot(r1, 5);
            Console.WriteLine("Upgraded robot with +5 additive upgrade: {0}", robotAdditive);
            Console.WriteLine($"Painted length in 2 time units: {robotAdditive.GetPaintedLength(2)}.");
            Console.WriteLine($"Painted length in 3 time units: {robotAdditive.GetPaintedLength(3)}.");
            Console.WriteLine(String.Empty);

            // Double
            PaintingRobot robotDouble = new DoublePaintingRobot(r1);
            Console.WriteLine("Upgraded robot with double upgrade: {0}", robotDouble);
            Console.WriteLine($"Painted length in 2 time units: {robotDouble.GetPaintedLength(2)}.");
            Console.WriteLine($"Painted length in 3 time units: {robotDouble.GetPaintedLength(3)}.");
            Console.WriteLine(String.Empty);

            // Multiplicative
            PaintingRobot robotMultiplicative = new MultiplicativePaintingRobot(r1, 7);
            Console.WriteLine("Upgraded robot with multiplicative times 7 upgrade: {0}", robotMultiplicative);
            Console.WriteLine($"Painted length in 2 time units: {robotMultiplicative.GetPaintedLength(2)}.");
            Console.WriteLine($"Painted length in 3 time units: {robotMultiplicative.GetPaintedLength(3)}.");
            Console.WriteLine(String.Empty);

            // Multiplicative
            PaintingRobot robotLogarithmic = new LogarithmicPaintingRobot(r1);
            Console.WriteLine("Upgraded robot with logarithmic N log N upgrade: {0}", robotLogarithmic);
            Console.WriteLine($"Painted length in 2 time units: {robotLogarithmic.GetPaintedLength(2)}.");
            Console.WriteLine($"Painted length in 3 time units: {robotLogarithmic.GetPaintedLength(3)}.");
            Console.WriteLine(String.Empty);


            // Złożenie
            PaintingRobot robotMultipleUpgrades = new MultiplicativePaintingRobot(robotLogarithmic, 2);
            Console.WriteLine("Upgraded logarithmic robot with x2 upgrades: {0}", robotMultipleUpgrades);
            Console.WriteLine($"Painted length in 2 time units: {robotMultipleUpgrades.GetPaintedLength(2)}.");
            Console.WriteLine($"Painted length in 3 time units: {robotMultipleUpgrades.GetPaintedLength(3)}.");
            Console.WriteLine(String.Empty);


            // Compound max
            List<PaintingRobot> childRobots = new List<PaintingRobot>();
            childRobots.Add(robotAdditive);
            childRobots.Add(robotAdditiveSingle);
            childRobots.Add(robotMultipleUpgrades);
            PaintingRobot robotCompoundMax = new CompoundMaxPaintingRobot(childRobots);
            Console.WriteLine("Upgraded compound robot max (single, additive, multiple upgrades) upgrades: {0}", robotCompoundMax);
            Console.WriteLine($"Painted length in 2 time units: {robotCompoundMax.GetPaintedLength(2)}.");
            Console.WriteLine($"Painted length in 3 time units: {robotCompoundMax.GetPaintedLength(3)}.");
            Console.WriteLine(String.Empty);



            // Compound sum
            PaintingRobot robotCompoundSum = new CompoundSumPaintingRobot(childRobots);
            Console.WriteLine("Upgraded compound robot sum (single, additive, multiple upgrades) upgrades: {0}", robotCompoundSum);
            Console.WriteLine($"Painted length in 2 time units: {robotCompoundSum.GetPaintedLength(2)}.");
            Console.WriteLine($"Painted length in 3 time units: {robotCompoundSum.GetPaintedLength(3)}.");
            Console.WriteLine(String.Empty);


            // Example as in the task
            List<PaintingRobot> exampleChildRobots = new List<PaintingRobot>();
            exampleChildRobots.Add(r1);
            exampleChildRobots.Add(new DoublePaintingRobot(r1));

            List<PaintingRobot> internalCompountChildren = new List<PaintingRobot>();
            internalCompountChildren.Add(r1);
            internalCompountChildren.Add(r1);
            PaintingRobot internalCompoundRobot = new LogarithmicPaintingRobot(new CompoundMaxPaintingRobot(internalCompountChildren));
            exampleChildRobots.Add(internalCompoundRobot);

            PaintingRobot exampleRobot = new CompoundMaxPaintingRobot(exampleChildRobots);
            Console.WriteLine("Robot as in the task: {0}", exampleRobot);
            Console.WriteLine($"Painted length in 2 time units: {exampleRobot.GetPaintedLength(2)}.");
            Console.WriteLine($"Painted length in 3 time units: {exampleRobot.GetPaintedLength(3)}.");
        }
    }
}
