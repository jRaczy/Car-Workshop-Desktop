namespace CarWorkshop.Forms
{
    partial class PreviewVisit
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
            this.checBoxDone = new System.Windows.Forms.CheckBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbService = new System.Windows.Forms.TextBox();
            this.tbPrize = new System.Windows.Forms.TextBox();
            this.mtbDateFrom = new System.Windows.Forms.MaskedTextBox();
            this.mtbDateTo = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // checBoxDone
            // 
            this.checBoxDone.AutoSize = true;
            this.checBoxDone.Location = new System.Drawing.Point(257, 28);
            this.checBoxDone.Name = "checBoxDone";
            this.checBoxDone.Size = new System.Drawing.Size(52, 17);
            this.checBoxDone.TabIndex = 35;
            this.checBoxDone.Text = "Done";
            this.checBoxDone.UseVisualStyleBackColor = true;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(105, 139);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.Size = new System.Drawing.Size(284, 155);
            this.tbDescription.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Service";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Date To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Date From";
            // 
            // tbService
            // 
            this.tbService.Location = new System.Drawing.Point(105, 81);
            this.tbService.Name = "tbService";
            this.tbService.ReadOnly = true;
            this.tbService.Size = new System.Drawing.Size(284, 20);
            this.tbService.TabIndex = 27;
            // 
            // tbPrize
            // 
            this.tbPrize.Location = new System.Drawing.Point(105, 109);
            this.tbPrize.Name = "tbPrize";
            this.tbPrize.ReadOnly = true;
            this.tbPrize.Size = new System.Drawing.Size(284, 20);
            this.tbPrize.TabIndex = 26;
            // 
            // mtbDateFrom
            // 
            this.mtbDateFrom.Location = new System.Drawing.Point(105, 28);
            this.mtbDateFrom.Mask = "00/00/0000";
            this.mtbDateFrom.Name = "mtbDateFrom";
            this.mtbDateFrom.ReadOnly = true;
            this.mtbDateFrom.Size = new System.Drawing.Size(100, 20);
            this.mtbDateFrom.TabIndex = 36;
            this.mtbDateFrom.ValidatingType = typeof(System.DateTime);
            // 
            // mtbDateTo
            // 
            this.mtbDateTo.Location = new System.Drawing.Point(105, 55);
            this.mtbDateTo.Mask = "00/00/0000";
            this.mtbDateTo.Name = "mtbDateTo";
            this.mtbDateTo.ReadOnly = true;
            this.mtbDateTo.Size = new System.Drawing.Size(100, 20);
            this.mtbDateTo.TabIndex = 37;
            this.mtbDateTo.ValidatingType = typeof(System.DateTime);
            // 
            // PreviewVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 351);
            this.Controls.Add(this.mtbDateTo);
            this.Controls.Add(this.mtbDateFrom);
            this.Controls.Add(this.checBoxDone);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbService);
            this.Controls.Add(this.tbPrize);
            this.Name = "PreviewVisit";
            this.Text = "PreviewVisit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checBoxDone;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbService;
        private System.Windows.Forms.TextBox tbPrize;
        private System.Windows.Forms.MaskedTextBox mtbDateFrom;
        private System.Windows.Forms.MaskedTextBox mtbDateTo;
    }
}