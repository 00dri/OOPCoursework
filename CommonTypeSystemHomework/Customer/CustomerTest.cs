using System;
using System.Collections.Generic;

namespace Customer
{
    class CustomerTest
    {
        static void Main(string[] args)
        {
            var first = new Customer("Tosho", "Toshev", "Toshev", "9101014050", "Sofia", "0883234987", "tosh@abv.bg",
                new List<Payment>(), CustomerType.Golden);

            var second = new Customer("Gosho", "Goshev", "Goshov", "9101014050", "Sofia", "0886987567", "gosho@abv.bg",
                            new List<Payment>(), CustomerType.Regular);

            var third = new Customer("Gosho", "Goshev", "Goshov", "9101014050", "Sofia", "0989454676", "gosho@abv.bg",
                            new List<Payment>(), CustomerType.Diamond);

            var fourth = (Customer)first.Clone();

            Console.WriteLine(first == third);
            Console.WriteLine(second == third);
            Console.WriteLine(first == fourth);
            Console.WriteLine(Object.ReferenceEquals(first, fourth));
        }
    }
}
