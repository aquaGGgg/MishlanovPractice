using System;
using System.Windows.Forms;

namespace ServiceDeskApp
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();

        }

        private void btnAddApplication_Click(object sender, EventArgs e)
        {
            AddApplicationForm addForm = new AddApplicationForm();
            addForm.Show();
        }

        private void btnEditApplication_Click(object sender, EventArgs e)
        {
            // Открываем форму для редактирования заявки
            EditApplicationForm editForm = new EditApplicationForm();
            editForm.Show();
        }

        private void btnSearchApplication_Click(object sender, EventArgs e)
        {
            // Открываем форму для поиска заявки по номеру
            SearchApplicationForm searchForm = new SearchApplicationForm();
            searchForm.Show();
        }

        private void btnShowAllApplications_Click(object sender, EventArgs e)
        {
            // Открываем форму для отображения всех заявок
            DisplayAllApplicationsForm displayAllForm = new DisplayAllApplicationsForm();
            displayAllForm.Show();
        }
        private void btnChangeMaster_Click(object sender, EventArgs e)
        {
            ChangeMasterForm changeMasterForm = new ChangeMasterForm();
            changeMasterForm.ShowDialog();
        }


        public interface IMainForm
        {
            event EventHandler AddCommentRequested;
        }

        private void btnDisplayStatistics_click(object sender, EventArgs e)
        {
            StatisticsForm statisticsForm = new StatisticsForm();
            statisticsForm.ShowDialog();
        }

        private void btnOpenMasterForm_Click(object sender, EventArgs e)
        {
            MasterForm masterForm = new MasterForm();
            masterForm.ShowDialog();
        }

    }
}
