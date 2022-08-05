using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public partial class Task
    {
        public Task(string description, DateTime date)
        {
            this.description = description;
            this.date = date;
        }

        public Task()
        {

        }

        public override string ToString()
        {
            return this.date.ToString() + " - " + this.description;
        }
    }
}
