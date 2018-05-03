using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Samos
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        int rid;
        Random random = new Random();
        TextBox[] tbarr = new TextBox[6];

        private void Random_access(string name)
        {
            dataGridView1[0, rid].Value = name;

            for (int i=1; i < 7; i++)
                dataGridView1[i, rid].Value = "False";

            if (random.Next(2) == 1)
            {
                dataGridView1[1, rid].Value = "True";
                if (random.Next(2) == 1)
                {
                    dataGridView1[2, rid].Value = "True";
                }
            }

            for (int i=3; i < 7; i++)
            {
                if (random.Next(2) == 1)
                    dataGridView1[i, rid].Value = "True";
            }

            Color_cell();

            rid++;
        }

        private void Expand_rows()
        {
            for (int i = 0; i < 15; i++)
                dataGridView1.Rows.Add();
        }

        private void Color_cell()
        {
            for (int i = 1; i < 7; i++)
                if (dataGridView1[i, rid].Value.ToString() == "True")
                {
                    dataGridView1[i, rid].Style.BackColor = Color.Green;
                    tbarr[i-1].BackColor = Color.Green;
                }
                else
                {
                    dataGridView1[i, rid].Style.BackColor = Color.Red;
                    tbarr[i - 1].BackColor = Color.Red;
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rid % 15 == 0)
                Expand_rows();
            Random_access(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            tbarr[0] = textBox2;
            tbarr[1] = textBox3;
            tbarr[2] = textBox4;
            tbarr[3] = textBox5;
            tbarr[4] = textBox6;
            tbarr[5] = textBox7;
        }
    }
}
