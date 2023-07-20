

using Banking.Domain;

namespace Banking.UnitTests.BankAccounts;

public class MakingWithdrawals
{
    [Fact]
    public void MakingAWithdrawalDecreasesTheBalance()
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        var amountToWithdraw = 1.01M;

        account.Withdraw(amountToWithdraw);

        Assert.Equal(openingBalance - amountToWithdraw,
            account.GetBalance());
    }
}
