using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
   public class CashContext
    {
        private CashSuper _cashSuper;

        public CashContext(string type)
        {
            switch (type)
            {
                case "Nomal Cash":
                    _cashSuper = new CashRebate(1);
                    break;
                case "Full 300 to 100":
                    _cashSuper = new CashReturn(300, 100);
                    break;
                case "80% off":
                    _cashSuper = new CashRebate(0.8);
                    break;
            }
        }
        public double GetResult(double money)
        {
            return _cashSuper.AcceptCash(money);
        }
    }
}
