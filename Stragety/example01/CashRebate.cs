using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class CashRebate : CashSuper
    {
        private double moneyRebate = 1d;

        public CashRebate(double moneyRebate)
        {
            this.moneyRebate = moneyRebate;
        }
        public override double AcceptCash(double money)
        {
            return money * moneyRebate;
        }
    }
}
