using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 建造者模式（Builder），将一个复杂对象的构建与它的表示分离，使得同样的构建过程可以创建不同的表示。
 * 
 * 建造者模式主要用于创建一些复杂的对象，这些对象内部创建间的建造顺序通常是稳定的，但对象内部的构建通常面临着复杂的变化。
 */
namespace Builder
{
   abstract class PersonBuilder
    {
        protected Graphics g;
        protected Pen p;

        public PersonBuilder(Graphics g,Pen p)
        {
            this.g = g;
            this.p = p;
        }
        public abstract void BuildHead();
        public abstract void BuildBody();
        public abstract void BuildArmLeft();
        public abstract void BuildArmRight();
        public abstract void BuildLegLeft();
        public abstract void BuildLegRight();          
    }
}
