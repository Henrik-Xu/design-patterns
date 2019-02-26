using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* 中介者模式（Mediator）,用一个中介对象来封装一系列的对象交互。中介者使各对象不需要显示地相互引用，从而使其耦合松散，而且可以独立地改变它们之间的交互。
* 
* 中介者模式一般应用于一组对象以定义良好但是复杂的方式进行通信的场合，比如窗体 Form 对象或 Web 页面 aspx,以及想定制一个分布在多个类中的行为，而又不想生成太多子类的场合。
*/
namespace Mediator
{
   public abstract class Mediator
    {        
        public abstract void Send(string message,Colleague colleague);
    }

    public class ConcreteMediator : Mediator
    {
        private ConcreteColleague1 concreteColleague1;

        private ConcreteColleague2 concreteColleague2;

        public ConcreteColleague1 ConcreteColleague1
        {
            set => concreteColleague1 = value;
        }

        public ConcreteColleague2 ConcreteColleague2
        {
            set => concreteColleague2 = value;
        }
        public override void Send(string message, Colleague colleague)
        {
            if(colleague==concreteColleague1)
            {
                concreteColleague2.Notify(message);
            }
            else
            {
                concreteColleague1.Notify(message);
            }
        }
    }

    public abstract class Colleague
    {
        protected Mediator mediator;

        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public abstract void Send(string message);
        public abstract void Notify(string message);
    }
    public class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(Mediator mediator) : base(mediator)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine($"{this.GetType().Name} Get Message:{message}");
        }

        public override void Send(string message)
        {
            mediator.Send(message, this);
        }
    }

    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator mediator) : base(mediator)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine($"{this.GetType().Name} Get Message:{message}");
        }

        public override void Send(string message)
        {
            mediator.Send(message, this);
        }
    }

}
