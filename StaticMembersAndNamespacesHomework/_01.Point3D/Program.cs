namespace _01.Point3D
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var newPoint = new Point3D(2, 3, 4);
            var startPoint = Point3D.StartingPoint;

            Console.WriteLine(newPoint);
            Console.WriteLine(startPoint);
        }
    }
}
