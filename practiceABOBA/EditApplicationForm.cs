using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ServiceDeskApp
{
    public partial class EditApplicationForm : Form
    {
        private static string connectionString = "Data Source=applications.db;Version=3;";

        public EditApplicationForm()
        {
            InitializeComponent();
            InitializeStatusComboBox();
        }

        private void InitializeStatusComboBox()
        {
            cmbStatus.DataSource = Enum.GetValues(typeof(ApplicationStatus))
                                       .Cast<ApplicationStatus>()
                                       .Select(e => e.ToString())
                                       .ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int applicationNumber;
            if (int.TryParse(txtApplicationNumber.Text, out applicationNumber))
            {
                string newDescription = txtDescription.Text;
                ApplicationStatus newStatus;
                if (Enum.TryParse<ApplicationStatus>(cmbStatus.SelectedValue.ToString(), out newStatus))
                {
                    EditApplication(applicationNumber, newDescription, newStatus);
                    MessageBox.Show("Заявка успешно обновлена!");

                    // Если статус изменился на "Завершена", показываем уведомление
                    if (newStatus == ApplicationStatus.Завершена)
                    {
                        ShowCompletionNotification(applicationNumber);
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите правильный статус.");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите правильный номер заявки.");
            }
        }

        private void EditApplication(int applicationNumber, string newDescription, ApplicationStatus newStatus)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string updateQuery = @"
                    UPDATE Applications
                    SET ProblemDescription = @ProblemDescription, Status = @Status, DateCompleted = @DateCompleted
                    WHERE ApplicationNumber = @ApplicationNumber";

                using (var command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@ProblemDescription", newDescription);
                    command.Parameters.AddWithValue("@Status", (int)newStatus);
                    command.Parameters.AddWithValue("@DateCompleted", newStatus == ApplicationStatus.Завершена ? (object)DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") : DBNull.Value);
                    command.Parameters.AddWithValue("@ApplicationNumber", applicationNumber);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void ShowCompletionNotification(int applicationNumber)
        {
            NotificationForm notificationForm = new NotificationForm($"Заявка №{applicationNumber} завершена!");
            notificationForm.Show();
        }
    }
}
