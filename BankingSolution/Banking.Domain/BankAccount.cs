namespace Banking.Domain;

public class BankAccount
{
    private decimal _balance = 5000;
    public void Deposit(decimal amountToDeposit)
    {
        GuardCorrectTransactionAmount(amountToDeposit);
        _balance += amountToDeposit;
    }

    public decimal GetBalance()
    {

        return _balance; // This is obviously BS.
    }

    public void Withdraw(decimal amountToWithdraw)
    {
        GuardCorrectTransactionAmount(amountToWithdraw);
        GuardHasSufficentBalance(amountToWithdraw);
        _balance -= amountToWithdraw;
    }

    private void GuardHasSufficentBalance(decimal amountToWithdraw)
    {
        if (amountToWithdraw > _balance)
        {
            throw new AccountOverdraftException();
        }
    }

    private void GuardCorrectTransactionAmount(decimal amountToWithdraw)
    {
        if (amountToWithdraw <= 0)
        {
            throw new InvalidBankAccountTransactionAmountException();
        }
    }
}
