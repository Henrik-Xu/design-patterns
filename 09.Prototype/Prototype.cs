using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 原型模式（Prototype）,用原型实例指定创建对象的种类，并且通过拷贝这些原型对象创建新的对象
 * 
 * .NET在System命名空间中提供了ICloneable接口，其中唯一的方法Clone()，这样你就只需实现这个接口就可以完成原型模式了。
 * 
 * "浅复制（shallow）",被复制对象的所有变量都含有与原来对象相同的值，而所有的对其他对象的引用都仍然指向原来的对象。
 * 深复制把引用对象的变量指向复制过的新对象，而不是原有的被引用的对象
 */
namespace Prototype
{
  public abstract class Prototype
    {
        private string _id;

        public Prototype(string id)
        {
            this._id = id;
        }

        public string Id
        {
            get { return _id; }
        }

        public abstract Prototype Clone();
    }
}
