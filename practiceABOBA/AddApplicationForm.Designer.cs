using System.Drawing;
using System.Windows.Forms;


namespace ServiceDeskApp
{
    partial class AddApplicationForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTypeOfEquipment;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnAdd;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddApplicationForm));
            this.txtTypeOfEquipment = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTypeOfEquipment = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTypeOfEquipment
            // 
            this.txtTypeOfEquipment.Location = new System.Drawing.Point(124, 8);
            this.txtTypeOfEquipment.Name = "txtTypeOfEquipment";
            this.txtTypeOfEquipment.Size = new System.Drawing.Size(260, 20);
            this.txtTypeOfEquipment.TabIndex = 0;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(124, 34);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(260, 20);
            this.txtModel.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(124, 60);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(260, 20);
            this.txtDescription.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(124, 86);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(260, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(124, 112);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(260, 20);
            this.txtFirstName.TabIndex = 4;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(124, 138);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(260, 20);
            this.txtMiddleName.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(124, 164);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(260, 20);
            this.txtPhone.TabIndex = 6;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(124, 190);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(260, 21);
            this.cmbStatus.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(124, 226);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(260, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Добавить заявку";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTypeOfEquipment
            // 
            this.lblTypeOfEquipment.AutoSize = true;
            this.lblTypeOfEquipment.Location = new System.Drawing.Point(15, 11);
            this.lblTypeOfEquipment.Name = "lblTypeOfEquipment";
            this.lblTypeOfEquipment.Size = new System.Drawing.Size(103, 13);
            this.lblTypeOfEquipment.TabIndex = 0;
            this.lblTypeOfEquipment.Text = "Тип оборудования:";
            this.lblTypeOfEquipment.Click += new System.EventHandler(this.lblTypeOfEquipment_Click);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(66, 37);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(49, 13);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Модель:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(3, 60);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(115, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Описание проблемы:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(15, 89);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(103, 13);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Фамилия клиента:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(42, 115);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 13);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "Имя клиента:";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(17, 141);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(101, 13);
            this.lblMiddleName.TabIndex = 5;
            this.lblMiddleName.Text = "Отчество клиента:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(19, 167);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(99, 13);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Телефон клиента:";
            this.lblPhone.Click += new System.EventHandler(this.lblPhone_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(74, 190);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 13);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Статус:";
            // 
            // AddApplicationForm
            // 
            this.ClientSize = new System.Drawing.Size(396, 265);
            this.Controls.Add(this.lblTypeOfEquipment);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtTypeOfEquipment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddApplicationForm";
            this.Text = "Добавить заявку";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label lblTypeOfEquipment;
        private Label lblModel;
        private Label lblDescription;
        private Label lblLastName;
        private Label lblFirstName;
        private Label lblMiddleName;
        private Label lblPhone;
        private Label lblStatus;
    }
}
