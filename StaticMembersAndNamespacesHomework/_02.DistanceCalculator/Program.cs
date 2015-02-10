namespace _02.DistanceCalculator
{
    using System;
    using _01.Point3D;

    public class Program
    {
        static void Main()
        {
            var p1 = new Point3D(3.3, 4.4, 5.5);
            var p2 = new Point3D(6.6, 7.7, 8.8);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

            var distance = DistanceCalculator.CalculateDistance(p1, p2);
            Console.WriteLine(distance);
        }
    }
}
