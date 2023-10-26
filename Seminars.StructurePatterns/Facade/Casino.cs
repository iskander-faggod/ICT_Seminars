namespace Seminars.StructurePatterns.Facade;

public interface ICasino
{
    void GetChips();
}

public class Casino : ICasino
{
    public void GetChips()
    {
        Console.WriteLine("обменял деньги на фишки");
    }
}