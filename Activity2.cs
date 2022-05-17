using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_2
{
    public partial class Activity2 : Form
    {
        double numConverter = 0;

        public Activity2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            outputBox2.Text = Convert.ToString(numConverter * 3);

            string message = outputBox2.Text;
            string title = "Message Box";
            MessageBox.Show(message, title);
        }

        private void inputBox1_TextChanged(object sender, EventArgs e)
        {
            numConverter = Convert.ToDouble(inputBox1.Text);
        }

        private void outputBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
