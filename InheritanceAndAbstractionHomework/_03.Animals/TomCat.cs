namespace _03.Animals
{
    using System;
    using System.Media;

    public class TomCat : Cat
    {
        private const string SoundPath = @"..\..\Sounds\tomcat.wav";

        public TomCat(string name, int age) : 
            base(name, age, Gender.Male)
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
