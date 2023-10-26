using Seminars.GenerativePatterns.Factory.AbstractModels;

namespace Seminars.GenerativePatterns.Factory.ConcreteFactory;

public class ConcreteB : AbstractB
{
    public ConcreteB(string name) : base(name)
    {
        Name = name;
    }
}