namespace Banking.Domain
{
    public class StandardBonusCalculator
    {
        public StandardBonusCalculator()
        {
        }

        public decimal CalculateBonusForDeposit(decimal balanceOnAccount, decimal amountOfDeposit)
        {
            decimal bonusMultiplier = DateTime.Now.Hour >= 9 && DateTime.Now.Hour < 17 ? .10M : .05M;
            return balanceOnAccount >= 6000M ? amountOfDeposit * bonusMultiplier : 0;
        }
    }
}