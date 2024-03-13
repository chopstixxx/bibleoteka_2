using ClassLibrary;
namespace bibleoteka_2
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            Load_projects();

            dataGridView1.Columns[0].Visible = false; // это айди


            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Описание";

        }
        public void Load_projects()
        {

            DB db = new DB();
            dataGridView1.DataSource = db.Goods_load();

        }
        private void project_add_Click(object sender, EventArgs e)
        {

            Project_add form = new Project_add();
            this.Hide();
            form.Show();
        }

        private void удалитьПроектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.Project_remove((int)dataGridView1.CurrentRow.Cells[0].Value);
            MessageBox.Show("Успешно удалено!");
            Load_projects();

        }

        private void отредактироватьПроектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int proj_id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            string proj_name = (string)dataGridView1.CurrentRow.Cells[1].Value;
            string proj_desc = (string)dataGridView1.CurrentRow.Cells[2].Value;
            Project_upd form = new Project_upd(proj_id, proj_name, proj_desc);
            this.Hide();
            form.Show();
        }

        private void списокЗадачToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int proj_id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            Task_lists form = new Task_lists(proj_id);
            this.Hide();
            form.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}