namespace CarWorkshop.Forms
{
    partial class Email
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
            this.lbFrom = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.lbSubject = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.tbBody = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Location = new System.Drawing.Point(35, 32);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(30, 13);
            this.lbFrom.TabIndex = 0;
            this.lbFrom.Text = "From";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(34, 120);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(20, 13);
            this.lbAddress.TabIndex = 1;
            this.lbAddress.Text = "To";
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(84, 32);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(286, 20);
            this.tbFrom.TabIndex = 2;
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(84, 113);
            this.tbTo.Name = "tbTo";
            this.tbTo.ReadOnly = true;
            this.tbTo.Size = new System.Drawing.Size(286, 20);
            this.tbTo.TabIndex = 3;
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Location = new System.Drawing.Point(22, 94);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(43, 13);
            this.lbSubject.TabIndex = 5;
            this.lbSubject.Text = "Subject";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(276, 347);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(94, 36);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(84, 87);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(286, 20);
            this.tbSubject.TabIndex = 8;
            // 
            // tbBody
            // 
            this.tbBody.Location = new System.Drawing.Point(84, 139);
            this.tbBody.Multiline = true;
            this.tbBody.Name = "tbBody";
            this.tbBody.Size = new System.Drawing.Size(286, 186);
            this.tbBody.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Body";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(84, 58);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(286, 20);
            this.tbPassword.TabIndex = 12;
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 435);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBody);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lbSubject);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbFrom);
            this.Name = "Email";
            this.Text = "Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.TextBox tbBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPassword;
    }
}