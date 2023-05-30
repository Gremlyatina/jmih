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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для продолжения нажмите ОК", "Машина добавлена!");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("230", "Цена в час (руб.)");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("400", "Цена в час (руб.)");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("450", "Цена в час (руб.)");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("450", "Цена в час (руб.)");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("500", "Цена в час (руб.)");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("500", "Цена в час (руб.)");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("+7(917)-003-52-61", "Техническая поддержка");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }
    }
}
