namespace ServiceDeskApp
{
    partial class ChangeMasterForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtApplicationId;
        private System.Windows.Forms.TextBox txtMasterName;
        private System.Windows.Forms.Button btnUpdateMaster;
        private System.Windows.Forms.Label lblApplicationId;
        private System.Windows.Forms.Label lblMasterName;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeMasterForm));
            this.txtApplicationId = new System.Windows.Forms.TextBox();
            this.txtMasterName = new System.Windows.Forms.TextBox();
            this.btnUpdateMaster = new System.Windows.Forms.Button();
            this.lblApplicationId = new System.Windows.Forms.Label();
            this.lblMasterName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtApplicationId
            // 
            this.txtApplicationId.Location = new System.Drawing.Point(15, 25);
            this.txtApplicationId.Name = "txtApplicationId";
            this.txtApplicationId.Size = new System.Drawing.Size(200, 20);
            this.txtApplicationId.TabIndex = 0;
            // 
            // txtMasterName
            // 
            this.txtMasterName.Location = new System.Drawing.Point(15, 65);
            this.txtMasterName.Name = "txtMasterName";
            this.txtMasterName.Size = new System.Drawing.Size(200, 20);
            this.txtMasterName.TabIndex = 1;
            // 
            // btnUpdateMaster
            // 
            this.btnUpdateMaster.Location = new System.Drawing.Point(15, 100);
            this.btnUpdateMaster.Name = "btnUpdateMaster";
            this.btnUpdateMaster.Size = new System.Drawing.Size(200, 23);
            this.btnUpdateMaster.TabIndex = 2;
            this.btnUpdateMaster.Text = "Изменить мастера";
            this.btnUpdateMaster.UseVisualStyleBackColor = true;
            this.btnUpdateMaster.Click += new System.EventHandler(this.btnUpdateMaster_Click);
            // 
            // lblApplicationId
            // 
            this.lblApplicationId.AutoSize = true;
            this.lblApplicationId.Location = new System.Drawing.Point(12, 9);
            this.lblApplicationId.Name = "lblApplicationId";
            this.lblApplicationId.Size = new System.Drawing.Size(80, 13);
            this.lblApplicationId.TabIndex = 3;
            this.lblApplicationId.Text = "Номер заявки";
            // 
            // lblMasterName
            // 
            this.lblMasterName.AutoSize = true;
            this.lblMasterName.Location = new System.Drawing.Point(12, 49);
            this.lblMasterName.Name = "lblMasterName";
            this.lblMasterName.Size = new System.Drawing.Size(75, 13);
            this.lblMasterName.TabIndex = 4;
            this.lblMasterName.Text = "Имя мастера";
            // 
            // ChangeMasterForm
            // 
            this.ClientSize = new System.Drawing.Size(234, 141);
            this.Controls.Add(this.lblMasterName);
            this.Controls.Add(this.lblApplicationId);
            this.Controls.Add(this.btnUpdateMaster);
            this.Controls.Add(this.txtMasterName);
            this.Controls.Add(this.txtApplicationId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangeMasterForm";
            this.Text = "Изменить мастера";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
