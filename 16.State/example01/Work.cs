using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
   public class Work
    {
        #region Field

        /// <summary>
        /// Hour
        /// </summary>
        public int Hour { get; set; }

        /// <summary>
        /// Is Task Finished
        /// </summary>
        public bool TaskFinished { get; set; }

        #endregion

        #region Method

        public void WriteProgram()
        {
            if(Hour<12)
            {
                Console.WriteLine($"Current time:{Hour},I have great power work morning");
            }
            else if(Hour<13)
            {
                Console.WriteLine($"Current time:{Hour},I have just eat lunch, i feel tired");
            }
            else if(Hour<17)
            {
                Console.WriteLine($"Current time:{Hour},it's vert good work afternoon");
            }
            else
            {
                if(TaskFinished)
                {
                    Console.WriteLine($"Current time:{Hour},Task Finished , i must go home now");
                }
                else
                {
                    if(Hour<21)
                    {
                        Console.WriteLine($"Current time:{Hour},I am very tired work overtime");
                    }
                    else
                    {
                        Console.WriteLine($"Current time:{Hour},i can not work anymore");
                    }
                }
            }
        }
        #endregion

    }

    public class WorkAdvance
    {
        /// <summary>
        /// Hour
        /// </summary>
        public int Hour { get; set; }

        /// <summary>
        /// Is Task Finished
        /// </summary>
        public bool TaskFinished { get; set; }


        private StateAdance currentState;        

        public WorkAdvance()
        {
            currentState = new ForeNoonState();
        }

        public void SetState(StateAdance s)
        {
            currentState = s;
        }

        public void WriteProgram()
        {
            currentState.WriteProgram(this);
        }
    }
}
