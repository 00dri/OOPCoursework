namespace _01.Shapes
{
    using System;

    public class Circle : IShape
    {
        private const string NegativeOrZeroInput = "Input has to be a positive number!";

        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get {
                if (this.radius <= 0)
                {
                    throw new ArgumentOutOfRangeException(NegativeOrZeroInput);
                }
                return radius;
            }
            set { radius = value; }
        }

        public double CalculateArea()
        {
            var area = this.Radius * this.Radius * Math.PI;
            return area;
        }

        public double CalculatePerimeter()
        {
            var perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }
    }
}
