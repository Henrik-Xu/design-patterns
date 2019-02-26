using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
* 合成/聚合复用原则（CARP），尽量使用合成/聚合，尽量不要使用类继承。
* 合成（Composition）和聚合（Aggregation）都是关联的特殊种类。聚合表示一种弱的拥有关系，体现A对象可以包含B对象，但B对象不是A对象的一部分；
* 合成则是一种强的拥有关系，体现了严格的部分和整体的关系，部分和整体的生命周期一样。
* 好处：优先使用对象的合成/聚合将有助于你保持每个类被封装，并被集中在单个任务上。这样类和类继承层次会保持较小规模，并且不太可能增长为不可控制的庞然大物。
* 
* 桥接模式（Bridge）将抽象部分与它的实现部分分离，使它们都可以独立地变化。
* 说明：实现系统可能有多个角度分类，每一种分类都有可能变化，那么就把这种多角度分离出来让它们独立变化，减少它们之间的耦合。
*/
namespace Bridge
{
    public abstract class Implementor
    {
        public abstract void Operation();
    }

    public class ConcreteImplementorA : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("具体实现A的方法执行");
        }
    }

    public class ConcreteImplementorB : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("具体实现B的方法执行");
        }
    }

    public class Abstraction
    {
        protected Implementor implementor;

        public void SetImplementor(Implementor implementor)
        {
            this.implementor = implementor;    
        }

        public virtual void Operation()
        {
            implementor.Operation();
        }
    }

    public class ConcreteAbstraction : Abstraction
    {
        public override void Operation()
        {
            base.Operation();
        }
    }
}
