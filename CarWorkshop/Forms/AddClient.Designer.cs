namespace CarWorkshop.Forms
{
    partial class AddClient
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
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbCAddress = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbComments = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(114, 111);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 25;
            this.lbEmail.Text = "Email";
            // 
            // lbCAddress
            // 
            this.lbCAddress.AutoSize = true;
            this.lbCAddress.Location = new System.Drawing.Point(113, 163);
            this.lbCAddress.Name = "lbCAddress";
            this.lbCAddress.Size = new System.Drawing.Size(45, 13);
            this.lbCAddress.TabIndex = 24;
            this.lbCAddress.Text = "Address";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(112, 59);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 23;
            this.lbName.Text = "Name";
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Location = new System.Drawing.Point(112, 137);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(76, 13);
            this.lbPhoneNumber.TabIndex = 22;
            this.lbPhoneNumber.Text = "Phone number";
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Location = new System.Drawing.Point(113, 85);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(49, 13);
            this.lbSurname.TabIndex = 21;
            this.lbSurname.Text = "Surname";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(398, 283);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(129, 55);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(243, 283);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(129, 55);
            this.btnAccept.TabIndex = 19;
            this.btnAccept.Text = "Save";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(243, 130);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(298, 20);
            this.tbPhoneNumber.TabIndex = 18;
            this.tbPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhoneNumber_KeyPress);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(243, 104);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(298, 20);
            this.tbEmail.TabIndex = 17;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(243, 156);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(298, 56);
            this.tbAddress.TabIndex = 16;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(243, 78);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(298, 20);
            this.tbSurname.TabIndex = 15;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(243, 52);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(298, 20);
            this.tbName.TabIndex = 14;
            // 
            // tbComments
            // 
            this.tbComments.Location = new System.Drawing.Point(243, 218);
            this.tbComments.Multiline = true;
            this.tbComments.Name = "tbComments";
            this.tbComments.Size = new System.Drawing.Size(298, 59);
            this.tbComments.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Comments";
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 348);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbComments);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbCAddress);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbPhoneNumber);
            this.Controls.Add(this.lbSurname);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbName);
            this.Name = "AddClient";
            this.Text = "Add client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbCAddress;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbComments;
        private System.Windows.Forms.Label label1;
    }
}