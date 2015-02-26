namespace EnvironmentSystem.Models.Objects
{
    using System.Collections.Generic;

    public class Snowflake : MovingObject
    {
        protected const char SnowflakeCharImage = '*';

        public Snowflake(int x, int y, int width, int height, Point direction)
            : base(x, y, width, height, direction)
        {
            this.ImageProfile = this.GenerateImageProfile();
            this.CollisionGroup = CollisionGroup.Snowflake;
        }

        protected virtual char[,] GenerateImageProfile()
        {
            return new char[,] { { SnowflakeCharImage } };
        }

        public override void RespondToCollision(CollisionInfo collisionInfo)
        {
            var collidedObject = collisionInfo.HitObject;
            if (collidedObject.CollisionGroup == CollisionGroup.Ground ||
                collidedObject.CollisionGroup == CollisionGroup.FallenSnow)
            {
                this.Exists = false;
            }
            ////This returns true for all classes that inherit Ground
            ////if (collidedObject is Ground)
            ////{
            ////    this.Exists = false;
            ////}
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            var producedObjects = new List<EnvironmentObject>();
            if (!this.Exists)
            {
                producedObjects.Add(new FallenSnow(this.Bounds.TopLeft.X, this.Bounds.TopLeft.Y - 1));
            }
            return producedObjects;
        }
    }
}
