using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface IUserOperation
    {
        void Insert(User user);

        User GetUser(int id);
    }
    public class SqlServerUser : IUserOperation
    {
        public User GetUser(int id)
        {
            Console.WriteLine("Get a sql Server User");
            return null; 
        }

        public void Insert(User user)
        {
            Console.WriteLine("Inser a sql Server User");
        }
    }
    public class AccessUser : IUserOperation
    {
        public User GetUser(int id)
        {
            Console.WriteLine("Get a Access User");
            return null;
        }

        public void Insert(User user)
        {
            Console.WriteLine("Inser a Access User");
        }
    }

    public interface IDepartmentOperation
    {
        void Insert(Department department);

        Department GetDep(int id);
    }
    public class SqlServerDepartment : IDepartmentOperation
    {
        public Department GetDep(int id)
        {
            Console.WriteLine("Get a sql Server Department");
            return null;
        }

        public void Insert(Department department)
        {
            Console.WriteLine("Inser a sql server Department");
        }
    }
    public class AcessDepartment : IDepartmentOperation
    {
        public Department GetDep(int id)
        {
            Console.WriteLine("Get a Access Department");
            return null;
        }

        public void Insert(Department department)
        {
            Console.WriteLine("Inser a Access Department");
        }
    }

}
