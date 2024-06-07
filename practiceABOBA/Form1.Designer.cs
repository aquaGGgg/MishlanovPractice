namespace ServiceDeskApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAddApplication;
        private System.Windows.Forms.DataGridView dataGridViewApplications;
        private System.Windows.Forms.ComboBox cmbStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnAddApplication = new System.Windows.Forms.Button();
            this.dataGridViewApplications = new System.Windows.Forms.DataGridView();
            this.cmbStatus = new System.Windows.Forms.ComboBox();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplications)).BeginInit();
            this.SuspendLayout();

            // 
            // btnAddApplication
            // 
            this.btnAddApplication.Location = new System.Drawing.Point(12, 12);
            this.btnAddApplication.Name = "btnAddApplication";
            this.btnAddApplication.Size = new System.Drawing.Size(150, 23);
            this.btnAddApplication.TabIndex = 0;
            this.btnAddApplication.Text = "Добавить заявку";
            this.btnAddApplication.UseVisualStyleBackColor = true;
            this.btnAddApplication.Click += new System.EventHandler(this.btnAddApplication_Click);

            // 
            // dataGridViewApplications
            // 
            this.dataGridViewApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewApplications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "ApplicationNumber", HeaderText = "Номер заявки" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "DateAdded", HeaderText = "Дата добавления" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "DateCompleted", HeaderText = "Дата завершения" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "TypeOfEquipment", HeaderText = "Тип оборудования" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "Model", HeaderText = "Модель" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "ProblemDescription", HeaderText = "Описание проблемы" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "ClientLastName", HeaderText = "Фамилия клиента" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "ClientFirstName", HeaderText = "Имя клиента" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "ClientMiddleName", HeaderText = "Отчество клиента" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "PhoneNumber", HeaderText = "Номер телефона" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "Status", HeaderText = "Статус" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "Master", HeaderText = "Мастер" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "Comments", HeaderText = "Комментарии" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "OrderedParts", HeaderText = "Заказанные запчасти" }
            });
            this.dataGridViewApplications.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewApplications.Name = "dataGridViewApplications";
            this.dataGridViewApplications.Size = new System.Drawing.Size(776, 397);
            this.dataGridViewApplications.TabIndex = 1;

            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(168, 14);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 2;

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.dataGridViewApplications);
            this.Controls.Add(this.btnAddApplication);
            this.Name = "Form1";
            this.Text = "Service Desk";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplications)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
