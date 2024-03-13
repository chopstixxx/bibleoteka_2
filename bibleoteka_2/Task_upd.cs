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
using System.Xml.Linq;

namespace bibleoteka_2
{
    public partial class Task_upd : Form
    {
        int proj_id;
        int id;
        string name;
        string desc;
        string status;
        public Task_upd(int proj_id_, int id_, string name_, string desc_, string status_)
        {
            InitializeComponent();
            proj_id = proj_id_;
            name = name_;
            desc = desc_;
            status = status_;
            id = id_;
        }

        private void Task_upd_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
            dB.Task_upd(proj_id, name, description, comboBox1.SelectedItem.ToString());
            MessageBox.Show("Задача успешно обновлена!");
        }

        private void Task_upd_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Выполнена");
            comboBox1.Items.Add("Не выполнена");

            if (status == "Выполнена")
            {
                comboBox1.SelectedIndex = 0;
            }
            else if (status == "Не выполнена")
            {
                comboBox1.SelectedIndex = 1;
            }
            textBox1.Text = name;
            textBox2.Text = desc;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Task_lists form = new Task_lists(proj_id);
            this.Hide();
            form.Show();
        }
    }
}
