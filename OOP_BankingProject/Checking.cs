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

            if (this.Withdraw(Amount)) {
                 
                this.ChkNbr = ChkNbr;
                 
                this.Withdraw(Amount);
                return true;
            }else {
                return false;
            }
            
        }
    }
}
