namespace _03.Animals
{
    using System;
    using System.Media;

    public class Dog : Animal
    {
        private const string SoundPath = @"..\..\Sounds\dog.wav";

        public Dog(string name, int age, Gender gender)
            : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Woof!");
            
            var player = new SoundPlayer(SoundPath);
            using (player)
            {
                player.PlaySync();
            }
        }
    }
}
