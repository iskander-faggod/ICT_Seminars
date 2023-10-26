using Seminars.GenerativePatterns.Factory.AbstractModels;
using Seminars.GenerativePatterns.Factory.ConcreteFactory;

namespace Seminars.GenerativePatterns.FabricMethod;

public class ConcreteAMethod : IFabricMethod
{
    public AbstractA MethodA()
    {
        return new ConcreteA("Чета делаем для конкретного метода А");
    }
     
    public AbstractB MethodB()
    {
        return new ConcreteB("Чета делаем для конкретного метода B");
    }
}