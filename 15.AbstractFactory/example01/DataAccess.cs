using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Configuration;

namespace AbstractFactory
{
  public  class DataAccess
    {
        private static readonly string AssemblyName = "AbstractFactory";
        private static readonly string db = ConfigurationManager.AppSettings["DB"];
        public static IUserOperation CerateUser()
        {
            IUserOperation iu = null;
            switch (db)
            {
                case "SqlServer":
                    iu = new SqlServerUser();
                    break;
                case "Access":
                    iu = new AccessUser();
                    break;
            }
            return iu;
        }

        public static IDepartmentOperation CerateDepartment()
        {
            IDepartmentOperation ip = null;
            switch (db)
            {
                case "SqlServer":
                    ip = new SqlServerDepartment();
                    break;
                case "Access":
                    ip = new AcessDepartment();
                    break;
            }
            return ip;
        }

        public static IUserOperation CreateUserAdvance()
        {
            string className = string.Concat(AssemblyName,".",db,"User");
            return (IUserOperation)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static IDepartmentOperation CreateDepartmentAdvance()
        {
            string className = string.Concat(AssemblyName, ".", db, "Department");
            return (IDepartmentOperation)Assembly.Load(AssemblyName).CreateInstance(className);
        }
    }
}
