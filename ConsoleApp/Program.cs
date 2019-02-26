using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using SimpleFactory;
using Decorator;
using Strategy;
using Proxy;
using FactoryMethod;
using Prototype;
using TemplateMethod;
using Facade;
using StatePattern;
using Builder;
using AbstractFactory;
using Visitor;
using ObserverPattern;
using Adapter;
using MenentoPattern;
using CompositePattern;
using Flyweight;
using Mediator;
using ChainOfResposibility;
using Command;
using Singleton;
using Iterator;
using Bridge;


namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.Simple Factory

            //Console.WriteLine("******Welcome to Calculator*****");
            //Console.Write("Please input first number：");
            //double numberA = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Please input Operator：+ - * /");
            //string operate = Console.ReadLine();

            //Console.Write("Please input second number：");
            //double numberB = Convert.ToDouble(Console.ReadLine());

            //var operation = OperationFactory.CreateOperation(operate);
            //operation.NumberA = numberA;
            //operation.NumberB = numberB;
            //Console.WriteLine(operation.GetResult());

            #endregion

            #region 2.Strategy

            /* Version 01 */
            //Context context;

            //context = new Context(new ConcreteStrategyA());
            //context.ContextInterface();

            //context = new Context(new ConcreteStrategyB());
            //context.ContextInterface();

            //context = new Context(new ConcreteStrategyC());
            //context.ContextInterface();

            /* Version 02 */
            //var contextAdvance = new ContextAdvance("ConcreteStrategyA");
            //contextAdvance.Excute();

            #endregion

            #region 3.SRP(Simple Responsibility Priciple)

            #endregion

            #region 06.Decorator

            //ConcreteComponent c = new ConcreteComponent();
            //ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            //ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            //d1.SetComponent(c);
            //d2.SetComponent(d1);
            //d2.Operation();

            #endregion

            #region 07.Proxy

            //Proxy.Proxy proxy = new Proxy.Proxy();
            //proxy.Request();
            #endregion

            #region 08.Factory Method

            //IFactory factory = new ProductAFactory();

            //Product product = factory.CreateOperation();

            //product.Operation();

            #endregion

            #region 09.Prototype

            //Resume resume01 = new Resume("daniao");
            //resume01.SetPersonalInfo("Male", "18");
            //resume01.SetWorkExperience("2014-2015", "tengxungongsi");

            //Resume resume02 = (Resume)resume01.Clone();
            //resume02.SetPersonalInfo("Male", "18");
            //resume02.SetWorkExperience("2015-2016", "alibaba");

            //Resume resume03 = (Resume)resume01.Clone();
            //resume03.SetPersonalInfo("Male", "18");
            //resume03.SetWorkExperience("2017-2018", "huawei");

            //resume01.Display();
            //resume02.Display();
            //resume03.Display();

            #endregion

            #region 13.Builder



            #endregion

            #region 14.Observer

            //ObserverPattern.Boss huhansan = new ObserverPattern.Boss();

            //StockObserver tongshi01 = new StockObserver(huhansan, "001");
            //NBAObserver tongshi02 = new NBAObserver(huhansan, "002");

            //huhansan.Update += tongshi01.ClostStockMarket;
            //huhansan.Update += tongshi02.ClostNBADirectingSeeding;


            //huhansan.SubjectState = "I am huhansan come back";
            //huhansan.Notify();

            //SpecificObserverA observerA = new SpecificObserverA();
            //SpecificObserverB observerB = new SpecificObserverB();

            //ConcreteSubjectA subjectA = new ConcreteSubjectA();

            //subjectA.Update += observerA.ActionA;
            //subjectA.Update += observerB.ActionB;

            //subjectA.Notify();
            #endregion

            #region 15.Abstract Factory

            //AbstractFactory.User user = new AbstractFactory.User();
            // // IFactory factory = new AccessFactory();

            // IUserOperation iu = DataAccess.CerateUser();
            // iu.Insert(user);
            // iu.GetUser(1);

            // Console.WriteLine("\r\n***********************************");

            // Department dp = new Department();
            // IDepartmentOperation ip = DataAccess.CerateDepartment();
            // ip.Insert(dp);
            // ip.GetDep(1);
            #endregion

            #region 16.State

            //WorkAdvance emergencyProjects = new WorkAdvance();
            //emergencyProjects.Hour = 22;
            //emergencyProjects.WriteProgram();

            #endregion

            #region 17.Adapter

            //Player kuli = new Forwards("kuli");
            //kuli.Attack();
            //kuli.Defence();

            //Player yaoming = new Translate("yaoming");
            //yaoming.Attack();
            //yaoming.Defence();
            #endregion

            #region 18.Memento

            //Originator o = new Originator();
            //o.State = "On";
            //o.Show();

            //Caretaker c = new Caretaker();
            //c.Memento = o.CreateMemento();

            //o.State = "Off";
            //o.Show();

            //o.SetMemento(c.Memento);
            //o.Show();

            #endregion

            #region 19.Composite

            /*
           * 组合模式（Composite）,将对象组合成树形结构以表示 ‘部分-整体’的层次结构。组合模式是的用户对单个对象和组合对象的使用具有一致性。
           */

            //Console.WriteLine(new string('-', 10));
            //Composite root = new Composite("root");
            //root.Add(new Leaf("Leaf A"));
            //root.Add(new Leaf("Leaf B"));

            //Composite comp = new Composite("Composite X");
            //comp.Add(new Leaf("Leaf XA"));
            //comp.Add(new Leaf("Leaf XB"));
            //root.Add(comp);

            //Composite comp2 = new Composite("Composite XY");
            //comp2.Add(new Leaf("Leaf XYA"));
            //comp2.Add(new Leaf("Leaf XYB"));
            //root.Add(comp2);

            //root.Add(new Leaf("Leaf C"));

            //root.Display(1);

            #endregion

            #region 20.Iterator

            //ConcreteAggregate aggregate = new ConcreteAggregate();
            //aggregate[0] = "000";
            //aggregate[1] = "111";
            //aggregate[2] = "222";
            //aggregate[3] = "333";
            //aggregate[4] = "444";

            //Iterator.Iterator iterator = new ConcreteIterator(aggregate);
            //while (!iterator.IsDone())
            //{
            //    Console.WriteLine($"{iterator.CurrentItem()} Please Buy Ticket");
            //    iterator.Next();
            //}

            //Console.WriteLine("--------------------------");
            //Iterator.Iterator iterator02 = new ConcreteIteratorDesc(aggregate);
            //object item02 = iterator.First();
            //while (!iterator02.IsDone())
            //{
            //    Console.WriteLine($"{iterator02.CurrentItem()} Please Buy Ticket");
            //    iterator02.Next();
            //}

            //// .Net的迭代器的实现
            //List<string> list = new List<string>()
            //{
            //    "000",
            //    "111",
            //    "222",
            //    "333",
            //    "444"
            //};
            //Console.WriteLine("--------------------------");
            //foreach (var item in list)
            //{
            //    Console.WriteLine($"{item} Please Buy Ticket");
            //}
            #endregion

            #region 21.Singleton

            /*
             * 单例模式（Singleton）:保证一个类只有一个实例，并提供一个访问它的全局访问点。
             */


            // /* Version 01 懒汉式 */
            // Singleton.Singleton instance = Singleton.Singleton.GetInstance();

            // Singleton.Singleton instance2 = Singleton.Singleton.GetInstance();

            // if (instance == instance2)
            // {
            //     Console.WriteLine("Same Instance");
            // }
            // else
            // {
            //     Console.WriteLine("Not Same Instance");
            // }

            ///* Version 02 饿汉式 */

            // SingletonAnotherWay instance03 = SingletonAnotherWay.Instance;

            // SingletonAnotherWay instance04 = SingletonAnotherWay.Instance;

            // if (instance03 == instance04)
            // {
            //     Console.WriteLine("Same Instance Another way");
            // }
            // else
            // {
            //     Console.WriteLine("Not Same Instance Another way");
            // }

            #endregion

            #region 22.Bridge

            //Abstraction abstraction = new ConcreteAbstraction();

            //abstraction.SetImplementor(new ConcreteImplementorA());

            //abstraction.Operation();

            //Abstraction abstraction2 = new ConcreteAbstraction();

            //abstraction2.SetImplementor(new ConcreteImplementorB());

            //abstraction2.Operation();

            #endregion

            #region 23.Command

            /*
             * 命令模式（Command），将一个请求封装为一个对象，从而使你可用不同的请求对客户进行参数化；对请求排队或记录请求日志，以及支持可撤销的操作。
             */
            /* Version 01 */
            //Receiver receiver = new Receiver();
            //Invoker invokerMan = new Invoker();
            //Command.Command command = new ConcreteCommandA(receiver);
            //Command.Command commandB = new ConcreteCommandB(receiver);
            //invokerMan.SetCommand(command);
            //invokerMan.ExecuteCommand();
            //invokerMan.SetCommand(commandB);
            //invokerMan.ExecuteCommand();

            /* Version 02*/
            //Waiter waiter = new Waiter();
            //Barbecuer barbecuer = new Barbecuer();
            //CommandInstance command = new MuttonCommand(barbecuer) { Amount = 10 };
            //CommandInstance command02 = new ChickenCommand(barbecuer) { Amount = 5 };
            //waiter.SetCommand(command);
            //waiter.SetCommand(command02);

            //waiter.ExecuteBarbecue();

            #endregion

            #region 24.Chain Of Resposibility

            /* Version 01 */
            //Handler h1 = new ConcreteHandler1();
            //Handler h2 = new ConcreteHandler2();
            //Handler h3 = new ConcreteHandler3();

            //h1.SetSuccessor(h2);
            //h2.SetSuccessor(h3);

            //int[] requests = { 2, 5, 15, 25, 35 };
            //foreach (var item in requests)
            //{
            //    h1.HandlerRequest(item);
            //}

            /* version 02 */
            //Request request01 = new Request() { RequestContent = "I am leave for something", RequestType = RequestType.Leave, RequestNumber = 1 };
            //Request request02 = new Request() { RequestContent = "I am leave for something", RequestType = RequestType.Leave, RequestNumber = 4 };
            //Request request03 = new Request() { RequestContent = "I am leave for something", RequestType = RequestType.Leave, RequestNumber = 6 };

            //Request request04 = new Request() { RequestContent = "I want raise money", RequestType = RequestType.RasieMoney, RequestNumber = 700 };
            //Request request05 = new Request() { RequestContent = "I want raise money", RequestType = RequestType.RasieMoney, RequestNumber = 1200 };
            //Request request06 = new Request() { RequestContent = "I want raise money", RequestType = RequestType.RasieMoney, RequestNumber = 2000 };
            //Request request07 = new Request() { RequestContent = "I want raise money", RequestType = RequestType.RasieMoney, RequestNumber = 2500 };

            //CommonManager manager = new CommonManager("XiaoTa");
            //MajorManager majorManager = new MajorManager("XiaoYou");
            //Boss boss = new Boss("XiaoXu");
            //manager.SetSuperior(majorManager);
            //majorManager.SetSuperior(boss);

            //manager.HandlerRequest(request01);
            //manager.HandlerRequest(request02);
            //manager.HandlerRequest(request03);
            //manager.HandlerRequest(request04);
            //manager.HandlerRequest(request05);
            //manager.HandlerRequest(request06);
            //manager.HandlerRequest(request07);

            #endregion

            #region 25.Mediator
            /*
             * 中介者模式优缺点
             * 优点：1.Mediator的出现减少了各个Colleague的耦合，使得可以独立地改变和复用各个Colleague类和Mediator.
             *       2.由于把对象如何协作进行了抽象，将中介作为一个独立的概念并将其封装在一个对象中，这样关注的对象就从对象各自本身的行为转移到它们之间的交互上来，也就是站在一个更宏观的角度去看待系统。
             * 缺点：由于ConcreteMediator控制了集中化，于是就把交互复杂性变为了中介者的复杂性，这就使得中介者会变得比任何一个ConcreteColleague都复杂。
             * 应用：中介者模式一般应用与一组对象以定义良好但是复杂的方式进行通信的场合，比如窗体Form或web页面aspx,以及想定制一个分布在多个类中的行为，而又不想生成太多子类的场合
             */

            //ConcreteMediator mediator = new ConcreteMediator();

            //ConcreteColleague1 colleague1 = new ConcreteColleague1(mediator);
            //ConcreteColleague2 colleague2 = new ConcreteColleague2(mediator);

            //mediator.ConcreteColleague1 = colleague1;
            //mediator.ConcreteColleague2 = colleague2;

            //colleague1.Send("Have Eat?");
            //colleague2.Send("No,are you ready treat me?");



            #endregion

            #region 26.Flyweight

            /*
             * 如果一个应用程序使用了大量的对象，而大量的这些对象造成了很大的存储开销时就应该考虑使用；还有就是对象的大多数状态可以外部状态，
             * 如果删除对象的外部状态，那么可以用相对较少的共享对象取代很多组对象，此时可以考虑使用享元模式。
             */
            //WebSiteFactory webSiteFactory = new WebSiteFactory();

            //WebSite fx = webSiteFactory.GetWebSite(1);
            //WebSite f02 = webSiteFactory.GetWebSite(1);
            //WebSite f03 = webSiteFactory.GetWebSite(1);

            //WebSite fy = webSiteFactory.GetWebSite(3);
            //WebSite f04 = webSiteFactory.GetWebSite(3);
            //WebSite f05 = webSiteFactory.GetWebSite(3);

            //fx.Use(new User("user001", "password001"));
            //f02.Use(new User("user002", "password002"));
            //f03.Use(new User("user003", "password003"));
            //fy.Use(new User("user004", "password004"));
            //f04.Use(new User("user005", "password005"));
            //f05.Use(new User("user006", "password006"));

            //Console.WriteLine("WebSite Total Count:" + webSiteFactory.GetWebSiteCount());

            #endregion

            #region 28.Visitor

            /*
             * 访问者模式（Vistor）,表示一个作用于某对象结构中的各元素的操作。它使你可以在不改变各元素的前提下定义作用于这些元素的新操作。
             */

            /* Version 01 */
            //IList<Person> persons = new List<Person>();

            //persons.Add(new Man() { Action = EAction.Success });
            //persons.Add(new Man() { Action = EAction.Failed });
            //persons.Add(new Man() { Action = EAction.FallInLove });
            //persons.Add(new Woman() { Action = EAction.Success });
            //persons.Add(new Woman() { Action = EAction.Failed });
            //persons.Add(new Woman() { Action = EAction.FallInLove });

            //foreach (var item in persons)
            //{
            //    item.GetConclusion();
            //}

            /* Version 02 */
            //ObjectStructure o = new ObjectStructure();
            //o.Attach(new ManAdvance());
            //o.Attach(new WomanAdvance());

            //Success s = new Success();
            //o.Display(s);

            //Failed f = new Failed();
            //o.Display(f);

            //FallInLove fil = new FallInLove();
            //o.Display(fil);

            //Marriage m = new Marriage();
            //o.Display(m);

            //ObjectStructureAdvance oAdvance = new ObjectStructureAdvance();
            //oAdvance.Attach(new ConcreteElementA());
            //oAdvance.Attach(new ConcreteElementB());

            //ConcreteVisitor1 visitor1 = new ConcreteVisitor1();
            //ConcreteVisitor2 visitor2 = new ConcreteVisitor2();

            //oAdvance.Accept(visitor1);
            //oAdvance.Accept(visitor2);


            #endregion

            Console.ReadLine();
        }
    }
}
