using System;

namespace OOP_BankingProject {
    class Program {
        static void Main(string[] args) {

            Savings newSav = new Savings();
            newSav.number = "Sav001";
            newSav.name = "Big Savings";
            newSav.Deposit(4000);

            MoneyMarket mmAcct = new MoneyMarket();
            mmAcct.number = "1003";
            mmAcct.name = "Test MM";
            mmAcct.Deposit(500);
            mmAcct.intPay(45);

            Account acct = new Account();
            acct.number = "1001";
            acct.name = "test account";
            acct.Deposit(20);

            Account[] Accounts = { acct, mmAcct, newSav };

            foreach (var account in Accounts) {
                Console.WriteLine(account.Print());
            }

            //Savings saveAcct = new Savings();
            //saveAcct.number = "1002";
            //saveAcct.name = "Test Savings";
            //saveAcct.intRate = 0.05;

            


            //saveAcct.Deposit(200);
            //saveAcct.Withdraw(100);

            //decimal toBePaid = saveAcct.intCalc(6);
            //saveAcct.PayInterest(toBePaid);

            //decimal savBal = saveAcct.GetBalance();
            //Console.WriteLine($"Save Balance is {savBal}");

            //Account acct = new Account();
            //acct.number = "1001";
            //acct.name = "Test Account";
            //acct.Deposit(20);
            //acct.Withdraw(10);


            //decimal balance = acct.GetBalance();
            //Console.WriteLine($"Account Balance is {balance} (should be 10)");

            //acct.Deposit(-10);
            //balance = acct.GetBalance();
            //Console.WriteLine($"Account Balance is {balance} (should be 10)");

            //acct.Withdraw(-10);
            //balance = acct.GetBalance();
            //Console.WriteLine($"Account Balance is {balance} (should be 10)");

            //acct.Withdraw(100);
            //balance = acct.GetBalance();
            //Console.WriteLine($"Account Balance is {balance} (should be 10)");

        }
    }
}
