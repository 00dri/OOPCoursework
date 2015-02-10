namespace _01.Shapes
{
    using System;

    public abstract class BasicShape :IShape
    {
        private const string NegativeOrZeroInput = "Input has to be a positive number!";

        private double width;
        private double height;

        public BasicShape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public BasicShape()
        {
        }

        public double Width
        {
            get {
                if (this.width <= 0)
                {
                    throw new ArgumentOutOfRangeException(NegativeOrZeroInput);
                }
                return width; 
            }
            set { width = value; }
        }

        public double Height
        {
            get
            {
                if (this.height <= 0)
                {
                    throw new ArgumentOutOfRangeException(NegativeOrZeroInput);
                } 
                return height;
            }
            set { height = value; }
        }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }
}
