using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection.Metadata;
using System.Xml;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        string number;
        string sign;
        string num2;
        bool perekluchatel = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (perekluchatel == false)
            {
                number += "1";
                textBox3.Text = number;
            }
            else
            {
                num2 += "1";
                textBox2.Text = num2;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (perekluchatel == false)
            {
                number += "2";
                textBox3.Text = number;
            }
            else
            {
                num2 += "2";
                textBox2.Text = num2;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (perekluchatel == false)
            {
                number += "3";
                textBox3.Text = number;
            }
            else
            {
                num2 += "3";
                textBox2.Text = num2;
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (perekluchatel == false)
            {
                number += "4";
                textBox3.Text = number;
            }
            else
            {
                num2 += "4";
                textBox2.Text = num2;
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (perekluchatel == false)
            {
                number += "5";
                textBox3.Text = number;
            }
            else
            {
                num2 += "5";
                textBox2.Text = num2;
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (perekluchatel == false)
            {
                number += "6";
                textBox3.Text = number;
            }
            else
            {
                num2 += "6";
                textBox2.Text = num2;
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (perekluchatel == false)
            {
                number += "7";
                textBox3.Text = number;
            }
            else
            {
                num2 += "7";
                textBox2.Text = num2;
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            if (perekluchatel == false)
            {
                number += "8";
                textBox3.Text = number;
            }
            else
            {
                num2 += "8";
                textBox2.Text = num2;
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (perekluchatel == false)
            {
                number += "9";
                textBox3.Text = number;
            }
            else
            {
                num2 += "9";
                textBox2.Text = num2;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (perekluchatel == false)
            {
                number += "0";
                textBox3.Text = number;
            }
            else
            {
                num2 += "0";
                textBox2.Text = num2;
            }
        }
        double chislo1;
        double chislo2;
        double chislo3;
        int chet = -1;
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                switch (sign)
                {
                    case "+":
                        chislo1 = double.Parse(number);
                        chislo2 = double.Parse(textBox2.Text);
                        chislo3 = chislo1 + chislo2;
                        textBox1.Text = chislo3.ToString();
                        break;
                    case "-":
                        chislo1 = double.Parse(number);
                        chislo2 = double.Parse(textBox2.Text);
                        chislo3 = chislo1 - chislo2;
                        textBox1.Text = chislo3.ToString();
                        break;
                    case "*":
                        chislo1 = double.Parse(number);
                        chislo2 = double.Parse(textBox2.Text);
                        chislo3 = chislo1 * chislo2;
                        textBox1.Text = chislo3.ToString();
                        break;
                    case "/":
                        chislo1 = double.Parse(number);
                        chislo2 = double.Parse(textBox2.Text);
                        chislo3 = chislo1 / chislo2;
                        textBox1.Text = chislo3.ToString();
                        break;
                    default:
                        break;
                }
            }
            chet++;
            switch (chet)
            {
                case 0:
                    textBox5.Text = textBox1.Text;
                    break;
                case 1:
                    textBox6.Text = textBox1.Text;
                    break;
                case 2:
                    textBox7.Text = textBox1.Text;
                    break;
                case 3:
                    textBox8.Text = textBox1.Text;
                    break;
                case 4:
                    textBox9.Text = textBox1.Text;
                    break;
                case 5:
                    textBox10.Text = textBox1.Text;
                    break;
                case 6:
                    textBox11.Text = textBox1.Text;
                    break;
                case 7:
                    textBox12.Text = textBox1.Text;
                    break;
            }
            if (chet == 7)
            {
                chet = -1;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            number = "";
            chislo1 = 0;
            chislo2 = 0;
            chislo3 = 0;
            textBox1.Text = "";
            num2 = "";
            textBox2.Text = "";
            textBox3.Text = "";
            perekluchatel = false;
            textBox4.Text = "";

        }



        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox3.Text = textBox1.Text;
                num2 = "";
                textBox2.Text = "";
                number = textBox3.Text;
                perekluchatel = true;
                textBox1.Text = "";
                

            }
            if (textBox3.Text != "")
            {
                sign = "+";
                textBox4.Text = sign;
                perekluchatel = true;
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox3.Text = textBox1.Text;
                num2 = "";
                textBox2.Text = "";
                perekluchatel = true;
                textBox1.Text = "";
                number = textBox3.Text;

            }
            if (textBox3.Text != "")
            {
                sign = "-";
                textBox4.Text = sign;
                perekluchatel = true;
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox3.Text = textBox1.Text;
                num2 = "";
                textBox2.Text = "";
                perekluchatel = true;
                textBox1.Text = "";
                number = textBox3.Text;

            }
            if (textBox3.Text != "")
            {
                sign = "/";
                textBox4.Text = sign;
                perekluchatel = true;
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox3.Text = textBox1.Text;
                number = textBox3.Text;
                textBox2.Text = "";
                num2 = "";
                perekluchatel = true;
                textBox1.Text = "";

            }
            if (textBox3.Text != "")
            {
                sign = "*";
                textBox4.Text = sign;
                perekluchatel = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
