namespace EnvironmentSystem.Models.Objects
{
    using System.Collections.Generic;

    public class FallingStar : MovingObject
    {
        private const char FallingStarImage = 'O';

        public FallingStar(int x, int y, Point direction) 
            : base(x, y, 1, 1, direction)
        {
            this.ImageProfile = new char[,]{{FallingStarImage}};
        }

        public override void RespondToCollision(CollisionInfo collisionInfo)
        {
            var collidedObject = collisionInfo.HitObject;
            if (collidedObject.CollisionGroup == CollisionGroup.Ground ||
                collidedObject.CollisionGroup == CollisionGroup.FallenSnow)
            {
                this.Exists = false;
            }
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            var producedObjects = new List<EnvironmentObject>();
            producedObjects.Add(new FallingStarTail(this.Bounds.TopLeft.X - this.Direction.X, this.Bounds.TopLeft.Y - this.Direction.Y));
            producedObjects.Add(new FallingStarTail(this.Bounds.TopLeft.X - 2 * this.Direction.X, this.Bounds.TopLeft.Y - 2 * this.Direction.Y));
            producedObjects.Add(new FallingStarTail(this.Bounds.TopLeft.X - 3 * this.Direction.X, this.Bounds.TopLeft.Y - 3 * this.Direction.Y));
            return producedObjects;
        }
    }
}
