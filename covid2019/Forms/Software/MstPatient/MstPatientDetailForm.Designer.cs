namespace covid2019.Forms.Software.MstPatient
{
    partial class MstPatientDetailForm
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRemarks = new System.Windows.Forms.TextBox();
            this.textBoxPassportNumber = new System.Windows.Forms.TextBox();
            this.comboBoxCluster = new System.Windows.Forms.ComboBox();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.comboBoxProvince = new System.Windows.Forms.ComboBox();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.comboBoxBarangay = new System.Windows.Forms.ComboBox();
            this.textBoxContactNumber = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateOfQuarantine = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateOfArrival = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateEncoded = new System.Windows.Forms.DateTimePicker();
            this.textBoxPatient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPatientCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 63);
            this.panel1.TabIndex = 1;
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
            this.buttonClose.Location = new System.Drawing.Point(590, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(93, 41);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(491, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(93, 41);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
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
            this.label1.Size = new System.Drawing.Size(210, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Detail";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBoxRemarks);
            this.panel2.Controls.Add(this.textBoxPassportNumber);
            this.panel2.Controls.Add(this.comboBoxCluster);
            this.panel2.Controls.Add(this.comboBoxCountry);
            this.panel2.Controls.Add(this.comboBoxProvince);
            this.panel2.Controls.Add(this.comboBoxCity);
            this.panel2.Controls.Add(this.comboBoxBarangay);
            this.panel2.Controls.Add(this.textBoxContactNumber);
            this.panel2.Controls.Add(this.textBoxAddress);
            this.panel2.Controls.Add(this.comboBoxSex);
            this.panel2.Controls.Add(this.textBoxAge);
            this.panel2.Controls.Add(this.dateTimePickerDateOfQuarantine);
            this.panel2.Controls.Add(this.dateTimePickerDateOfArrival);
            this.panel2.Controls.Add(this.dateTimePickerDateEncoded);
            this.panel2.Controls.Add(this.textBoxPatient);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBoxPatientCode);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(695, 760);
            this.panel2.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label17.Location = new System.Drawing.Point(131, 628);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 23);
            this.label17.TabIndex = 31;
            this.label17.Text = "Remarks:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label16.Location = new System.Drawing.Point(63, 592);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(146, 23);
            this.label16.TabIndex = 30;
            this.label16.Text = "Passport Number:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label15.Location = new System.Drawing.Point(142, 555);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 23);
            this.label15.TabIndex = 29;
            this.label15.Text = "Cluster:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label14.Location = new System.Drawing.Point(134, 407);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 23);
            this.label14.TabIndex = 28;
            this.label14.Text = "Country:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label13.Location = new System.Drawing.Point(130, 444);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 23);
            this.label13.TabIndex = 27;
            this.label13.Text = "Province:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label12.Location = new System.Drawing.Point(166, 481);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 23);
            this.label12.TabIndex = 26;
            this.label12.Text = "City:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label11.Location = new System.Drawing.Point(124, 518);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 23);
            this.label11.TabIndex = 25;
            this.label11.Text = "Barangay:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label10.Location = new System.Drawing.Point(67, 371);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 23);
            this.label10.TabIndex = 24;
            this.label10.Text = "Contact Number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label9.Location = new System.Drawing.Point(135, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 23);
            this.label9.TabIndex = 23;
            this.label9.Text = "Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label8.Location = new System.Drawing.Point(169, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 23);
            this.label8.TabIndex = 22;
            this.label8.Text = "Sex:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label7.Location = new System.Drawing.Point(165, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "Age:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label6.Location = new System.Drawing.Point(48, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Date of Quarantine:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label5.Location = new System.Drawing.Point(86, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "Date of Arrival:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label4.Location = new System.Drawing.Point(88, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Date Encoded:";
            // 
            // textBoxRemarks
            // 
            this.textBoxRemarks.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.textBoxRemarks.Location = new System.Drawing.Point(215, 625);
            this.textBoxRemarks.Multiline = true;
            this.textBoxRemarks.Name = "textBoxRemarks";
            this.textBoxRemarks.Size = new System.Drawing.Size(445, 123);
            this.textBoxRemarks.TabIndex = 19;
            // 
            // textBoxPassportNumber
            // 
            this.textBoxPassportNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.textBoxPassportNumber.Location = new System.Drawing.Point(215, 589);
            this.textBoxPassportNumber.Name = "textBoxPassportNumber";
            this.textBoxPassportNumber.Size = new System.Drawing.Size(310, 30);
            this.textBoxPassportNumber.TabIndex = 18;
            // 
            // comboBoxCluster
            // 
            this.comboBoxCluster.DisplayMember = "Value";
            this.comboBoxCluster.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.comboBoxCluster.FormattingEnabled = true;
            this.comboBoxCluster.Location = new System.Drawing.Point(215, 552);
            this.comboBoxCluster.Name = "comboBoxCluster";
            this.comboBoxCluster.Size = new System.Drawing.Size(310, 31);
            this.comboBoxCluster.TabIndex = 17;
            this.comboBoxCluster.ValueMember = "Value";
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.DisplayMember = "Country";
            this.comboBoxCountry.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(215, 404);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(310, 31);
            this.comboBoxCountry.TabIndex = 13;
            this.comboBoxCountry.ValueMember = "Id";
            this.comboBoxCountry.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountry_SelectedIndexChanged);
            // 
            // comboBoxProvince
            // 
            this.comboBoxProvince.DisplayMember = "Province";
            this.comboBoxProvince.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.comboBoxProvince.FormattingEnabled = true;
            this.comboBoxProvince.Location = new System.Drawing.Point(215, 441);
            this.comboBoxProvince.Name = "comboBoxProvince";
            this.comboBoxProvince.Size = new System.Drawing.Size(310, 31);
            this.comboBoxProvince.TabIndex = 14;
            this.comboBoxProvince.ValueMember = "Id";
            this.comboBoxProvince.SelectedIndexChanged += new System.EventHandler(this.comboBoxProvince_SelectedIndexChanged);
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.DisplayMember = "City";
            this.comboBoxCity.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(215, 478);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(310, 31);
            this.comboBoxCity.TabIndex = 15;
            this.comboBoxCity.ValueMember = "Id";
            this.comboBoxCity.SelectedIndexChanged += new System.EventHandler(this.comboBoxCity_SelectedIndexChanged);
            // 
            // comboBoxBarangay
            // 
            this.comboBoxBarangay.DisplayMember = "Barangay";
            this.comboBoxBarangay.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.comboBoxBarangay.FormattingEnabled = true;
            this.comboBoxBarangay.Location = new System.Drawing.Point(215, 515);
            this.comboBoxBarangay.Name = "comboBoxBarangay";
            this.comboBoxBarangay.Size = new System.Drawing.Size(310, 31);
            this.comboBoxBarangay.TabIndex = 16;
            this.comboBoxBarangay.ValueMember = "Id";
            this.comboBoxBarangay.SelectedIndexChanged += new System.EventHandler(this.comboBoxBarangay_SelectedIndexChanged);
            // 
            // textBoxContactNumber
            // 
            this.textBoxContactNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.textBoxContactNumber.Location = new System.Drawing.Point(215, 368);
            this.textBoxContactNumber.Name = "textBoxContactNumber";
            this.textBoxContactNumber.Size = new System.Drawing.Size(310, 30);
            this.textBoxContactNumber.TabIndex = 12;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.textBoxAddress.Location = new System.Drawing.Point(215, 259);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(445, 103);
            this.textBoxAddress.TabIndex = 11;
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.DisplayMember = "Value";
            this.comboBoxSex.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Location = new System.Drawing.Point(215, 222);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(208, 31);
            this.comboBoxSex.TabIndex = 10;
            this.comboBoxSex.ValueMember = "Value";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.textBoxAge.Location = new System.Drawing.Point(215, 186);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(146, 30);
            this.textBoxAge.TabIndex = 9;
            // 
            // dateTimePickerDateOfQuarantine
            // 
            this.dateTimePickerDateOfQuarantine.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.dateTimePickerDateOfQuarantine.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateOfQuarantine.Location = new System.Drawing.Point(215, 150);
            this.dateTimePickerDateOfQuarantine.Name = "dateTimePickerDateOfQuarantine";
            this.dateTimePickerDateOfQuarantine.Size = new System.Drawing.Size(146, 30);
            this.dateTimePickerDateOfQuarantine.TabIndex = 8;
            // 
            // dateTimePickerDateOfArrival
            // 
            this.dateTimePickerDateOfArrival.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.dateTimePickerDateOfArrival.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateOfArrival.Location = new System.Drawing.Point(215, 114);
            this.dateTimePickerDateOfArrival.Name = "dateTimePickerDateOfArrival";
            this.dateTimePickerDateOfArrival.Size = new System.Drawing.Size(146, 30);
            this.dateTimePickerDateOfArrival.TabIndex = 7;
            // 
            // dateTimePickerDateEncoded
            // 
            this.dateTimePickerDateEncoded.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.dateTimePickerDateEncoded.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateEncoded.Location = new System.Drawing.Point(215, 78);
            this.dateTimePickerDateEncoded.Name = "dateTimePickerDateEncoded";
            this.dateTimePickerDateEncoded.Size = new System.Drawing.Size(146, 30);
            this.dateTimePickerDateEncoded.TabIndex = 6;
            // 
            // textBoxPatient
            // 
            this.textBoxPatient.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.textBoxPatient.Location = new System.Drawing.Point(215, 42);
            this.textBoxPatient.Name = "textBoxPatient";
            this.textBoxPatient.Size = new System.Drawing.Size(310, 30);
            this.textBoxPatient.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label3.Location = new System.Drawing.Point(142, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Patient:";
            // 
            // textBoxPatientCode
            // 
            this.textBoxPatientCode.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.textBoxPatientCode.Location = new System.Drawing.Point(215, 6);
            this.textBoxPatientCode.Name = "textBoxPatientCode";
            this.textBoxPatientCode.ReadOnly = true;
            this.textBoxPatientCode.Size = new System.Drawing.Size(208, 30);
            this.textBoxPatientCode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label2.Location = new System.Drawing.Point(97, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Patient Code:";
            // 
            // MstPatientDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(695, 823);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MstPatientDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Detail";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRemarks;
        private System.Windows.Forms.TextBox textBoxPassportNumber;
        private System.Windows.Forms.ComboBox comboBoxCluster;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.ComboBox comboBoxProvince;
        private System.Windows.Forms.ComboBox comboBoxBarangay;
        private System.Windows.Forms.TextBox textBoxContactNumber;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfQuarantine;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfArrival;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateEncoded;
        private System.Windows.Forms.TextBox textBoxPatient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPatientCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCity;
    }
}