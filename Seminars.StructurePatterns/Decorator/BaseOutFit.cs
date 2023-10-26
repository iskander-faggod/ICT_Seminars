namespace Seminars.StructurePatterns.Decorator;

public class BaseOutFit : IOutfit
{
    public void Wear()
    {
        Console.WriteLine("базовый гардероб");
    }
}