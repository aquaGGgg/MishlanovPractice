using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ServiceDeskApp
{


    public partial class UserTrackingForm : Form
    {
        private static string connectionString = "Data Source=applications.db;Version=3;";

        public UserTrackingForm()
        {
            InitializeComponent();
        }

        private void btnTrackOrder_Click(object sender, EventArgs e)
        {
            int applicationNumber;
            if (!int.TryParse(txtApplicationNumber.Text, out applicationNumber))
            {
                MessageBox.Show("Некорректный номер заявки.");
                return;
            }

            TrackOrder(applicationNumber);
        }

        private void TrackOrder(int applicationNumber)
        {
            string databasePath = @"applications.db";
            string connectionString = $"Data Source={databasePath};Version=3;";
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Applications WHERE ApplicationNumber = @ApplicationNumber";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationNumber", applicationNumber);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string statusString = reader["Status"].ToString();
                            ApplicationStatus status;
                            if (Enum.TryParse(statusString, out status))
                            {
                                MessageBox.Show($"Статус вашей заявки: {status}");
                            }
                            else
                            {
                                MessageBox.Show("Не удалось определить статус заявки.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Заявка с указанным номером не найдена.");
                        }
                    }
                }
            }
        }
    }
}
