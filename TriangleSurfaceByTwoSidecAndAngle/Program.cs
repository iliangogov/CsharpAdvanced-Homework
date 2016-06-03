using System;
namespace TriangleSurfaceByTwoSidecAndAngle
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine
                (
                    (double.Parse(Console.ReadLine()) *
                     double.Parse(Console.ReadLine()) *
                     (Math.Sin
                        (
                            double.Parse(Console.ReadLine()) *
                            Math.PI / 180
                        )
                        / 2)
                    )
                    .ToString("F2")
                );
        }
    }
}
