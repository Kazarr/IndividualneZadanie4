namespace CompanyStructure
{
    partial class StructureView
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbDepartmentType = new System.Windows.Forms.ComboBox();
            this.cmbParentDepartment = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCheifEmployee = new System.Windows.Forms.Label();
            this.lblDepartmentType = new System.Windows.Forms.Label();
            this.lblParentDepartment = new System.Windows.Forms.Label();
            this.cmbCheifEmployee = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(269, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 0;
            // 
            // cmbDepartmentType
            // 
            this.cmbDepartmentType.FormattingEnabled = true;
            this.cmbDepartmentType.Location = new System.Drawing.Point(269, 64);
            this.cmbDepartmentType.Name = "cmbDepartmentType";
            this.cmbDepartmentType.Size = new System.Drawing.Size(121, 21);
            this.cmbDepartmentType.TabIndex = 2;
            // 
            // cmbParentDepartment
            // 
            this.cmbParentDepartment.FormattingEnabled = true;
            this.cmbParentDepartment.Location = new System.Drawing.Point(269, 91);
            this.cmbParentDepartment.Name = "cmbParentDepartment";
            this.cmbParentDepartment.Size = new System.Drawing.Size(121, 21);
            this.cmbParentDepartment.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(91, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Department name";
            // 
            // lblCheifEmployee
            // 
            this.lblCheifEmployee.AutoSize = true;
            this.lblCheifEmployee.Location = new System.Drawing.Point(12, 41);
            this.lblCheifEmployee.Name = "lblCheifEmployee";
            this.lblCheifEmployee.Size = new System.Drawing.Size(31, 13);
            this.lblCheifEmployee.TabIndex = 5;
            this.lblCheifEmployee.Text = "Cheif";
            // 
            // lblDepartmentType
            // 
            this.lblDepartmentType.AutoSize = true;
            this.lblDepartmentType.Location = new System.Drawing.Point(12, 67);
            this.lblDepartmentType.Name = "lblDepartmentType";
            this.lblDepartmentType.Size = new System.Drawing.Size(85, 13);
            this.lblDepartmentType.TabIndex = 6;
            this.lblDepartmentType.Text = "Department type";
            // 
            // lblParentDepartment
            // 
            this.lblParentDepartment.AutoSize = true;
            this.lblParentDepartment.Location = new System.Drawing.Point(12, 94);
            this.lblParentDepartment.Name = "lblParentDepartment";
            this.lblParentDepartment.Size = new System.Drawing.Size(74, 13);
            this.lblParentDepartment.TabIndex = 7;
            this.lblParentDepartment.Text = "Department of";
            // 
            // cmbCheifEmployee
            // 
            this.cmbCheifEmployee.FormattingEnabled = true;
            this.cmbCheifEmployee.Location = new System.Drawing.Point(269, 38);
            this.cmbCheifEmployee.Name = "cmbCheifEmployee";
            this.cmbCheifEmployee.Size = new System.Drawing.Size(121, 21);
            this.cmbCheifEmployee.TabIndex = 8;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(315, 152);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(234, 152);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // Structure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 187);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cmbCheifEmployee);
            this.Controls.Add(this.lblParentDepartment);
            this.Controls.Add(this.lblDepartmentType);
            this.Controls.Add(this.lblCheifEmployee);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cmbParentDepartment);
            this.Controls.Add(this.cmbDepartmentType);
            this.Controls.Add(this.textBox1);
            this.Name = "Structure";
            this.Text = "Structure";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbDepartmentType;
        private System.Windows.Forms.ComboBox cmbParentDepartment;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCheifEmployee;
        private System.Windows.Forms.Label lblDepartmentType;
        private System.Windows.Forms.Label lblParentDepartment;
        private System.Windows.Forms.ComboBox cmbCheifEmployee;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}