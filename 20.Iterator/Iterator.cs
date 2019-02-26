using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* 迭代器模式（Iterator），提供一种方法顺序访问一个聚合对象中各个元素，而又不暴露该对象的内部表示
*/
namespace Iterator
{
  /// <summary>
  /// 迭代抽象类，用于定义得到开始对象、得到下一个对象，判断是否到结尾、当前对象等抽象方法，统一接口。
  /// </summary>
   public abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();
    }

    /// <summary>
    /// 聚集抽象类
    /// </summary>
    public abstract class Aggregate
    {
       // public abstract Iterator CreateIterator();
    }

    /// <summary>
    /// 具体聚集类，继承Aggregate
    /// </summary>
    public class ConcreteAggregate : Aggregate
    {
        private IList<object> items = new List<object>();

        public int Count => items.Count;

        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index,value); }
        }
    }

    //public class ConcreteAggregateDesc:Aggregate
    //{

    //}

    /// <summary>
    /// 具体迭代器类，继承Iterator,实现开始、下一个，是否结尾，当前对象等方法。
    /// </summary>
    public class ConcreteIterator : Iterator
    {
        private ConcreteAggregate aggregate;

        private int current = 0;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        public override object CurrentItem()
        {
            return aggregate[current];
        }

        public override object First()
        {
            return aggregate[0];
        }

        public override bool IsDone()
        {
            return aggregate.Count <= current;
        }

        public override object Next()
        {
            object rel = null;
            current++;
            if(current<aggregate.Count)
            {
                rel = aggregate[current];
            }
            return rel;
        }
    }
    public class ConcreteIteratorDesc : Iterator
    {
        private ConcreteAggregate aggregate;

        private int current = 0;

        public ConcreteIteratorDesc(ConcreteAggregate concrete)
        {
            this.aggregate = concrete;
            current = concrete.Count - 1;
        }

        public override object CurrentItem()
        {
            return aggregate[current];
        }

        public override object First()
        {
            return aggregate[aggregate.Count - 1];
        }

        public override bool IsDone()
        {
            return current < 0;
        }

        public override object Next()
        {
            object rel = null;
            current--;
            if(current>=0)
            {
                rel = aggregate[current];
            }
            return rel;
        }
    }
}
