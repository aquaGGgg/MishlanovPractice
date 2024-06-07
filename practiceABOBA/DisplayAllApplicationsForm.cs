using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ServiceDeskApp
{
    public partial class DisplayAllApplicationsForm : Form
    {
        private string connectionString = "Data Source=applications.db;Version=3;";

        public DisplayAllApplicationsForm()
        {
            InitializeComponent();
            LoadAllApplications();
        }

        private void LoadAllApplications()
        {
            lstApplications.Items.Clear();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM Applications";

                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new ListViewItem(reader["ApplicationNumber"].ToString());
                            item.SubItems.Add(reader["DateAdded"].ToString());
                            item.SubItems.Add(reader["TypeOfEquipment"].ToString());
                            item.SubItems.Add(reader["Model"].ToString());
                            item.SubItems.Add(reader["ProblemDescription"].ToString());
                            item.SubItems.Add($"{reader["ClientLastName"]} {reader["ClientFirstName"]} {reader["ClientMiddleName"]}");
                            item.SubItems.Add(reader["PhoneNumber"].ToString());
                            item.SubItems.Add(reader["Master"].ToString());
                            item.SubItems.Add(((ApplicationStatus)Convert.ToInt32(reader["Status"])).ToString());
                            item.SubItems.Add(reader["Comments"].ToString());
                            item.SubItems.Add(reader["OrderedParts"].ToString());
                            item.SubItems.Add(reader["DateCompleted"] == DBNull.Value ? "Не завершена" : reader["DateCompleted"].ToString());

                            lstApplications.Items.Add(item);
                        }
                    }
                }
            }
        }
    }
}
