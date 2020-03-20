namespace covid2019.Forms.Software.MstPatient
{
    partial class MstPatientForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonGet = new System.Windows.Forms.Button();
            this.buttonCSV = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPatientCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateEncoded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateOfArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateOfQuarantine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBarangayId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBarangay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProvinceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProvince = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCountryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCluster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPassportNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSpace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSearchPatient = new System.Windows.Forms.TextBox();
            this.folderBrowserDialogGenerateCSV = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonGet);
            this.panel1.Controls.Add(this.buttonCSV);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1497, 63);
            this.panel1.TabIndex = 0;
            // 
            // buttonGet
            // 
            this.buttonGet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGet.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonGet.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonGet.FlatAppearance.BorderSize = 0;
            this.buttonGet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGet.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGet.ForeColor = System.Drawing.Color.White;
            this.buttonGet.Location = new System.Drawing.Point(1095, 12);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(93, 41);
            this.buttonGet.TabIndex = 6;
            this.buttonGet.Text = "Get";
            this.buttonGet.UseVisualStyleBackColor = false;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // buttonCSV
            // 
            this.buttonCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCSV.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonCSV.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonCSV.FlatAppearance.BorderSize = 0;
            this.buttonCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCSV.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCSV.ForeColor = System.Drawing.Color.White;
            this.buttonCSV.Location = new System.Drawing.Point(1194, 12);
            this.buttonCSV.Name = "buttonCSV";
            this.buttonCSV.Size = new System.Drawing.Size(93, 41);
            this.buttonCSV.TabIndex = 5;
            this.buttonCSV.Text = "CSV";
            this.buttonCSV.UseVisualStyleBackColor = false;
            this.buttonCSV.Click += new System.EventHandler(this.buttonCSV_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.IndianRed;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(1392, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(93, 41);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(1293, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(93, 41);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::covid2019.Properties.Resources.patient;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(61, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patients";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 687);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1497, 37);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Covid 2019";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridViewPatients);
            this.panel3.Controls.Add(this.textBoxSearchPatient);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1497, 624);
            this.panel3.TabIndex = 2;
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.AllowUserToAddRows = false;
            this.dataGridViewPatients.AllowUserToDeleteRows = false;
            this.dataGridViewPatients.AllowUserToResizeRows = false;
            this.dataGridViewPatients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPatients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnEdit,
            this.ColumnDelete,
            this.ColumnId,
            this.ColumnPatientCode,
            this.ColumnPatient,
            this.ColumnDateEncoded,
            this.ColumnDateOfArrival,
            this.ColumnDateOfQuarantine,
            this.ColumnAge,
            this.ColumnSex,
            this.ColumnAddress,
            this.ColumnContactNumber,
            this.ColumnBarangayId,
            this.ColumnBarangay,
            this.ColumnCityId,
            this.ColumnCity,
            this.ColumnProvinceId,
            this.ColumnProvince,
            this.ColumnCountryId,
            this.ColumnCountry,
            this.ColumnCluster,
            this.ColumnPassportNumber,
            this.ColumnRemarks,
            this.ColumnSpace});
            this.dataGridViewPatients.Location = new System.Drawing.Point(12, 42);
            this.dataGridViewPatients.MultiSelect = false;
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.ReadOnly = true;
            this.dataGridViewPatients.RowHeadersVisible = false;
            this.dataGridViewPatients.RowTemplate.Height = 24;
            this.dataGridViewPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPatients.Size = new System.Drawing.Size(1473, 576);
            this.dataGridViewPatients.TabIndex = 7;
            this.dataGridViewPatients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPatients_CellClick);
            // 
            // ColumnEdit
            // 
            this.ColumnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnEdit.Frozen = true;
            this.ColumnEdit.HeaderText = "Edit";
            this.ColumnEdit.Name = "ColumnEdit";
            this.ColumnEdit.ReadOnly = true;
            this.ColumnEdit.Width = 70;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnDelete.Frozen = true;
            this.ColumnDelete.HeaderText = "Delete";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.ReadOnly = true;
            this.ColumnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnDelete.Width = 70;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            // 
            // ColumnPatientCode
            // 
            this.ColumnPatientCode.HeaderText = "Patient Code";
            this.ColumnPatientCode.Name = "ColumnPatientCode";
            this.ColumnPatientCode.ReadOnly = true;
            this.ColumnPatientCode.Width = 150;
            // 
            // ColumnPatient
            // 
            this.ColumnPatient.HeaderText = "Patient";
            this.ColumnPatient.Name = "ColumnPatient";
            this.ColumnPatient.ReadOnly = true;
            this.ColumnPatient.Width = 150;
            // 
            // ColumnDateEncoded
            // 
            this.ColumnDateEncoded.HeaderText = "Date Encoded";
            this.ColumnDateEncoded.Name = "ColumnDateEncoded";
            this.ColumnDateEncoded.ReadOnly = true;
            this.ColumnDateEncoded.Width = 150;
            // 
            // ColumnDateOfArrival
            // 
            this.ColumnDateOfArrival.HeaderText = "Date of Arrival";
            this.ColumnDateOfArrival.Name = "ColumnDateOfArrival";
            this.ColumnDateOfArrival.ReadOnly = true;
            this.ColumnDateOfArrival.Width = 150;
            // 
            // ColumnDateOfQuarantine
            // 
            this.ColumnDateOfQuarantine.HeaderText = "Date of Quarantine";
            this.ColumnDateOfQuarantine.Name = "ColumnDateOfQuarantine";
            this.ColumnDateOfQuarantine.ReadOnly = true;
            this.ColumnDateOfQuarantine.Width = 200;
            // 
            // ColumnAge
            // 
            this.ColumnAge.HeaderText = "Age";
            this.ColumnAge.Name = "ColumnAge";
            this.ColumnAge.ReadOnly = true;
            // 
            // ColumnSex
            // 
            this.ColumnSex.HeaderText = "Sex";
            this.ColumnSex.Name = "ColumnSex";
            this.ColumnSex.ReadOnly = true;
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.HeaderText = "Address";
            this.ColumnAddress.Name = "ColumnAddress";
            this.ColumnAddress.ReadOnly = true;
            this.ColumnAddress.Width = 250;
            // 
            // ColumnContactNumber
            // 
            this.ColumnContactNumber.HeaderText = "Contact Number";
            this.ColumnContactNumber.Name = "ColumnContactNumber";
            this.ColumnContactNumber.ReadOnly = true;
            this.ColumnContactNumber.Width = 200;
            // 
            // ColumnBarangayId
            // 
            this.ColumnBarangayId.HeaderText = "Barangay Id";
            this.ColumnBarangayId.Name = "ColumnBarangayId";
            this.ColumnBarangayId.ReadOnly = true;
            this.ColumnBarangayId.Visible = false;
            // 
            // ColumnBarangay
            // 
            this.ColumnBarangay.HeaderText = "Barangay";
            this.ColumnBarangay.Name = "ColumnBarangay";
            this.ColumnBarangay.ReadOnly = true;
            this.ColumnBarangay.Width = 150;
            // 
            // ColumnCityId
            // 
            this.ColumnCityId.HeaderText = "City Id";
            this.ColumnCityId.Name = "ColumnCityId";
            this.ColumnCityId.ReadOnly = true;
            this.ColumnCityId.Visible = false;
            // 
            // ColumnCity
            // 
            this.ColumnCity.HeaderText = "City";
            this.ColumnCity.Name = "ColumnCity";
            this.ColumnCity.ReadOnly = true;
            this.ColumnCity.Width = 150;
            // 
            // ColumnProvinceId
            // 
            this.ColumnProvinceId.HeaderText = "Province Id";
            this.ColumnProvinceId.Name = "ColumnProvinceId";
            this.ColumnProvinceId.ReadOnly = true;
            this.ColumnProvinceId.Visible = false;
            // 
            // ColumnProvince
            // 
            this.ColumnProvince.HeaderText = "Province";
            this.ColumnProvince.Name = "ColumnProvince";
            this.ColumnProvince.ReadOnly = true;
            this.ColumnProvince.Width = 150;
            // 
            // ColumnCountryId
            // 
            this.ColumnCountryId.HeaderText = "Country Id";
            this.ColumnCountryId.Name = "ColumnCountryId";
            this.ColumnCountryId.ReadOnly = true;
            this.ColumnCountryId.Visible = false;
            // 
            // ColumnCountry
            // 
            this.ColumnCountry.HeaderText = "Country";
            this.ColumnCountry.Name = "ColumnCountry";
            this.ColumnCountry.ReadOnly = true;
            this.ColumnCountry.Width = 150;
            // 
            // ColumnCluster
            // 
            this.ColumnCluster.HeaderText = "Cluster";
            this.ColumnCluster.Name = "ColumnCluster";
            this.ColumnCluster.ReadOnly = true;
            // 
            // ColumnPassportNumber
            // 
            this.ColumnPassportNumber.HeaderText = "Passport Number";
            this.ColumnPassportNumber.Name = "ColumnPassportNumber";
            this.ColumnPassportNumber.ReadOnly = true;
            this.ColumnPassportNumber.Width = 200;
            // 
            // ColumnRemarks
            // 
            this.ColumnRemarks.HeaderText = "Remarks";
            this.ColumnRemarks.Name = "ColumnRemarks";
            this.ColumnRemarks.ReadOnly = true;
            this.ColumnRemarks.Width = 250;
            // 
            // ColumnSpace
            // 
            this.ColumnSpace.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnSpace.HeaderText = "";
            this.ColumnSpace.Name = "ColumnSpace";
            this.ColumnSpace.ReadOnly = true;
            // 
            // textBoxSearchPatient
            // 
            this.textBoxSearchPatient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchPatient.Location = new System.Drawing.Point(12, 6);
            this.textBoxSearchPatient.Name = "textBoxSearchPatient";
            this.textBoxSearchPatient.Size = new System.Drawing.Size(1473, 30);
            this.textBoxSearchPatient.TabIndex = 1;
            this.textBoxSearchPatient.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearchPatient_KeyDown);
            // 
            // MstPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1497, 724);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MstPatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCSV;
        private System.Windows.Forms.TextBox textBoxSearchPatient;
        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPatientCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateEncoded;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateOfArrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateOfQuarantine;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBarangayId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBarangay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCityId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProvinceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProvince;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCountryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCluster;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPassportNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSpace;
        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogGenerateCSV;
    }
}