using System;
namespace TriangleSurface
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine 
                (
                    ((double.Parse(Console.ReadLine()) *
                      double.Parse(Console.ReadLine())) / 2)
                      .ToString("F2")
                );
        }
    }
}
