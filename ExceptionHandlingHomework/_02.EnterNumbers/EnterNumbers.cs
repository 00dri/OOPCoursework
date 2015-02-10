namespace _02.EnterNumbers
{
    using System;

    public class EnterNumbers
    {
        public static void Main()
        {
            const int start = 1;
            const int end = 100;
            var numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                var validNumber = false;
                do
                {
                    try
                    {
                        var tempNumber = ReadNumber(start, end);

                        if (i > 0 && tempNumber <= numbers[i - 1])
                        {
                            throw new ArgumentOutOfRangeException();
                        }
                        numbers[i] = tempNumber;
                        validNumber = true;
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("Number must be greater than {0}", numbers[i - 1]);
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Number must be in the range of Int32!");
                    }
                } while (!validNumber);
            }

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
        }

        public static int ReadNumber(int start, int end)
        {
            while (true)
            {
                Console.Write("Enter integer number: ");
                var input = Console.ReadLine();
                try
                {
                    if (input == null) continue;
                    var num = int.Parse(input);

                    if (num < start || num > end)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    return num;
                }
                catch (FormatException)
                {
                    Console.WriteLine("You entered invalid number!");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Number must be between {0} and {1}", start, end);
                }
            }
        }
    }
}
