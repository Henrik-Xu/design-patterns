using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 享元模式（Flyweight）.利用共享技术有效地支持大量细粒度的对象
 */
namespace Flyweight
{   
   /*
    * 所有具体享元类的超类或接口，通过这个接口， Flyweight 可以接受并作用于外部状态
    */
   public abstract class Flyweight
    {
        public abstract void Operation(int  extrinsicstate);
    }

    /*
     * 继承 Flyweight 超类或实现 Flyweight接口，并为内部状态增加存储空间。
     */
    public class ConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine($"Specific Flyweight:{extrinsicstate}");
        }
    }

    /*
     * 指那些不需要共享的 Flyweight 子类。因为 Flyweight 接口共享成为可能，但它并不强制共享。
     */
    public class UnshareConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine($"Unshare Flyweight:{extrinsicstate}");
        }
    }

    /*
     * 一个享元工厂，用来创建并管理 Flyweight 对象。它主要用来确保合理的共享 Flyweight,当用户请求一个 Flyweight时， 
     * FlyweightFactory 对象提供一个已创建的实例或者创建一个（如果不存在的话）
     */
    public class FlyweightFactory
    {
        private Hashtable flyweights = new Hashtable();

        public Flyweight GetFlyweight(int key)
        {
            if(!flyweights.ContainsKey(key))
            {
                flyweights.Add(key,new ConcreteFlyweight());
            } 
            return (Flyweight)flyweights[key];
        }
    }
}
