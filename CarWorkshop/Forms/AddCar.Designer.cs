namespace CarWorkshop.Forms
{
    partial class AddCarForm
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
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbComments = new System.Windows.Forms.TextBox();
            this.tbVin = new System.Windows.Forms.TextBox();
            this.tbYearOfProduction = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lbModel = new System.Windows.Forms.Label();
            this.lbYearOfProduction = new System.Windows.Forms.Label();
            this.lbBrand = new System.Windows.Forms.Label();
            this.lbComments = new System.Windows.Forms.Label();
            this.lbVIN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbBrand
            // 
            this.tbBrand.Location = new System.Drawing.Point(224, 75);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Size = new System.Drawing.Size(515, 20);
            this.tbBrand.TabIndex = 0;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(224, 105);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(515, 20);
            this.tbModel.TabIndex = 1;
            // 
            // tbComments
            // 
            this.tbComments.Location = new System.Drawing.Point(224, 179);
            this.tbComments.Multiline = true;
            this.tbComments.Name = "tbComments";
            this.tbComments.Size = new System.Drawing.Size(515, 97);
            this.tbComments.TabIndex = 3;
            // 
            // tbVin
            // 
            this.tbVin.Location = new System.Drawing.Point(224, 127);
            this.tbVin.Name = "tbVin";
            this.tbVin.Size = new System.Drawing.Size(515, 20);
            this.tbVin.TabIndex = 4;
            this.tbVin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbVin_KeyPress);
            // 
            // tbYearOfProduction
            // 
            this.tbYearOfProduction.Location = new System.Drawing.Point(224, 153);
            this.tbYearOfProduction.Name = "tbYearOfProduction";
            this.tbYearOfProduction.Size = new System.Drawing.Size(515, 20);
            this.tbYearOfProduction.TabIndex = 5;
            this.tbYearOfProduction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbYearOfProduction_KeyPress);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(268, 462);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(129, 55);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "Save";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lbModel
            // 
            this.lbModel.AutoSize = true;
            this.lbModel.Location = new System.Drawing.Point(87, 104);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(36, 13);
            this.lbModel.TabIndex = 8;
            this.lbModel.Text = "Model";
            // 
            // lbYearOfProduction
            // 
            this.lbYearOfProduction.AutoSize = true;
            this.lbYearOfProduction.Location = new System.Drawing.Point(86, 156);
            this.lbYearOfProduction.Name = "lbYearOfProduction";
            this.lbYearOfProduction.Size = new System.Drawing.Size(94, 13);
            this.lbYearOfProduction.TabIndex = 9;
            this.lbYearOfProduction.Text = "Year of production";
            // 
            // lbBrand
            // 
            this.lbBrand.AutoSize = true;
            this.lbBrand.Location = new System.Drawing.Point(86, 78);
            this.lbBrand.Name = "lbBrand";
            this.lbBrand.Size = new System.Drawing.Size(35, 13);
            this.lbBrand.TabIndex = 10;
            this.lbBrand.Text = "Brand";
            // 
            // lbComments
            // 
            this.lbComments.AutoSize = true;
            this.lbComments.Location = new System.Drawing.Point(87, 182);
            this.lbComments.Name = "lbComments";
            this.lbComments.Size = new System.Drawing.Size(56, 13);
            this.lbComments.TabIndex = 11;
            this.lbComments.Text = "Comments";
            // 
            // lbVIN
            // 
            this.lbVIN.AutoSize = true;
            this.lbVIN.Location = new System.Drawing.Point(88, 130);
            this.lbVIN.Name = "lbVIN";
            this.lbVIN.Size = new System.Drawing.Size(25, 13);
            this.lbVIN.TabIndex = 13;
            this.lbVIN.Text = "VIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(96, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Klient: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(224, 282);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(749, 150);
            this.dataGridView1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Lista samochodów klienta";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 55);
            this.button1.TabIndex = 17;
            this.button1.Text = "Zamknij";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 549);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbVIN);
            this.Controls.Add(this.lbComments);
            this.Controls.Add(this.lbBrand);
            this.Controls.Add(this.lbYearOfProduction);
            this.Controls.Add(this.lbModel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.tbYearOfProduction);
            this.Controls.Add(this.tbVin);
            this.Controls.Add(this.tbComments);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbBrand);
            this.Name = "AddCarForm";
            this.Text = "AddCar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbComments;
        private System.Windows.Forms.TextBox tbVin;
        private System.Windows.Forms.TextBox tbYearOfProduction;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lbModel;
        private System.Windows.Forms.Label lbYearOfProduction;
        private System.Windows.Forms.Label lbBrand;
        private System.Windows.Forms.Label lbComments;
        private System.Windows.Forms.Label lbVIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}