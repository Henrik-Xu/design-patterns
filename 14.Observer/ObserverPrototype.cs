using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 观察者模式（Observer）: Observer 定义了一种一对多的依赖关系，让多个观察者对象同时监听某一主题对象。
 * 这个主题对象在状态发生变化时，会通知所有观察者对象，使它们能够自动更新自己。
 * 
 * 观察者模式又叫做 发布-订阅（Public/Subscribe）
 * 
 * 使用场景：当一个对象的改变需要同时改变其他对象的时候。
 */

namespace ObserverPattern
{
    interface SubjectPrototype
    {
        void Notify();
    }

    public class ConcreteSubjectA : SubjectPrototype
    {
        public event EventHandler Update;

        // ConcreteObserver A 自己的其他属性
        public string ObserverPropertyA { get; set; }

        public void Notify()
        {
            Update();
        }
    }

    public class ConcreteSubjectB : SubjectPrototype
    {
        public event EventHandler Update;

        // ConcreteObserver A 自己的其他属性
        public string ObserverPropertyB { get; set; }

        public void Notify()
        {
            Update();
        }
    }

    /// <summary>
    /// 定义多种多样的观察则
    /// </summary>
    public class SpecificObserverA
    {
        public void ActionA()
        {
            Console.WriteLine("Action A ...");
        }
    }

    public class SpecificObserverB
    {
        public void ActionB()
        {
            Console.WriteLine("Action B ...");
        }
    }
}
