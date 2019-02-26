using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
   public abstract class CommandInstance
    {
        protected Barbecuer barbecuer;

        public CommandInstance(Barbecuer barbecuer)
        {
            this.barbecuer = barbecuer;
        }

        public int Amount { get; set; }

        public abstract void ExecuteCommand(int amount);
    }

    public class MuttonCommand : CommandInstance
    {
        public MuttonCommand(Barbecuer barbecuer) : base(barbecuer)
        {
        }

        public override void ExecuteCommand(int amount)
        {
            this.Amount = amount;
            barbecuer.BarbecueMutton(amount);
        }
    }

    public class ChickenCommand : CommandInstance
    {
        public ChickenCommand(Barbecuer barbecuer) : base(barbecuer)
        {
        }

        public override void ExecuteCommand(int amount)
        {
            this.Amount = amount;
            barbecuer.BarbecueChicken(amount);
        }
    }
    public class Barbecuer
    {
        public void BarbecueMutton(int amount)
        {
            Console.WriteLine($"Barbecue Mutton,Amount {amount}");
        }
        public void BarbecueChicken(int amount)
        {
            Console.WriteLine($"Barbecue Chicken,Amount {amount}");
        }
    }

    public class Waiter
    {
        private IList<CommandInstance> commands = new List<CommandInstance>();

        public void SetCommand(CommandInstance command)
        {
            commands.Add(command);
        }

        public void ExecuteBarbecue()
        {
            foreach (var item in commands)
            {
                item.ExecuteCommand(item.Amount);
            }
        }
    }
}
