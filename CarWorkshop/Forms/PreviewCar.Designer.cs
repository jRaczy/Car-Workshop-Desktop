namespace CarWorkshop.Forms
{
    partial class PreviewCar
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
            this.lbVIN = new System.Windows.Forms.Label();
            this.lbComments = new System.Windows.Forms.Label();
            this.lbBrand = new System.Windows.Forms.Label();
            this.lbYearOfProduction = new System.Windows.Forms.Label();
            this.lbModel = new System.Windows.Forms.Label();
            this.tbYearOfProduction = new System.Windows.Forms.TextBox();
            this.tbVin = new System.Windows.Forms.TextBox();
            this.tbComments = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbVIN
            // 
            this.lbVIN.AutoSize = true;
            this.lbVIN.Location = new System.Drawing.Point(34, 74);
            this.lbVIN.Name = "lbVIN";
            this.lbVIN.Size = new System.Drawing.Size(25, 13);
            this.lbVIN.TabIndex = 25;
            this.lbVIN.Text = "VIN";
            // 
            // lbComments
            // 
            this.lbComments.AutoSize = true;
            this.lbComments.Location = new System.Drawing.Point(33, 126);
            this.lbComments.Name = "lbComments";
            this.lbComments.Size = new System.Drawing.Size(56, 13);
            this.lbComments.TabIndex = 24;
            this.lbComments.Text = "Comments";
            // 
            // lbBrand
            // 
            this.lbBrand.AutoSize = true;
            this.lbBrand.Location = new System.Drawing.Point(32, 22);
            this.lbBrand.Name = "lbBrand";
            this.lbBrand.Size = new System.Drawing.Size(35, 13);
            this.lbBrand.TabIndex = 23;
            this.lbBrand.Text = "Brand";
            // 
            // lbYearOfProduction
            // 
            this.lbYearOfProduction.AutoSize = true;
            this.lbYearOfProduction.Location = new System.Drawing.Point(32, 100);
            this.lbYearOfProduction.Name = "lbYearOfProduction";
            this.lbYearOfProduction.Size = new System.Drawing.Size(94, 13);
            this.lbYearOfProduction.TabIndex = 22;
            this.lbYearOfProduction.Text = "Year of production";
            // 
            // lbModel
            // 
            this.lbModel.AutoSize = true;
            this.lbModel.Location = new System.Drawing.Point(33, 48);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(36, 13);
            this.lbModel.TabIndex = 21;
            this.lbModel.Text = "Model";
            // 
            // tbYearOfProduction
            // 
            this.tbYearOfProduction.Location = new System.Drawing.Point(163, 93);
            this.tbYearOfProduction.Name = "tbYearOfProduction";
            this.tbYearOfProduction.ReadOnly = true;
            this.tbYearOfProduction.Size = new System.Drawing.Size(144, 20);
            this.tbYearOfProduction.TabIndex = 18;
            // 
            // tbVin
            // 
            this.tbVin.Location = new System.Drawing.Point(163, 67);
            this.tbVin.Name = "tbVin";
            this.tbVin.ReadOnly = true;
            this.tbVin.Size = new System.Drawing.Size(144, 20);
            this.tbVin.TabIndex = 17;
            // 
            // tbComments
            // 
            this.tbComments.Location = new System.Drawing.Point(163, 119);
            this.tbComments.Name = "tbComments";
            this.tbComments.ReadOnly = true;
            this.tbComments.Size = new System.Drawing.Size(144, 20);
            this.tbComments.TabIndex = 16;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(163, 41);
            this.tbModel.Name = "tbModel";
            this.tbModel.ReadOnly = true;
            this.tbModel.Size = new System.Drawing.Size(144, 20);
            this.tbModel.TabIndex = 15;
            // 
            // tbBrand
            // 
            this.tbBrand.Location = new System.Drawing.Point(163, 15);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.ReadOnly = true;
            this.tbBrand.Size = new System.Drawing.Size(144, 20);
            this.tbBrand.TabIndex = 14;
            // 
            // PreviewCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 243);
            this.Controls.Add(this.lbVIN);
            this.Controls.Add(this.lbComments);
            this.Controls.Add(this.lbBrand);
            this.Controls.Add(this.lbYearOfProduction);
            this.Controls.Add(this.lbModel);
            this.Controls.Add(this.tbYearOfProduction);
            this.Controls.Add(this.tbVin);
            this.Controls.Add(this.tbComments);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbBrand);
            this.Name = "PreviewCar";
            this.Text = "PreviewCar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbVIN;
        private System.Windows.Forms.Label lbComments;
        private System.Windows.Forms.Label lbBrand;
        private System.Windows.Forms.Label lbYearOfProduction;
        private System.Windows.Forms.Label lbModel;
        private System.Windows.Forms.TextBox tbYearOfProduction;
        private System.Windows.Forms.TextBox tbVin;
        private System.Windows.Forms.TextBox tbComments;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbBrand;
    }
}