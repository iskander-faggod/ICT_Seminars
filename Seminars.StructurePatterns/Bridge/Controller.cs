namespace Seminars.StructurePatterns.Bridge;

public class Controller : IController
{
    private readonly IDevice _device;

    public Controller(IDevice device)
    {
        _device = device;
    }

    public void TurnOn()
    {
        _device.Disable();
    }

    public void TurnOff()
    {
        _device.Disable();
    }

    public void MoveNext()
    {
        _device.ChangeResource();
    }
}