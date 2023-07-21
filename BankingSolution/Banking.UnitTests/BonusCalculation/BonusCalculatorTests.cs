

using Banking.Domain;

namespace Banking.UnitTests.BonusCalculation;

public class BonusCalculatorTests
{
    [Theory]
    [InlineData(100, 10)]
    [InlineData(200, 20)]
    public void HasSufficientBalance(decimal amountOfDeposit, decimal expectedBonus)
    {
        var bonusCalculator = new StandardBonusCalculator();
       
        var balanceOnAccount = 6000M;

        decimal bonus = bonusCalculator.CalculateBonusForDeposit(balanceOnAccount, amountOfDeposit);

        Assert.Equal(expectedBonus, bonus);
    }

    [Theory]
    [InlineData(100, 0)]
    [InlineData(200, 0)]
    public void HasInsufficientBalance(decimal amountOfDeposit, decimal expectedBonus)
    {
        var bonusCalculator = new StandardBonusCalculator();

        var balanceOnAccount = 5999.99M;

        decimal bonus = bonusCalculator.CalculateBonusForDeposit(balanceOnAccount, amountOfDeposit);

        Assert.Equal(expectedBonus, bonus);
    }

}
