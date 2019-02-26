using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 工厂方法模式（Factory Method）,定义一个用于创建对象的接口，让子类决定实例化哪一个类。工厂方法使一个类的实例化延迟到其子类。
 */
namespace FactoryMethod
{
   public abstract class Product
    {
        public abstract void Operation();
    }

    public class ConcreteProductA : Product
    {
        public override void Operation()
        {
            Console.WriteLine("Operation for A");
        }     
    }

    public class ConcreteProductB : Product
    {
        public override void Operation()
        {
            Console.WriteLine("Operation for B");
        }
    }

    public abstract class IFactory
    {
       public abstract Product CreateOperation();
    }

    public class ProductAFactory : IFactory
    {
        public override Product CreateOperation()
        {
            return new ConcreteProductA();
        }
    }

    public class ProductBFactory : IFactory
    {
        public override Product CreateOperation()
        {
            return new ConcreteProductB();
        }
    }
}
