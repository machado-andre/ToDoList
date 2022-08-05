namespace ToDoList
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonCreateTask = new System.Windows.Forms.Button();
            this.labelTask = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plannerDBDataSet = new ToDoList.PlannerDBDataSet();
            this.tasksTableAdapter = new ToDoList.PlannerDBDataSetTableAdapters.TasksTableAdapter();
            this.buttonRemoveTask = new System.Windows.Forms.Button();
            this.labelTaskCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plannerDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreateTask
            // 
            this.buttonCreateTask.Location = new System.Drawing.Point(12, 318);
            this.buttonCreateTask.Name = "buttonCreateTask";
            this.buttonCreateTask.Size = new System.Drawing.Size(150, 23);
            this.buttonCreateTask.TabIndex = 0;
            this.buttonCreateTask.Text = "Create Task";
            this.buttonCreateTask.UseVisualStyleBackColor = true;
            this.buttonCreateTask.Click += new System.EventHandler(this.buttonCreateTask_Click);
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Location = new System.Drawing.Point(12, 9);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(90, 13);
            this.labelTask.TabIndex = 1;
            this.labelTask.Text = "Task Description:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(12, 85);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(33, 13);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Date:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(12, 25);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(260, 52);
            this.textBoxDescription.TabIndex = 3;
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(12, 101);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(128, 20);
            this.datePicker.TabIndex = 4;
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(146, 101);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(126, 20);
            this.timePicker.TabIndex = 5;
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.DataSource = this.tasksBindingSource;
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.Location = new System.Drawing.Point(278, 25);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(300, 316);
            this.listBoxTasks.TabIndex = 6;
            // 
            // tasksBindingSource
            // 
            this.tasksBindingSource.DataMember = "Tasks";
            this.tasksBindingSource.DataSource = this.plannerDBDataSet;
            // 
            // plannerDBDataSet
            // 
            this.plannerDBDataSet.DataSetName = "PlannerDBDataSet";
            this.plannerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tasksTableAdapter
            // 
            this.tasksTableAdapter.ClearBeforeFill = true;
            // 
            // buttonRemoveTask
            // 
            this.buttonRemoveTask.BackColor = System.Drawing.Color.Maroon;
            this.buttonRemoveTask.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonRemoveTask.Location = new System.Drawing.Point(172, 318);
            this.buttonRemoveTask.Name = "buttonRemoveTask";
            this.buttonRemoveTask.Size = new System.Drawing.Size(100, 23);
            this.buttonRemoveTask.TabIndex = 7;
            this.buttonRemoveTask.Text = "Mark as Done";
            this.buttonRemoveTask.UseVisualStyleBackColor = false;
            this.buttonRemoveTask.Click += new System.EventHandler(this.buttonRemoveTask_Click);
            // 
            // labelTaskCount
            // 
            this.labelTaskCount.AutoSize = true;
            this.labelTaskCount.Location = new System.Drawing.Point(275, 350);
            this.labelTaskCount.Name = "labelTaskCount";
            this.labelTaskCount.Size = new System.Drawing.Size(39, 13);
            this.labelTaskCount.TabIndex = 8;
            this.labelTaskCount.Text = "Tasks:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 372);
            this.Controls.Add(this.labelTaskCount);
            this.Controls.Add(this.buttonRemoveTask);
            this.Controls.Add(this.listBoxTasks);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelTask);
            this.Controls.Add(this.buttonCreateTask);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plannerDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateTask;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.ListBox listBoxTasks;
        private PlannerDBDataSet plannerDBDataSet;
        private System.Windows.Forms.BindingSource tasksBindingSource;
        private PlannerDBDataSetTableAdapters.TasksTableAdapter tasksTableAdapter;
        private System.Windows.Forms.Button buttonRemoveTask;
        private System.Windows.Forms.Label labelTaskCount;
    }
}

