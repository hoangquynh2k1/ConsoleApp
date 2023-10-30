namespace TestConsoleApp.Facade
{
    public class BankAccountFacade
    {
        private readonly string accountID;
        private readonly string sercurityCode;
        AccountChecker accountChecker;
        SercurityCodeChecker sercurityCodeChecker;
        CashManager cashManager;

        public BankAccountFacade(string accountID, string sercurityCode)
        {
            this.accountID = accountID;
            this.sercurityCode = sercurityCode;
            accountChecker = new AccountChecker();
            sercurityCodeChecker = new SercurityCodeChecker();
            cashManager = new CashManager();
        }

        public void DepositCash(long amount)
        {
            if(accountChecker.IsValid(accountID) && sercurityCodeChecker.IsValid(sercurityCode))
            {
                cashManager.Deposit(amount);
            }
            else
            {
                Console.WriteLine("Have error!");
            }    
        }

        public void WithdrawCash(long amount)
        {
            if (accountChecker.IsValid(accountID) && sercurityCodeChecker.IsValid(sercurityCode)
                && cashManager.HaveEnoughMoney(amount))
            {
                cashManager.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Have error!");
            }
        }
    }
}
