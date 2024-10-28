using System.Transactions;

public class SingleResponsibilityPrinciple
{

    public  int AccountNo { get; set; }
    public double Balance { get; set; } = 0;
    public List<string> Transactions { get; set; }

    public SingleResponsibilityPrinciple(int accountNo)
    {
        AccountNo = accountNo;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited Amount:{amount}. Balace:{Balance}");

    }
    public void Withdraw(double amount)
    {

        Balance -= amount;
        Console.WriteLine($"Withdrawn Amount:{amount}. Balace:{Balance}");

    } 
   

}

public class PrintStatement
{
    public void Print(SingleResponsibilityPrinciple account)
    {
        Console.WriteLine($"Statements for account : {account.AccountNo}");
        foreach(var trans in account.Transactions)
        {
            Console.WriteLine(trans);


        }
    }
}
//Testing the Single Responsibility Principle
public class Program
{
    public static void Main()
    {
        SingleResponsibilityPrinciple johnsAccount = new SingleResponsibilityPrinciple(123456);
        johnsAccount.Deposit(500);
        johnsAccount.Withdraw(100);
        PrintStatement printer = new PrintStatement();
        printer.Print(johnsAccount);

        Console.ReadKey();
    }
}