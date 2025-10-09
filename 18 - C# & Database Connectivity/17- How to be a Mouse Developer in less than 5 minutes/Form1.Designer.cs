namespace WindowsFormsApp1
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hR_DatabaseDataSet = new WindowsFormsApp1.HR_DatabaseDataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new WindowsFormsApp1.HR_DatabaseDataSetTableAdapters.EmployeesTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gendorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hireDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlySalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonusPercDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.gendorDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.countryIDDataGridViewTextBoxColumn,
            this.departmentIDDataGridViewTextBoxColumn,
            this.hireDateDataGridViewTextBoxColumn,
            this.exitDateDataGridViewTextBoxColumn,
            this.monthlySalaryDataGridViewTextBoxColumn,
            this.bonusPercDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1171, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // hR_DatabaseDataSet
            // 
            this.hR_DatabaseDataSet.DataSetName = "HR_DatabaseDataSet";
            this.hR_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.hR_DatabaseDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // gendorDataGridViewTextBoxColumn
            // 
            this.gendorDataGridViewTextBoxColumn.DataPropertyName = "Gendor";
            this.gendorDataGridViewTextBoxColumn.HeaderText = "Gendor";
            this.gendorDataGridViewTextBoxColumn.Name = "gendorDataGridViewTextBoxColumn";
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            // 
            // countryIDDataGridViewTextBoxColumn
            // 
            this.countryIDDataGridViewTextBoxColumn.DataPropertyName = "CountryID";
            this.countryIDDataGridViewTextBoxColumn.HeaderText = "CountryID";
            this.countryIDDataGridViewTextBoxColumn.Name = "countryIDDataGridViewTextBoxColumn";
            // 
            // departmentIDDataGridViewTextBoxColumn
            // 
            this.departmentIDDataGridViewTextBoxColumn.DataPropertyName = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn.HeaderText = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn.Name = "departmentIDDataGridViewTextBoxColumn";
            // 
            // hireDateDataGridViewTextBoxColumn
            // 
            this.hireDateDataGridViewTextBoxColumn.DataPropertyName = "HireDate";
            this.hireDateDataGridViewTextBoxColumn.HeaderText = "HireDate";
            this.hireDateDataGridViewTextBoxColumn.Name = "hireDateDataGridViewTextBoxColumn";
            // 
            // exitDateDataGridViewTextBoxColumn
            // 
            this.exitDateDataGridViewTextBoxColumn.DataPropertyName = "ExitDate";
            this.exitDateDataGridViewTextBoxColumn.HeaderText = "ExitDate";
            this.exitDateDataGridViewTextBoxColumn.Name = "exitDateDataGridViewTextBoxColumn";
            // 
            // monthlySalaryDataGridViewTextBoxColumn
            // 
            this.monthlySalaryDataGridViewTextBoxColumn.DataPropertyName = "MonthlySalary";
            this.monthlySalaryDataGridViewTextBoxColumn.HeaderText = "MonthlySalary";
            this.monthlySalaryDataGridViewTextBoxColumn.Name = "monthlySalaryDataGridViewTextBoxColumn";
            // 
            // bonusPercDataGridViewTextBoxColumn
            // 
            this.bonusPercDataGridViewTextBoxColumn.DataPropertyName = "BonusPerc";
            this.bonusPercDataGridViewTextBoxColumn.HeaderText = "BonusPerc";
            this.bonusPercDataGridViewTextBoxColumn.Name = "bonusPercDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HR_DatabaseDataSet hR_DatabaseDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private HR_DatabaseDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gendorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hireDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exitDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthlySalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonusPercDataGridViewTextBoxColumn;
    }
}

