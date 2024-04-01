namespace Zadania2;

public interface IHazardNotificer
{
    void NotifyDangerousSituation(string Id)
    {
        Console.WriteLine($"W kontenerze {Id} wykryto niebezpieczną sytuację.");
    }
}