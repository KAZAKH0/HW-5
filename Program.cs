using System; 

namespace HW_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankaccount = new BankAccount("56238767", "Nurzhan");
            BankAccount alex = new BankAccount("97862963", "Alex");
            bankaccount.Deposit(3000);
            bankaccount.Withdraw(1500);
            Console.WriteLine(alex.GetAccountInfo());
            Console.WriteLine(bankaccount.GetAccountInfo());
        }

    }

}