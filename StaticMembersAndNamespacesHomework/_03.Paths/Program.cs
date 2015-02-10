namespace _03.Paths
{
    using System;
    using System.Collections.Generic;
    using _01.Point3D;
    class Program
    {
        static void Main()
        {
            var p1 = new Point3D(50, -5, 15);
            var p2 = new Point3D(-40, 44, 14);
            var p3 = new Point3D(66, 16, -6);

            var points1 = new List<Point3D> { p1, p2, p3 };
            var points2 = new List<Point3D> { p2, p3 };
            var points3 = new List<Point3D> { p1, p3 };

            var path1 = new Path3D(points1);
            var path2 = new Path3D(points2);
            var path3 = new Path3D(points3);
            
            Console.WriteLine(path1);
            Console.WriteLine("From file: \n");
            Storage.Save("../../paths.txt", path1, path2, path3);
            var newPath = Storage.Load("../../loadpaths.txt");
            Storage.Save("../../paths.txt", newPath);

            Console.WriteLine(newPath);
        }
    }
}
