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
    public partial class Form2 : Form
    {
        int n=0, count = 0;
        public string n1;
        Random r1 = new Random();
        int num;
        string numst;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n += 3;
            count++;
            this.button1.Enabled = false;
            this.button1.Text = "3";
            if (count > 3)
            {
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
                if (n > 50)
                {
                    MessageBox.Show("Congratz" + n1 + "You Win");
                }
                else
                {
                    MessageBox.Show("You Lose" + n1);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n += 18;
            count++;
            this.button2.Enabled = false;
            this.button2.Text = "18";
            if (count > 3)
            {
                this.button1.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
                if (n > 50)
                {
                    MessageBox.Show("Congratz" + n1 + "You Win");
                }
                else
                {
                    MessageBox.Show("You Lose" + n1);
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n += 20;
            count++;
            this.button3.Enabled = false;
            this.button3.Text = "20";
            if (count > 3)
            {
                this.button1.Enabled = false;
                this.button2.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
                if (n > 50)
                {
                    MessageBox.Show("Congratz" + n1 + "You Win");
                }
                else
                {
                    MessageBox.Show("You Lose" + n1);
                }

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            n += 23;
            count++;
            this.button4.Enabled = false;
            this.button4.Text = "23";
            if (count > 3)
            {
                this.button1.Enabled = false;
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
                if (n > 50)
                {
                    MessageBox.Show("Congratz" + n1 + "You Win");
                }
                else
                {
                    MessageBox.Show("You Lose" + n1);
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            n += 3;
            count++;
            this.button5.Enabled = false;
            this.button5.Text = "3";
            if (count > 3)
            {
                this.button1.Enabled = false;
                this.button2.Enabled = false;
                this.button4.Enabled = false;
                this.button3.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
                if (n > 50)
                {
                    MessageBox.Show("Congratz" + n1 + "You Win");
                }
                else
                {
                    MessageBox.Show("You Lose" + n1);
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            n += 4;
            count++;
            this.button6.Enabled = false;
            this.button6.Text = "4";
            if (count > 3)
            {
                this.button1.Enabled = false;
                this.button2.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button3.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
                if (n > 50)
                {
                    MessageBox.Show("Congratz" + n1 + "You Win");
                }
                else
                {
                    MessageBox.Show("You Lose" + n1);
                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            n += 2;
            count++;
            this.button7.Enabled = false;
            this.button7.Text = "2";
            if (count > 3)
            {
                this.button1.Enabled = false;
                this.button2.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button3.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
                if (n > 50)
                {
                    MessageBox.Show("Congratz" + n1 + "You Win");
                }
                else
                {
                    MessageBox.Show("You Lose" + n1);
                }

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            n += 5;
            count++;
            this.button8.Enabled = false;
            this.button8.Text = "5";
            if (count > 3)
            {
                this.button1.Enabled = false;
                this.button2.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button3.Enabled = false;
                this.button9.Enabled = false;
                if (n > 50)
                {
                    MessageBox.Show("Congratz" + n1 + "You Win");
                }
                else
                {
                    MessageBox.Show("You Lose" + n1);
                }

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            n += 12;
            count++;
            this.button9.Enabled = false;
            this.button9.Text = "12";
            if (count > 3)
            {
                this.button1.Enabled = false;
                this.button2.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button3.Enabled = false;
                if (n > 50)
                {
                    MessageBox.Show("Congratz" + n1 + "You Win");
                }
                else
                {
                    MessageBox.Show("You Lose" + n1);
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
            this.button7.Enabled = true;
            this.button8.Enabled = true;
            this.button9.Enabled = true;
            this.button1.Text = "";
            this.button2.Text = "";
            this.button3.Text = "";
            this.button4.Text = "";
            this.button5.Text = "";
            this.button6.Text = "";
            this.button7.Text = "";
            this.button8.Text = "";
            this.button9.Text = "";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int[] arry = { 20, 10, 15, 6, 7, 5, 4, 3, 12 };
            Random random = new Random();
            int random1 = random.Next(arry.Length);
            button1.Text = arry[random1]+"";
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
            int random7 = random.Next(arry.Length);
            button7.Text = arry[random7] + "";
            int random8 = random.Next(arry.Length);
            button8.Text = arry[random8] + "";
            int random9 = random.Next(arry.Length);
            button9.Text = arry[random9] + "";
            n = r1.Next(3, 30);
        }

    }
}
