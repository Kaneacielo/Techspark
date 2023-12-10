using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TECHSPARK
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            InitializeProgressBar();
        }

        private void InitializeProgressBar()
        {
        }

        private async void btnUser_Click(object sender, EventArgs e)
        {

            ShowLoadingIndicator();

            await Task.Delay(500);

            HideLoadingIndicator();

            Form6 form6 = new Form6();
            form6.Show();


            Form7 form7 = new Form7();
            form7.Show();
            this.Close(); 
        }

        private async void btnAdmin_Click(object sender, EventArgs e)
        {
            
            ShowLoadingIndicator();

           
            await Task.Delay(500); 
            HideLoadingIndicator();

            Form3 form3 = new Form3();
            form3.Show();
            this.Close(); 
        }

        private void ShowLoadingIndicator()
        {
            
            progressBar1.Visible = true;
            progressBar1.Style = ProgressBarStyle.Marquee;
        }

        private void HideLoadingIndicator()
        {
            progressBar1.Style = ProgressBarStyle.Blocks;
            progressBar1.Visible = false;
        }


    }
}
