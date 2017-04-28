using A1;
using A1.CustomCollections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomList<double> fibonacci = new FibonacciLazyList(5);
            ICustomList<double> d2rc = init2DRC();
            ICustomList<double> d2cr = init2DCR();

            // 3. ACR & ARC
            IEnumerable<double> d2rcIterator = new ListAggregateIterator(d2rc),
                d2crIterator = new ListAggregateIterator(d2cr),
                fibonacciIterator = new ListIterator(fibonacci);

            Console.WriteLine("ARC");
            foreach (double v in d2rcIterator)
                Console.Write(v + " ");
            Console.WriteLine("\nACR");
            foreach (double v in d2crIterator)
                Console.Write(v + " ");
            Console.WriteLine("\n\n");

            // 4. Fibbonacci elements
            Console.WriteLine("Fibbonacci elements");
            foreach (double v in fibonacciIterator)
                Console.Write(v + " ");
            Console.WriteLine("\n\n");


            // 5. Variations
            Console.WriteLine("Variations");
            foreach (double v1 in d2rcIterator)
                foreach (double v2 in d2crIterator)
                    Console.WriteLine($"{v1} {v2}");
            foreach (double v1 in d2rcIterator)
                foreach (double v2 in fibonacciIterator)
                    Console.WriteLine($"{v1} {v2}");
            foreach (double v1 in d2crIterator)
                foreach (double v2 in fibonacciIterator)
                    Console.WriteLine($"{v1} {v2}");
            Console.WriteLine("\n\n");


            // 6. Sums
            Console.WriteLine("Sums");
            foreach (double v1 in d2rcIterator)
                foreach (double v2 in d2crIterator)
                    Console.WriteLine(v1 + v2);
            foreach (double v1 in d2rcIterator)
                foreach (double v2 in fibonacciIterator)
                    Console.WriteLine(v1 + v2);
            foreach (double v1 in d2crIterator)
                foreach (double v2 in fibonacciIterator)
                    Console.WriteLine(v1 + v2);
            Console.WriteLine("\n\n");
        }


        //DO NOT change code below
        static ArrayList2DRC init2DRC()
        {
            double[,] matrix = new double[2, 3];
            int n = 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = n++;
                }
            }

            return new ArrayList2DRC(matrix);
        }

        static ArrayList2DCR init2DCR()
        {
            double[,] matrix = new double[3, 3];
            int n = 10;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = n++;
                }
            }

            return new ArrayList2DCR(matrix);
        }
    }
}
