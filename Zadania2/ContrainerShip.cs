namespace Zadania2;

public class ContrainerShip
{
    public List<Container> Containers { get; private set; }
    public int MaxCountContrainers;
    public int MaxSpeed;
    public float MaxWeightContrainers;
    private float currentWeight => Containers.Count == 0 ? 0f : Containers.Sum(contrainer => contrainer.Weight);
    private static int maxCountShips;
    private int id;

    public ContrainerShip(int maxCountContrainers, int maxSpeed, float maxWeightContrainers)
    {
        MaxCountContrainers = maxCountContrainers;
        MaxSpeed = maxSpeed;
        MaxWeightContrainers = maxWeightContrainers;
        SetNumerContainer();
    }
    
    public void AddContrainer(Container contrainer)
    {
        if (Containers == null)
        {
            Containers = new();
        }

        if (CanAddContrainer(contrainer))
        {
            Containers.Add(contrainer);
        }
    }

    public void RemoveContrainer(Container container)
    {
        Containers.Remove(container);
    }

    public void AddContrainers(List<Container> contrainers)
    {
        if (Containers == null)
        {
            Containers = new();
        }

        if (CanAddContrainers(contrainers))
        {
            Containers = contrainers;
        }
    }

    public static void MoveCotainerToAnotherShip(string idContainer, ContrainerShip fromShip, ContrainerShip toShip)
    {
        var container = fromShip.findContainerById(idContainer);
        fromShip.RemoveContrainer(container);
        toShip.AddContrainer(container);
    }

    public void ReplaceContainer(Container newContainer, string idContainerToRemove)
    {
        var container = findContainerById(idContainerToRemove);
        RemoveContrainer(container);
        AddContrainer(newContainer);
    }

    private bool CanAddContrainer(Container contrainer)
    {
        //kg to ton
        return ((currentWeight + contrainer.Weight) * 0.0001f <= MaxWeightContrainers &&
                Containers.Count + 1 <= MaxCountContrainers);
    }
    
    private bool CanAddContrainers(List<Container> contrainers)
    {
        //kg to ton
        return (contrainers.Sum(contrainer => contrainer.Weight) * 0.0001f <= MaxWeightContrainers &&
                contrainers.Count <= MaxCountContrainers);
    }

    private Container findContainerById(string Id)
    {
        return Containers.First(contrainer => contrainer.Id == Id);
    }

    private void SetNumerContainer()
    {
        maxCountShips++;
        id = maxCountShips;
    }

    public void Print()
    {
        Console.WriteLine($"Ship {id} (speed: {MaxSpeed}, maxContainerNum: {MaxCountContrainers}, maxWeight: {MaxWeightContrainers}, weight: {currentWeight})");
    }
}