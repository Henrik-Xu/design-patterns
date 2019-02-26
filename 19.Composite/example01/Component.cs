using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
   public abstract class Component
    {
        /*
         * Component为组合中的对象声明接口，在适当情况下，实现所有类共有接口的默认行为。声明一个接口用于访问和管理Component的子部件。
         */
        protected string name;

        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);
        
    }

    /*
     * Leaf在组合中表示页节点对象，叶节点没有子节点。
     */
    public class Leaf:Component
    {
        public Leaf(string name):base(name)
        {

        }

        public override void Add(Component c)
        {
            Console.WriteLine("Can not add to a leaf");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-',depth)+name);
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("Can not remove from a leaf");
        }
    }

    /*
     * Composite定义有支节点行为，用来存储子部件，在Component接口中实现与子部件有关的操作，比如增加Add和删除Remove.
     */
    public class Composite : Component
    {
        private List<Component> children = new List<Component>();

        public Composite(string name):base(name)
        {

        }
        public override void Add(Component c)
        {
            children.Add(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-',depth)+name);
            foreach (Component component in children)
            {
                component.Display(depth+2);
            }
        }

        public override void Remove(Component c)
        {
            children.Remove(c);
        }
    }
}
