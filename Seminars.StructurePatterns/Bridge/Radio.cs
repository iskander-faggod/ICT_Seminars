namespace Seminars.StructurePatterns.Bridge;

public class Radio : IDevice
{
    public void Enable()
    {
        Console.WriteLine("вкл радио");
    }

    public void Disable()
    {
        Console.WriteLine("выкл радио");
    }

    public void ChangeResource()
    {
        Console.WriteLine("переключить радио волну");
    }
}