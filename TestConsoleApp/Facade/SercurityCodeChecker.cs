namespace TestConsoleApp.Facade
{
    public class SercurityCodeChecker
    {
        private string sercurityCode = "123456";

        public SercurityCodeChecker() { }

        public bool IsValid(string sercurityCode)
        {
            return this.sercurityCode == sercurityCode;
        }
    }
}
