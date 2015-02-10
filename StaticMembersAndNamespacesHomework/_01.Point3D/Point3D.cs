namespace _01.Point3D
{
    /*Ponit3D is a 3 element point that is represented by double precision floating point x,y,z coordinates*/
    public class Point3D
    {
        private static readonly Point3D startingPoint = new Point3D(0, 0, 0);

        private double x;
        private double y;
        private double z;

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point3D StartingPoint
        {
            get { return startingPoint; }
        }

        public double Z
        {
            get { return z; }
            set { z = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public override string ToString()
        {
            return string.Format("{0}:{1}:{2}", x, y, z);
        }
    }
}
