namespace Zadania2;

public class GasContainer : Container, IHazardNotificer
{
    public double Pressure;

    public GasContainer(float maxWeight, float containerHeight, float height, float weight, float depth, double pressure) : base(maxWeight, containerHeight, height, weight, depth)
    {
        TypeContainer = "G";
        Pressure = pressure;
    }

    public void LoadCargo(Product product)
    {
        base.LoadCargo(product.CargoWeight);
    }

    public void UnloadCargo()
    {
        MaxWeight = MaxWeight * 0.05f;
    }
    
    public void Print()
    {
        Console.WriteLine(ContainerToString() + $" (pressure: {Pressure})");
    }
}