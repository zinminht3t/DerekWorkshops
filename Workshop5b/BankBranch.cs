using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop5b
{
    class BankBranch
    {
        string BranchName;
        string BranchManager;
        List<Account> accountLists;

        public void AddAcount(Account account)
        {
            accountLists.Add(account);
        }
        public void PrintCustomers()
        {
            for (int i = 0; i < accountLists.Count; i++)
            {
                Console.WriteLine(accountLists[i].AccountHolderName);
                Console.WriteLine("------");
            }
            Console.WriteLine();
        }

        public double TotalDeposits()
        {
            double total = 0;
            for (int i = 0; i < accountLists.Count; i++)
            {
                total += accountLists[i].Balance;
            }
            return total;
        }
        public double TotalInterestPaid()
        {
            double total = 0;
            for (int i = 0; i < accountLists.Count; i++)
            {
                if (accountLists[i].Balance > 0)
                    total += accountLists[i].CalculateInterest();
            }
            return total;

        }
        public double TotalInterestEarned()
        {
            double total = 0;
            for (int i = 0; i < accountLists.Count; i++)
            {
                if (accountLists[i].Balance < 0)
                    total -= accountLists[i].CalculateInterest();
            }
            return total;

        }
    }
}
