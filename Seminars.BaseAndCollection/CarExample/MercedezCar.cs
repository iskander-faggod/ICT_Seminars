namespace Seminars.BaseAndCollection;

public class MercedezCar : ICar
{
    public MercedezCar(int wheelsCount, long distance, string carName)
    {
        WheelsCount = wheelsCount;
        Distance = distance;
        CarName = carName;
    }

    public int WheelsCount { get; set; }
    public long Distance { get; set; }
    public string CarName { get; set; }

    public void AddWheel()
    {
        WheelsCount += 1;
    }

    public void AddDistance(long distance)
    {
        Distance += distance;
    }

    public long GetDistance()
    {
        return Distance;
    }

    public void VrumVrumMethod()
    {
        Console.WriteLine("Мерседез делает Врум врум");
    }
}