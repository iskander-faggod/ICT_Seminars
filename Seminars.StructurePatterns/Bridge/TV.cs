namespace Seminars.StructurePatterns.Bridge;

public class TV : IDevice
{
    public void Enable()
    {
        Console.WriteLine("вкл телевизор");
        // тут можно добавить больше функционала
    }

    public void Disable()
    {
        Console.WriteLine("выкл телевизор");

    }

    public void ChangeResource()
    {
        Console.WriteLine("переключаю канал телевизора");
    }
}