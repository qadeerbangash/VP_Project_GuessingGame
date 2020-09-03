using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guessing_Game
{
    public partial class Form1 : Form
    {
        Form2 a = new Form2();
        Form3 b = new Form3();

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.radioButton1.AutoCheck = false;
            this.radioButton2.AutoCheck = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a.n1 = textBox1.Text;
            if (radioButton1.Checked && this.textBox1.Text == "qadeer" && this.textBox2.Text == "9922")
            {
                a.Show();
            }
            else
            {
                this.Show();
            }
            b.b1 = textBox1.Text;
            if (radioButton2.Checked && this.textBox1.Text == "qadeer" && this.textBox2.Text == "9922")
            {
                b.Show();
            }
            else
            {
                this.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
