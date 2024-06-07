namespace ServiceDeskApp
{
    partial class MasterForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblApplicationId;
        private System.Windows.Forms.TextBox txtApplicationId;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnAddComment;
        private System.Windows.Forms.Label lblOrderedParts;
        private System.Windows.Forms.TextBox txtOrderedParts;
        private System.Windows.Forms.Button btnOrderParts;

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
            this.lblApplicationId = new System.Windows.Forms.Label();
            this.txtApplicationId = new System.Windows.Forms.TextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnAddComment = new System.Windows.Forms.Button();
            this.lblOrderedParts = new System.Windows.Forms.Label();
            this.txtOrderedParts = new System.Windows.Forms.TextBox();
            this.btnOrderParts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblApplicationId
            // 
            this.lblApplicationId.AutoSize = true;
            this.lblApplicationId.Location = new System.Drawing.Point(15, 15);
            this.lblApplicationId.Name = "lblApplicationId";
            this.lblApplicationId.Size = new System.Drawing.Size(61, 13);
            this.lblApplicationId.TabIndex = 0;
            this.lblApplicationId.Text = "ID Заявки:";
            // 
            // txtApplicationId
            // 
            this.txtApplicationId.Location = new System.Drawing.Point(82, 12);
            this.txtApplicationId.Name = "txtApplicationId";
            this.txtApplicationId.Size = new System.Drawing.Size(190, 20);
            this.txtApplicationId.TabIndex = 1;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(-4, 41);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(80, 13);
            this.lblComment.TabIndex = 2;
            this.lblComment.Text = "Комментарий:";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(82, 38);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(190, 80);
            this.txtComment.TabIndex = 3;
            // 
            // btnAddComment
            // 
            this.btnAddComment.Location = new System.Drawing.Point(197, 124);
            this.btnAddComment.Name = "btnAddComment";
            this.btnAddComment.Size = new System.Drawing.Size(75, 23);
            this.btnAddComment.TabIndex = 4;
            this.btnAddComment.Text = "Добавить";
            this.btnAddComment.UseVisualStyleBackColor = true;
            this.btnAddComment.Click += new System.EventHandler(this.btnAddComment_Click);
            // 
            // lblOrderedParts
            // 
            this.lblOrderedParts.AutoSize = true;
            this.lblOrderedParts.Location = new System.Drawing.Point(12, 154);
            this.lblOrderedParts.Name = "lblOrderedParts";
            this.lblOrderedParts.Size = new System.Drawing.Size(191, 13);
            this.lblOrderedParts.TabIndex = 5;
            this.lblOrderedParts.Text = "Заказанные запчасти и материалы:";
            // 
            // txtOrderedParts
            // 
            this.txtOrderedParts.Location = new System.Drawing.Point(15, 170);
            this.txtOrderedParts.Multiline = true;
            this.txtOrderedParts.Name = "txtOrderedParts";
            this.txtOrderedParts.Size = new System.Drawing.Size(257, 80);
            this.txtOrderedParts.TabIndex = 6;
            // 
            // btnOrderParts
            // 
            this.btnOrderParts.Location = new System.Drawing.Point(197, 256);
            this.btnOrderParts.Name = "btnOrderParts";
            this.btnOrderParts.Size = new System.Drawing.Size(75, 23);
            this.btnOrderParts.TabIndex = 7;
            this.btnOrderParts.Text = "Заказать";
            this.btnOrderParts.UseVisualStyleBackColor = true;
            this.btnOrderParts.Click += new System.EventHandler(this.btnOrderParts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Заявки:";
            // 
            // MasterForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 291);
            this.Controls.Add(this.btnOrderParts);
            this.Controls.Add(this.txtOrderedParts);
            this.Controls.Add(this.lblOrderedParts);
            this.Controls.Add(this.btnAddComment);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.txtApplicationId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblApplicationId);
            this.Name = "MasterForm";
            this.Text = "Мастер: Добавить комментарий и заказать запчасти";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
    }
}
