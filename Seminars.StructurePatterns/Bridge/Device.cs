namespace Seminars.StructurePatterns.Bridge;

public class Device : IDevice
{
    public void Enable()
    {
        Console.WriteLine("включить устройство");
    }

    public void Disable()
    {
        Console.WriteLine("выключить устройство");
    }

    public void ChangeResource()
    {
        Console.WriteLine("поменять канал");
    }
}