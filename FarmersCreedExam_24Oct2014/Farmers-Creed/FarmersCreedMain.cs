namespace FarmersCreed
{
    using FarmersCreed.Simulator;

    class FarmersCreedMain
    {
        static void Main()
        {
            var simulator = new ExtendedFarmSimulator();
            simulator.Run();
        }
    }
}
