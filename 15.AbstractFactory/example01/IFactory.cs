using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* 抽象工厂模式（Abstract Factory）:提供一个创建一系列相关或依赖对象的接口，而无需指定它们具体的操作类。
*/
namespace AbstractFactory
{
   public  interface IFactory
    {
        IUserOperation CreateUser();
        IDepartmentOperation CreateDepartment();
       
    }
    public class SqlServerFactory : IFactory
    {
        public IDepartmentOperation CreateDepartment()
        {
            return new SqlServerDepartment();
        }

        public IUserOperation CreateUser()
        {
            return new SqlServerUser();
        }
    }
    public class AccessFactory : IFactory
    {
        public IDepartmentOperation CreateDepartment()
        {
            return new AcessDepartment();
        }

        public IUserOperation CreateUser()
        {
            return new AccessUser();
        }
    }
}
