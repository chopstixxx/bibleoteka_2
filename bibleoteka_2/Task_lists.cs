using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bibleoteka_2
{
    public partial class Task_lists : Form
    {
        int proj_id;
        public Task_lists(int proj_id_)
        {
            InitializeComponent();
            proj_id = proj_id_;
        }

        private void Task_lists_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            Task_load();

            

        }
        public void Task_load()
        {
            DB dB = new DB();
            DataTable dt = new DataTable();
            dt = dB.Task_load(proj_id);

            if (dt.Rows.Count < 1)
            {
                dataGridView1.Visible = false;
                label2.Visible = true;
                return;
            }
            else
            {
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Visible = false; // это айди
                dataGridView1.Columns[1].Visible = false; // это айди

                dataGridView1.Columns[2].HeaderText = "Название";
                dataGridView1.Columns[3].HeaderText = "Описание";
                dataGridView1.Columns[4].HeaderText = "Статус";
            }


        }
        private void Task_lists_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void project_add_Click(object sender, EventArgs e)
        {
            Task_add form = new Task_add(proj_id);
            this.Hide();
            form.Show();
        }

        private void уадалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.Task_remove((int)dataGridView1.CurrentRow.Cells[0].Value);
            MessageBox.Show("Успешно удалено!");
            Task_load();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task_upd form = new Task_upd(proj_id, (int)dataGridView1.CurrentRow.Cells[1].Value, (string)dataGridView1.CurrentRow.Cells[2].Value, (string)dataGridView1.CurrentRow.Cells[4].Value, (string)dataGridView1.CurrentRow.Cells[4].Value);
            this.Hide();
            form.Show();
        }
    }
}
