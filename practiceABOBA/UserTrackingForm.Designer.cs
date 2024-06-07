namespace ServiceDeskApp
{
    partial class UserTrackingForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblApplicationNumber;
        private System.Windows.Forms.TextBox txtApplicationNumber;
        private System.Windows.Forms.Button btnTrackOrder;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserTrackingForm));
            this.lblApplicationNumber = new System.Windows.Forms.Label();
            this.txtApplicationNumber = new System.Windows.Forms.TextBox();
            this.btnTrackOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblApplicationNumber
            // 
            this.lblApplicationNumber.AutoSize = true;
            this.lblApplicationNumber.Location = new System.Drawing.Point(12, 15);
            this.lblApplicationNumber.Name = "lblApplicationNumber";
            this.lblApplicationNumber.Size = new System.Drawing.Size(83, 13);
            this.lblApplicationNumber.TabIndex = 0;
            this.lblApplicationNumber.Text = "Номер заявки:";
            // 
            // txtApplicationNumber
            // 
            this.txtApplicationNumber.Location = new System.Drawing.Point(105, 12);
            this.txtApplicationNumber.Name = "txtApplicationNumber";
            this.txtApplicationNumber.Size = new System.Drawing.Size(167, 20);
            this.txtApplicationNumber.TabIndex = 1;
            // 
            // btnTrackOrder
            // 
            this.btnTrackOrder.Location = new System.Drawing.Point(105, 38);
            this.btnTrackOrder.Name = "btnTrackOrder";
            this.btnTrackOrder.Size = new System.Drawing.Size(75, 23);
            this.btnTrackOrder.TabIndex = 2;
            this.btnTrackOrder.Text = "Отследить";
            this.btnTrackOrder.UseVisualStyleBackColor = true;
            this.btnTrackOrder.Click += new System.EventHandler(this.btnTrackOrder_Click);
            // 
            // UserTrackingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 71);
            this.Controls.Add(this.btnTrackOrder);
            this.Controls.Add(this.txtApplicationNumber);
            this.Controls.Add(this.lblApplicationNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserTrackingForm";
            this.Text = "Отслеживание заявки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
