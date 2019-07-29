using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_BankingProject {
    class MoneyMarket : Account {

        public double intRate { get; set; } = 0.06;

        public override string Print() {
            return base.Print() + $"| {intRate}";
        }

        public void intPay (int weeks) {
            double intToBePaid = this.intRate / 52 * weeks * (double)this.GetBalance();
            this.Deposit((decimal)intToBePaid);
        }

    }
}
