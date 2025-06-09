namespace ToDoList
{
    partial class Form2
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
            this.lbl_new_event = new System.Windows.Forms.Label();
            this.txt_task = new System.Windows.Forms.TextBox();
            this.txt_note = new System.Windows.Forms.TextBox();
            this.lbl_task = new System.Windows.Forms.Label();
            this.lbl_due = new System.Windows.Forms.Label();
            this.lbl_priority = new System.Windows.Forms.Label();
            this.lbl_note = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.gpb_data = new System.Windows.Forms.GroupBox();
            this.rdb_low = new System.Windows.Forms.RadioButton();
            this.rdb_high = new System.Windows.Forms.RadioButton();
            this.rdb_med = new System.Windows.Forms.RadioButton();
            this.pgb_completion = new System.Windows.Forms.ProgressBar();
            this.lbl_message = new System.Windows.Forms.Label();
            this.gpb_data.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_new_event
            // 
            this.lbl_new_event.AutoSize = true;
            this.lbl_new_event.BackColor = System.Drawing.Color.AliceBlue;
            this.lbl_new_event.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_new_event.Location = new System.Drawing.Point(33, 39);
            this.lbl_new_event.Name = "lbl_new_event";
            this.lbl_new_event.Size = new System.Drawing.Size(222, 42);
            this.lbl_new_event.TabIndex = 0;
            this.lbl_new_event.Text = "Add A Task";
            // 
            // txt_task
            // 
            this.txt_task.Location = new System.Drawing.Point(142, 47);
            this.txt_task.Name = "txt_task";
            this.txt_task.Size = new System.Drawing.Size(323, 26);
            this.txt_task.TabIndex = 2;
            this.txt_task.TextChanged += new System.EventHandler(this.txt_task_TextChanged);
            // 
            // txt_note
            // 
            this.txt_note.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_note.Location = new System.Drawing.Point(142, 158);
            this.txt_note.Multiline = true;
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(323, 71);
            this.txt_note.TabIndex = 4;
            this.txt_note.TextChanged += new System.EventHandler(this.txt_note_TextChanged);
            // 
            // lbl_task
            // 
            this.lbl_task.AutoSize = true;
            this.lbl_task.Location = new System.Drawing.Point(16, 53);
            this.lbl_task.Name = "lbl_task";
            this.lbl_task.Size = new System.Drawing.Size(103, 20);
            this.lbl_task.TabIndex = 5;
            this.lbl_task.Text = "Task Name:";
            // 
            // lbl_due
            // 
            this.lbl_due.AutoSize = true;
            this.lbl_due.Location = new System.Drawing.Point(16, 88);
            this.lbl_due.Name = "lbl_due";
            this.lbl_due.Size = new System.Drawing.Size(88, 20);
            this.lbl_due.TabIndex = 6;
            this.lbl_due.Text = "Due date:";
            // 
            // lbl_priority
            // 
            this.lbl_priority.AutoSize = true;
            this.lbl_priority.Location = new System.Drawing.Point(16, 125);
            this.lbl_priority.Name = "lbl_priority";
            this.lbl_priority.Size = new System.Drawing.Size(69, 20);
            this.lbl_priority.TabIndex = 7;
            this.lbl_priority.Text = "Priority:";
            // 
            // lbl_note
            // 
            this.lbl_note.AutoSize = true;
            this.lbl_note.Location = new System.Drawing.Point(16, 164);
            this.lbl_note.Name = "lbl_note";
            this.lbl_note.Size = new System.Drawing.Size(52, 20);
            this.lbl_note.TabIndex = 8;
            this.lbl_note.Text = "Note:";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(30, 400);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(137, 54);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // date
            // 
            this.date.ImeMode = System.Windows.Forms.ImeMode.On;
            this.date.Location = new System.Drawing.Point(142, 83);
            this.date.MinDate = new System.DateTime(2025, 6, 6, 13, 32, 12, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(323, 26);
            this.date.TabIndex = 11;
            this.date.Value = new System.DateTime(2025, 6, 6, 13, 32, 12, 0);
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // gpb_data
            // 
            this.gpb_data.BackColor = System.Drawing.Color.AliceBlue;
            this.gpb_data.Controls.Add(this.rdb_low);
            this.gpb_data.Controls.Add(this.rdb_high);
            this.gpb_data.Controls.Add(this.lbl_task);
            this.gpb_data.Controls.Add(this.txt_note);
            this.gpb_data.Controls.Add(this.rdb_med);
            this.gpb_data.Controls.Add(this.lbl_note);
            this.gpb_data.Controls.Add(this.date);
            this.gpb_data.Controls.Add(this.txt_task);
            this.gpb_data.Controls.Add(this.lbl_due);
            this.gpb_data.Controls.Add(this.lbl_priority);
            this.gpb_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_data.Location = new System.Drawing.Point(30, 84);
            this.gpb_data.Name = "gpb_data";
            this.gpb_data.Size = new System.Drawing.Size(598, 251);
            this.gpb_data.TabIndex = 12;
            this.gpb_data.TabStop = false;
            this.gpb_data.Text = "Add data";
            // 
            // rdb_low
            // 
            this.rdb_low.AutoSize = true;
            this.rdb_low.Location = new System.Drawing.Point(142, 121);
            this.rdb_low.Name = "rdb_low";
            this.rdb_low.Size = new System.Drawing.Size(59, 24);
            this.rdb_low.TabIndex = 15;
            this.rdb_low.TabStop = true;
            this.rdb_low.Text = "Low";
            this.rdb_low.UseVisualStyleBackColor = true;
            this.rdb_low.CheckedChanged += new System.EventHandler(this.rdb_low_CheckedChanged);
            // 
            // rdb_high
            // 
            this.rdb_high.AutoSize = true;
            this.rdb_high.Location = new System.Drawing.Point(302, 121);
            this.rdb_high.Name = "rdb_high";
            this.rdb_high.Size = new System.Drawing.Size(64, 24);
            this.rdb_high.TabIndex = 14;
            this.rdb_high.TabStop = true;
            this.rdb_high.Text = "High";
            this.rdb_high.UseVisualStyleBackColor = true;
            this.rdb_high.CheckedChanged += new System.EventHandler(this.rdb_high_CheckedChanged);
            // 
            // rdb_med
            // 
            this.rdb_med.AutoSize = true;
            this.rdb_med.Location = new System.Drawing.Point(207, 121);
            this.rdb_med.Name = "rdb_med";
            this.rdb_med.Size = new System.Drawing.Size(89, 24);
            this.rdb_med.TabIndex = 13;
            this.rdb_med.TabStop = true;
            this.rdb_med.Text = "Medium";
            this.rdb_med.UseVisualStyleBackColor = true;
            this.rdb_med.CheckedChanged += new System.EventHandler(this.rdb_med_CheckedChanged);
            // 
            // pgb_completion
            // 
            this.pgb_completion.Location = new System.Drawing.Point(313, 417);
            this.pgb_completion.Name = "pgb_completion";
            this.pgb_completion.Size = new System.Drawing.Size(253, 22);
            this.pgb_completion.TabIndex = 14;
            // 
            // lbl_message
            // 
            this.lbl_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_message.Location = new System.Drawing.Point(195, 400);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(112, 54);
            this.lbl_message.TabIndex = 15;
            this.lbl_message.Text = "Completed ";
            this.lbl_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(727, 479);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.pgb_completion);
            this.Controls.Add(this.gpb_data);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_new_event);
            this.Name = "Form2";
            this.Text = "Add new Task";
            this.gpb_data.ResumeLayout(false);
            this.gpb_data.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_new_event;
        private System.Windows.Forms.TextBox txt_task;
        private System.Windows.Forms.TextBox txt_note;
        private System.Windows.Forms.Label lbl_task;
        private System.Windows.Forms.Label lbl_due;
        private System.Windows.Forms.Label lbl_priority;
        private System.Windows.Forms.Label lbl_note;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.GroupBox gpb_data;
        private System.Windows.Forms.RadioButton rdb_med;
        private System.Windows.Forms.ProgressBar pgb_completion;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.RadioButton rdb_low;
        private System.Windows.Forms.RadioButton rdb_high;
    }
}