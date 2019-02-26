using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 策略模式（Strategy）:它定义了算法家族，分别封装变化，让他们之间可以互相替换。此模式让算法的变化，不会影响到使用算法的客户。
 */
namespace Strategy
{
    public abstract class Strategy
    {
        public abstract void AlgorithmInterface();
    }

    public class ConcreteStrategyA : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法A实现");
        }
    }

    public class ConcreteStrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法B实现");
        }
    }

    public class ConcreteStrategyC : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法C实现");
        }
    }

    public class Context
    {
        Strategy strategy;

        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void ContextInterface()
        {
            strategy.AlgorithmInterface();
        }
    }


    /// <summary>
    /// 策略模式 + 简单工厂
    /// </summary>
    public class ContextAdvance
    {
        Strategy strategyAdvance;

        public ContextAdvance(string type)
        {
            switch (type)
            {
                case "ConcreteStrategyA":
                    strategyAdvance = new ConcreteStrategyA();
                    break;
                case "ConcreteStrategyB":
                    strategyAdvance = new ConcreteStrategyB();
                    break;
                case "ConcreteStrategyC":
                    strategyAdvance = new ConcreteStrategyC();
                    break;
                default:
                    strategyAdvance = null;
                    break;
            }
        }

        public void Excute()
        {
            if(strategyAdvance != null)
            {
                strategyAdvance.AlgorithmInterface();
            }
        }
    }
}
