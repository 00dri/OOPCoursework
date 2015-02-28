namespace FarmersCreed.Units
{
    public abstract class Plant : FarmUnit
    {
        public Plant(string id, int health, int productionQuantity, int growTime)
            : base(id, health, productionQuantity)
        {
            this.GrowTime = growTime;

        }

        public bool HasGrown
        {
            get { return this.GrowTime <= 0; }
        }

        public int GrowTime { get; set; }

        public virtual void Water()
        {
            this.Health += 2;
        }

        public virtual void Wither()
        {
            this.Health--;
        }

        public virtual void Grow()
        {
            this.GrowTime--;
        }
    }
}
