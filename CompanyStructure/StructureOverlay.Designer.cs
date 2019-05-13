namespace CompanyStructure
{
    partial class StructureOverlay
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
            this.grdStructure = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelStructure = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.treeStructures = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.grdDepartmentEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdStructure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDepartmentEmployees
            // 
            this.grdDepartmentEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDepartmentEmployees.Location = new System.Drawing.Point(149, 316);
            this.grdDepartmentEmployees.Name = "grdDepartmentEmployees";
            this.grdDepartmentEmployees.Size = new System.Drawing.Size(694, 167);
            this.grdDepartmentEmployees.TabIndex = 0;
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
            // grdStructure
            // 
            this.grdStructure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStructure.Location = new System.Drawing.Point(150, 39);
            this.grdStructure.Name = "grdStructure";
            this.grdStructure.Size = new System.Drawing.Size(227, 265);
            this.grdStructure.TabIndex = 7;
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(383, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(227, 265);
            this.dataGridView1.TabIndex = 10;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(616, 39);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(227, 265);
            this.dataGridView2.TabIndex = 11;
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
            // treeStructures
            // 
            this.treeStructures.Location = new System.Drawing.Point(849, 39);
            this.treeStructures.Name = "treeStructures";
            this.treeStructures.Size = new System.Drawing.Size(307, 444);
            this.treeStructures.TabIndex = 16;
            // 
            // StructureOverlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 495);
            this.Controls.Add(this.treeStructures);
            this.Controls.Add(this.lblDivision);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelStructure);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grdStructure);
            this.Controls.Add(this.btnEditStructure);
            this.Controls.Add(this.btnAddStructure);
            this.Controls.Add(this.btnGuiHeirarchy);
            this.Controls.Add(this.btnDelEmployee);
            this.Controls.Add(this.btnEditEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.grdDepartmentEmployees);
            this.Name = "StructureOverlay";
            this.Text = "StructureOverlay";
            ((System.ComponentModel.ISupportInitialize)(this.grdDepartmentEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdStructure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.DataGridView grdStructure;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelStructure;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.TreeView treeStructures;
    }
}