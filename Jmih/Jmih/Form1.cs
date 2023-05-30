using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jmih
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Неверный логин или пароль!", "Ошибка!");
                }
                else
                {
                    if (textBox2.Text == "12345") //password
                    {
                        if (textBox1.Text == "jmih") //login
                        {
                            this.Hide();
                            Form2 f2 = new Form2();
                            f2.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Неверный логин или пароль!", "Ошибка!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль!", "Ошибка!");
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            {
                if (checkBox1.Checked)
                {
                    textBox2.UseSystemPasswordChar = false;
                }
                else
                {
                    textBox2.UseSystemPasswordChar = true;
                }
            }
        }
    }
}
