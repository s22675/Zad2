namespace Zadania2;

public class FridgeContainer : Container, IHazardNotificer
{
    public TypeProduct TypeProduct { get; }
    public float CurrentTemperature { get; set; }

    public FridgeContainer(float maxWeight, float containerHeight, float height, float weight, float depth, TypeProduct typeProduct, float currentTemperature) : base(maxWeight, containerHeight, height, weight, depth)
    {
        TypeContainer = "C";
        TypeProduct = typeProduct;
        CurrentTemperature = currentTemperature;
    }

    public void LoadCargo(FridgeProduct product)
    {
        bool canLoad = TypeProduct == product.TypeProduct || CurrentTemperature >= product.PosibleTemperature;
        
        if (!canLoad)
        {
            ((IHazardNotificer)this).NotifyDangerousSituation(Id);
        }
        
        base.LoadCargo(product.CargoWeight, canLoad);
    }

    public void Print()
    {
        Console.WriteLine(ContainerToString() + $" (typeProduct: {TypeProduct.ToString()}, temperature: {CurrentTemperature})");
    }
}