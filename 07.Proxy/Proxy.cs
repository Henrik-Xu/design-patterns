using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 代理模式（Proxy）,为其他对象提供一种代理以控制对这个对象的访问。
 * 代理就是真实对象的代表
 */
namespace Proxy
{
    /// <summary>
    /// Subject 类，定义了 RealSubject 和 Proxy 的共用接口，这样就在任何使用 RealSubject 的地方都是用 Proxy
    /// </summary>
   public abstract class Subject
    {
        public abstract void Request();
    }

    /// <summary>
    /// RealSubject类，定义了Proxy所代表的真实实体
    /// </summary>
    public class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("Real Request!");
        }
    }

    /// <summary>
    /// Proxy类，保存一个引用使得代理可以访问实体，并提供一个 Subject的接口相同的接口，这样代理就可以用来替代实体。
    /// </summary>
    public class Proxy : Subject
    {
        RealSubject realSubject;

        public override void Request()
        {
            if(realSubject == null)
            {
                realSubject = new RealSubject();
            }
            realSubject.Request();
        }
    }
}
