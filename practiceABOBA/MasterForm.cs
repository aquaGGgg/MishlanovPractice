using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ServiceDeskApp
{
    public partial class MasterForm : Form
    {
        private static string connectionString = "Data Source=database.db;Version=3;";

        public MasterForm()
        {
            InitializeComponent();
        }

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            int applicationId;
            if (!int.TryParse(txtApplicationId.Text, out applicationId))
            {
                MessageBox.Show("Некорректный формат ID заявки.");
                return;
            }

            string comment = txtComment.Text;

            if (string.IsNullOrWhiteSpace(comment))
            {
                MessageBox.Show("Пожалуйста, введите комментарий.");
                return;
            }

            AddComment(applicationId, comment);
        }

        private void btnOrderParts_Click(object sender, EventArgs e)
        {
            int applicationId;
            if (!int.TryParse(txtApplicationId.Text, out applicationId))
            {
                MessageBox.Show("Некорректный формат ID заявки.");
                return;
            }

            string orderedParts = txtOrderedParts.Text;

            if (string.IsNullOrWhiteSpace(orderedParts))
            {
                MessageBox.Show("Пожалуйста, укажите заказанные запчасти и материалы.");
                return;
            }

            OrderParts(applicationId, orderedParts);
        }

        private static void AddComment(int applicationId, string comment)
            
        {
            string databasePath = @"D:\кодики\practiceABOBA\practiceABOBA\bin\Debug\applications.db";
        string connectionString = $"Data Source={databasePath};Version=3;";
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE Applications SET Comments = @Comment WHERE ApplicationNumber = @ApplicationId";

                using (var command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Comment", comment);
                    command.Parameters.AddWithValue("@ApplicationId", applicationId);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Комментарий успешно добавлен.");
                    }
                    else
                    {
                        MessageBox.Show("Не удалось найти заявку с указанным ID.");
                    }
                }
            }
        }

        private static void OrderParts(int applicationId, string orderedParts)
        {
            string databasePath = @"D:\кодики\practiceABOBA\practiceABOBA\bin\Debug\applications.db";
            string connectionString = $"Data Source={databasePath};Version=3;";
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE Applications SET OrderedParts = @OrderedParts WHERE ApplicationNumber = @ApplicationId";

                using (var command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@OrderedParts", orderedParts);
                    command.Parameters.AddWithValue("@ApplicationId", applicationId);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Информация о заказанных запчастях и материалах успешно обновлена.");
                    }
                    else
                    {
                        MessageBox.Show("Не удалось найти заявку с указанным ID.");
                    }
                }
            }
        }
    }
}
