namespace CompanyStructure
{
    partial class StructureOverlayView
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
            this.grdDepartmentEmployees = new System.Windows.Forms.DataGridView();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnDelEmployee = new System.Windows.Forms.Button();
            this.btnGuiHeirarchy = new System.Windows.Forms.Button();
            this.btnAddStructure = new System.Windows.Forms.Button();
            this.btnEditStructure = new System.Windows.Forms.Button();
            this.grdDepartments = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelStructure = new System.Windows.Forms.Button();
            this.grdProjects = new System.Windows.Forms.DataGridView();
            this.grdDivisions = new System.Windows.Forms.DataGridView();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.grdCompanies = new System.Windows.Forms.DataGridView();
            this.lblCompany = new System.Windows.Forms.Label();
            this.treeStructure = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.grdDepartmentEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDepartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDivisions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCompanies)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDepartmentEmployees
            // 
            this.grdDepartmentEmployees.AllowUserToAddRows = false;
            this.grdDepartmentEmployees.AllowUserToDeleteRows = false;
            this.grdDepartmentEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDepartmentEmployees.Location = new System.Drawing.Point(149, 316);
            this.grdDepartmentEmployees.Name = "grdDepartmentEmployees";
            this.grdDepartmentEmployees.ReadOnly = true;
            this.grdDepartmentEmployees.Size = new System.Drawing.Size(927, 167);
            this.grdDepartmentEmployees.TabIndex = 0;
            this.grdDepartmentEmployees.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDepartmentEmployees_RowEnter);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(43, 316);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(101, 23);
            this.btnAddEmployee.TabIndex = 1;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Location = new System.Drawing.Point(43, 345);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(101, 23);
            this.btnEditEmployee.TabIndex = 2;
            this.btnEditEmployee.Text = "Edit Employee";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // btnDelEmployee
            // 
            this.btnDelEmployee.Location = new System.Drawing.Point(43, 374);
            this.btnDelEmployee.Name = "btnDelEmployee";
            this.btnDelEmployee.Size = new System.Drawing.Size(101, 23);
            this.btnDelEmployee.TabIndex = 3;
            this.btnDelEmployee.Text = "Delete Employee";
            this.btnDelEmployee.UseVisualStyleBackColor = true;
            this.btnDelEmployee.Click += new System.EventHandler(this.btnDelEmployee_Click);
            // 
            // btnGuiHeirarchy
            // 
            this.btnGuiHeirarchy.Location = new System.Drawing.Point(43, 403);
            this.btnGuiHeirarchy.Name = "btnGuiHeirarchy";
            this.btnGuiHeirarchy.Size = new System.Drawing.Size(100, 23);
            this.btnGuiHeirarchy.TabIndex = 4;
            this.btnGuiHeirarchy.Text = "Render heirarchy";
            this.btnGuiHeirarchy.UseVisualStyleBackColor = true;
            this.btnGuiHeirarchy.Click += new System.EventHandler(this.btnGuiHeirarchy_Click);
            // 
            // btnAddStructure
            // 
            this.btnAddStructure.Location = new System.Drawing.Point(44, 39);
            this.btnAddStructure.Name = "btnAddStructure";
            this.btnAddStructure.Size = new System.Drawing.Size(100, 23);
            this.btnAddStructure.TabIndex = 5;
            this.btnAddStructure.Text = "Add Structure";
            this.btnAddStructure.UseVisualStyleBackColor = true;
            this.btnAddStructure.Click += new System.EventHandler(this.btnAddStructure_Click);
            // 
            // btnEditStructure
            // 
            this.btnEditStructure.Location = new System.Drawing.Point(44, 68);
            this.btnEditStructure.Name = "btnEditStructure";
            this.btnEditStructure.Size = new System.Drawing.Size(100, 23);
            this.btnEditStructure.TabIndex = 6;
            this.btnEditStructure.Text = "Edit Structure";
            this.btnEditStructure.UseVisualStyleBackColor = true;
            this.btnEditStructure.Click += new System.EventHandler(this.btnEditStructure_Click);
            // 
            // grdDepartments
            // 
            this.grdDepartments.AllowUserToAddRows = false;
            this.grdDepartments.AllowUserToDeleteRows = false;
            this.grdDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDepartments.Location = new System.Drawing.Point(150, 39);
            this.grdDepartments.Name = "grdDepartments";
            this.grdDepartments.ReadOnly = true;
            this.grdDepartments.Size = new System.Drawing.Size(227, 265);
            this.grdDepartments.TabIndex = 7;
            this.grdDepartments.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDepartments_RowEnter);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(44, 460);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnDelStructure
            // 
            this.btnDelStructure.Location = new System.Drawing.Point(44, 97);
            this.btnDelStructure.Name = "btnDelStructure";
            this.btnDelStructure.Size = new System.Drawing.Size(100, 23);
            this.btnDelStructure.TabIndex = 9;
            this.btnDelStructure.Text = "Delete Structure";
            this.btnDelStructure.UseVisualStyleBackColor = true;
            this.btnDelStructure.Click += new System.EventHandler(this.btnDelStructure_Click);
            // 
            // grdProjects
            // 
            this.grdProjects.AllowUserToAddRows = false;
            this.grdProjects.AllowUserToDeleteRows = false;
            this.grdProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProjects.Location = new System.Drawing.Point(383, 39);
            this.grdProjects.Name = "grdProjects";
            this.grdProjects.ReadOnly = true;
            this.grdProjects.Size = new System.Drawing.Size(227, 265);
            this.grdProjects.TabIndex = 10;
            this.grdProjects.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProjects_RowEnter);
            // 
            // grdDivisions
            // 
            this.grdDivisions.AllowUserToAddRows = false;
            this.grdDivisions.AllowUserToDeleteRows = false;
            this.grdDivisions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDivisions.Location = new System.Drawing.Point(616, 39);
            this.grdDivisions.Name = "grdDivisions";
            this.grdDivisions.ReadOnly = true;
            this.grdDivisions.Size = new System.Drawing.Size(227, 265);
            this.grdDivisions.TabIndex = 11;
            this.grdDivisions.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDivisions_RowEnter);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(147, 23);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 13;
            this.lblDepartment.Text = "Department";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(380, 23);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(40, 13);
            this.lblProject.TabIndex = 14;
            this.lblProject.Text = "Project";
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(613, 23);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(44, 13);
            this.lblDivision.TabIndex = 15;
            this.lblDivision.Text = "Division";
            // 
            // grdCompanies
            // 
            this.grdCompanies.AllowUserToAddRows = false;
            this.grdCompanies.AllowUserToDeleteRows = false;
            this.grdCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCompanies.Location = new System.Drawing.Point(849, 39);
            this.grdCompanies.Name = "grdCompanies";
            this.grdCompanies.ReadOnly = true;
            this.grdCompanies.Size = new System.Drawing.Size(227, 265);
            this.grdCompanies.TabIndex = 16;
            this.grdCompanies.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCompanies_RowEnter);
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(846, 23);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(51, 13);
            this.lblCompany.TabIndex = 17;
            this.lblCompany.Text = "Company";
            // 
            // treeStructure
            // 
            this.treeStructure.Location = new System.Drawing.Point(1082, 39);
            this.treeStructure.Name = "treeStructure";
            this.treeStructure.Size = new System.Drawing.Size(183, 444);
            this.treeStructure.TabIndex = 18;
            // 
            // StructureOverlayView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 495);
            this.Controls.Add(this.treeStructure);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.grdCompanies);
            this.Controls.Add(this.lblDivision);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.grdDivisions);
            this.Controls.Add(this.grdProjects);
            this.Controls.Add(this.btnDelStructure);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grdDepartments);
            this.Controls.Add(this.btnEditStructure);
            this.Controls.Add(this.btnAddStructure);
            this.Controls.Add(this.btnGuiHeirarchy);
            this.Controls.Add(this.btnDelEmployee);
            this.Controls.Add(this.btnEditEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.grdDepartmentEmployees);
            this.Name = "StructureOverlayView";
            this.Text = "StructureOverlay";
            ((System.ComponentModel.ISupportInitialize)(this.grdDepartmentEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDepartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDivisions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCompanies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDepartmentEmployees;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnDelEmployee;
        private System.Windows.Forms.Button btnGuiHeirarchy;
        private System.Windows.Forms.Button btnAddStructure;
        private System.Windows.Forms.Button btnEditStructure;
        private System.Windows.Forms.DataGridView grdDepartments;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelStructure;
        private System.Windows.Forms.DataGridView grdProjects;
        private System.Windows.Forms.DataGridView grdDivisions;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.DataGridView grdCompanies;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.TreeView treeStructure;
    }
}