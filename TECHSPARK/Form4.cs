using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing;

namespace TECHSPARK
{
    public partial class Form4 : Form
    {
        private const string ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password='';database=techspark";
        private MySqlConnection connection = new MySqlConnection(ConnectionString);
        private MySqlCommand command;
        private MySqlDataReader mdr;

        private Form6 form6;
        private int userId;

        public Form4(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            InitializePanelClickHandlers();

            form6 = new Form6();
            form6.Show();

            foreach (Panel panel in this.Controls.OfType<Panel>())
            {
                panel.Click += (sender, e) =>
                {
                    Panel panel6 = form6.Controls.Find(panel.Name, true).FirstOrDefault() as Panel;
                    if (panel6 != null)
                    {
                        panel6.BackColor = panel.BackColor;
                    }
                };
            }

            this.FormClosing += Form4_FormClosing;
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (form6 != null && !form6.IsDisposed)
            {
                form6.Close();
            }
            if (e.CloseReason != CloseReason.UserClosing)
            {
                return;
            }
        }

        private void InitializePanelClickHandlers()
        {
            for (int i = 1; i <= 6; i++)
            {
                Panel panel = Controls.Find($"panel{i}", true).FirstOrDefault() as Panel;

                if (panel != null)
                {
                    panel.Click += (sender, e) => ToggleAvailability(panel);
                }
            }
        }

        private void ToggleAvailability(Panel panel)
        {
            if (panel.BackColor == System.Drawing.Color.ForestGreen)
            {
                Console.WriteLine($"Spot {panel.Name} is occupied.");
                string plateNumber = PromptForPlateNumber();

                if (!string.IsNullOrEmpty(plateNumber))
                {
                    SaveReservationToDatabase(panel.Name, plateNumber);
                    panel.BackColor = Color.Transparent;
                    MessageBox.Show("Parking space is now unavailable", "Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                Console.WriteLine($"Spot {panel.Name} is unavailable.");
                DialogResult result = MessageBox.Show("Make this parking space available?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    panel.BackColor = System.Drawing.Color.ForestGreen;
                    SaveCheckoutToDatabase(panel.Name);

                    MessageBox.Show("Parking space is now available", "Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void SaveCheckoutToDatabase(string panelName)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    int slotNumber = GetSlotNumberForPanel(panelName);

                    string updateQuery = "UPDATE ParkingReservations SET checkout_time = @CheckoutTime, date = @Date, user_credentials_id = @UserId " +
                                         "WHERE slot_number = @SlotNumber AND checkout_time IS NULL";

                    using (MySqlCommand command = new MySqlCommand(updateQuery, conn))
                    {
                        command.Parameters.AddWithValue("@CheckoutTime", DateTime.Now);
                        command.Parameters.AddWithValue("@Date", DateTime.Now.Date);
                        command.Parameters.AddWithValue("@SlotNumber", slotNumber);
                        command.Parameters.AddWithValue("@UserId", userId); // Add user ID parameter
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Checkout time saved to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving checkout time: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string PromptForPlateNumber()
        {
            using (Form inputForm = new Form())
            {
                Label lblPrompt = new Label
                {
                    Text = "Please enter the plate number of the car:",
                    Location = new System.Drawing.Point(12, 20),
                    AutoSize = true
                };

                TextBox txtInput = new TextBox
                {
                    Location = new System.Drawing.Point(15, 50),
                    Size = new System.Drawing.Size(250, 20)
                };

                Button btnOK = new Button
                {
                    DialogResult = DialogResult.OK,
                    Text = "OK",
                    Location = new System.Drawing.Point(15, 80)
                };

                Button btnCancel = new Button
                {
                    DialogResult = DialogResult.Cancel,
                    Text = "Cancel",
                    Location = new System.Drawing.Point(100, 80)
                };

                btnOK.Click += (sender, e) =>
                {
                    inputForm.DialogResult = DialogResult.OK;
                    inputForm.Close();
                };

                inputForm.Text = "Enter Plate Number";
                inputForm.ClientSize = new System.Drawing.Size(280, 130);
                inputForm.Controls.AddRange(new Control[] { lblPrompt, txtInput, btnOK, btnCancel });

                DialogResult result = inputForm.ShowDialog();

                return result == DialogResult.OK ? txtInput.Text : null;
            }
        }

        private void SaveReservationToDatabase(string panelName, string plateNumber)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    int slotNumber = GetSlotNumberForPanel(panelName);

                    string insertQuery = "INSERT INTO ParkingReservations (plate_number, slot_number, checkin_time, user_credentials_id) " +
                                         "VALUES (@PlateNumber, @SlotNumber, @CheckinTime, @UserId)";

                    using (MySqlCommand command = new MySqlCommand(insertQuery, conn))
                    {
                        command.Parameters.AddWithValue("@PlateNumber", plateNumber);
                        command.Parameters.AddWithValue("@SlotNumber", slotNumber);
                        command.Parameters.AddWithValue("@CheckinTime", DateTime.Now);
                        command.Parameters.AddWithValue("@UserId", userId);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Reservation saved to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving reservation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetSlotNumberForPanel(string panelName)
        {
            switch (panelName)
            {
                case "panel1":
                    return 1;
                case "panel2":
                    return 2;
                case "panel3":
                    return 3;
                case "panel4":
                    return 4;
                case "panel5":
                    return 5;
                case "panel6":
                    return 6;

                default:
                    throw new ArgumentException("Invalid panel name");
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form6 != null && !form6.IsDisposed)
            {
                form6.Close();
            }

            this.Hide();
            Form1 loginPage = new Form1();
            loginPage.ShowDialog();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void feedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.ShowDialog();
        }
    }

}
