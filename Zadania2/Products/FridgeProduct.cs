namespace Zadania2;

public class FridgeProduct : Product
{
    public TypeProduct TypeProduct;
    public float PosibleTemperature;


    public FridgeProduct(float cargoWeight, TypeProduct typeProduct, float posibleTemperature) : base(cargoWeight)
    {
        TypeProduct = typeProduct;
        PosibleTemperature = posibleTemperature;
    }
}