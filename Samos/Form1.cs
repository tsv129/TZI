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

        private void Random_access()
        {
            for (int i = 1; i < 7; i++)
                Access_type(random.Next(4), i);

            rid++;
        }

        private void Access_type(int rand,int num)
        {
            switch (rand)
            {
                case 0:
                    dataGridView1[num, rid].Style.BackColor = Color.Red;
                    break;

                case 1:
                    dataGridView1[num, rid].Style.BackColor = Color.Yellow;
                    break;

                case 2:
                    dataGridView1[num, rid].Style.BackColor = Color.Blue;
                    break;

                case 3:
                    dataGridView1[num, rid].Style.BackColor = Color.Green;
                    break;
            }
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
            for (int i = 0; i < 3; i++)
                dataGridView1.Rows.Add();
            for (int i = 0; i < 4; i++)
            Random_access();
            button1.Visible = false;
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
