using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 外观模式（Facede),为子系统中的一组接口提供一个一致的界面，此模式定义了一个高层接口，这个接口使得这一子系统更加容易使用。
 * 
 * 说明：
 * 1.设计初期阶段，应该要有意识的将不同的两个层分离，比如经典的三层架构，就需要在数据访问层、业务逻辑层和表示层的层与层之间
 * 建立外观Facade,这样可以为复杂的子系统提供一个简单的接口，使得耦合性大大降低。
 * 2.当子系统因为不断重构演化而变得越来越复杂，增加外观 Facede 可以提供一个简单的接口，减少它们之间的依赖。
 * 3.在维护一个遗留的大型系统时，可能这个系统已经非常难以维护和扩展，但因为它包含非常重要的功能，新的需求开发必需要依赖于它。
 * 此时可以为新系统开发一个外观 Facede 类，来提供设计粗糙或高度复杂的遗留代码的比较清晰简单的接口，让新系统与Facede 对象交互，
 * Facede与遗留代码交互所有复杂的工作。开发分为两个组，一组开发 Facade与老系统交互，另一个只要了解 Facade 的接口，直接开发新
 * 系统调用这些接口即可。
 */
namespace Facade
{
    public class SubSystemOne
    {
        public void MethodOne()
        {
            Console.WriteLine("System One Operation");
        }
    }
    public class SubSystemTwo
    {
        public void MethodTwo()
        {
            Console.WriteLine("System Two Operation");
        }
    }
    public class SubSystemThree
    {
        public void MethodThree()
        {
            Console.WriteLine("System Three Operation");
        }
    }

    public class Facade
    {
        SubSystemOne one;
        SubSystemTwo two;
        SubSystemThree three;

        public Facade()
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubSystemThree();
        }

        public void MethodA()
        {
            Console.WriteLine("----- A Method -----");
            one.MethodOne();
            two.MethodTwo();
            three.MethodThree();
        }

        public void MethodB()
        {
            Console.WriteLine("----- B Method -----");
            two.MethodTwo();
            three.MethodThree();
        }
    }
}
