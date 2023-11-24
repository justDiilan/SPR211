using System;
using Bank;

namespace Bank_Opearations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount("111111", 1000);
            BankAccount account2 = new BankAccount("222222", 500);

            account1.BankOperation += HandleBankOperation;
            account2.BankOperation += HandleBankOperation;

            TransactionManager.Deposit(account1, 200);
            TransactionManager.Withdraw(account2, 100);

            Console.WriteLine($"Account 1 balance: {account1.Balance}");
            Console.WriteLine($"Account 2 balance: {account2.Balance}");

            Console.ReadKey();
        }

        static void HandleBankOperation(object sender, BankOperationEventArgs e)
        {
            Console.WriteLine($"Account Number: {e.AccountNumber}, Amount: {e.Amount}, Operation Type: {e.OperationType}");
        }
    }
}
