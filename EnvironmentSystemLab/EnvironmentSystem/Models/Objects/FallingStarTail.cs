using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentSystem.Models.Objects
{
    using Data.Structures;

    public class FallingStarTail : EnvironmentObject
    {
        private const char TailImage = '.';

        private int lifeTime;

        public FallingStarTail(int x, int y, int lifeTime = 1) 
            : base(x, y, 1, 1)
        {
            this.LifeTime = lifeTime;
            this.ImageProfile = new char[,]{{TailImage}};
            this.CollisionGroup = CollisionGroup.FallingStarTail;
        }

        public FallingStarTail(Rectangle bounds, int lifeTime) : base(bounds)
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
            LifeTime--;
            if (this.LifeTime <= 0)
            {
                this.Exists = false;
            }
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
