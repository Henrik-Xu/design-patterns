using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
  public  class CashFactory
    {
        public static CashSuper CreateCashAccept(string type)
        {
            CashSuper cashSuper = null;
            switch (type)
            {
                case "Nomal Cash":
                    cashSuper = new CashRebate(1);
                    break;
                case "Full 300 to 100":
                    cashSuper = new CashReturn(300,100);
                    break;
                case "80% off":
                    cashSuper = new CashRebate(0.8);
                    break;
            }
            return cashSuper;
        }
    }
}
