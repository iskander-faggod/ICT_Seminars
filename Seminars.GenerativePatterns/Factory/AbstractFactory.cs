using Seminars.GenerativePatterns.Factory.AbstractModels;

namespace Seminars.GenerativePatterns.Factory;

public interface IAbstractFactory
{
    public AbstractA CreateAbstractA();
    public AbstractB CreateAbstractB();
}