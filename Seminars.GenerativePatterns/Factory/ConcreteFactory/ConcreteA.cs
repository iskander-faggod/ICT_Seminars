using Seminars.GenerativePatterns.Factory.AbstractModels;

namespace Seminars.GenerativePatterns.Factory.ConcreteFactory;

public class ConcreteA : AbstractA
{
    public ConcreteA(string name) : base(name)
    {
        Name = name;
    }
}