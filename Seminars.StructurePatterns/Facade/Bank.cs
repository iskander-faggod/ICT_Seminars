namespace Seminars.StructurePatterns.Facade;

public interface IBank
{
    void WithdrawMoney();
}

public class Bank : IBank
{
    public void WithdrawMoney()
    {
        Console.WriteLine("сняли деньги с банка");
    }
}