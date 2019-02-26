using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 状态模式（State）,当一个对象的内在状态改变时允许改变其行为，这个对象看起来像是改变了其类。
 * 
 * 状态模式主要解决的是当控制一个对象状态转换的条件表达式过于复杂时的情况。把状态的判断逻辑转移到表示不同状态
 * 的一系列类中，可以把复杂的判断逻辑简化。
 */
namespace StatePattern
{
    public class Context
    {
        private State state;
        public Context(State state)
        {
            this.state = state;
        }

        public State State
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine($"Current State : {state.GetType().Name}");
            }
        }

        public void Request()
        {
            state.Handle(this);
        }
    }

  public abstract class State
    {
        public abstract void Handle(Context context);
    }
    public class ConcreteStateA : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreateStateB();
        }
    }


    public class ConcreateStateB : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }

    public abstract class StateAdance
    {
        public abstract void WriteProgram(WorkAdvance workAdvance);
    }
    public class ForeNoonState : StateAdance
    {
        public override void WriteProgram(WorkAdvance workAdvance)
        {
            if (workAdvance.Hour < 12)
            {
                Console.WriteLine($"Current time:{workAdvance.Hour},I have great power work morning");
            }
            else
            {
                workAdvance.SetState(new NoonState());
                workAdvance.WriteProgram();
            }
        }
    }

    public class NoonState : StateAdance
    {
        public override void WriteProgram(WorkAdvance workAdvance)
        {
            if (workAdvance.Hour < 13)
            {
                Console.WriteLine($"Current time:{workAdvance.Hour},I have just eat lunch, i feel tired");
            }
            else
            {
                workAdvance.SetState(new AfterNoonState());
                workAdvance.WriteProgram();
            }
        }
    }

    public class AfterNoonState : StateAdance
    {
        public override void WriteProgram(WorkAdvance workAdvance)
        {
            if(workAdvance.Hour<17)
            {
                Console.WriteLine($"Current time:{workAdvance.Hour},it's vert good work afternoon");
            }
            else
            {
                workAdvance.SetState(new EveningState());
                workAdvance.WriteProgram();
            }            
        }        
    }

    public class EveningState : StateAdance
    {
        public override void WriteProgram(WorkAdvance workAdvance)
        {
            if(workAdvance.TaskFinished)
            {
                workAdvance.SetState(new RestState());
                workAdvance.WriteProgram();
            }
            else
            {
                if (workAdvance.Hour < 21)
                {
                    Console.WriteLine($"Current time:{workAdvance.Hour},I am very tired work overtime");
                }
                else
                {
                    workAdvance.SetState(new SleepState());
                    workAdvance.WriteProgram();
                }
            }           
        }
    }

    public class SleepState : StateAdance
    {
        public override void WriteProgram(WorkAdvance workAdvance)
        {
            Console.WriteLine($"Current time:{workAdvance.Hour},Can not work anymore,i am fall asleep");
        }
    }

    public class RestState : StateAdance
    {
        public override void WriteProgram(WorkAdvance workAdvance)
        {
            Console.WriteLine($"Current time:{workAdvance.Hour},Work done ,i can go home now");
        }
    }


}
