using System;

namespace FarmersCreed.Units
{
    using Interfaces;

    public class Cow : Animal
    {
        private const int CowHealth = 15;
        private const int CowProductHealthEffect = 4;
        private const int CowProductQuantity = 6;

        public Cow(string id) 
            : base(id, CowHealth, CowProductQuantity)
        {
        }

        public override Product GetProduct()
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException("The cow is dead.");
            }
            var product = new Food(this.Id + "Product", ProductType.Milk, FoodType.Organic, this.ProductionQuantity, CowProductHealthEffect);
            this.Health-=2;
            return product;
        }

        public override void Eat(IEdible food, int quantity)
        {
            if (food.FoodType == FoodType.Organic)
            {
                this.Health += food.HealthEffect * food.Quantity;
            }
            if (food.FoodType == FoodType.Meat)
            {
                this.Health -= food.HealthEffect * food.Quantity;
            }
        }
    }
}
