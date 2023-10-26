using Seminars.GenerativePatterns.Factory.AbstractModels;
using Seminars.GenerativePatterns.Factory.ConcreteFactory;

namespace Seminars.GenerativePatterns.Factory;

public class ConcreteFabricA : IAbstractFactory
{
    public AbstractA CreateAbstractA()
    {
        return new ConcreteA("concreteA");
    }

    public AbstractB CreateAbstractB()
    {
        return new ConcreteB("concreteB");
    }
}