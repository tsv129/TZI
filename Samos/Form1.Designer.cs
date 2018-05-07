namespace Samos
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
<<<<<<< HEAD
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.File1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.File2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.File3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.File4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.File5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.File6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
=======
>>>>>>> 6f7e988ed31967857c1d6b9fb624bb1581d0884e
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
<<<<<<< HEAD
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
=======
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.File1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.File2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.File3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.File4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.File5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.File6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
>>>>>>> 6f7e988ed31967857c1d6b9fb624bb1581d0884e
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User,
            this.File1,
            this.File2,
            this.File3,
            this.File4,
            this.File5,
            this.File6});
            this.dataGridView1.Location = new System.Drawing.Point(231, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 35;
            this.dataGridView1.RowTemplate.Height = 20;
            this.dataGridView1.Size = new System.Drawing.Size(528, 303);
            this.dataGridView1.TabIndex = 0;
            // 
<<<<<<< HEAD
            // User
            // 
            this.User.HeaderText = "User";
            this.User.Name = "User";
            this.User.ReadOnly = true;
            this.User.Width = 75;
            // 
            // File1
            // 
            this.File1.HeaderText = "File1";
            this.File1.Name = "File1";
            this.File1.ReadOnly = true;
            this.File1.Width = 75;
            // 
            // File2
            // 
            this.File2.HeaderText = "File2";
            this.File2.Name = "File2";
            this.File2.ReadOnly = true;
            this.File2.Width = 75;
            // 
            // File3
            // 
            this.File3.HeaderText = "File3";
            this.File3.Name = "File3";
            this.File3.ReadOnly = true;
            this.File3.Width = 75;
            // 
            // File4
            // 
            this.File4.HeaderText = "File4";
            this.File4.Name = "File4";
            this.File4.ReadOnly = true;
            this.File4.Width = 75;
            // 
            // File5
            // 
            this.File5.HeaderText = "File5";
            this.File5.Name = "File5";
            this.File5.ReadOnly = true;
            this.File5.Width = 75;
            // 
            // File6
            // 
            this.File6.HeaderText = "File6";
            this.File6.Name = "File6";
            this.File6.ReadOnly = true;
            this.File6.Width = 75;
            // 
=======
>>>>>>> 6f7e988ed31967857c1d6b9fb624bb1581d0884e
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сгенирировать права";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя:";
            this.label1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 174);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "File 1";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(118, 174);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "File 2";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(118, 200);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "File 4";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 200);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 6;
            this.textBox5.Text = "File 3";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(118, 226);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 9;
            this.textBox6.Text = "File 6";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(12, 226);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 8;
            this.textBox7.Text = "File 5";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
<<<<<<< HEAD
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(80, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(80, 107);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 12;
=======
            // User
            // 
            this.User.HeaderText = "User";
            this.User.Name = "User";
            this.User.ReadOnly = true;
            this.User.Width = 75;
            // 
            // File1
            // 
            this.File1.HeaderText = "File1";
            this.File1.Name = "File1";
            this.File1.ReadOnly = true;
            this.File1.Width = 75;
            // 
            // File2
            // 
            this.File2.HeaderText = "File2";
            this.File2.Name = "File2";
            this.File2.ReadOnly = true;
            this.File2.Width = 75;
            // 
            // File3
            // 
            this.File3.HeaderText = "File3";
            this.File3.Name = "File3";
            this.File3.ReadOnly = true;
            this.File3.Width = 75;
            // 
            // File4
            // 
            this.File4.HeaderText = "File4";
            this.File4.Name = "File4";
            this.File4.ReadOnly = true;
            this.File4.Width = 75;
            // 
            // File5
            // 
            this.File5.HeaderText = "File5";
            this.File5.Name = "File5";
            this.File5.ReadOnly = true;
            this.File5.Width = 75;
            // 
            // File6
            // 
            this.File6.HeaderText = "File6";
            this.File6.Name = "File6";
            this.File6.ReadOnly = true;
            this.File6.Width = 75;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(76, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
>>>>>>> 6f7e988ed31967857c1d6b9fb624bb1581d0884e
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 334);
<<<<<<< HEAD
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button2);
=======
>>>>>>> 6f7e988ed31967857c1d6b9fb624bb1581d0884e
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ТЗИ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn File1;
        private System.Windows.Forms.DataGridViewTextBoxColumn File2;
        private System.Windows.Forms.DataGridViewTextBoxColumn File3;
        private System.Windows.Forms.DataGridViewTextBoxColumn File4;
        private System.Windows.Forms.DataGridViewTextBoxColumn File5;
        private System.Windows.Forms.DataGridViewTextBoxColumn File6;
        private System.Windows.Forms.ComboBox comboBox1;
<<<<<<< HEAD
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
=======
>>>>>>> 6f7e988ed31967857c1d6b9fb624bb1581d0884e
    }
}

