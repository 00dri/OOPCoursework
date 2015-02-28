using System;

namespace FarmersCreed.Units
{
    class TobaccoPlant : Plant
    {
        private const int InitialTobaccoHealth = 12;
        private const int TobaccoQuantity = 10;
        private const int TobaccoGrowTime = 4;

        public TobaccoPlant(string id) 
            : base(id, InitialTobaccoHealth, TobaccoQuantity, TobaccoGrowTime)
        {
        }

        public override Product GetProduct()
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException("Tobacco plant is dead.");
            }
            if (!this.HasGrown)
            {
                throw new InvalidOperationException("Tobacco plant has not yet grown.");
            }
            return new Product(this.Id + "Product", ProductType.Tobacco, this.ProductionQuantity);
        }

        public override void Grow()
        {
            for (int i = 0; i < 2; i++)
            {
                base.Grow();
            }
        }
    }
}
