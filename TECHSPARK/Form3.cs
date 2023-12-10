using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace TECHSPARK
{
    public partial class Form3 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password='';database=techspark");
        MySqlCommand command;
        MySqlDataReader mdr;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    connection.Open();
                    string selectQuery = "SELECT * FROM UserCredentials WHERE BINARY Username = @Username AND BINARY Password = @Password";
                    command = new MySqlCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    mdr = command.ExecuteReader();

                    if (mdr.Read())
                    {
                        MessageBox.Show("Login Successful!");

                        int userId = Convert.ToInt32(mdr["ID"]);
                        Form4 form4 = new Form4(userId);
                        form4.Show();

                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Incorrect Login Information! Try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    mdr?.Close();
                    connection.Close();
                }

                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}