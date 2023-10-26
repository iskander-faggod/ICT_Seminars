namespace Seminars.StructurePatterns.Facade;

// суть в том, чтобы сделать общий интерфейс для работы с n сложными классами
// тут мы создаем метод GetCasinoBalance, который подразумевает

// пойти в банк - снять деньги - прийти в казик - обменять деньги на фишки
public class BankCasinoFacade
{
    private ICasino _casino;
    private IBank _bank;

    public BankCasinoFacade(ICasino casino, IBank bank)
    {
        _casino = casino;
        _bank = bank;
    }

    public void GetCasinoBalance()
    {
        // тут должны сохранять деньги куда-то
        _bank.WithdrawMoney();
        
        // тут должны деньги с этапа выше конвертировать в фишки
        _casino.GetChips();
    }
}
