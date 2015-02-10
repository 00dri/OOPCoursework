namespace _02.DistanceCalculator
{
    using _01.Point3D;
    using System;

    public static class DistanceCalculator
    {
        public static double CalculateDistance(Point3D p1, Point3D p2)
        {
            var xDiff = Math.Pow((p1.X - p2.X), 2);
            var yDiff = Math.Pow((p1.Y - p2.Y), 2);
            var zDiff = Math.Pow((p1.Z - p2.Z), 2);

            return Math.Sqrt(xDiff + yDiff + zDiff);
        }
    }
}
