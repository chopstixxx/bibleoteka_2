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
    public partial class Task_add : Form
    {
        int proj_id;
        public Task_add(int proj_id_)
        {
            InitializeComponent();
            proj_id = proj_id_;
        }

        private void add_cl_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string description = textBox2.Text;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Поле с именем пустое!");
                return;
            }
            if (string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Поле с описанием пустое!");
                return;
            }
            DB dB = new DB();
            dB.Task_add(proj_id, name, description);
            MessageBox.Show("Задача успешно добавлена!");

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Task_lists form = new Task_lists(proj_id);
            this.Hide();
            form.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
