namespace CarWorkshop.Forms
{
    partial class EditCar
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
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
            this.lbVIN.Location = new System.Drawing.Point(39, 80);
            this.lbVIN.Name = "lbVIN";
            this.lbVIN.Size = new System.Drawing.Size(25, 13);
            this.lbVIN.TabIndex = 25;
            this.lbVIN.Text = "VIN";
            // 
            // lbComments
            // 
            this.lbComments.AutoSize = true;
            this.lbComments.Location = new System.Drawing.Point(38, 132);
            this.lbComments.Name = "lbComments";
            this.lbComments.Size = new System.Drawing.Size(56, 13);
            this.lbComments.TabIndex = 24;
            this.lbComments.Text = "Comments";
            // 
            // lbBrand
            // 
            this.lbBrand.AutoSize = true;
            this.lbBrand.Location = new System.Drawing.Point(37, 28);
            this.lbBrand.Name = "lbBrand";
            this.lbBrand.Size = new System.Drawing.Size(35, 13);
            this.lbBrand.TabIndex = 23;
            this.lbBrand.Text = "Brand";
            // 
            // lbYearOfProduction
            // 
            this.lbYearOfProduction.AutoSize = true;
            this.lbYearOfProduction.Location = new System.Drawing.Point(37, 106);
            this.lbYearOfProduction.Name = "lbYearOfProduction";
            this.lbYearOfProduction.Size = new System.Drawing.Size(94, 13);
            this.lbYearOfProduction.TabIndex = 22;
            this.lbYearOfProduction.Text = "Year of production";
            // 
            // lbModel
            // 
            this.lbModel.AutoSize = true;
            this.lbModel.Location = new System.Drawing.Point(38, 54);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(36, 13);
            this.lbModel.TabIndex = 21;
            this.lbModel.Text = "Model";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(183, 197);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(129, 55);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(40, 197);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(129, 55);
            this.btnAccept.TabIndex = 19;
            this.btnAccept.Text = "Save";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // tbYearOfProduction
            // 
            this.tbYearOfProduction.Location = new System.Drawing.Point(168, 99);
            this.tbYearOfProduction.Name = "tbYearOfProduction";
            this.tbYearOfProduction.Size = new System.Drawing.Size(144, 20);
            this.tbYearOfProduction.TabIndex = 18;
            this.tbYearOfProduction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbYearOfProduction_KeyPress_1);
            // 
            // tbVin
            // 
            this.tbVin.Location = new System.Drawing.Point(168, 73);
            this.tbVin.Name = "tbVin";
            this.tbVin.Size = new System.Drawing.Size(144, 20);
            this.tbVin.TabIndex = 17;
            this.tbVin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbVin_KeyPress_1);
            // 
            // tbComments
            // 
            this.tbComments.Location = new System.Drawing.Point(168, 125);
            this.tbComments.Multiline = true;
            this.tbComments.Name = "tbComments";
            this.tbComments.Size = new System.Drawing.Size(144, 66);
            this.tbComments.TabIndex = 16;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(168, 47);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(144, 20);
            this.tbModel.TabIndex = 15;
            // 
            // tbBrand
            // 
            this.tbBrand.Location = new System.Drawing.Point(168, 21);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Size = new System.Drawing.Size(144, 20);
            this.tbBrand.TabIndex = 14;
            // 
            // EditCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 288);
            this.Controls.Add(this.lbVIN);
            this.Controls.Add(this.lbComments);
            this.Controls.Add(this.lbBrand);
            this.Controls.Add(this.lbYearOfProduction);
            this.Controls.Add(this.lbModel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.tbYearOfProduction);
            this.Controls.Add(this.tbVin);
            this.Controls.Add(this.tbComments);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbBrand);
            this.Name = "EditCar";
            this.Text = "EditCar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbVIN;
        private System.Windows.Forms.Label lbComments;
        private System.Windows.Forms.Label lbBrand;
        private System.Windows.Forms.Label lbYearOfProduction;
        private System.Windows.Forms.Label lbModel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TextBox tbYearOfProduction;
        private System.Windows.Forms.TextBox tbVin;
        private System.Windows.Forms.TextBox tbComments;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbBrand;
    }
}