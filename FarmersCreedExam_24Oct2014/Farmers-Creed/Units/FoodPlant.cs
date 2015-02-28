namespace FarmersCreed.Units
{
    public abstract class FoodPlant : Plant
    {
        protected FoodPlant(string id, int health, int productionQuantity, int growTime) 
            : base(id, health, productionQuantity, growTime)
        {
        }

        public override void Water()
        {
            this.Health++;
        }

        public override void Wither()
        {
            for (int i = 0; i < 2; i++)
            {
                base.Wither();
            }
        }
    }
}
