namespace ServiceDeskApp
{
    partial class Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface));
            this.btnAddApplication = new BlinkingButton();
            this.btnEditApplication = new BlinkingButton();
            this.btnSearchApplication = new BlinkingButton();
            this.btnShowAllApplications = new BlinkingButton();
            this.btnChangeMaster = new BlinkingButton();
            this.btnDisplayStatistics = new BlinkingButton();
            this.btnAddOrderedParts = new BlinkingButton();
            this.btnOpenMasterForm = new BlinkingButton();
            this.SuspendLayout();
            // 
            // btnAddApplication
            // 
            this.btnAddApplication.Location = new System.Drawing.Point(12, 12);
            this.btnAddApplication.Name = "btnAddApplication";
            this.btnAddApplication.Size = new System.Drawing.Size(145, 23);
            this.btnAddApplication.TabIndex = 0;
            this.btnAddApplication.Text = "Добавить заявку";
            this.btnAddApplication.UseVisualStyleBackColor = true;
            this.btnAddApplication.Click += new System.EventHandler(this.btnAddApplication_Click);
            // 
            // btnEditApplication
            // 
            this.btnEditApplication.Location = new System.Drawing.Point(12, 41);
            this.btnEditApplication.Name = "btnEditApplication";
            this.btnEditApplication.Size = new System.Drawing.Size(145, 23);
            this.btnEditApplication.TabIndex = 1;
            this.btnEditApplication.Text = "Редактировать заявку";
            this.btnEditApplication.UseVisualStyleBackColor = true;
            this.btnEditApplication.Click += new System.EventHandler(this.btnEditApplication_Click);
            // 
            // btnSearchApplication
            // 
            this.btnSearchApplication.Location = new System.Drawing.Point(12, 70);
            this.btnSearchApplication.Name = "btnSearchApplication";
            this.btnSearchApplication.Size = new System.Drawing.Size(145, 23);
            this.btnSearchApplication.TabIndex = 2;
            this.btnSearchApplication.Text = "Поиск заявки";
            this.btnSearchApplication.UseVisualStyleBackColor = true;
            this.btnSearchApplication.Click += new System.EventHandler(this.btnSearchApplication_Click);
            // 
            // btnShowAllApplications
            // 
            this.btnShowAllApplications.Location = new System.Drawing.Point(12, 99);
            this.btnShowAllApplications.Name = "btnShowAllApplications";
            this.btnShowAllApplications.Size = new System.Drawing.Size(145, 23);
            this.btnShowAllApplications.TabIndex = 3;
            this.btnShowAllApplications.Text = "Показать все заявки";
            this.btnShowAllApplications.UseVisualStyleBackColor = true;
            this.btnShowAllApplications.Click += new System.EventHandler(this.btnShowAllApplications_Click);
            // 
            // btnChangeMaster
            // 
            this.btnChangeMaster.Location = new System.Drawing.Point(12, 128);
            this.btnChangeMaster.Name = "btnChangeMaster";
            this.btnChangeMaster.Size = new System.Drawing.Size(145, 23);
            this.btnChangeMaster.TabIndex = 4;
            this.btnChangeMaster.Text = "Изменить мастера";
            this.btnChangeMaster.UseVisualStyleBackColor = true;
            this.btnChangeMaster.Click += new System.EventHandler(this.btnChangeMaster_Click);
            // 
            // btnDisplayStatistics
            // 
            this.btnDisplayStatistics.Location = new System.Drawing.Point(12, 157);
            this.btnDisplayStatistics.Name = "btnDisplayStatistics";
            this.btnDisplayStatistics.Size = new System.Drawing.Size(145, 23);
            this.btnDisplayStatistics.TabIndex = 5;
            this.btnDisplayStatistics.Text = "Показать статистику";
            this.btnDisplayStatistics.UseVisualStyleBackColor = true;
            this.btnDisplayStatistics.Click += new System.EventHandler(this.btnDisplayStatistics_click);
            // 
            // btnAddOrderedParts
            // 
            this.btnAddOrderedParts.Location = new System.Drawing.Point(42, 186);
            this.btnAddOrderedParts.Name = "btnAddOrderedParts";
            this.btnAddOrderedParts.Size = new System.Drawing.Size(75, 23);
            this.btnAddOrderedParts.TabIndex = 6;
            // 
            // btnOpenMasterForm
            // 
            this.btnOpenMasterForm.Location = new System.Drawing.Point(12, 186);
            this.btnOpenMasterForm.Name = "btnOpenMasterForm";
            this.btnOpenMasterForm.Size = new System.Drawing.Size(145, 23);
            this.btnOpenMasterForm.TabIndex = 7;
            this.btnOpenMasterForm.Text = "Комментарий + запчасти";
            this.btnOpenMasterForm.UseVisualStyleBackColor = true;
            this.btnOpenMasterForm.Click += new System.EventHandler(this.btnOpenMasterForm_Click);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(169, 221);
            this.Controls.Add(this.btnOpenMasterForm);
            this.Controls.Add(this.btnAddOrderedParts);
            this.Controls.Add(this.btnDisplayStatistics);
            this.Controls.Add(this.btnChangeMaster);
            this.Controls.Add(this.btnShowAllApplications);
            this.Controls.Add(this.btnSearchApplication);
            this.Controls.Add(this.btnEditApplication);
            this.Controls.Add(this.btnAddApplication);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Interface";
            this.Text = "Выбор действия";
            this.ResumeLayout(false);

        }

        #endregion
        private BlinkingButton btnOpenMasterForm;
        private BlinkingButton btnAddApplication;
        private BlinkingButton btnEditApplication;
        private BlinkingButton btnSearchApplication;
        private BlinkingButton btnShowAllApplications;
        private BlinkingButton btnChangeMaster;
        private BlinkingButton btnDisplayStatistics;
        private BlinkingButton btnAddOrderedParts;
    }
}
