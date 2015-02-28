using System;

namespace FarmersCreed.Units
{
    using Interfaces;

    public class Swine : Animal
    {
        private const int SwineHealth = 20;
        private const int SwineProductionQuantity = 1;
        private const int SwineMeatHealthEffect = 5;

        public Swine(string id) 
            : base(id, SwineHealth, SwineProductionQuantity)
        {
        }

        public override Product GetProduct()
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException("The swine is dead.");
            }
            var product = new Food(this.Id + "Product", ProductType.PorkMeat, FoodType.Meat, this.ProductionQuantity,
                SwineMeatHealthEffect);
            this.Health = 0;
            return product;
        }

        public override void Eat(IEdible food, int quantity)
        {
            switch (food.FoodType)
            {
                case FoodType.Organic:
                case FoodType.Meat:
                    this.Health += 2 * food.HealthEffect * quantity;
                    break;
                default:
                    break;
            }
        }

        public override void Starve()
        {
            for (int i = 0; i < 3; i++)
            {
                base.Starve();
            }
        }
    }
}
