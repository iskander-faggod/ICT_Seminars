namespace Seminars.GenerativePatterns.Factory.AbstractModels;

public abstract class AbstractA
{
    public AbstractA(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
}