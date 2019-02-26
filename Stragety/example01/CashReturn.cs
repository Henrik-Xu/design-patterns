using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class CashReturn : CashSuper
    {
        private double _moneyConditon=0.0d;
        private double _moneyReturn = 0.0d;


        public CashReturn(double moneyCondition,double moneyReturn)
        {
            this._moneyConditon = moneyCondition;
            this._moneyReturn = moneyReturn;
        }

        public override double AcceptCash(double money)
        {          
           if(money>_moneyConditon)
            {
                money = money - Math.Floor(money / _moneyConditon)*_moneyReturn;
            }
            return money;
        }
    }
}
