namespace FarmersCreed.Simulator
{
    using Interfaces;
    using Units;

    public class ExtendedFarmSimulator : FarmSimulator
    {
        protected override void ProcessInput(string input)
        {
            var inputCommands = input.Split(' ');
            var action = inputCommands[0];

            switch (action)
            {
                case "feed":
                {
                    var id = inputCommands[1];
                    var foodId = inputCommands[2];
                    var quantity = int.Parse(inputCommands[3]);

                    var animal = this.GetAnimalById(id);
                    var food = this.GetProductById(foodId) as IEdible;
                    this.farm.Feed(animal, food, quantity);
                }
                    break;
                case "water":
                {
                    var id = inputCommands[1];
                    var plantId = this.GetPlantById(id);

                    this.farm.Water(plantId);
                }
                    break;
                case "exploit":
                {
                    var type = inputCommands[1];
                    var id = inputCommands[2];

                    if (type == "animal")
                    {
                        var animal = this.GetAnimalById(id);
                        this.farm.Exploit(animal);
                    }
                    if (type == "plant")
                    {
                        var plant = this.GetPlantById(id);
                        this.farm.Exploit(plant);
                    }
                }
                    break;
                default:
                    base.ProcessInput(input);
                    break;
            }
        }

        protected override void AddObjectToFarm(string[] inputCommands)
        {
            var type = inputCommands[1];
            var id = inputCommands[2];

            switch (type)
            {
                case "CherryTree":
                {
                    var cherry = new CherryTree(id);
                    farm.Plants.Add(cherry);
                }
                    break;
                case "TobaccoPlant":
                    {
                        var tobacco = new TobaccoPlant(id);
                        farm.Plants.Add(tobacco);
                    }
                    break;
                case "Cow":
                    {
                        var cow = new Cow(id);
                        farm.Animals.Add(cow);
                    }
                    break;
                case "Swine":
                    {
                        var swine = new Swine(id);
                        farm.Animals.Add(swine);
                    }
                    break;
                default:
                    base.AddObjectToFarm(inputCommands);
                    break;
            }
        }

        protected override void PrintObjectStatus(string[] inputCommands)
        {
            base.PrintObjectStatus(inputCommands);
        }
    }
}
