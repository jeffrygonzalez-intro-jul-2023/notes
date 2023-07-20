
using Banking.Domain;



var account = new BankAccount();

Console.Write("How much do you want to deposit?: ");

var amountEntered = Console.ReadLine();
if (amountEntered is not null)
{
    var amount = decimal.Parse(amountEntered);
    account.Deposit(amount);
    Console.WriteLine($"Your new balance is {account.GetBalance():c}");
}
