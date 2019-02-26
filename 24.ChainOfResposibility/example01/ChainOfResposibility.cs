using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResposibility
{
    /*
     * 职责链模式（Chain of Resposiblility）:使多个对象都有机会处理请求，从而避免请求的发送者和接受者之间的耦合关系。将这个对象连成一条链，并沿着这条链传递该请求，直到有一个对象处理它为止。
     * Key:当客户提交一个请求时，请求是沿链传递直至一个ConcreteHandler对象负责处理它。
     * 好处：接收者和发送者都没有对方的明确信息，且链中的对象自己也并不知道链的结构。结果是职责链可简化对象的相互链接，它们仅需保持一个指向其后继者的引用，而不需要保持它所有的候选接受者的引用。这也就大大降低了耦合度了。
     */
    public abstract class Handler
    {
        protected Handler successor;

        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }

        public abstract void HandlerRequest(int request);
    }

    public class ConcreteHandler1 : Handler
    {
        public override void HandlerRequest(int request)
        {
            if(request>0&&request<=10)
            {
                Console.WriteLine($"{this.GetType().Name} Handler Request {request}");
            }
            else if(successor!=null)
            {
                successor.HandlerRequest(request);
            }
        }
    }

    public class ConcreteHandler2 : Handler
    {
        public override void HandlerRequest(int request)
        {
            if (request > 10 && request <= 20)
            {
                Console.WriteLine($"{this.GetType().Name} Handler Request {request}");
            }
            else if (successor != null)
            {
                successor.HandlerRequest(request);
            }
        }
    }

    public class ConcreteHandler3 : Handler
    {
        public override void HandlerRequest(int request)
        {
            if (request > 20 && request <= 30)
            {
                Console.WriteLine($"{this.GetType().Name} Handler Request {request}");
            }
            else if (successor != null)
            {
                successor.HandlerRequest(request);
            }
            else
            {
                Console.WriteLine("Request can not passed!");
            }
        }
    }
} 
