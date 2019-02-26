using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    /*
     * 命令模式（Command）将一个请求封装为一个对象，从而使你可用不同的请求对客户进行参数化；对请求排队或记录请求日志，以及支持可撤销的操作。
    */
    public abstract class Command
    {
        protected Receiver receiver;

        public Command(Receiver receiver)
        {
            this.receiver = receiver;
        }
        abstract public void Execute();
    }
    public class ConcreteCommandA : Command
    {
        public ConcreteCommandA(Receiver receiver) : base(receiver)
        {
        }

        public override void Execute()
        {
            receiver.ActionCommandA();
        }
    }

    public class ConcreteCommandB : Command
    {
        public ConcreteCommandB(Receiver receiver) : base(receiver)
        {
        }

        public override void Execute()
        {
            receiver.ActionCommandB();
        }
    }
    public class Receiver
    {
        public void ActionCommandA()
        {
            Console.WriteLine("Execute Behavior A!");
        }
        public void ActionCommandB()
        {
            Console.WriteLine("Execute Behavior B!");
        }
    }

    public class Invoker
    {
        private Command command;

        public void SetCommand(Command command)
        {
            this.command = command;
        }

        public void ExecuteCommand()
        {
            command.Execute();
        }
    }
}
