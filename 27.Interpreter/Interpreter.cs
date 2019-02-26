using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* 解释器模式（Interpreter）,给定一个语言，定义它的文法的一种表示，并定义一个解释器，这个解释器使用该表示来解释语言中的句子。
* 
* 优点：解释器使用类继承来扩展，这意味着可以很容易地改变和扩展。
* 缺点：解释器模式为文法中的每一条规则至少定义了一个类，因此包含许多规则的文法可能难以管理和维护。
*/
namespace Interpreter
{
    /// <summary>
    /// 上下文
    /// </summary>
    public class Context
    {
        public string Input { get; set; }

        public string Output { get; set; }
    }

    /// <summary>
    /// 解释器抽象类
    /// </summary>
    public abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }

    public class TerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("终端解释器");
        }
    }

    public class NonTerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("非终端解释器");
        }
    }
}
