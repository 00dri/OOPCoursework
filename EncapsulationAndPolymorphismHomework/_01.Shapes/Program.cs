namespace _01.Shapes
{
    using System;

    class Program
    {
        static void Main()
        {
            var testArray = new Object[]
            {
                new Rectangle(2,3).CalculateArea(), 
                new Triangle(2,3,4).CalculatePerimeter(), 
                new Triangle(2,3).CalculateArea(), 
                new Circle(1).CalculatePerimeter() 
            };

            foreach (var o in testArray)
            {
                Console.WriteLine(o);
            }
        }
    }
}
