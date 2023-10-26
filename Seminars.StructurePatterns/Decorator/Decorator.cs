namespace Seminars.StructurePatterns.Decorator;

public class Decorator : IOutfit
{
    private IOutfit _outfit;

    // для облегчения подставим сюда сразу базовый аутфит
    public Decorator(IOutfit outfit)
    {
        _outfit = outfit;
    }

    public void Wear()
    {
        _outfit.Wear();
    }
}