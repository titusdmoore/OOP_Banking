using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_BankingProject {
    public class Savings : Account {

        public double intRate { get; set; } = 0.03;

        public override string Print() {
            return base.Print() + $"| {intRate}";
        }

        public bool changeRate (double value) {
            bool success = false;
            if ((this.intRate + value) >= 0) {
                this.intRate += value;
                success = true;
            } else {
                Console.WriteLine("Invalid Change in Interest: Interest Rate cannot be less than 0");
            }
            return success;
        }
        public decimal intCalc (int months) {
            double intToBePaid = this.intRate / 12 * months * (double)this.GetBalance();
            return (decimal)intToBePaid;
        }

        public void PayInterest(decimal amountInterest) {
            this.Deposit(amountInterest);
        }
    }
}
