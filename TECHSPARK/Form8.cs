using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace TECHSPARK
{
    public partial class Form8 : Form
    {

        private readonly string connectionString = "Server=127.0.0.1;Port=3306;Database=techspark;User ID=root;Password=;";
        private MySqlConnection connection;

        public Form8()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
            LoadFeedback();
        }

        private void LoadFeedback()
        {
            try
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id, feedback_text FROM feedback", connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewFeedback.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading feedback: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
