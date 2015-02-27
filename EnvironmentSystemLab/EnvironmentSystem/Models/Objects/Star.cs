namespace EnvironmentSystem.Models.Objects
{
    using System;
    using System.Collections.Generic;
    using Data.Structures;

    public class Star : EnvironmentObject
    {
        private const char DefaultImage = 'O';
        private const int StarImageUpdateFrequency = 10;

        private static char[] starImageProfiles = {'O', '@', '0'};
        private static readonly Random randomizer = new Random();
        private int updateCount = 0;

        public Star(int x, int y) 
            : base(x, y, 1, 1)
        {
            this.ImageProfile = new char[,]{ { DefaultImage} };
        }

        public Star(Rectangle bounds) : base(bounds)
        {
        }

        public override void Update()
        {
            if (this.updateCount == StarImageUpdateFrequency)
            {
                int index = randomizer.Next(0, starImageProfiles.Length);
                this.ImageProfile = new char[,] { { starImageProfiles[index] } };
                updateCount = 0;
            }
            updateCount++;
        }

        public override void RespondToCollision(CollisionInfo collisionInfo)
        {
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            return new List<EnvironmentObject>();
        }
    }
}
