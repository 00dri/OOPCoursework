namespace _01.SquareRoot
{
    using System;

    public class SquareRoot
    {
        private static void Main()
        {
            Console.Write("Enter a number: ");
            var input = Console.ReadLine();
            try
            {
                if (input == null) return;
                var number = int.Parse(input);

                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                var result = Math.Sqrt(number);

                Console.WriteLine("Square root from: {0} is {1}", number, result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number!");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Number should be positive!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Number should be in the range of Int32");
            }
            finally
            {
                Console.WriteLine("Good bye!");
                Main();
            }
        }
    }
}
