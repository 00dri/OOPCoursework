namespace _01.Persons
{
    using System;

    public class Program
    {
        private static void Main(string[] args)
        {
            var peshka = new Person("Peshka", 20); 
            var pesho = new Person("Pesho", 30, "pesho@mail.bg");

            Console.WriteLine(peshka);
            Console.WriteLine(pesho);

            ////throw an exception
            ////var penka = new Person("Penka", 23, "blabalTOVANEeEMAIL");
            ////var pencho = new Person("", 55, "email@email.com");
            ////Console.WriteLine(penka);
            ////Console.WriteLine(pencho);
        }
    }
}
