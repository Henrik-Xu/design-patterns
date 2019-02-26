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
 */
namespace ObserverPattern
{
  public interface Observer
    {
         void Update();
    }
}
