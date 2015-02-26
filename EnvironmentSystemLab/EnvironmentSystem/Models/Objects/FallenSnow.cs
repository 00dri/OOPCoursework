namespace EnvironmentSystem.Models.Objects
{
    using System.Collections.Generic;
    using Data.Structures;

    public class FallenSnow : EnvironmentObject
    {
        private const char FallenSnowImage = '.';
        private const int Width = 1;
        private const int Height = 1;

        public FallenSnow(int x, int y) 
            : base(x, y, Width, Height)
        {
            this.ImageProfile = new char[,] { {FallenSnowImage} };
            this.CollisionGroup = CollisionGroup.FallenSnow;
        }

        public FallenSnow(Rectangle bounds) 
            : base(bounds)
        {
        }

        public override void Update()
        {
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
