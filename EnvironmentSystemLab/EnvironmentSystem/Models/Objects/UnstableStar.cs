namespace EnvironmentSystem.Models.Objects
{
    using System.Collections.Generic;

    class UnstableStar : FallingStar
    {
        private int lifeTime;

        public UnstableStar(int x, int y, Point direction, int lifeTime = 8) 
            : base(x, y, direction)
        {
            this.LifeTime = lifeTime;
        }

        public int LifeTime
        {
            get { return this.lifeTime; }
            set { this.lifeTime = value; }
        }

        public override void Update()
        {
            this.LifeTime--;
            if (this.LifeTime <= 0)
            {
                this.Exists = false;
            }
            base.Update();
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            if (this.Exists)
            {
                return base.ProduceObjects();
            }

            var producedObjects = new List<EnvironmentObject>();
            for (int y = this.Bounds.TopLeft.Y - 2; y <= this.Bounds.TopLeft.Y + 2; y++)
            {
                for (int x = this.Bounds.TopLeft.X - 2; x <= this.Bounds.TopLeft.X + 2; x++)
                {
                    if (!(x == this.Bounds.TopLeft.X && y == this.Bounds.TopLeft.Y))
                    {
                        producedObjects.Add(new Explosion(x, y));
                    }
                }
            }
            return producedObjects;
        }
    }
}
