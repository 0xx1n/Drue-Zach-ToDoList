using System;
using System.Windows.Forms;
// Zach Tian
// Drue Monterola
// Ms. Bains 6/4/2023
namespace ToDoList
{
    public partial class Form1 : Form
    {
        int count = -1;

        public Form1()
        {
            InitializeComponent();
            
        }

        enum Filter
        {
            //Priority Levels
            Low = 0,
            Medium,
            High,
            All
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            count++;
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
            table_list.Rows.Add(false, frm2.TaskName, frm2.DueDate, frm2.Priority, frm2.Note);
            table_list.Rows[count].Cells[0].ReadOnly = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (count >= 0 && !table_list.Rows[count].IsNewRow)
            {
                if (table_list.Rows[count] != null)
                {
                    table_list.Rows.RemoveAt(count);
                    count--;
                }
            }
        }

        private void mnu_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnu_clear_Click(object sender, EventArgs e)
        {
            table_list.Rows.Clear();
        }
        private void clearAllCheckedTasksToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            table_list.EndEdit();
            table_list.CurrentCell = null;

            for (int i = table_list.Rows.Count - 1; i >= 0; i--)
            {
                var row = table_list.Rows[i];
                if (row.IsNewRow) continue;

                var value = row.Cells[0].Value;
                if (value != null && (bool)value)
                {
                    table_list.Rows.RemoveAt(i);
                    count--;
                }
            }
        }
        private void cbx_priority_SelectedIndexChanged(object sender, EventArgs e)
        {
            table_list.AllowUserToAddRows = false;
            string selectedPriority = "";

            switch (cbx_priority.SelectedIndex)
            {
                case (int)Filter.Low:
                    selectedPriority = "Low";
                    break;

                case (int)Filter.Medium:
                    selectedPriority = "Medium";
                    break;

                case (int)Filter.High:
                    selectedPriority = "High";
                    break;

                case (int)Filter.All:
                    selectedPriority = "All";
                    break;
            }

            foreach (DataGridViewRow row in table_list.Rows)
            {
                if (row.Cells[3].Value != null && row.Cells[3].Value.ToString() == selectedPriority)
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                    if (selectedPriority == "All")
                    {
                        row.Visible = true;
                    }
                }
            }
            table_list.CurrentCell = null;
        }
    }
}