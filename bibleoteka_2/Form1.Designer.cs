namespace bibleoteka_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            удалитьПроектToolStripMenuItem = new ToolStripMenuItem();
            отредактироватьПроектToolStripMenuItem = new ToolStripMenuItem();
            списокЗадачToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            project_add = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(12, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 385);
            dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { удалитьПроектToolStripMenuItem, отредактироватьПроектToolStripMenuItem, списокЗадачToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(210, 70);
            // 
            // удалитьПроектToolStripMenuItem
            // 
            удалитьПроектToolStripMenuItem.Name = "удалитьПроектToolStripMenuItem";
            удалитьПроектToolStripMenuItem.Size = new Size(209, 22);
            удалитьПроектToolStripMenuItem.Text = "Удалить проект";
            удалитьПроектToolStripMenuItem.Click += удалитьПроектToolStripMenuItem_Click;
            // 
            // отредактироватьПроектToolStripMenuItem
            // 
            отредактироватьПроектToolStripMenuItem.Name = "отредактироватьПроектToolStripMenuItem";
            отредактироватьПроектToolStripMenuItem.Size = new Size(209, 22);
            отредактироватьПроектToolStripMenuItem.Text = "Отредактировать проект";
            отредактироватьПроектToolStripMenuItem.Click += отредактироватьПроектToolStripMenuItem_Click;
            // 
            // списокЗадачToolStripMenuItem
            // 
            списокЗадачToolStripMenuItem.Name = "списокЗадачToolStripMenuItem";
            списокЗадачToolStripMenuItem.Size = new Size(209, 22);
            списокЗадачToolStripMenuItem.Text = "Список задач";
            списокЗадачToolStripMenuItem.Click += списокЗадачToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(305, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 30);
            label1.TabIndex = 1;
            label1.Text = "Список проектов";
            // 
            // project_add
            // 
            project_add.Location = new Point(262, 444);
            project_add.Name = "project_add";
            project_add.Size = new Size(276, 37);
            project_add.TabIndex = 2;
            project_add.Text = "Добавить проект";
            project_add.UseVisualStyleBackColor = true;
            project_add.Click += project_add_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(800, 493);
            Controls.Add(project_add);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Список проектов";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button project_add;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem удалитьПроектToolStripMenuItem;
        private ToolStripMenuItem отредактироватьПроектToolStripMenuItem;
        private ToolStripMenuItem списокЗадачToolStripMenuItem;
    }
}