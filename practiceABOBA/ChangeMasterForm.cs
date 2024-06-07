using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ServiceDeskApp
{
    public partial class ChangeMasterForm : Form
    {
        private static string connectionString = "Data Source=applications.db;Version=3;";

        public ChangeMasterForm()
        {
            InitializeComponent();
        }

        private void btnUpdateMaster_Click(object sender, EventArgs e)
        {
            int applicationId;
            string masterName = txtMasterName.Text;

            if (int.TryParse(txtApplicationId.Text, out applicationId) && !string.IsNullOrEmpty(masterName))
            {
                bool success = UpdateMaster(applicationId, masterName);
                if (success)
                {
                    MessageBox.Show("Мастер успешно обновлен.");
                }
                else
                {
                    MessageBox.Show("Не удалось обновить мастера. Проверьте номер заявки.");
                }
            }
            else
            {
                MessageBox.Show("Введите корректный номер заявки и имя мастера.");
            }
        }

        private bool UpdateMaster(int applicationId, string masterName)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE Applications SET Master = @Master WHERE ApplicationNumber = @ApplicationNumber";

                using (var command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Master", masterName);
                    command.Parameters.AddWithValue("@ApplicationNumber", applicationId);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
