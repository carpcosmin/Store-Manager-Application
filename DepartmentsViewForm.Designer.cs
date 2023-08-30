namespace Project
{
    partial class DepartmentsViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentsViewForm));
            this.DepartmentsDGV = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DepartmentsDGV
            // 
            this.DepartmentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepartmentsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.NameColumn});
            this.DepartmentsDGV.Location = new System.Drawing.Point(13, 13);
            this.DepartmentsDGV.Name = "DepartmentsDGV";
            this.DepartmentsDGV.RowHeadersWidth = 51;
            this.DepartmentsDGV.RowTemplate.Height = 24;
            this.DepartmentsDGV.Size = new System.Drawing.Size(431, 391);
            this.DepartmentsDGV.TabIndex = 0;
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.MinimumWidth = 6;
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.Width = 125;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.MinimumWidth = 6;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.Width = 125;
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ExitButton.Location = new System.Drawing.Point(369, 417);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // DepartmentsViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 452);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DepartmentsDGV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DepartmentsViewForm";
            this.Text = "Departments";
            this.Load += new System.EventHandler(this.DepartmentsViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentsDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DepartmentsDGV;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
    }
}