using System.Text;
using TestConsoleApp.LinQ;
using Delegate = TestConsoleApp.LinQ.Delegate;

//BankAccountFacade bankAccountFacade = new("1015094686", "123456");
//bankAccountFacade.DepositCash(1000);
//bankAccountFacade.WithdrawCash(1500);

{
    Console.OutputEncoding = Encoding.UTF8;
    //LinQ.Run();
    //Delegate.Run();
    Lambda.Run();
    Console.ReadLine();
}
