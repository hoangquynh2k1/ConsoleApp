namespace TestConsoleApp.Facade
{
    public class AccountChecker
    {
        private string accountID = "1015094686";

        public AccountChecker()
        {

        }

        public bool IsValid(string accountID)
        {
            return this.accountID == accountID;
        }
    }
}
