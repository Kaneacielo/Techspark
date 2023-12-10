using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECHSPARK
{
    public class ParkingSpotManager
    {
        private DataTable dataTable;
        private MySqlDataAdapter dataAdapter;
        private MySqlCommand command;

        public ParkingSpotManager()
        {
            // Initialize your fields here or in a separate method.
            dataTable = new DataTable();
            dataAdapter = new MySqlDataAdapter();
            command = new MySqlCommand();
        }

        // Add your methods for managing parking spots
        // For example:
        public bool IsSpotOccupied(int spotNumber)
        {
            // Implement the logic to check if a spot is occupied
            return false;
        }

        public List<int> GetAvailableSpots()
        {
            // Implement the logic to get available spots
            return new List<int>();
        }

        // Add other methods as needed
    }


}
