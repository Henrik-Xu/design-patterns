using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public abstract class WebSite
    {
        public abstract void Use(User user);
    }
    public class ConcreteWebSite : WebSite
    {
        private string name = string.Empty;

        public ConcreteWebSite(string name)
        {
            this.name = name;
        }

        public override void Use(User user)
        {
            Console.WriteLine($"WebSite Category :{name}, UerName:{user.Name},Password:{user.Password}");
        }
    }
    public class WebSiteFactory
    {
        private Hashtable hashtable = new Hashtable();

        public WebSite GetWebSite(int key)
        {
            if (!hashtable.ContainsKey(key))
            {
                hashtable.Add(key, new ConcreteWebSite(key.ToString()));
            }
            return (WebSite)hashtable[key];
        }

        public int GetWebSiteCount()
        {
            return hashtable.Count;
        }
    }
}
