namespace _03.Animals
{
    using System;
    using System.Media;

    public class Kitten : Cat
    {
        private const string SoundPath = @"..\..\Sounds\kitten.wav";

        public Kitten(string name, int age) : 
            base(name, age, Gender.Female)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Meow!");

            var player = new SoundPlayer(SoundPath);
            using (player)
            {
                player.PlaySync();
            }
        }
    }
}
