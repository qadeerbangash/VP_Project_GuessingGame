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
    public partial class Form3 : Form
    {
        int b=0, count = 0;
        public string b1;
        Random r1 = new Random();
        int num;
        string numst;
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b += 6;
            count++;
            this.button2.Enabled = false;
            this.button2.Text = "6";
            if (count > 1)
            {
                this.button1.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                if (b > 50)
                {
                    MessageBox.Show("Congratz" + b1 + "You Win");

                }
                else
                {
                    MessageBox.Show("You Lose" + b1);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            b += 9;
            count++;
            this.button3.Enabled = false;
            this.button3.Text = "9";
            if (count > 1)
            {
                this.button2.Enabled = false;
                this.button1.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                if (b > 50)
                {
                    MessageBox.Show("Congratz" + b1 + "You Win");

                }
                else
                {
                    MessageBox.Show("You Lose" + b1);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            b += 12;
            count++;
            this.button4.Enabled = false;
            this.button4.Text = "12";
            if (count > 1)
            {
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button1.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                if (b > 50)
                {
                    MessageBox.Show("Congratz" + b1 + "You Win");

                }
                else
                {
                    MessageBox.Show("You Lose" + b1);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            b += 14;
            count++;
            this.button5.Enabled = false;
            this.button5.Text = "14";
            if (count > 1)
            {
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button1.Enabled = false;
                this.button6.Enabled = false;
                if (b > 50)
                {
                    MessageBox.Show("Congratz" + b1 + "You Win");

                }
                else
                {
                    MessageBox.Show("You Lose" + b1);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            b += 2;
            count++;
            this.button6.Enabled = false;
            this.button6.Text = "2";
            if (count > 1)
            {
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button1.Enabled = false;
                if (b > 50)
                {
                    MessageBox.Show("Congratz" + b1 + "You Win");

                }
                else
                {
                    MessageBox.Show("You Lose" + b1);
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            count = 0;
            this.button1.Enabled = true;
            this.button2.Enabled = true;
            this.button3.Enabled = true;
            this.button4.Enabled = true;
            this.button5.Enabled = true;
            this.button6.Enabled = true;
            this.button1.Text = "";
            this.button2.Text = "";
            this.button3.Text = "";
            this.button4.Text = "";
            this.button5.Text = "";
            this.button6.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int[] arry = { 25, 11, 9, 6, 7, 15};
            Random random = new Random();
            int random1 = random.Next(arry.Length);
            button1.Text = arry[random1] + "";
            int random2 = random.Next(arry.Length);
            button2.Text = arry[random2] + "";
            int random3 = random.Next(arry.Length);
            button3.Text = arry[random3] + "";
            int random4 = random.Next(arry.Length);
            button4.Text = arry[random4] + "";
            int random5 = random.Next(arry.Length);
            button5.Text = arry[random5] + "";
            int random6 = random.Next(arry.Length);
            button6.Text = arry[random6] + "";
            b = r1.Next(3, 30);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            b=r1.Next(3,30);
           b += 3;
            count++;
            this.button1.Enabled = false;
           this.button1.Text = "3";
            if (count > 1)
            {
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                if (b > 50)
                {
                    MessageBox.Show("Congratz" + b1 + "You Win");

                }
                else
                {
                    MessageBox.Show("You Lose" + b1);
                }
            }
        }
    }
}
