namespace Personnel_Registration
{
    partial class FrmMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MskSalary = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtJob = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbCity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnGraphics = new System.Windows.Forms.Button();
            this.BtnStatistics = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnList = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.peridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perJobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personal_DatabaseDataSet = new Personnel_Registration.Personal_DatabaseDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbl_PersonalTableAdapter = new Personnel_Registration.Personal_DatabaseDataSetTableAdapters.Tbl_PersonalTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personal_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.MskSalary);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtJob);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CmbCity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtLastName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtFirstName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 341);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personnel Registration";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Salary";
            // 
            // MskSalary
            // 
            this.MskSalary.Location = new System.Drawing.Point(138, 189);
            this.MskSalary.Mask = "0000000000";
            this.MskSalary.Name = "MskSalary";
            this.MskSalary.Size = new System.Drawing.Size(130, 26);
            this.MskSalary.TabIndex = 5;
            this.MskSalary.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Job";
            // 
            // TxtJob
            // 
            this.TxtJob.Location = new System.Drawing.Point(138, 273);
            this.TxtJob.Name = "TxtJob";
            this.TxtJob.Size = new System.Drawing.Size(130, 26);
            this.TxtJob.TabIndex = 6;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(220, 225);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(64, 22);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Single";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(138, 225);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 22);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Maried";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Status";
            // 
            // CmbCity
            // 
            this.CmbCity.FormattingEnabled = true;
            this.CmbCity.Location = new System.Drawing.Point(138, 158);
            this.CmbCity.Name = "CmbCity";
            this.CmbCity.Size = new System.Drawing.Size(130, 26);
            this.CmbCity.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "City";
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(138, 127);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(130, 26);
            this.TxtLastName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(138, 93);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(130, 26);
            this.TxtFirstName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(138, 57);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(130, 26);
            this.TxtId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Personnel ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnGraphics);
            this.groupBox2.Controls.Add(this.BtnStatistics);
            this.groupBox2.Controls.Add(this.BtnClear);
            this.groupBox2.Controls.Add(this.BtnUpdate);
            this.groupBox2.Controls.Add(this.BtnDelete);
            this.groupBox2.Controls.Add(this.BtnSave);
            this.groupBox2.Controls.Add(this.BtnList);
            this.groupBox2.Location = new System.Drawing.Point(445, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 333);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Process";
            // 
            // BtnGraphics
            // 
            this.BtnGraphics.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGraphics.Location = new System.Drawing.Point(55, 221);
            this.BtnGraphics.Name = "BtnGraphics";
            this.BtnGraphics.Size = new System.Drawing.Size(159, 27);
            this.BtnGraphics.TabIndex = 12;
            this.BtnGraphics.Text = "Graphics";
            this.BtnGraphics.UseVisualStyleBackColor = true;
            this.BtnGraphics.Click += new System.EventHandler(this.BtnGraphics_Click);
            // 
            // BtnStatistics
            // 
            this.BtnStatistics.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnStatistics.Location = new System.Drawing.Point(55, 188);
            this.BtnStatistics.Name = "BtnStatistics";
            this.BtnStatistics.Size = new System.Drawing.Size(159, 27);
            this.BtnStatistics.TabIndex = 11;
            this.BtnStatistics.Text = "Statistics";
            this.BtnStatistics.UseVisualStyleBackColor = true;
            this.BtnStatistics.Click += new System.EventHandler(this.BtnStatistics_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnClear.Location = new System.Drawing.Point(55, 153);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(159, 27);
            this.BtnClear.TabIndex = 10;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUpdate.Location = new System.Drawing.Point(55, 120);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(159, 27);
            this.BtnUpdate.TabIndex = 9;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDelete.Location = new System.Drawing.Point(55, 87);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(159, 27);
            this.BtnDelete.TabIndex = 8;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSave.Location = new System.Drawing.Point(55, 54);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(159, 27);
            this.BtnSave.TabIndex = 7;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnList
            // 
            this.BtnList.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnList.Location = new System.Drawing.Point(55, 25);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(159, 27);
            this.BtnList.TabIndex = 0;
            this.BtnList.Text = "List";
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(26, 369);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(769, 178);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Records";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peridDataGridViewTextBoxColumn,
            this.perFirstNameDataGridViewTextBoxColumn,
            this.perLastNameDataGridViewTextBoxColumn,
            this.perCityDataGridViewTextBoxColumn,
            this.perSalaryDataGridViewTextBoxColumn,
            this.perStatusDataGridViewCheckBoxColumn,
            this.perJobDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonalBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(763, 153);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // peridDataGridViewTextBoxColumn
            // 
            this.peridDataGridViewTextBoxColumn.DataPropertyName = "Perid";
            this.peridDataGridViewTextBoxColumn.HeaderText = "Perid";
            this.peridDataGridViewTextBoxColumn.Name = "peridDataGridViewTextBoxColumn";
            this.peridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perFirstNameDataGridViewTextBoxColumn
            // 
            this.perFirstNameDataGridViewTextBoxColumn.DataPropertyName = "PerFirstName";
            this.perFirstNameDataGridViewTextBoxColumn.HeaderText = "PerFirstName";
            this.perFirstNameDataGridViewTextBoxColumn.Name = "perFirstNameDataGridViewTextBoxColumn";
            // 
            // perLastNameDataGridViewTextBoxColumn
            // 
            this.perLastNameDataGridViewTextBoxColumn.DataPropertyName = "PerLastName";
            this.perLastNameDataGridViewTextBoxColumn.HeaderText = "PerLastName";
            this.perLastNameDataGridViewTextBoxColumn.Name = "perLastNameDataGridViewTextBoxColumn";
            // 
            // perCityDataGridViewTextBoxColumn
            // 
            this.perCityDataGridViewTextBoxColumn.DataPropertyName = "PerCity";
            this.perCityDataGridViewTextBoxColumn.HeaderText = "PerCity";
            this.perCityDataGridViewTextBoxColumn.Name = "perCityDataGridViewTextBoxColumn";
            // 
            // perSalaryDataGridViewTextBoxColumn
            // 
            this.perSalaryDataGridViewTextBoxColumn.DataPropertyName = "PerSalary";
            this.perSalaryDataGridViewTextBoxColumn.HeaderText = "PerSalary";
            this.perSalaryDataGridViewTextBoxColumn.Name = "perSalaryDataGridViewTextBoxColumn";
            // 
            // perStatusDataGridViewCheckBoxColumn
            // 
            this.perStatusDataGridViewCheckBoxColumn.DataPropertyName = "PerStatus";
            this.perStatusDataGridViewCheckBoxColumn.HeaderText = "PerStatus";
            this.perStatusDataGridViewCheckBoxColumn.Name = "perStatusDataGridViewCheckBoxColumn";
            // 
            // perJobDataGridViewTextBoxColumn
            // 
            this.perJobDataGridViewTextBoxColumn.DataPropertyName = "PerJob";
            this.perJobDataGridViewTextBoxColumn.HeaderText = "PerJob";
            this.perJobDataGridViewTextBoxColumn.Name = "perJobDataGridViewTextBoxColumn";
            // 
            // tblPersonalBindingSource
            // 
            this.tblPersonalBindingSource.DataMember = "Tbl_Personal";
            this.tblPersonalBindingSource.DataSource = this.personal_DatabaseDataSet;
            // 
            // personal_DatabaseDataSet
            // 
            this.personal_DatabaseDataSet.DataSetName = "Personal_DatabaseDataSet";
            this.personal_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(717, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // tbl_PersonalTableAdapter
            // 
            this.tbl_PersonalTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(758, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            this.label8.TextChanged += new System.EventHandler(this.label8_TextChanged);
            // 
            // FrmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1003, 548);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personal_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtJob;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbCity;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox MskSalary;
        private System.Windows.Forms.Button BtnGraphics;
        private System.Windows.Forms.Button BtnStatistics;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Personal_DatabaseDataSet personal_DatabaseDataSet;
        private System.Windows.Forms.BindingSource tblPersonalBindingSource;
        private Personal_DatabaseDataSetTableAdapters.Tbl_PersonalTableAdapter tbl_PersonalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn peridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perStatusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perJobDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
    }
}

