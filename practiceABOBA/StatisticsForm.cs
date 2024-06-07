using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ServiceDeskApp
{
    public partial class StatisticsForm : Form
    {
        private string connectionString = "Data Source=applications.db;Version=3;";

        public StatisticsForm()
        {
            InitializeComponent();
            LoadStatistics();
        }

        private void LoadStatistics()
        {
            // Заголовки столбцов
            dgvStatistics.ColumnCount = 4;
            dgvStatistics.Columns[0].Name = "Статус";
            dgvStatistics.Columns[1].Name = "Количество";
            dgvStatistics.Columns[2].Name = "Среднее время выполнения (дни)";
            dgvStatistics.Columns[3].Name = "Тип неисправности";

            // Словарь для хранения количества заявок по статусам
            Dictionary<ApplicationStatus, int> counts = new Dictionary<ApplicationStatus, int>();

            // Получение статистики из базы данных
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                foreach (ApplicationStatus status in Enum.GetValues(typeof(ApplicationStatus)))
                {
                    // Инициализация количества заявок для текущего статуса
                    counts[status] = 0;

                    using (var command = new SQLiteCommand("SELECT COUNT(*) FROM Applications WHERE Status = @Status", connection))
                    {
                        command.Parameters.AddWithValue("@Status", (int)status);
                        counts[status] = Convert.ToInt32(command.ExecuteScalar());
                    }
                }

                // Добавление данных по статусам
                foreach (ApplicationStatus status in Enum.GetValues(typeof(ApplicationStatus)))
                {
                    dgvStatistics.Rows.Add(status.ToString(), counts[status].ToString(), "", "");
                }

                // Добавление пустой строки для разделения
                dgvStatistics.Rows.Add("", "", "", "");

                // Добавление заголовка для типов неисправностей
                dgvStatistics.Rows.Add("Типы неисправностей", "", "", "");

                // Добавление статистики по типам неисправностей
                using (var command = new SQLiteCommand("SELECT TypeOfEquipment, COUNT(*) FROM Applications GROUP BY TypeOfEquipment", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvStatistics.Rows.Add("", "", "", reader.GetString(0) + ": " + reader.GetInt32(1).ToString());
                        }
                    }
                }
            }
        }
    }
}
