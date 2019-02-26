using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResposibility
{
    public enum RequestType
    {
        Leave = 1,
        RasieMoney = 2
    }
    public class Request
    {
        public RequestType RequestType { get; set; }

        public string RequestContent { get; set; }

        public int RequestNumber { get; set; }
    }

    public abstract class Manager
    {
        protected string name;

        protected Manager superior;

        public Manager(string name)
        {
            this.name = name;
        }

        public void SetSuperior(Manager superior)
        {
            this.superior = superior;
        }

        public abstract void HandlerRequest(Request request);
    }

    public class CommonManager : Manager
    {
        public CommonManager(string name) : base(name)
        {
        }

        public override void HandlerRequest(Request request)
        {
            if(request.RequestType==RequestType.Leave&&request.RequestNumber<=1)
            {
                Console.WriteLine($"{request.RequestContent},{this.GetType().Name}: {name} Approved {request.RequestNumber} day's Leave.");
            }
            else if(superior!=null)
            {
                superior.HandlerRequest(request);
            }
        }
    }

    public class MajorManager : Manager
    {
        public MajorManager(string name) : base(name)
        {
        }

        public override void HandlerRequest(Request request)
        {
            if (request.RequestType == RequestType.Leave && request.RequestNumber <= 3)
            {
                Console.WriteLine($"{request.RequestContent},{this.GetType().Name}: {name} Approved {request.RequestNumber} day's {request.RequestType}.");
            }
            else if(request.RequestType == RequestType.RasieMoney && request.RequestNumber <= 1000)
            {
                Console.WriteLine($"{request.RequestContent},{this.GetType().Name}: {name} Approved {request.RequestNumber} RMB {request.RequestType}.");
            }
            else if (superior != null)
            {
                superior.HandlerRequest(request);
            }
        }
    }

    public class Boss : Manager
    {
        public Boss(string name) : base(name)
        {
        }

        public override void HandlerRequest(Request request)
        {
            if (request.RequestType == RequestType.Leave && request.RequestNumber <= 5)
            {
                Console.WriteLine($"{request.RequestContent},{this.GetType().Name}: {name} Approved {request.RequestNumber} day's {request.RequestType}.");
            }
            else if (request.RequestType == RequestType.RasieMoney && request.RequestNumber <= 2000)
            {
                Console.WriteLine($"{request.RequestContent},{this.GetType().Name}: {name} Approved {request.RequestNumber} RMB {request.RequestType}.");
            }
            else if (superior != null)
            {
                superior.HandlerRequest(request);
            }
            else
            {
                Console.WriteLine("Request Can not Passed! Forget it!");
            }
        }
    }
}
