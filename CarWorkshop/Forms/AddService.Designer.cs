namespace CarWorkshop.Forms
{
    partial class AddService
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
            this.lbServiceName = new System.Windows.Forms.Label();
            this.lbPrize = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.tbServiceName = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbServiceName
            // 
            this.lbServiceName.AutoSize = true;
            this.lbServiceName.Location = new System.Drawing.Point(59, 39);
            this.lbServiceName.Name = "lbServiceName";
            this.lbServiceName.Size = new System.Drawing.Size(72, 13);
            this.lbServiceName.TabIndex = 0;
            this.lbServiceName.Text = "Service name";
            // 
            // lbPrize
            // 
            this.lbPrize.AutoSize = true;
            this.lbPrize.Location = new System.Drawing.Point(91, 68);
            this.lbPrize.Name = "lbPrize";
            this.lbPrize.Size = new System.Drawing.Size(31, 13);
            this.lbPrize.TabIndex = 1;
            this.lbPrize.Text = "Price";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(62, 119);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(166, 119);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // tbServiceName
            // 
            this.tbServiceName.Location = new System.Drawing.Point(141, 39);
            this.tbServiceName.Name = "tbServiceName";
            this.tbServiceName.Size = new System.Drawing.Size(203, 20);
            this.tbServiceName.TabIndex = 4;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(141, 65);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 20);
            this.tbPrice.TabIndex = 6;
            // 
            // AddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 191);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbServiceName);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lbPrize);
            this.Controls.Add(this.lbServiceName);
            this.Name = "AddService";
            this.Text = "AddService";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbServiceName;
        private System.Windows.Forms.Label lbPrize;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.TextBox tbServiceName;
        private System.Windows.Forms.TextBox tbPrice;
    }
}