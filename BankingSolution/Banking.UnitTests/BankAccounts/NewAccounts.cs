

using Banking.Domain;

namespace Banking.UnitTests.BankAccounts;

public class NewAccounts
{

    [Fact]
    public void NewAccountsHaveCorrectOpeningBalance()
    {
        // this creates a new instance of the BankAccount class
        // called account

        
        var account = new BankAccount(new Mock<ICanCalculateBonusesForBankAccountDeposits>().Object);

        //account._balance = 100_000;

        decimal balance = account.GetBalance();

        Assert.Equal(5000, balance);
    }
}
