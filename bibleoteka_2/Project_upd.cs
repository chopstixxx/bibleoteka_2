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
    public partial class Project_upd : Form
    {
        int proj_id;
        string name;
        string desc;
        public Project_upd(int id_, string name_, string desc_)
        {
            InitializeComponent();
            proj_id = id_;
            name = name_;
            desc = desc_;
        }

        private void upd_cl_Click(object sender, EventArgs e)
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
            dB.Project_upd(proj_id, name, description);
            MessageBox.Show("Проект успешно обновлён!");
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void Project_upd_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Project_upd_Load(object sender, EventArgs e)
        {
            textBox1.Text = name;
            textBox2.Text = desc;
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
