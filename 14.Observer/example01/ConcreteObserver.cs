using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
  public  class ConcreteObserver : Observer
    {
        private string name;
        private string observerState;
        private ConcreteSubject subject;
        public ConcreteSubject Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        public ConcreteObserver(ConcreteSubject subject,string name)
        {
            this.subject = subject;
            this.name = name;
        }

        protected ConcreteObserver()
        {
        }

        public void Update()
        {
            observerState = subject.SubjectState;
            Console.WriteLine("Observer {0} 's new State {1}", name, observerState);
        }
    }
}
