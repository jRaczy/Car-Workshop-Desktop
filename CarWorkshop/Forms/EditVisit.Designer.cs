namespace CarWorkshop.Forms
{
    partial class EditVisit
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbService = new System.Windows.Forms.TextBox();
            this.tbPrize = new System.Windows.Forms.TextBox();
            this.checBoxDone = new System.Windows.Forms.CheckBox();
            this.mtbDateFrom = new System.Windows.Forms.MaskedTextBox();
            this.mtbDateTo = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(320, 298);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 42);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(134, 298);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 42);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(134, 137);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(284, 155);
            this.tbDescription.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Service";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Date To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Date From";
            // 
            // tbService
            // 
            this.tbService.Location = new System.Drawing.Point(134, 79);
            this.tbService.Name = "tbService";
            this.tbService.Size = new System.Drawing.Size(284, 20);
            this.tbService.TabIndex = 14;
            // 
            // tbPrize
            // 
            this.tbPrize.Location = new System.Drawing.Point(134, 107);
            this.tbPrize.Name = "tbPrize";
            this.tbPrize.Size = new System.Drawing.Size(284, 20);
            this.tbPrize.TabIndex = 13;
            // 
            // checBoxDone
            // 
            this.checBoxDone.AutoSize = true;
            this.checBoxDone.Location = new System.Drawing.Point(366, 24);
            this.checBoxDone.Name = "checBoxDone";
            this.checBoxDone.Size = new System.Drawing.Size(52, 17);
            this.checBoxDone.TabIndex = 24;
            this.checBoxDone.Text = "Done";
            this.checBoxDone.UseVisualStyleBackColor = true;
            // 
            // mtbDateFrom
            // 
            this.mtbDateFrom.Location = new System.Drawing.Point(134, 28);
            this.mtbDateFrom.Mask = "00/00/0000";
            this.mtbDateFrom.Name = "mtbDateFrom";
            this.mtbDateFrom.Size = new System.Drawing.Size(100, 20);
            this.mtbDateFrom.TabIndex = 25;
            this.mtbDateFrom.ValidatingType = typeof(System.DateTime);
            // 
            // mtbDateTo
            // 
            this.mtbDateTo.Location = new System.Drawing.Point(134, 55);
            this.mtbDateTo.Mask = "00/00/0000";
            this.mtbDateTo.Name = "mtbDateTo";
            this.mtbDateTo.Size = new System.Drawing.Size(100, 20);
            this.mtbDateTo.TabIndex = 26;
            this.mtbDateTo.ValidatingType = typeof(System.DateTime);
            // 
            // EditVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 412);
            this.Controls.Add(this.mtbDateTo);
            this.Controls.Add(this.mtbDateFrom);
            this.Controls.Add(this.checBoxDone);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbService);
            this.Controls.Add(this.tbPrize);
            this.Name = "EditVisit";
            this.Text = "EditVisit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbService;
        private System.Windows.Forms.TextBox tbPrize;
        private System.Windows.Forms.CheckBox checBoxDone;
        private System.Windows.Forms.MaskedTextBox mtbDateFrom;
        private System.Windows.Forms.MaskedTextBox mtbDateTo;
    }
}