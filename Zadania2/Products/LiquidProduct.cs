namespace Zadania2;

public class LiquidProduct : Product
{
    public bool isDangerousProduct;

    public LiquidProduct(float cargoWeight, bool isDangerousProduct) : base(cargoWeight)
    {
        this.isDangerousProduct = isDangerousProduct;
    }
}