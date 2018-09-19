using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double result = 0;
        int i = 0;
        double b = 0;
        char znak;

        public Form1()
        {
            InitializeComponent();
        }


          public void prZnak(char c)
          {  switch (c) {
                          case '+':
                              result += b;
                              break;
                          case '-':
                              result -= b;
                              break;
                          case '*':
                              result *= b;
                              break;
                          case '/':
                              result /= b;
                              break;
                      }
          } 





        public void procedure1(int a) {
            //Convert.ToInt32(textBox1.Text) == 0
            if (textBox1.Text == "0" || i == 1)
            {
                textBox1.Text = Convert.ToString(a);
                i = 0;
            }
            else
            {
                textBox1.Text += Convert.ToString(a);
            }  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            procedure1(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            procedure1(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            procedure1(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            procedure1(4); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            procedure1(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            procedure1(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            procedure1(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            procedure1(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            procedure1(9);
        }

        private void BC_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(0);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += Convert.ToString(0);
        }

        private void BPlus_Click(object sender, EventArgs e)
        {
            if (result == 0)
            {
                result = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(0);
            }
            else { if (result != 0 && b == 0)
                {
                    b = Convert.ToDouble(textBox1.Text);
                    prZnak(znak);
                    b = 0;
                    textBox1.Text = Convert.ToString(result);
                    i = 1;
                }
            }
            znak = '+' ;
        }

        private void BRavno_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox1.Text);
            prZnak(znak);
            b = 0;
            textBox1.Text = Convert.ToString(result);
            i = 1;
            result = Convert.ToDouble(0);
        }

        private void BMinus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "-";
                i = 0;
            }
            else
            {
                if (result == 0)
                {
                    result = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = Convert.ToString(0);
                }
                else
                {
                    if (result != 0 && b == 0)
                    {
                        b = Convert.ToDouble(textBox1.Text);
                        prZnak(znak);
                        b = 0;
                        textBox1.Text = Convert.ToString(result);
                        i = 1;
                    }
                }
             znak = '-';
            }
        }

        private void BX_Click(object sender, EventArgs e)
        {
            if (result == 0)
            {
                result = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(0);
            }
            else
            {
                if (result != 0 && b == 0)
                {
                    b = Convert.ToDouble(textBox1.Text);
                    prZnak(znak);
                    b = 0;
                    textBox1.Text = Convert.ToString(result);
                    i = 1;
                }
            }
            znak = '*';
        }

        private void Bd_Click(object sender, EventArgs e)
        {
            if (result == 0)
            {
                result = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(0);
            }
            else
            {
                if (result != 0 && b == 0)
                {
                    b = Convert.ToDouble(textBox1.Text);
                    prZnak(znak);
                    b = 0;
                    textBox1.Text = Convert.ToString(result);
                    i = 1;
                }
            }
            znak = '/';
        }

        private void Bzap_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) == 0 || i == 1)
            {
                Console.WriteLine("Error404");
            }
            else
            {
                textBox1.Text += Convert.ToString(",");
            }
        }

        private void BCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(0);
            result = 0;
        }
    }
}
