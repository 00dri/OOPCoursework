namespace _01.Shapes
{
    using System;

    public class Triangle : BasicShape
    {
        private const string NegativeOrZeroInput = "Input has to be a positive number!";

        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
        }

        public Triangle(double width, double height)
            : base(width, height)
        {
        }

        public double SideA
        {
            get
            {
                if (this.sideA <= 0)
                {
                    throw new ArgumentOutOfRangeException(NegativeOrZeroInput);
                } 
                return sideA;
            }
            set { sideA = value; }
        }

        public double SideB
        {
            get
            {
                if (this.sideB <= 0)
                {
                    throw new ArgumentOutOfRangeException(NegativeOrZeroInput);
                } 
                return sideB;
            }
            set { sideB = value; }
        }

        public double SideC
        {
            get
            {
                if (this.sideC <= 0)
                {
                    throw new ArgumentOutOfRangeException(NegativeOrZeroInput);
                } 
                return sideC;
            }
            set { sideC = value; }
        }

        public override double CalculateArea()
        {
            var area = (Width * Height) / 2;
            return area;
        }

        public override double CalculatePerimeter()
        {
            var perimeter = this.SideA + this.SideB + this.SideC;
            return perimeter;
        }
    }
}
