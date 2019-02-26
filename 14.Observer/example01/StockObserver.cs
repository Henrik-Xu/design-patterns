using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
   public class StockObserver
    {
        private string name;
        private Subject subject;

        public StockObserver(Subject subject, string name)
        {
            this.subject = subject;
            this.name = name;
        }

        public void ClostStockMarket()
        {
            Console.WriteLine("{0} {1} Close Stock, go on work！", subject.SubjectState, name);
        }
    }
   public class NBAObserver
    {
        private string name;
        private Subject subject;

        public NBAObserver(Subject subject, string name)
        {
            this.subject = subject;
            this.name = name;
        }

        public void ClostNBADirectingSeeding()
        {
            Console.WriteLine("{0} {1} Close NBA, go on work！", subject.SubjectState, name);
        }
    }
}
