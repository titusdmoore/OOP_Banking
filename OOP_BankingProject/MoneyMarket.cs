using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_BankingProject {
    class MoneyMarket : Account {

        public double intRate { get; set; } = 0.06;

        public override string Print() {
            return base.Print() + $"| {intRate}";
        }

        public bool changeRate(double value) {
            bool success = false;
            if ((this.intRate + value) >= 0) {
                this.intRate += value;
                success = true;
            } else {
                Console.WriteLine("Invalid Change in Interest: Interest Rate cannot be less than 0");
            }
            return success;
        }

        public void intPay (int weeks) {
            double intToBePaid = this.intRate / 52 * weeks * (double)this.GetBalance();
            this.Deposit((decimal)intToBePaid);
        }

    }
}
