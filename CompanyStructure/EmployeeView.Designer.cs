namespace CompanyStructure
{
    partial class EmployeeView
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtDegree = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.cmbWorkingDepartment = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblDegree = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblWorkingDepartment = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(139, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(139, 38);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(121, 20);
            this.txtSurname.TabIndex = 1;
            // 
            // txtDegree
            // 
            this.txtDegree.Location = new System.Drawing.Point(139, 64);
            this.txtDegree.Name = "txtDegree";
            this.txtDegree.Size = new System.Drawing.Size(121, 20);
            this.txtDegree.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(139, 90);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(121, 20);
            this.txtPhone.TabIndex = 3;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(139, 116);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(121, 20);
            this.txtMail.TabIndex = 4;
            // 
            // cmbWorkingDepartment
            // 
            this.cmbWorkingDepartment.FormattingEnabled = true;
            this.cmbWorkingDepartment.Location = new System.Drawing.Point(139, 142);
            this.cmbWorkingDepartment.Name = "cmbWorkingDepartment";
            this.cmbWorkingDepartment.Size = new System.Drawing.Size(121, 21);
            this.cmbWorkingDepartment.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(12, 41);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 7;
            this.lblSurname.Text = "Surname";
            // 
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.Location = new System.Drawing.Point(12, 67);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(42, 13);
            this.lblDegree.TabIndex = 8;
            this.lblDegree.Text = "Degree";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 93);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Phone";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(12, 119);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(26, 13);
            this.lblMail.TabIndex = 10;
            this.lblMail.Text = "Mail";
            // 
            // lblWorkingDepartment
            // 
            this.lblWorkingDepartment.AutoSize = true;
            this.lblWorkingDepartment.Location = new System.Drawing.Point(12, 145);
            this.lblWorkingDepartment.Name = "lblWorkingDepartment";
            this.lblWorkingDepartment.Size = new System.Drawing.Size(103, 13);
            this.lblWorkingDepartment.TabIndex = 11;
            this.lblWorkingDepartment.Text = "Working department";
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(185, 204);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(12, 204);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 239);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblWorkingDepartment);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblDegree);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cmbWorkingDepartment);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtDegree);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Name = "Employee";
            this.Text = "Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtDegree;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.ComboBox cmbWorkingDepartment;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblDegree;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblWorkingDepartment;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}