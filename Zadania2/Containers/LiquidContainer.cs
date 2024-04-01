namespace Zadania2;

public class LiquidContainer : Container, IHazardNotificer
{
    public LiquidContainer(float maxWeight, float containerHeight, float height, float weight, float depth) : base(maxWeight, containerHeight, height, weight, depth)
    {
        TypeContainer = "L";
    }

    public void LoadCargo(LiquidProduct product)
    {
        float maxLoadCapacity = (product.isDangerousProduct ? 0.5f : 0.9f) * MaxWeight;
        
        if (product.CargoWeight > maxLoadCapacity)
        {
            ((IHazardNotificer)this).NotifyDangerousSituation(Id);
        }
        
        base.LoadCargo(product.CargoWeight, maxLoadCapacity);
    }

    public void Print()
    {
        Console.WriteLine(ContainerToString());
    }
}