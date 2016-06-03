using System;
namespace TriangleSurfaceByThreeSides
{
    class Program
    {
        static void Main()
        {
            double sideA, sideB, sideC;

            double halfP =
            (
                (((sideA = double.Parse(Console.ReadLine())) +
                  (sideB = double.Parse(Console.ReadLine())) +
                  (sideC = double.Parse(Console.ReadLine()))) / 2)
            );

            Console.WriteLine
            (
                Math.Sqrt
                (
                   halfP *
                   (halfP - sideA) *
                   (halfP - sideB) *
                   (halfP - sideC)
                )
                .ToString("F2")
            );
        }
    }
}
