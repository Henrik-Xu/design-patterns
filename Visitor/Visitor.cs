using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* 访问者模式（Vistor）,表示一个作用于某对象结构中的各元素的操作。它使你可以在不改变各元素的前提下定义作用于这些元素的新操作。
* 
* 访问者模式适用于数据结构相对稳定的系统，即 Elment 类的分类有限。如果数据结构不稳定，则每增加一中数据结构，Visitor以及它的所有子类都需要增加一个方法。
* 访问者模式的目的是要把处理从数据结构分离出来。
* 
* 优点：访问者模式增加新的操作很容易，因为增加新的操作就意味着增加一个新的访问者，只要添加新的类就好。
* 缺点：访问者模式增加新的数据结构变得困难。
*/
namespace Visitor
{
   public abstract class Visitor
    {
        public abstract void VisitConcreteElementA(ConcreteElementA concreteElementA);
        public abstract void VisitConcreteElementB(ConcreteElementB concreteElementB);
    }

    public class ConcreteVisitor1 : Visitor
    {
        public override void VisitConcreteElementA(ConcreteElementA concreteElementA)
        {
            Console.WriteLine("ConcreteVisitor1--VisitConcreteElementA(ConcreteElementA concreteElementA) Invoked");
        }

        public override void VisitConcreteElementB(ConcreteElementB concreteElementB)
        {
            Console.WriteLine("ConcreteVisitor1--VisitConcreteElementB(ConcreteElementB concreteElementB) Invoked");
        }
    }

    public class ConcreteVisitor2 : Visitor
    {
        public override void VisitConcreteElementA(ConcreteElementA concreteElementA)
        {
            Console.WriteLine("ConcreteVisitor2--VisitConcreteElementA(ConcreteElementA concreteElementA) Invoked");
        }

        public override void VisitConcreteElementB(ConcreteElementB concreteElementB)
        {
            Console.WriteLine("ConcreteVisitor2--VisitConcreteElementB(ConcreteElementB concreteElementB) Invoked");
        }
    }

    public abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }

    public class ConcreteElementA : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }
    }

    public class ConcreteElementB : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementB(this);
        }
    }

    public class ObjectStructureAdvance
    {
        private IList<Element> elements = new List<Element>();

        public void Attach(Element element)
        {
            elements.Add(element);
        }

        public void Detach(Element element)
        {
            elements.Remove(element);
        }

        public void Accept(Visitor visitor)
        {
            foreach (Element item in elements)
            {
                item.Accept(visitor);
            }
        }
    }
}
