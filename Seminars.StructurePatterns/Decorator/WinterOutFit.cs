namespace Seminars.StructurePatterns.Decorator;

public class WinterOutFit : Decorator
{
    public WinterOutFit(IOutfit outfit) : base(outfit)
    {
    }

    public new void Wear()
    {
        base.Wear();
        Console.WriteLine("надеваем пуховик и утепляемся");
    }
}