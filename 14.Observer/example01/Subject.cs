using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
   public delegate void EventHandler();

  public interface Subject
    {
        void Notify();

        string SubjectState { get; set; }
    }

  public  class Boss : Subject
    {
        private string action;

        public event EventHandler Update;

        public string SubjectState
        {
            get => action;
            set => action = value;
        }        

        public void Notify()
        {
            Update();
        }
    }

    public class Secretary : Subject
    {
        private string action;

        public event EventHandler Update;

        public string SubjectState
        {
            get => action;
            set => action = value;
        }

        public void Notify()
        {
            Update();
        }
    }

}
