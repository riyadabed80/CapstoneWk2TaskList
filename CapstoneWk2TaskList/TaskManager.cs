using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneWk2TaskList
{
    class TaskManager
    {
        #region DataMembers
        private string name;
        private string description;
        private DateTime duedate;
        private bool complete;
     
        #endregion

        #region Properties
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public string Description
        {
            set
            {
                description = value;
            }
            get
            {
                return description;
            }
        }
        public DateTime DueDate
        {
            set
            {
                duedate = value;
            }
            get
            {
                return duedate;
            }
        }
        public bool Complete
        {
            set
            {
                complete = value;
            }
            get
            {
                return complete;
            }
        }
        #endregion

        #region Constructors
        public TaskManager()
        {

        }

        public TaskManager(string n, string d, DateTime due)
        {
            Name = n;
            Description = d;
            DueDate = due;
            Complete = false;
        }




        #endregion

        #region Methods
        public void PrintInfo()
        {
            Console.Write($" Team Member: " + Name + " Description: " + Description + " Due Date: " + DueDate + " Completion: " + Complete);
        }

        #endregion
    

    }
}
