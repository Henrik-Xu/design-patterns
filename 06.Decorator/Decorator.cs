using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
通过使用修饰模式，可以在运行时扩充一个类的功能。原理是：增加一个修饰类包裹原来的类，
包裹的方式一般是通过在将原来的对象作为修饰类的构造函数的参数。装饰类实现新的功能，
但是，在不需要用到新功能的地方，它可以直接调用原来的类中的方法。修饰类必须和原来的类有相同的接口。
修饰模式是类继承的另外一种选择。类继承在编译时候增加行为，而装饰模式是在运行时增加行为。
当有几个相互独立的功能需要扩充时，这个区别就变得很重要。在有些面向对象的编程语言中，类不能在运行时被创建，通常在设计的时候也不能预测到有哪几种功能组合。
这就意味著要为每一种组合创建一个新类。相反，修饰模式是面向运行时候的对象实例的,这样就可以在运行时根据需要进行组合。
一个修饰模式的示例是JAVA里的Java I/O Streams的实现。
*/
namespace Decorator
{
    public class Decorator : Component
    {
        protected Component component;

        public void SetComponent(Component com)
        {
            this.component = com;
        }

        public override void Operation()
        {
            if(component!=null)
            {
                component.Operation();
            }
        }
    }
}
