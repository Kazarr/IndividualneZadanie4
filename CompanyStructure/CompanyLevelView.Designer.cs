namespace CompanyStructure
{
    partial class CompanyLevelView
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
            this.grdCompanies = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdCompanies)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCompanies
            // 
            this.grdCompanies.AllowUserToAddRows = false;
            this.grdCompanies.AllowUserToDeleteRows = false;
            this.grdCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCompanies.Location = new System.Drawing.Point(12, 12);
            this.grdCompanies.Name = "grdCompanies";
            this.grdCompanies.ReadOnly = true;
            this.grdCompanies.Size = new System.Drawing.Size(267, 209);
            this.grdCompanies.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(124, 227);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Company";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(205, 227);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(75, 23);
            this.btnChoose.TabIndex = 2;
            this.btnChoose.Text = "Show Company";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(12, 227);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Cancel";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // CompanyLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 269);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grdCompanies);
            this.Name = "CompanyLevel";
            this.Text = "CompanyLevel";
            ((System.ComponentModel.ISupportInitialize)(this.grdCompanies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdCompanies;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnExit;
    }
}