namespace TestConsoleApp.Facade
{
    public class CashManager
    {
        private long cashAmount = 20000;
        public CashManager() { }

        public bool HaveEnoughMoney(long amount)
        {
            return cashAmount > amount;
        }

        public void Deposit(long amount)
        {
            cashAmount += amount;
            Console.WriteLine("Cash in account: " + cashAmount);
        }

        public void Withdraw(long amount)
        {
            cashAmount -= amount;
            Console.WriteLine("Cash in account: " + cashAmount);
        }
    }
}
