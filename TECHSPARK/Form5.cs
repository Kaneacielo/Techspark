
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace TECHSPARK
{
    public partial class Form5 : Form
    {
        private readonly string connectionString = "Server=127.0.0.1;Port=3306;Database=techspark;User ID=root;Password=;";

        private MySqlConnection connection;
        private int selectRow;
        private int rowIndex;

        public Form5()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
            LoadParkingReservations();
        }

        private void LoadParkingReservations()
        {
            try
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT pr.*, uc.Username FROM ParkingReservations pr INNER JOIN usercredentials uc ON pr.user_credentials_id = uc.ID", connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewHistory.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading parking reservations: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (MySqlCommand command = new MySqlCommand("INSERT INTO ParkingReservations (plate_number, slot_number, checkout_time, date, user_credentials_id) VALUES (@PlateNumber, @SlotNumber, @CheckoutTime, @Date, @ID);", connection))
                {
                    command.Parameters.AddWithValue("@PlateNumber", txtPlateNumber.Text);
                    command.Parameters.AddWithValue("@SlotNumber", 1);
                    command.Parameters.AddWithValue("@CheckoutTime", DBNull.Value);
                    command.Parameters.AddWithValue("@Date", DateTime.Now);
                    command.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));

                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Reservation added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadParkingReservations();
                    ClearTextBoxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            edit();
            if (dataGridViewHistory.SelectedCells.Count > 0)
            {
                var editedValue = dataGridViewHistory.Rows[selectRow].Cells[rowIndex].Value.ToString();

                string query = $"UPDATE techspark.parkingreservations SET `{dataGridViewHistory.Columns[rowIndex].Name}` = @editedValue WHERE id = @ID";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {

                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    cmd.Parameters.AddWithValue("@editedValue", editedValue);
                    cmd.Parameters.AddWithValue("@ID", dataGridViewHistory.Rows[selectRow].Cells["id"].Value);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Updated!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }

                dataGridViewHistory.Rows[selectRow].Cells[rowIndex].Style.BackColor = Color.Red;
                dataGridViewHistory.ReadOnly = false;
            }
            else
            {
                MessageBox.Show("Please select a cell to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                connection.Close();
            }

      
       
        }

        public void edit()
        {

            if (dataGridViewHistory.SelectedCells.Count > 0)
            {
                selectRow = dataGridViewHistory.SelectedCells[0].RowIndex;
                rowIndex = dataGridViewHistory.SelectedCells[0].ColumnIndex;

                dataGridViewHistory.ReadOnly = false;
                dataGridViewHistory.Rows[selectRow].Cells[rowIndex].ReadOnly = false;
                dataGridViewHistory.Rows[selectRow].Cells[rowIndex].Style.BackColor = Color.Red;
            }
            else
            {
                MessageBox.Show("Please select a cell to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                string connection = "datasource=localhost;port=3306;username=root;password=''";
                if (dataGridViewHistory.SelectedRows.Count > 0)
                {
                    var dataID = int.Parse(dataGridViewHistory.SelectedRows[0].Cells["id"].FormattedValue.ToString());

                    DialogResult result = MessageBox.Show("Do you want to delete this row of data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        using (MySqlConnection conn = new MySqlConnection(connection))
                        {
                            conn.Open();
                            string query = "DELETE FROM techspark.ParkingReservations WHERE id = @dataID";
                            MySqlCommand cmd = new MySqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@dataID", dataID);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Data Deleted!");
                            conn.Close();
                            dataGridViewHistory.Rows.Remove(dataGridViewHistory.SelectedRows[0]);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnRetrieve_Click_1(object sender, EventArgs e)
        {
            LoadParkingReservations();
        }

        private void ClearTextBoxes()
        {
            txtPlateNumber.Text = "";
            txtSlotNumber.Text = "";
            txtCheckoutTime.Text = "";
            txtDate.Text = "";
        }

        private void dataGridViewHistory_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewHistory.Rows[e.RowIndex];

                row.Cells["id"].Value.ToString();
                txtPlateNumber.Text = row.Cells["plate_number"].Value.ToString();
                txtSlotNumber.Text = row.Cells["slot_number"].Value.ToString();
                row.Cells["checkin_time"].Value.ToString();
                txtCheckoutTime.Text = row.Cells["checkout_time"].Value.ToString();
                txtDate.Text = row.Cells["date"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM ParkingReservations;", connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewHistory.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading parking reservations: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}