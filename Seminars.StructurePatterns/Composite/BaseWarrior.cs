namespace Seminars.StructurePatterns.Composite;

public class BaseWarrior : IRomeEmpireWarrior
{
    public void ManageWarriors(IRomeEmpireWarrior warrior)
    {
        Console.WriteLine("я знаю свое место и воюю");
    }

    public void War()
    {
        Console.WriteLine("АААААА убить варваров");
    }
}