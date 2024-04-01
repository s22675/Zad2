namespace Zadania2;

public class Container
{
    public string Id => $"KON-{TypeContainer}-{nrContrainer}";
    protected string TypeContainer;
    protected float MaxWeight;
    protected float ContainerHeight;
    protected float Height;
    public float Weight { get; protected set; }
    protected float Depth;

    private float currentHeight;
    private static int countContrainers;
    private int nrContrainer;
    
    public Container(float maxWeight, float containerHeight, float height, float weight, float depth)
    {
        MaxWeight = maxWeight;
        ContainerHeight = containerHeight;
        Height = height;
        Weight = weight;
        Depth = depth;

        SetNumerContainer();
    }

    public void UnloadCargo()
    {
        currentHeight = 0f;
    }
    
    protected void LoadCargo(float cargoWeight)
    {
        if (cargoWeight > MaxWeight)
            throw new OverfillException("Cargo weight exceeds container's max load capacity.");
        
        currentHeight = cargoWeight;
    }
    
    protected void LoadCargo(float cargoWeight, float maxCapacity)
    {
        if (cargoWeight > maxCapacity)
            throw new OverfillException("Cargo weight exceeds container's max load capacity.");
        
        Weight = cargoWeight;
    }
    
    protected void LoadCargo(float cargoWeight, bool canLoad)
    {
        if (cargoWeight > MaxWeight)
            throw new OverfillException("Cargo weight exceeds container's max load capacity.");
        
        if (!canLoad)
            throw new OverfillException("Cannot add load cargo");
        
        Weight = cargoWeight;
    }
    
    private void SetNumerContainer()
    {
        countContrainers++;
        nrContrainer = countContrainers;
    }
    
    protected string ContainerToString()
    {
        return
            $"{Id}: (maxHeight: {MaxWeight}, containerWeight: {ContainerHeight}, currentWeight: {currentHeight}, height: {Height}, weight: {Weight}, depth: {Depth})";
    }
}