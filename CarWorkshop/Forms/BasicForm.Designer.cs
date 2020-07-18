namespace CarWorkshop.Forms
{
    partial class BasicForm
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
            this.components = new System.ComponentModel.Container();
            this.carVisitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicarDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicarDataSet = new CarWorkshop.medicarDataSet();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridVisits = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditVisit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PreviewVisit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteVisit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRefreshCar = new System.Windows.Forms.Button();
            this.dataGridCars = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearOfProductionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditCar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PreviewCar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AddVisit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteCar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridClients = new System.Windows.Forms.DataGridView();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbClient = new System.Windows.Forms.TabControl();
            this.clientTableAdapter = new CarWorkshop.medicarDataSetTableAdapters.ClientTableAdapter();
            this.carTableAdapter = new CarWorkshop.medicarDataSetTableAdapters.CarTableAdapter();
            this.carVisitTableAdapter = new CarWorkshop.medicarDataSetTableAdapters.CarVisitTableAdapter();
            this.serviceTableAdapter = new CarWorkshop.medicarDataSetTableAdapters.ServiceTableAdapter();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditClient = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PreviewClient = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AddCar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteClient = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SendEmail = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.carVisitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicarDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVisits)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.tbClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // carVisitBindingSource
            // 
            this.carVisitBindingSource.DataMember = "CarVisit";
            this.carVisitBindingSource.DataSource = this.medicarDataSetBindingSource;
            // 
            // medicarDataSetBindingSource
            // 
            this.medicarDataSetBindingSource.DataSource = this.medicarDataSet;
            this.medicarDataSetBindingSource.Position = 0;
            // 
            // medicarDataSet
            // 
            this.medicarDataSet.DataSetName = "medicarDataSet";
            this.medicarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.medicarDataSetBindingSource;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridVisits);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(950, 501);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Visits";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridVisits
            // 
            this.dataGridVisits.AllowUserToAddRows = false;
            this.dataGridVisits.AllowUserToDeleteRows = false;
            this.dataGridVisits.AutoGenerateColumns = false;
            this.dataGridVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVisits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.carIDDataGridViewTextBoxColumn,
            this.DateFrom,
            this.DateTo,
            this.descriptionDataGridViewTextBoxColumn,
            this.EditVisit,
            this.PreviewVisit,
            this.DeleteVisit});
            this.dataGridVisits.DataSource = this.carVisitBindingSource;
            this.dataGridVisits.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridVisits.Location = new System.Drawing.Point(3, 65);
            this.dataGridVisits.Name = "dataGridVisits";
            this.dataGridVisits.ReadOnly = true;
            this.dataGridVisits.Size = new System.Drawing.Size(944, 433);
            this.dataGridVisits.TabIndex = 16;
            this.dataGridVisits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVisits_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carIDDataGridViewTextBoxColumn
            // 
            this.carIDDataGridViewTextBoxColumn.DataPropertyName = "CarID";
            this.carIDDataGridViewTextBoxColumn.HeaderText = "CarID";
            this.carIDDataGridViewTextBoxColumn.Name = "carIDDataGridViewTextBoxColumn";
            this.carIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DateFrom
            // 
            this.DateFrom.DataPropertyName = "DateFrom";
            this.DateFrom.HeaderText = "DateFrom";
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.ReadOnly = true;
            // 
            // DateTo
            // 
            this.DateTo.DataPropertyName = "DateTo";
            this.DateTo.HeaderText = "DateTo";
            this.DateTo.Name = "DateTo";
            this.DateTo.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EditVisit
            // 
            this.EditVisit.HeaderText = "";
            this.EditVisit.Name = "EditVisit";
            this.EditVisit.ReadOnly = true;
            this.EditVisit.Text = "Edit";
            this.EditVisit.UseColumnTextForButtonValue = true;
            // 
            // PreviewVisit
            // 
            this.PreviewVisit.HeaderText = "";
            this.PreviewVisit.Name = "PreviewVisit";
            this.PreviewVisit.ReadOnly = true;
            this.PreviewVisit.Text = "Preview";
            this.PreviewVisit.UseColumnTextForButtonValue = true;
            // 
            // DeleteVisit
            // 
            this.DeleteVisit.HeaderText = "";
            this.DeleteVisit.Name = "DeleteVisit";
            this.DeleteVisit.ReadOnly = true;
            this.DeleteVisit.Text = "Delete";
            this.DeleteVisit.UseColumnTextForButtonValue = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 51);
            this.button1.TabIndex = 15;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRefreshCar);
            this.tabPage2.Controls.Add(this.dataGridCars);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(950, 501);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cars";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRefreshCar
            // 
            this.btnRefreshCar.Location = new System.Drawing.Point(8, 6);
            this.btnRefreshCar.Name = "btnRefreshCar";
            this.btnRefreshCar.Size = new System.Drawing.Size(105, 51);
            this.btnRefreshCar.TabIndex = 10;
            this.btnRefreshCar.Text = "Refresh";
            this.btnRefreshCar.UseVisualStyleBackColor = true;
            this.btnRefreshCar.Click += new System.EventHandler(this.btnRefreshCar_Click);
            // 
            // dataGridCars
            // 
            this.dataGridCars.AllowUserToAddRows = false;
            this.dataGridCars.AllowUserToDeleteRows = false;
            this.dataGridCars.AutoGenerateColumns = false;
            this.dataGridCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.brandDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.yearOfProductionDataGridViewTextBoxColumn,
            this.EditCar,
            this.PreviewCar,
            this.AddVisit,
            this.DeleteCar});
            this.dataGridCars.DataSource = this.carBindingSource;
            this.dataGridCars.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridCars.Location = new System.Drawing.Point(3, 65);
            this.dataGridCars.Name = "dataGridCars";
            this.dataGridCars.ReadOnly = true;
            this.dataGridCars.Size = new System.Drawing.Size(944, 433);
            this.dataGridCars.TabIndex = 0;
            this.dataGridCars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCars_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearOfProductionDataGridViewTextBoxColumn
            // 
            this.yearOfProductionDataGridViewTextBoxColumn.DataPropertyName = "YearOfProduction";
            this.yearOfProductionDataGridViewTextBoxColumn.HeaderText = "YearOfProduction";
            this.yearOfProductionDataGridViewTextBoxColumn.Name = "yearOfProductionDataGridViewTextBoxColumn";
            this.yearOfProductionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EditCar
            // 
            this.EditCar.HeaderText = "";
            this.EditCar.Name = "EditCar";
            this.EditCar.ReadOnly = true;
            this.EditCar.Text = "Edit";
            this.EditCar.UseColumnTextForButtonValue = true;
            // 
            // PreviewCar
            // 
            this.PreviewCar.HeaderText = "";
            this.PreviewCar.Name = "PreviewCar";
            this.PreviewCar.ReadOnly = true;
            this.PreviewCar.Text = "Preview";
            this.PreviewCar.ToolTipText = "Preview";
            this.PreviewCar.UseColumnTextForButtonValue = true;
            // 
            // AddVisit
            // 
            this.AddVisit.HeaderText = "";
            this.AddVisit.Name = "AddVisit";
            this.AddVisit.ReadOnly = true;
            this.AddVisit.Text = "Add visit";
            this.AddVisit.UseColumnTextForButtonValue = true;
            // 
            // DeleteCar
            // 
            this.DeleteCar.HeaderText = "";
            this.DeleteCar.Name = "DeleteCar";
            this.DeleteCar.ReadOnly = true;
            this.DeleteCar.Text = "Delete";
            this.DeleteCar.UseColumnTextForButtonValue = true;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this.medicarDataSet;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridClients);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(950, 501);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clients";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridClients
            // 
            this.dataGridClients.AllowUserToAddRows = false;
            this.dataGridClients.AllowUserToDeleteRows = false;
            this.dataGridClients.AutoGenerateColumns = false;
            this.dataGridClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.EditClient,
            this.PreviewClient,
            this.AddCar,
            this.DeleteClient,
            this.SendEmail});
            this.dataGridClients.DataSource = this.clientBindingSource;
            this.dataGridClients.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridClients.GridColor = System.Drawing.Color.CadetBlue;
            this.dataGridClients.Location = new System.Drawing.Point(3, 65);
            this.dataGridClients.Name = "dataGridClients";
            this.dataGridClients.ReadOnly = true;
            this.dataGridClients.Size = new System.Drawing.Size(944, 433);
            this.dataGridClients.TabIndex = 0;
            this.dataGridClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClients_CellContentClick_1);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.medicarDataSet;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(8, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 51);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbClient
            // 
            this.tbClient.Controls.Add(this.tabPage1);
            this.tbClient.Controls.Add(this.tabPage2);
            this.tbClient.Controls.Add(this.tabPage3);
            this.tbClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbClient.Location = new System.Drawing.Point(0, 0);
            this.tbClient.Name = "tbClient";
            this.tbClient.SelectedIndex = 0;
            this.tbClient.Size = new System.Drawing.Size(958, 527);
            this.tbClient.TabIndex = 0;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // carVisitTableAdapter
            // 
            this.carVisitTableAdapter.ClearBeforeFill = true;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EditClient
            // 
            this.EditClient.HeaderText = "";
            this.EditClient.Name = "EditClient";
            this.EditClient.ReadOnly = true;
            this.EditClient.Text = "Edit";
            this.EditClient.UseColumnTextForButtonValue = true;
            // 
            // PreviewClient
            // 
            this.PreviewClient.HeaderText = "";
            this.PreviewClient.Name = "PreviewClient";
            this.PreviewClient.ReadOnly = true;
            this.PreviewClient.Text = "Preview";
            this.PreviewClient.UseColumnTextForButtonValue = true;
            // 
            // AddCar
            // 
            this.AddCar.HeaderText = "";
            this.AddCar.Name = "AddCar";
            this.AddCar.ReadOnly = true;
            this.AddCar.Text = "Add Car";
            this.AddCar.UseColumnTextForButtonValue = true;
            // 
            // DeleteClient
            // 
            this.DeleteClient.HeaderText = "";
            this.DeleteClient.Name = "DeleteClient";
            this.DeleteClient.ReadOnly = true;
            this.DeleteClient.Text = "Delete";
            this.DeleteClient.UseColumnTextForButtonValue = true;
            // 
            // SendEmail
            // 
            this.SendEmail.HeaderText = "";
            this.SendEmail.Name = "SendEmail";
            this.SendEmail.ReadOnly = true;
            this.SendEmail.Text = "SendEmail";
            this.SendEmail.UseColumnTextForButtonValue = true;
            // 
            // BasicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 527);
            this.Controls.Add(this.tbClient);
            this.Name = "BasicForm";
            this.Text = "Car workshop";
            this.Load += new System.EventHandler(this.BasicForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carVisitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicarDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVisits)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.tbClient.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private medicarDataSet medicarDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private medicarDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource medicarDataSetBindingSource;
        private System.Windows.Forms.BindingSource carBindingSource;
        private medicarDataSetTableAdapters.CarTableAdapter carTableAdapter;
        private System.Windows.Forms.BindingSource carVisitBindingSource;
        private medicarDataSetTableAdapters.CarVisitTableAdapter carVisitTableAdapter;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private medicarDataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridVisits;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridCars;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridClients;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabControl tbClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearOfProductionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditCar;
        private System.Windows.Forms.DataGridViewButtonColumn PreviewCar;
        private System.Windows.Forms.DataGridViewButtonColumn AddVisit;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteCar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRefreshCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditVisit;
        private System.Windows.Forms.DataGridViewButtonColumn PreviewVisit;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteVisit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditClient;
        private System.Windows.Forms.DataGridViewButtonColumn PreviewClient;
        private System.Windows.Forms.DataGridViewButtonColumn AddCar;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteClient;
        private System.Windows.Forms.DataGridViewButtonColumn SendEmail;
    }
}