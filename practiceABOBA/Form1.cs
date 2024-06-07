using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ServiceDeskApp
{
    public partial class Form1 : Form
    {
        private static string connectionString = "Data Source=applications.db;Version=3;";

        public Form1()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadApplicationsFromDatabase();
        }

        private void btnAddApplication_Click(object sender, EventArgs e)
        {
            AddApplicationForm addForm = new AddApplicationForm();
            addForm.ShowDialog();
            LoadApplicationsFromDatabase();
        }


        private void LoadApplicationsFromDatabase()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM Applications";

                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        dataGridViewApplications.Rows.Clear();
                        while (reader.Read())
                        {
                            dataGridViewApplications.Rows.Add(
                                reader["ApplicationNumber"],
                                reader["DateAdded"],
                                reader["DateCompleted"],
                                reader["TypeOfEquipment"],
                                reader["Model"],
                                reader["ProblemDescription"],
                                reader["ClientLastName"],
                                reader["ClientFirstName"],
                                reader["ClientMiddleName"],
                                reader["PhoneNumber"],
                                ((ApplicationStatus)Convert.ToInt32(reader["Status"])).ToString(),
                                reader["Master"],
                                reader["Comments"],
                                reader["OrderedParts"]
                            );
                        }
                    }
                }
            }
        }

        private void InitializeDatabase()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS Applications (
                    ApplicationNumber INTEGER PRIMARY KEY AUTOINCREMENT,
                    DateAdded TEXT,
                    DateCompleted TEXT,
                    TypeOfEquipment TEXT,
                    Model TEXT,
                    ProblemDescription TEXT,
                    ClientLastName TEXT,
                    ClientFirstName TEXT,
                    ClientMiddleName TEXT,
                    PhoneNumber TEXT,
                    Status INTEGER,
                    Master TEXT,
                    Comments TEXT,
                    OrderedParts TEXT
                )";

                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
