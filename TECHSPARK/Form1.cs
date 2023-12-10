using System;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace TECHSPARK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Click += Form1_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
