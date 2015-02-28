namespace FarmersCreed.Units
{
    using FarmersCreed.Interfaces;

    public abstract class Animal : FarmUnit
    {
        public Animal(string id, int health, int productionQuantity)
            : base(id, health, productionQuantity)
        {
        }

        public abstract void Eat(IEdible food, int quantity);

        public virtual void Starve()
        {
            this.Health--;
        }
    }
}
