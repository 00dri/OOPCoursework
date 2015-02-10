namespace _01.Shapes
{
    public class Rectangle : BasicShape
    {
        public Rectangle(double width, double height)
            : base(width, height)
        {
        }

        public override double CalculateArea()
        {
            var area = Width * Height;
            return area;
        }

        public override double CalculatePerimeter()
        {
            var perimeter = (this.Height + this.Width) * 2;
            return perimeter;
        }
    }
}
