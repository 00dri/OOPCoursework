namespace FarmersCreed.Units
{
    using System;

    public class CherryTree : FoodPlant
    {
        private const int CherryTreeHealth = 14;
        private const int CherryTreeGrowTime = 3;
        private const int CherryTreeQuantity = 4;
        private const int CherryTreeHealthEffect = 2;

        public CherryTree(string id) 
            : base(id, CherryTreeHealth, CherryTreeQuantity, CherryTreeGrowTime)
        {
            
        }

        public override Product GetProduct()
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException("Cherry tree is dead.");
            }
            return new Food(this.Id + "Product", 
                ProductType.Cherry, 
                FoodType.Organic, 
                this.ProductionQuantity, 
                CherryTreeHealthEffect);
        }
    }
}
