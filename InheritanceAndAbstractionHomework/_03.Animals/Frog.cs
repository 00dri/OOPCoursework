namespace _03.Animals
{
    using System;
    using System.Media;

    public class Frog : Animal
    {
        private const string SoundPath = @"..\..\Sounds\frog.wav";

        public Frog(string name, int age, Gender gender)
            : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Croak!");

            var player = new SoundPlayer(SoundPath);
            using (player)
            {
                player.PlaySync();
            }
        }
    }
}
