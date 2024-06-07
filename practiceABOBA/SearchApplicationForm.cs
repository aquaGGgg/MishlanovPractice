using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ServiceDeskApp
{
    public partial class SearchApplicationForm : Form
    {
        private static string connectionString = "Data Source=applications.db;Version=3;";

        public SearchApplicationForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int applicationId;
            if (int.TryParse(txtApplicationId.Text, out applicationId))
            {
                var application = SearchApplicationById(applicationId);
                if (application != null)
                {
                    lblResult.Text = $"Номер заявки: {application.ApplicationNumber}\n" +
                                     $"Дата добавления: {application.DateAdded}\n" +
                                     $"Вид оборудования: {application.TypeOfEquipment}\n" +
                                     $"Модель: {application.Model}\n" +
                                     $"Описание проблемы: {application.ProblemDescription}\n" +
                                     $"Фамилия клиента: {application.ClientLastName}\n" +
                                     $"Имя клиента: {application.ClientFirstName}\n" +
                                     $"Отчество клиента: {application.ClientMiddleName}\n" +
                                     $"Телефон клиента: {application.PhoneNumber}\n" +
                                     $"Статус: {application.Status}\n" +
                                     $"Мастер: {application.Master}\n" +
                                     $"Комментарии: {application.Comments}\n" +
                                     $"Заказанные запчасти: {application.OrderedParts}\n" +
                                     $"Дата завершения: {application.DateCompleted}";
                }
                else
                {
                    lblResult.Text = "Заявка не найдена.";
                }
            }
            else
            {
                MessageBox.Show("Введите корректный ID заявки.");
            }
        }

        private Application SearchApplicationById(int applicationId)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM Applications WHERE ApplicationNumber = @ApplicationNumber";

                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationNumber", applicationId);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Application
                            {
                                ApplicationNumber = Convert.ToInt32(reader["ApplicationNumber"]),
                                DateAdded = DateTime.Parse(reader["DateAdded"].ToString()),
                                DateCompleted = reader["DateCompleted"] == DBNull.Value ? (DateTime?)null : DateTime.Parse(reader["DateCompleted"].ToString()),
                                TypeOfEquipment = reader["TypeOfEquipment"].ToString(),
                                Model = reader["Model"].ToString(),
                                ProblemDescription = reader["ProblemDescription"].ToString(),
                                ClientLastName = reader["ClientLastName"].ToString(),
                                ClientFirstName = reader["ClientFirstName"].ToString(),
                                ClientMiddleName = reader["ClientMiddleName"].ToString(),
                                PhoneNumber = reader["PhoneNumber"].ToString(),
                                Status = (ApplicationStatus)Convert.ToInt32(reader["Status"]),
                                Master = reader["Master"].ToString(),
                                Comments = reader["Comments"].ToString(),
                                OrderedParts = reader["OrderedParts"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}
