using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop3b
{
    class Account
    {
        string accountNumber;
        string accountHolderName;
        double balance;
        public Account(string accountNumber, string accountHolderName, double balance)
        {
            this.accountNumber = accountNumber;
            this.accountHolderName = accountHolderName;
            this.balance = balance;
        }
        public Account(string accountNumber, Customer customer, double balance): this(accountNumber, customer.Name, balance)
        {

        }
        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        public string AccountHolderName
        {
            get { return accountHolderName; }
            set { accountHolderName = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
            }
        }
        public void Deposit(double amount)
        {
            balance += amount;
        }
        public void TransferTo(double amount, Account account)
        {
            Withdraw(amount);
            account.Deposit(amount);
        }
        public string Show()
        {
            return string.Format(" Account No : {0} \n Holder Name : {1} \n Balance : {2} \n **************************", accountNumber, accountHolderName, balance);
        }
    }
}
