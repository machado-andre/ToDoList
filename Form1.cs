using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        PlannerContainer Planner;

        public Form1()
        {
            InitializeComponent();

            Planner = new PlannerContainer();

            (from tasks in Planner.Tasks
             orderby tasks.date
             select tasks).Load();

            tasksBindingSource.DataSource = Planner.Tasks.Local.ToBindingList();

            labelTaskCount.Text = "Tasks: " + Planner.Tasks.Count().ToString();
        }

        private void buttonCreateTask_Click(object sender, EventArgs e)
        {
            if(textBoxDescription.Text == "")
            {
                return;
            }
            DateTime date = datePicker.Value.Date + timePicker.Value.TimeOfDay;
            Task task = new Task(textBoxDescription.Text, date);

            try
            {
                Planner.Tasks.Add(task);
                Planner.SaveChanges();

                tasksBindingSource.DataSource = null;

                Planner.Dispose();
                Planner = new PlannerContainer();

                (from tasks in Planner.Tasks
                 orderby tasks.date
                 select tasks).Load();

                tasksBindingSource.DataSource = Planner.Tasks.Local.ToBindingList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            labelTaskCount.Text = "Tasks: " + Planner.Tasks.Count().ToString();
            textBoxDescription.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'plannerDBDataSet.Tasks' table. You can move, or remove it, as needed.
            this.tasksTableAdapter.Fill(this.plannerDBDataSet.Tasks);

        }

        private void buttonRemoveTask_Click(object sender, EventArgs e)
        {
            if(listBoxTasks.SelectedIndex == -1)
            {
                return;
            }

            Task taskToRemove = (Task)listBoxTasks.SelectedItem;
            
            tasksBindingSource.Remove(listBoxTasks.SelectedIndex);

            Planner.Tasks.Remove(taskToRemove);
            Planner.SaveChanges();

            labelTaskCount.Text = "Tasks: " + Planner.Tasks.Count().ToString();
        }
    }
}
