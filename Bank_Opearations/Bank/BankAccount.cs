using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public int Balance { get; set; }
        public BankAccount(string accountNumber, int balance) 
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public delegate void BankOperationHandler(object sender, BankOperationEventArgs e);
        public event BankOperationHandler BankOperation;

        public void PerformOperation(int amount, string operationType)
        {
            if (operationType == "Deposit")
            {
                Balance += amount;
            }
            else if (operationType == "Withdraw" && amount <= Balance)
            {
                Balance -= amount;
            }

            OnBankOperation(new BankOperationEventArgs(AccountNumber, amount, operationType));
        }

        public virtual void OnBankOperation(BankOperationEventArgs e)
        {
            BankOperation?.Invoke(this, e);
        }
    }

    public class BankOperationEventArgs : EventArgs 
    {
        public string AccountNumber { get; set; }
        public int Amount { get; set; }
        public string OperationType { get; set; }
        public BankOperationEventArgs(string accountNumber, int amount, string operationType)
        {
            AccountNumber = accountNumber;
            Amount = amount;
            OperationType = operationType;
        }
    }

    public class TransactionManager
    {
        public static void Deposit(BankAccount account, int amount)
        {
            account.PerformOperation(amount, "Deposit");
        }
        public static void Withdraw(BankAccount account, int amount)
        {
            account.PerformOperation(amount, "Withdraw");
        }
    }
}
