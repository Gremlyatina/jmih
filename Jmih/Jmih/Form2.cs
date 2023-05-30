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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для продолжения нажмите ОК", "Услуга изменена!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для продолжения нажмите ОК", "Услуга изменена!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для продолжения нажмите ОК", "Услуга изменена!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для продолжения нажмите ОК", "Услуга изменена!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для продолжения нажмите ОК", "Услуга изменена!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для продолжения нажмите ОК", "Услуга изменена!");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("+7(917)-003-52-61", "Техническая поддержка");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }
    }
}
