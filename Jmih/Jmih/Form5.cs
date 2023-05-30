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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Текст сообщения!", "Заголовок сообщения!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Текст сообщения!", "Заголовок сообщения!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Текст сообщения!", "Заголовок сообщения!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Текст сообщения!", "Заголовок сообщения!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Текст сообщения!", "Заголовок сообщения!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Текст сообщения!", "Заголовок сообщения!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }
    }
}
