using System;
using System.Windows.Forms;
// Zach Tian
// Drue Monterola
// Ms. Bains 6/4/2023
namespace ToDoList
{
    public partial class Form2 : Form
    {
        //Properties
        public string TaskName { get; set; }
        public string DueDate { get; set; }
        public string Priority { get; set; }
        public string Note { get; set; }

        bool[] priorityChanged = { false, false, false, false };
        bool dateChanged = false, noteChanged = false, taskChanged = false;
        int count = 0;

        public Form2()
        {
            InitializeComponent();
            date.MinDate = DateTime.Now;
        }
        public void IncrementProgressBar()  //For Radio Buttons
        {
            if (!priorityChanged[count])    
            {
                priorityChanged[count] = true;
                pgb_completion.Increment(25);
            }
           
        }
        public bool CheckRadioButtons() //To check if they are clicked
        {
            if (rdb_high.Checked || rdb_low.Checked || rdb_med.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string ChangePriority()
        {
            count++;
            if (rdb_high.Checked)
            {
                return "High";
            }
            if (rdb_med.Checked)
            {
                return "Medium";
            }
            else
            {
                return "Low";
            }
        }

        public bool IsControlUsed(bool change)
        {
            if (!change)
            {
                pgb_completion.Increment(25);
                change = true;
            }
            return change;
        }
        public bool UpdateFlag(bool currentFlag)
        {
            if (!currentFlag)
            {
                currentFlag = IsControlUsed(currentFlag);
            }
            return currentFlag;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            pgb_completion.Maximum = 100000;
            pgb_completion.Step = 1;

            if (TaskName != "" && CheckRadioButtons())
            {
                TaskName = txt_task.Text;
                DueDate = date.Value.ToString("yyyy-MM-dd");
                Note = txt_note.Text;
                Priority = ChangePriority();
                this.Close();
            }
            else
            {
                MessageBox.Show("All fields must be filled in!", "Error");
            }
        }
        public bool CheckIfEmpty(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                pgb_completion.Increment(-25);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txt_task_TextChanged(object sender, EventArgs e)
        {
            taskChanged = UpdateFlag(taskChanged);
            taskChanged = CheckIfEmpty(txt_task.Text);
        }

        private void txt_note_TextChanged(object sender, EventArgs e)
        {
            noteChanged = UpdateFlag(noteChanged);
            noteChanged = CheckIfEmpty(txt_note.Text);    
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {
            dateChanged = UpdateFlag(dateChanged);
        }

        private void rdb_low_CheckedChanged(object sender, EventArgs e)
        {
            IncrementProgressBar();
        }

        private void rdb_med_CheckedChanged(object sender, EventArgs e)
        {
            IncrementProgressBar();
        }

        private void rdb_high_CheckedChanged(object sender, EventArgs e)
        {
            IncrementProgressBar();
        }
    }
}
