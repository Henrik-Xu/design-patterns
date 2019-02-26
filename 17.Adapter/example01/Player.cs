using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 适配器模式（Adapter）,将一个类的接口转换成客户希望的另外一个接口。Adapter使得原本由于接口不兼容而不能
 * 一起工作的那些类可以一起工作。
 * 
 * 使用场景：使用一个已经存在的类，但如果它的接口，也就是它的方法和你的要求不相同时，就应该考虑适配器模式。
 * 
 * .Net中的适配器：DataAdapater
 * DataAdapter用作DataSet和数据源之间的适配器以便检索和保存数据。DataAdapter通过映射 Fill（这更改了DataSet 中的数据
 * 以便与数据源中的数据相匹配） 和 Update(这更改了数据源中的数据以便与 DataSet中的数据相匹配) 来提供这一适配器。由于
 * 数据源可能来自 SQLServer,可能来自 Oracle,也可能来自 Access，这些数据在组织上可能有不同之处，但我们希望得到统一的
 * DataSet(实质是XML数据)，此时用DataAdapter就是非常好的手段，我们不必关注不同数据库的数据细节，就可以灵活的使用数据。
 */
namespace Adapter
{
    public abstract class Player
    {
        protected string name;
        public Player(string name)
        {
            this.name = name;
        }

        public abstract void Attack();
        public abstract void Defence();
    }

    public class Forwards : Player
    {
        public Forwards(string name) : base(name)
        {

        }
        public override void Attack()
        {
            Console.WriteLine($"Foreign Forward {name} Attack!");
        }

        public override void Defence()
        {
            Console.WriteLine($"Foreign Forward {name} Defence!");
        }
    }

    public class Center : Player
    {
        public Center(string name) : base(name)
        {

        }
        public override void Attack()
        {
            Console.WriteLine($"Foreign Center {name} Attack!");
        }

        public override void Defence()
        {
            Console.WriteLine($"Foreign Center {name} Defence!");
        }
    }

    public class Guard : Player
    {
        public Guard(string name) : base(name)
        {

        }
        public override void Attack()
        {
            Console.WriteLine($"Foreign Center {name} Attack!");
        }

        public override void Defence()
        {
            Console.WriteLine($"Foreign Center {name} Defence!");
        }
    }

    public class ForeignCenter
    {
        protected string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public ForeignCenter()
        {
            
        }

        public  void ChineseAttack()
        {
            Console.WriteLine($"zhongfeng {name} jingong!");
        }
        public void ChineseDefence()
        {
            Console.WriteLine($"zhongfeng {name} fangshou!");
        }
    }
    public class Translate : Player
    {
        private ForeignCenter foreignCenter = new ForeignCenter();

        public Translate(string name):base(name)
        {
            foreignCenter.Name = name;
        }

        public override void Attack()
        {
            foreignCenter.ChineseAttack();
        }

        public override void Defence()
        {
            foreignCenter.ChineseDefence();
        }
    }
}
