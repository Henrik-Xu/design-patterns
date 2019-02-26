using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 模板方法模式，定义一个操作中的算法的骨架，而将一些步骤延迟到子类中。模板方法使得子类可以不改变一个算法的结构即可重定义该算法的某些特定步骤。
 * 
 * 有时候，我们会遇到由一系列步骤构成的过程需要执行，这个过程从高层次上看是相同的，但有些步骤的实现可能不同，这时候就可以考虑模板方法了。
 * 
 * 模板方法模式通过把不变行为搬到超类，去除子类中的重复代码来体现它的优势。
 */
namespace TemplateMethod
{
  public abstract class AbstracClass
    {
        public abstract void PrimitiveOperation01();
        public abstract void PrimitiveOperation02();

        public void TemplateMethod()
        {
            PrimitiveOperation01();
            PrimitiveOperation02();           
        }
    }
}
