namespace CarWorkshop.Forms
{
    partial class EditClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbComments = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbCAddress = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(403, 238);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(147, 53);
            this.btnCancel.TabIndex = 53;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Comments";
            // 
            // tbComments
            // 
            this.tbComments.Location = new System.Drawing.Point(252, 197);
            this.tbComments.Multiline = true;
            this.tbComments.Name = "tbComments";
            this.tbComments.Size = new System.Drawing.Size(298, 35);
            this.tbComments.TabIndex = 51;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(123, 126);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 50;
            this.lbEmail.Text = "Email";
            // 
            // lbCAddress
            // 
            this.lbCAddress.AutoSize = true;
            this.lbCAddress.Location = new System.Drawing.Point(122, 178);
            this.lbCAddress.Name = "lbCAddress";
            this.lbCAddress.Size = new System.Drawing.Size(45, 13);
            this.lbCAddress.TabIndex = 49;
            this.lbCAddress.Text = "Address";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(121, 74);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 48;
            this.lbName.Text = "Name";
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Location = new System.Drawing.Point(121, 152);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(76, 13);
            this.lbPhoneNumber.TabIndex = 47;
            this.lbPhoneNumber.Text = "Phone number";
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Location = new System.Drawing.Point(122, 100);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(49, 13);
            this.lbSurname.TabIndex = 46;
            this.lbSurname.Text = "Surname";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(252, 145);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(298, 20);
            this.tbPhoneNumber.TabIndex = 45;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(252, 119);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(298, 20);
            this.tbEmail.TabIndex = 44;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(252, 171);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(298, 20);
            this.tbAddress.TabIndex = 43;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(252, 93);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(298, 20);
            this.tbSurname.TabIndex = 42;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(252, 67);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(298, 20);
            this.tbName.TabIndex = 41;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(250, 238);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 53);
            this.btnSave.TabIndex = 54;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 353);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbComments);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbCAddress);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbPhoneNumber);
            this.Controls.Add(this.lbSurname);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbName);
            this.Name = "EditClient";
            this.Text = "EditClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbComments;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbCAddress;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnSave;
    }
}