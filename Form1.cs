using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace jianma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            textBox1.Focus();
            Random random = new Random();
            int RandomNum1 = random.Next(0, 10);
            int RandomNum2 = random.Next(0, 10);
            label4.Text = RandomNum1.ToString();
            label5.Text = RandomNum2.ToString();

        }

        private void radioButton2_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            textBox1.Focus();
            Random random = new Random();
            int RandomNum1 = random.Next(0, 10000);
            int RandomNum2 = random.Next(0, 10000);
            string formattedNumber1 = RandomNum1.ToString("D4");
            string formattedNumber2 = RandomNum2.ToString("D4");
            label4.Text = formattedNumber1;
            label5.Text = formattedNumber2;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                // 从Label控件中获取文本
                string textLabel4 = label4.Text;
                string textLabel5 = label5.Text;
                string textinput = textBox1.Text;
                // 尝试将文本转换为数字
                if (int.TryParse(textLabel4, out int number4) && int.TryParse(textLabel5, out int number5) && int.TryParse(textinput, out int number))
                {
                    // 比较数字大小
                    if (number4 >= number5)
                    {
                        //MessageBox.Show("Label4 中的数字大于 Label5 中的数字。");
                        if (number == number4 - number5)
                        {
                            textBox1.Text = "";
                            textBox1.Focus();
                            Random random = new Random();
                            int RandomNum1 = random.Next(0, 10);
                            int RandomNum2 = random.Next(0, 10);
                            label4.Text = RandomNum1.ToString();
                            label5.Text = RandomNum2.ToString();
                        }
                        else
                        {
                            textBox1.Text = "";
                            textBox1.Focus();
                        }
                    }
                    else if (number4 < number5)
                    {
                        //MessageBox.Show("Label4 中的数字小于 Label5 中的数字。");
                        if (number == number4 + 10 - number5)
                        {
                            textBox1.Text = "";
                            textBox1.Focus();
                            Random random = new Random();
                            int RandomNum1 = random.Next(0, 10);
                            int RandomNum2 = random.Next(0, 10);
                            label4.Text = RandomNum1.ToString();
                            label5.Text = RandomNum2.ToString();
                        }
                        else
                        {
                            textBox1.Text = "";
                            textBox1.Focus();
                        }
                    }
                }
            }
            else if (radioButton2.Checked)
            {
                // 从Label控件中获取文本
                string textLabel4 = label4.Text;
                string textLabel5 = label5.Text;
                string textinput = textBox1.Text;
                // 尝试将文本转换为数字
                if (int.TryParse(textLabel4, out int number4) && int.TryParse(textLabel5, out int number5) && int.TryParse(textinput, out int number))
                {
                    if (textinput.Length == 4)
                    {
                        // 比较数字大小
                        int a1, b1, c1, d1;
                        int a2, b2, c2, d2;
                        int a3, b3, c3, d3;

                        a1 = (number4 / 1000) % 10;
                        b1 = (number4 / 100) % 10;
                        c1 = (number4 / 10) % 10;
                        d1 = (number4 / 1) % 10;
                        a2 = (number5 / 1000) % 10;
                        b2 = (number5 / 100) % 10;
                        c2 = (number5 / 10) % 10;
                        d2 = (number5 / 1) % 10;
                        a3 = (number / 1000) % 10;
                        b3 = (number / 100) % 10;
                        c3 = (number / 10) % 10;
                        d3 = (number / 1) % 10;

                        //a = (number4 / 1000) % 10;
                        //b = (number5 / 100) % 10;
                        //c = (number /  10) % 10;
                        //d = 
                        if (a1 >= a2)
                        {
                            if (a3 == a1 - a2)
                            {
                                if (b1 >= b2)
                                {
                                    if (b3 == b1 - b2)
                                    {
                                        if (c1 >= c2)
                                        {
                                            if (c3 == c1 - c2)
                                            {
                                                if (d1 >= d2)
                                                {
                                                    if (d3 == d1 - d2)
                                                    {
                                                        textBox1.Text = "";
                                                        textBox1.Focus();
                                                        Random random = new Random();
                                                        int RandomNum1 = random.Next(0, 10000);
                                                        int RandomNum2 = random.Next(0, 10000);
                                                        string formattedNumber1 = RandomNum1.ToString("D4");
                                                        string formattedNumber2 = RandomNum2.ToString("D4");
                                                        label4.Text = formattedNumber1;
                                                        label5.Text = formattedNumber2;
                                                    }
                                                    else
                                                    {
                                                        textBox1.Text = "";
                                                        textBox1.Focus();
                                                    }
                                                }
                                                else
                                                {
                                                    if (d3 == 10 + d1 - d2)
                                                    {
                                                        textBox1.Text = "";
                                                        textBox1.Focus();
                                                        Random random = new Random();
                                                        int RandomNum1 = random.Next(0, 10000);
                                                        int RandomNum2 = random.Next(0, 10000);
                                                        string formattedNumber1 = RandomNum1.ToString("D4");
                                                        string formattedNumber2 = RandomNum2.ToString("D4");
                                                        label4.Text = formattedNumber1;
                                                        label5.Text = formattedNumber2;
                                                    }
                                                    else
                                                    {
                                                        textBox1.Text = "";
                                                        textBox1.Focus();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                textBox1.Text = "";
                                                textBox1.Focus();
                                            }
                                        }
                                        else
                                        {
                                            if (c3 == 10 + c1 - c2)
                                            {
                                                if (d1 >= d2)
                                                {
                                                    if (d3 == d1 - d2)
                                                    {
                                                        textBox1.Text = "";
                                                        textBox1.Focus();
                                                        Random random = new Random();
                                                        int RandomNum1 = random.Next(0, 10000);
                                                        int RandomNum2 = random.Next(0, 10000);
                                                        string formattedNumber1 = RandomNum1.ToString("D4");
                                                        string formattedNumber2 = RandomNum2.ToString("D4");
                                                        label4.Text = formattedNumber1;
                                                        label5.Text = formattedNumber2;
                                                    }
                                                    else
                                                    {
                                                        textBox1.Text = "";
                                                        textBox1.Focus();
                                                    }
                                                }
                                                else
                                                {
                                                    if (d3 == 10 + d1 - d2)
                                                    {
                                                        textBox1.Text = "";
                                                        textBox1.Focus();
                                                        Random random = new Random();
                                                        int RandomNum1 = random.Next(0, 10000);
                                                        int RandomNum2 = random.Next(0, 10000);
                                                        string formattedNumber1 = RandomNum1.ToString("D4");
                                                        string formattedNumber2 = RandomNum2.ToString("D4");
                                                        label4.Text = formattedNumber1;
                                                        label5.Text = formattedNumber2;
                                                    }
                                                    else
                                                    {
                                                        textBox1.Text = "";
                                                        textBox1.Focus();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                textBox1.Text = "";
                                                textBox1.Focus();
                                            }
                                        }
                                    }
                                    else
                                    {
                                        textBox1.Text = "";
                                        textBox1.Focus();
                                    }
                                }
                                else
                                {
                                    if (b3 == 10 + b1 - b2)
                                    {
                                        if (c1 >= c2)
                                        {
                                            if (c3 == c1 - c2)
                                            {
                                                if (d1 >= d2)
                                                {
                                                    if (d3 == d1 - d2)
                                                    {
                                                        textBox1.Text = "";
                                                        textBox1.Focus();
                                                        Random random = new Random();
                                                        int RandomNum1 = random.Next(0, 10000);
                                                        int RandomNum2 = random.Next(0, 10000);
                                                        string formattedNumber1 = RandomNum1.ToString("D4");
                                                        string formattedNumber2 = RandomNum2.ToString("D4");
                                                        label4.Text = formattedNumber1;
                                                        label5.Text = formattedNumber2;
                                                    }
                                                    else
                                                    {
                                                        textBox1.Text = "";
                                                        textBox1.Focus();
                                                    }
                                                }
                                                else
                                                {
                                                    if (d3 == 10 + d1 - d2)
                                                    {
                                                        textBox1.Text = "";
                                                        textBox1.Focus();
                                                        Random random = new Random();
                                                        int RandomNum1 = random.Next(0, 10000);
                                                        int RandomNum2 = random.Next(0, 10000);
                                                        string formattedNumber1 = RandomNum1.ToString("D4");
                                                        string formattedNumber2 = RandomNum2.ToString("D4");
                                                        label4.Text = formattedNumber1;
                                                        label5.Text = formattedNumber2;
                                                    }
                                                    else
                                                    {
                                                        textBox1.Text = "";
                                                        textBox1.Focus();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                textBox1.Text = "";
                                                textBox1.Focus();
                                            }
                                        }
                                        else
                                        {
                                            if (c3 == 10 + c1 - c2)
                                            {
                                                if (d1 >= d2)
                                                {
                                                    if (d3 == d1 - d2)
                                                    {
                                                        textBox1.Text = "";
                                                        textBox1.Focus();
                                                        Random random = new Random();
                                                        int RandomNum1 = random.Next(0, 10000);
                                                        int RandomNum2 = random.Next(0, 10000);
                                                        string formattedNumber1 = RandomNum1.ToString("D4");
                                                        string formattedNumber2 = RandomNum2.ToString("D4");
                                                        label4.Text = formattedNumber1;
                                                        label5.Text = formattedNumber2;
                                                    }
                                                    else
                                                    {
                                                        textBox1.Text = "";
                                                        textBox1.Focus();
                                                    }
                                                }
                                                else
                                                {
                                                    if (d3 == 10 + d1 - d2)
                                                    {
                                                        textBox1.Text = "";
                                                        textBox1.Focus();
                                                        Random random = new Random();
                                                        int RandomNum1 = random.Next(0, 10000);
                                                        int RandomNum2 = random.Next(0, 10000);
                                                        string formattedNumber1 = RandomNum1.ToString("D4");
                                                        string formattedNumber2 = RandomNum2.ToString("D4");
                                                        label4.Text = formattedNumber1;
                                                        label5.Text = formattedNumber2;
                                                    }
                                                    else
                                                    {
                                                        textBox1.Text = "";
                                                        textBox1.Focus();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                textBox1.Text = "";
                                                textBox1.Focus();
                                            }
                                        }
                                    }
                                    else
                                    {
                                        textBox1.Text = "";
                                        textBox1.Focus();
                                    }
                                }
                            }
                            else
                            {
                                textBox1.Text = "";
                                textBox1.Focus();
                            }
                        }
                        else
                        {
                            if (a3 == 10 + a1 - a2)
                            {
                                if (b1 >= b2)
                                {
                                    if (b3 == b1 - b2)
                                    {
                                        if (c1 >= c2)
                                        {
                                            if (c3 == c1 - c2)
                                            {
                                                if (d1 >= d2)
                                                {
                                                    if (d3 == d1 - d2)
                                                    {
                                                        textBox1.Text = "";
                                                        textBox1.Focus();
                                                        Random random = new Random();
                                                        int RandomNum1 = random.Next(0, 10000);
                                                        int RandomNum2 = random.Next(0, 10000);
                                                        string formattedNumber1 = RandomNum1.ToString("D4");
                                                        string formattedNumber2 = RandomNum2.ToString("D4");
                                                        label4.Text = formattedNumber1;
                                                        label5.Text = formattedNumber2;
                                                    }
                                                    else
                                                    {
                                                        textBox1.Text = "";
                                                        textBox1.Focus();
                                                    }
                                                }
                                                else
                                                {
                                                    if (d3 == 10 + d1 - d2)
                                                    {
                                                        textBox1.Text = "";
                                                        textBox1.Focus();
                                                        Random random = new Random();
                                                        int RandomNum1 = random.Next(0, 10000);
                                                        int RandomNum2 = random.Next(0, 10000);
                                                        string formattedNumber1 = RandomNum1.ToString("D4");
                                                        string formattedNumber2 = RandomNum2.ToString("D4");
                                                        label4.Text = formattedNumber1;
                                                        label5.Text = formattedNumber2;
                                                    }
                                                    else
                                                    {
                                                        textBox1.Text = "";
                                                        textBox1.Focus();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                textBox1.Text = "";
                                                textBox1.Focus();
                                            }
                                        }
                                        else
                                        {
                                            if (c3 == 10 + c1 - c2)
                                            {
                                                if (d1 >= d2)
                                                {
                                                    if (d3 == d1 - d2)
                                                    {
                                                        textBox1.Text = "";
                                                        textBox1.Focus();
                                                        Random random = new Random();
                                                        int RandomNum1 = random.Next(0, 10000);
                                                        int RandomNum2 = random.Next(0, 10000);
                                                        string formattedNumber1 = RandomNum1.ToString("D4");
                                                        string formattedNumber2 = RandomNum2.ToString("D4");
                                                        label4.Text = formattedNumber1;
                                                        label5.Text = formattedNumber2;
                                                    }
                                                    else
                                                    {
                                                        textBox1.Text = "";
                                                        textBox1.Focus();
                                                    }
                                                }
                                                else
                                                {
                                                    if (d3 == 10 + d1 - d2)
                                                    {
                                                        textBox1.Text = "";
                                                        textBox1.Focus();
                                                        Random random = new Random();
                                                        int RandomNum1 = random.Next(0, 10000);
                                                        int RandomNum2 = random.Next(0, 10000);
                                                        string formattedNumber1 = RandomNum1.ToString("D4");
                                                        string formattedNumber2 = RandomNum2.ToString("D4");
                                                        label4.Text = formattedNumber1;
                                                        label5.Text = formattedNumber2;
                                                    }
                                                    else
                                                    {
                                                        textBox1.Text = "";
                                                        textBox1.Focus();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                textBox1.Text = "";
                                                textBox1.Focus();
                                            }
                                        }
                                    }
                                    else
                                    {
                                        textBox1.Text = "";
                                        textBox1.Focus();
                                    }
                                }
                                else
                                {
                                    if (b3 == 10 + b1 - b2)
                                    {
                                        if (c1 >= c2)
                                        {
                                            if (c3 == c1 - c2)
                                            {
                                                if (d1 >= d2)
                                                {
                                                    if (d3 == d1 - d2)
                                                    {
                                                        textBox1.Text = "";
                                                        textBox1.Focus();
                                                        Random random = new Random();
                                                        int RandomNum1 = random.Next(0, 10000);
                                                        int RandomNum2 = random.Next(0, 10000);
                                                        string formattedNumber1 = RandomNum1.ToString("D4");
                                                        string formattedNumber2 = RandomNum2.ToString("D4");
                                                        label4.Text = formattedNumber1;
                                                        label5.Text = formattedNumber2;
                                                    }
                                                    else
                                                    {
                                                        textBox1.Text = "";
                                                        textBox1.Focus();
                                                    }
                                                }
                                                else
                                                {
                                                    if (d3 == 10 + d1 - d2)
                                                    {
                                                        textBox1.Text = "";
                                                        textBox1.Focus();
                                                        Random random = new Random();
                                                        int RandomNum1 = random.Next(0, 10000);
                                                        int RandomNum2 = random.Next(0, 10000);
                                                        string formattedNumber1 = RandomNum1.ToString("D4");
                                                        string formattedNumber2 = RandomNum2.ToString("D4");
                                                        label4.Text = formattedNumber1;
                                                        label5.Text = formattedNumber2;
                                                    }
                                                    else
                                                    {
                                                        textBox1.Text = "";
                                                        textBox1.Focus();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                textBox1.Text = "";
                                                textBox1.Focus();
                                            }
                                        }
                                        else
                                        {
                                            if (c3 == 10 + c1 - c2)
                                            {
                                                if (d1 >= d2)
                                                {
                                                    if (d3 == d1 - d2)
                                                    {
                                                        textBox1.Text = "";
                                                        textBox1.Focus();
                                                        Random random = new Random();
                                                        int RandomNum1 = random.Next(0, 10000);
                                                        int RandomNum2 = random.Next(0, 10000);
                                                        string formattedNumber1 = RandomNum1.ToString("D4");
                                                        string formattedNumber2 = RandomNum2.ToString("D4");
                                                        label4.Text = formattedNumber1;
                                                        label5.Text = formattedNumber2;
                                                    }
                                                    else
                                                    {
                                                        textBox1.Text = "";
                                                        textBox1.Focus();
                                                    }
                                                }
                                                else
                                                {
                                                    if (d3 == 10 + d1 - d2)
                                                    {
                                                        textBox1.Text = "";
                                                        textBox1.Focus();
                                                        Random random = new Random();
                                                        int RandomNum1 = random.Next(0, 10000);
                                                        int RandomNum2 = random.Next(0, 10000);
                                                        string formattedNumber1 = RandomNum1.ToString("D4");
                                                        string formattedNumber2 = RandomNum2.ToString("D4");
                                                        label4.Text = formattedNumber1;
                                                        label5.Text = formattedNumber2;
                                                    }
                                                    else
                                                    {
                                                        textBox1.Text = "";
                                                        textBox1.Focus();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                textBox1.Text = "";
                                                textBox1.Focus();
                                            }
                                        }
                                    }
                                    else
                                    {
                                        textBox1.Text = "";
                                        textBox1.Focus();
                                    }
                                }
                            }
                            else
                            {
                                textBox1.Text = "";
                                textBox1.Focus();
                            }
                        }


                    }



                }
            }

        }
    }
}
