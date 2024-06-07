namespace ServiceDeskApp
{
    partial class DisplayAllApplicationsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayAllApplicationsForm));
            this.lstApplications = new System.Windows.Forms.ListView();
            this.columnApplicationNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDateAdded = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTypeOfEquipment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnProblemDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnClientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMaster = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnComments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOrderedParts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDateCompleted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstApplications
            // 
            this.lstApplications.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnApplicationNumber,
            this.columnDateAdded,
            this.columnTypeOfEquipment,
            this.columnModel,
            this.columnProblemDescription,
            this.columnClientName,
            this.columnPhoneNumber,
            this.columnMaster,
            this.columnStatus,
            this.columnComments,
            this.columnOrderedParts,
            this.columnDateCompleted});
            this.lstApplications.FullRowSelect = true;
            this.lstApplications.GridLines = true;
            this.lstApplications.HideSelection = false;
            this.lstApplications.Location = new System.Drawing.Point(12, 12);
            this.lstApplications.Name = "lstApplications";
            this.lstApplications.Size = new System.Drawing.Size(960, 537);
            this.lstApplications.TabIndex = 0;
            this.lstApplications.UseCompatibleStateImageBehavior = false;
            this.lstApplications.View = System.Windows.Forms.View.Details;
            // 
            // columnApplicationNumber
            // 
            this.columnApplicationNumber.Text = "Номер заявки";
            this.columnApplicationNumber.Width = 100;
            // 
            // columnDateAdded
            // 
            this.columnDateAdded.Text = "Дата добавления";
            this.columnDateAdded.Width = 120;
            // 
            // columnTypeOfEquipment
            // 
            this.columnTypeOfEquipment.Text = "Вид оргтехники";
            this.columnTypeOfEquipment.Width = 120;
            // 
            // columnModel
            // 
            this.columnModel.Text = "Модель";
            this.columnModel.Width = 100;
            // 
            // columnProblemDescription
            // 
            this.columnProblemDescription.Text = "Описание проблемы";
            this.columnProblemDescription.Width = 200;
            // 
            // columnClientName
            // 
            this.columnClientName.Text = "ФИО клиента";
            this.columnClientName.Width = 150;
            // 
            // columnPhoneNumber
            // 
            this.columnPhoneNumber.Text = "Телефон";
            this.columnPhoneNumber.Width = 100;
            // 
            // columnMaster
            // 
            this.columnMaster.Text = "Мастер";
            this.columnMaster.Width = 100;
            // 
            // columnStatus
            // 
            this.columnStatus.Text = "Статус";
            this.columnStatus.Width = 100;
            // 
            // columnComments
            // 
            this.columnComments.Text = "Комментарии";
            this.columnComments.Width = 200;
            // 
            // columnOrderedParts
            // 
            this.columnOrderedParts.Text = "Заказанные запчасти";
            this.columnOrderedParts.Width = 200;
            // 
            // columnDateCompleted
            // 
            this.columnDateCompleted.Text = "Дата завершения";
            this.columnDateCompleted.Width = 120;
            // 
            // DisplayAllApplicationsForm
            // 
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.lstApplications);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DisplayAllApplicationsForm";
            this.Text = "Все заявки";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstApplications;
        private System.Windows.Forms.ColumnHeader columnApplicationNumber;
        private System.Windows.Forms.ColumnHeader columnDateAdded;
        private System.Windows.Forms.ColumnHeader columnTypeOfEquipment;
        private System.Windows.Forms.ColumnHeader columnModel;
        private System.Windows.Forms.ColumnHeader columnProblemDescription;
        private System.Windows.Forms.ColumnHeader columnClientName;
        private System.Windows.Forms.ColumnHeader columnPhoneNumber;
        private System.Windows.Forms.ColumnHeader columnMaster;
        private System.Windows.Forms.ColumnHeader columnStatus;
        private System.Windows.Forms.ColumnHeader columnComments;
        private System.Windows.Forms.ColumnHeader columnOrderedParts;
        private System.Windows.Forms.ColumnHeader columnDateCompleted;
    }
}
