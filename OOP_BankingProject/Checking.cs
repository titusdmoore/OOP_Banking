using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_BankingProject {
    class Checking : Account {
        private int ChkNbr { get; set; } = 0;

        public override string Print() {
            return base.Print() + $"| {ChkNbr} ";
        }

        public bool Pay(int ChkNbr, decimal Amount) {
            this.ChkNbr = ChkNbr;
            if (this.Withdraw(Amount)) {
                this.Withdraw(Amount);
                return true;
            }else {
                return false;
            }
            
        }
    }
}
