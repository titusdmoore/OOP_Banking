using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_BankingProject {
    public class Account {

        public string number { get; set; }
        private decimal balance { get; set; } = 0m;
        public string name { get; set; }
        public bool isActive { get; set; } = true;

        public virtual string Print() {
            return $"{this.number} | {this.balance} | {this.name} ";
        }

        public bool TransferTo(Account toAccount, decimal amount) {
            bool success = this.Withdraw(amount);
            if (success) {
                toAccount.Deposit(amount);
            }
            return success;
        }

        public bool Deposit (decimal amount) {
            if (amount <= 0) {
                Console.WriteLine("Invalid Deposit amount: Deposit cannot be less than 0");
                return false;
            } else {
                this.balance += amount;
                return true;
            }
            return false;
        }

        public bool Withdraw (decimal amount) {
            bool success = false;
            if (amount <= 0) {
                Console.WriteLine("Invalid Withdraw amount: Withdraw cannot be less than 0");
            } else {
                if (this.balance >= amount) {
                    this.balance -= amount;
                    success = true;
                } else {
                    Console.WriteLine("Invalid Withdraw amount: Withdraw is greater than Balance");
                }
            }
            return success;
        }

        public decimal GetBalance () {
            return this.balance;
        }

    }
}
