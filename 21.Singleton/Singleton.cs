using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 单例模式（Singleton）,保证一个类仅有一个实例，并提供一个访问它的全局访问点
/// </summary>
namespace Singleton
{
    /// <summary>
    /// 多线程情况下的单利模式（懒汉式单例模式）
    /// </summary>
    public class Singleton
    {
        private static Singleton instance = null;

        private static readonly object synObject = new object();

        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (instance == null) //Double Checking Locking(双重锁定)
            {
                lock (synObject)
                {
                    if(instance == null)
                    {
                        instance = new Singleton();
                    }
                }                
            }

            return instance;
        }
    }

    /// <summary>
    /// 饿汉式单例模式
    /// </summary>
    public sealed class SingletonAnotherWay
    {
        private static readonly SingletonAnotherWay instance = new SingletonAnotherWay();

        private SingletonAnotherWay() { }

        public static SingletonAnotherWay Instance => instance;
    }
}
