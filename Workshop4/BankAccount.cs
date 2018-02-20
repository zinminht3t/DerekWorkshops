using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop4
{
    class Account
    {
        string accountNumber;
        string accountHolderName;
        double balance;
        double interestRate;
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
        public double InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
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
        public double CalculateInterest()
        {
            return balance * 1 / 100;
        }
        public void CreditInterest()
        {
            Deposit(CalculateInterest());
        }
    }
    class CurrentAccount : Account
    {
        public CurrentAccount(string accountNumber, string accountHolderName, double balance):base(accountNumber, accountHolderName, balance)
        { }
        public new double CalculateInterest()
        {
            return Balance * 0.25 / 100;
        }
        public new string Show()
        {
            return string.Format(" Account No : {0} \n Holder Name : {1} \n Balance : {2} \n **************************", AccountNumber, AccountHolderName, Balance);
        }

    }
    class OverdraftAccount : Account
    {
        public OverdraftAccount(string accountNumber, string accountHolderName, double balance) : base(accountNumber, accountHolderName, balance)
        { }
        public new void Withdraw(double amount)
        {
           Balance -= amount;
        }
        public new double CalculateInterest()
        {
            if(Balance > 0)
            {
                return Balance * 0.25 / 100;
            }
            else
            {
                return Balance * 6 / 100;
            }
        }
        public new string Show()
        {
            return string.Format(" Account No : {0} \n Holder Name : {1} \n Balance : {2} \n **************************", AccountNumber, AccountHolderName, Balance);
        }

    }
}
