namespace FarmersCreed.Units
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FarmersCreed.Interfaces;

    public class Farm : GameObject, IFarm
    {
        public Farm(string id)
            : base(id)
        {
            this.Plants = new List<Plant>();
            this.Animals = new List<Animal>();
            this.Products = new List<Product>();
        }

        public List<Plant> Plants { get; private set; }

        public List<Animal> Animals { get; private set; }

        public List<Product> Products { get; private set; }

        public void AddProduct(Product product)
        {
            var foundProduct = this.Products.FirstOrDefault(p => p.Id == product.Id);
            if (foundProduct != null)
            {
                foundProduct.Quantity += product.Quantity;
            }
            else
            {
                this.Products.Add(product);
            }
        }

        public void Exploit(IProductProduceable productProducer)
        {
            var product = productProducer.GetProduct();
            this.AddProduct(product);
        }

        public void Feed(Animal animal, IEdible edibleProduct, int productQuantity)
        {
            animal.Eat(edibleProduct, productQuantity);
            var foundProduct = this.Products.FirstOrDefault(p => p == edibleProduct);
            if (foundProduct!= null)
            {
                if (foundProduct.Quantity < productQuantity)
                {
                    throw new ArgumentOutOfRangeException("Insufficient quantity.");
                }
                //Can use only this line -> reference
                foundProduct.Quantity -= productQuantity;
            }
            else
            {
                throw new ArgumentException("There is no such product in the farm.");
            }
        }

        public void Water(Plant plant)
        {
            plant.Water();
        }

        public void UpdateFarmState()
        {
            foreach (var animal in this.Animals.Where(animal => animal.IsAlive))
            {
                animal.Starve();
            }

            foreach (var plant in Plants)
            {
                if (plant.HasGrown)
                {
                    plant.Wither();
                }
                plant.Grow();
            }
        }

        public override string ToString()
        {
            var farmInfo = new StringBuilder();
            farmInfo.AppendLine();
            var animals = this.Animals.Where(a => a.IsAlive).OrderBy(a => a.Id);
            foreach (var animal in animals)
            {
                farmInfo.AppendLine(animal.ToString());
            }
            var plants = this.Plants.Where(p => p.IsAlive).OrderBy(p => p.Health).ThenBy(p => p.Id);
            foreach (var plant in plants)
            {
                farmInfo.AppendLine(plant.ToString());
            }
            var products =
                this.Products.OrderBy(pr => pr.ProductType.ToString()).ThenByDescending(pr => pr.Quantity).ThenBy(pr => pr.Id);
            foreach (var product in products)
            {
                farmInfo.AppendLine(product.ToString());
            }
            return base.ToString() + farmInfo.ToString();
        }
    }
}
