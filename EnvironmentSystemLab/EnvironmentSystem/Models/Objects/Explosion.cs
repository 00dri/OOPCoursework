namespace EnvironmentSystem.Models.Objects
{
    using Data.Structures;

    public class Explosion : FallingStarTail
    {
        public Explosion(int x, int y, int lifeTime = 2) 
            : base(x, y, lifeTime)
        {
            this.CollisionGroup = CollisionGroup.Explosion;
        }

        public Explosion(Rectangle bounds, int lifeTime) : base(bounds, lifeTime)
        {
        }
    }
}
