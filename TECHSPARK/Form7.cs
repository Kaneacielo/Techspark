using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TECHSPARK
{
    public partial class Form7 : Form
    {
        private const string ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password='';database=techspark";
        private MySqlConnection connection = new MySqlConnection(ConnectionString);

        public Form7()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);

            if (this.Owner is Form6 form6)
            {
                form6.FormClosing += delegate { this.Close(); }; 
            }
        }

        private void SaveFeedbackToDatabase(string feedbackText)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();

                    string insertQuery = "INSERT INTO Feedback (feedback_text) VALUES (@FeedbackText)";
                    using (MySqlCommand command = new MySqlCommand(insertQuery, conn))
                    {
                        command.Parameters.AddWithValue("@FeedbackText", feedbackText);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving feedback: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubmitFeedback_Click_1(object sender, EventArgs e)
        {
            string feedbackText = richTextBoxFeedback.Text;

            if (!string.IsNullOrEmpty(feedbackText))
            {
                SaveFeedbackToDatabase(feedbackText);
                MessageBox.Show("Feedback submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richTextBoxFeedback.Clear();
            }
            else
            {
                MessageBox.Show("Please enter your feedback before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
