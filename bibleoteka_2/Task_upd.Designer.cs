namespace bibleoteka_2
{
    partial class Task_upd
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
            back_btn = new Button();
            upd_cl = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // back_btn
            // 
            back_btn.Location = new Point(10, 247);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(230, 24);
            back_btn.TabIndex = 17;
            back_btn.Text = "Назад";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // upd_cl
            // 
            upd_cl.Location = new Point(10, 204);
            upd_cl.Name = "upd_cl";
            upd_cl.Size = new Size(230, 37);
            upd_cl.TabIndex = 16;
            upd_cl.Text = "Обновить";
            upd_cl.UseVisualStyleBackColor = true;
            upd_cl.Click += upd_cl_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(10, 64);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 15;
            label2.Text = "Описание";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 14;
            label1.Text = "Название";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(10, 82);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(230, 64);
            textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(10, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 23);
            textBox1.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(10, 165);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(230, 23);
            comboBox1.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 149);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 19;
            label3.Text = "Статус";
            // 
            // Task_upd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(250, 283);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(back_btn);
            Controls.Add(upd_cl);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Task_upd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Обновление задачи";
            FormClosing += Task_upd_FormClosing;
            Load += Task_upd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back_btn;
        private Button upd_cl;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label3;
    }
}