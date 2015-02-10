namespace _03.Paths
{
    using System.Collections.Generic;
    using _01.Point3D;

    public class Path3D
    {
        private List<Point3D> points;

        public Path3D(List<Point3D> points)
        {
            this.Points = points;
        }

        public List<Point3D> Points
        {
            get { return points; }
            set { points = value; }
        }

        public override string ToString()
        {
            string path = null;

            for (int i = 0; i < points.Count; i++)
            {
                path += "Point " + (i + 1) + " coordinates: " + points[i].X + ", " + points[i].Y + ", " + points[i].Z +
                        "\n";
            }

            return path;
        }
    }
}
