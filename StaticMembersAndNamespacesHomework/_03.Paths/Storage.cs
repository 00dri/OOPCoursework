namespace _03.Paths
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using _01.Point3D;

    public static class Storage
    {
        public static void Save(string fileName, params Path3D[] paths)
        {
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(fileName, FileMode.Append);
                var streamWriter = new StreamWriter(fileStream);
                using (streamWriter)
                {
                    foreach (var path in paths)
                    {
                        streamWriter.Write(path);
                    }
                }
            }
            catch (Exception e)
            {
                var ex = new Exception("Could not save", e);
                throw ex;
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Dispose();
                }
            }
        }

        public static Path3D Load(string fileName)
        {
            var points = new List<Point3D>();

            try
            {
                var sr = new StreamReader(fileName);
                using (sr)
                {
                    var line = sr.ReadLine();
                    while (line != null)
                    {
                        var coords = PointExtractor(line);
                        var p = new Point3D(coords[0], coords[1], coords[2]);
                        points.Add(p);
                        line = sr.ReadLine();
                    }
                }

            }
            catch (Exception e)
            {
                var ex = new Exception("Could not load", e);
                throw ex;
            }

            var path = new Path3D(points);
            return path;
        }

        private static double[] PointExtractor(string line)
        {
            var pointCoordinates = new double[3];
            var data = line.Split(',');

            for (int i = 0; i < data.Length; i++)
            {
                pointCoordinates[i] = double.Parse(data[i]);
            }

            return pointCoordinates;
        }
    }
}
