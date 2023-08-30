namespace Project
{
    partial class SalesListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesListForm));
            this.SalesDGV = new System.Windows.Forms.DataGridView();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serializationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSerializeXML = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSerializeBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSerializeJSON = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSerializeTextFile = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeserializeXML = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeserializeBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeserializeJSON = new System.Windows.Forms.ToolStripMenuItem();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SalesDGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalesDGV
            // 
            this.SalesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.FirstNameColumn,
            this.LastNameColumn,
            this.PhoneNumberColumn,
            this.EmailColumn,
            this.ValueColumn,
            this.DateTimeColumn,
            this.DepartmentColumn});
            this.SalesDGV.Location = new System.Drawing.Point(12, 31);
            this.SalesDGV.Name = "SalesDGV";
            this.SalesDGV.RowHeadersWidth = 51;
            this.SalesDGV.RowTemplate.Height = 24;
            this.SalesDGV.Size = new System.Drawing.Size(940, 389);
            this.SalesDGV.TabIndex = 0;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(634, 436);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(796, 436);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(877, 436);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(715, 436);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 4;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializationToolStripMenuItem,
            this.deserializationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(961, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serializationToolStripMenuItem
            // 
            this.serializationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSerializeXML,
            this.btnSerializeBinary,
            this.btnSerializeJSON,
            this.btnSerializeTextFile});
            this.serializationToolStripMenuItem.Name = "serializationToolStripMenuItem";
            this.serializationToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.serializationToolStripMenuItem.Text = "Serialization";
            // 
            // btnSerializeXML
            // 
            this.btnSerializeXML.Name = "btnSerializeXML";
            this.btnSerializeXML.Size = new System.Drawing.Size(146, 26);
            this.btnSerializeXML.Text = "XML";
            this.btnSerializeXML.Click += new System.EventHandler(this.btnSerializeXML_Click);
            // 
            // btnSerializeBinary
            // 
            this.btnSerializeBinary.Name = "btnSerializeBinary";
            this.btnSerializeBinary.Size = new System.Drawing.Size(146, 26);
            this.btnSerializeBinary.Text = "Binary";
            this.btnSerializeBinary.Click += new System.EventHandler(this.btnSerializeBinary_Click);
            // 
            // btnSerializeJSON
            // 
            this.btnSerializeJSON.Name = "btnSerializeJSON";
            this.btnSerializeJSON.Size = new System.Drawing.Size(146, 26);
            this.btnSerializeJSON.Text = "JSON";
            this.btnSerializeJSON.Click += new System.EventHandler(this.btnSerializeJSON_Click);
            // 
            // btnSerializeTextFile
            // 
            this.btnSerializeTextFile.Name = "btnSerializeTextFile";
            this.btnSerializeTextFile.Size = new System.Drawing.Size(146, 26);
            this.btnSerializeTextFile.Text = "Text File";
            this.btnSerializeTextFile.Click += new System.EventHandler(this.btnSerializeTextFile_Click);
            // 
            // deserializationToolStripMenuItem
            // 
            this.deserializationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDeserializeXML,
            this.btnDeserializeBinary,
            this.btnDeserializeJSON});
            this.deserializationToolStripMenuItem.Name = "deserializationToolStripMenuItem";
            this.deserializationToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deserializationToolStripMenuItem.Text = "Deserialization";
            // 
            // btnDeserializeXML
            // 
            this.btnDeserializeXML.Name = "btnDeserializeXML";
            this.btnDeserializeXML.Size = new System.Drawing.Size(133, 26);
            this.btnDeserializeXML.Text = "XML";
            this.btnDeserializeXML.Click += new System.EventHandler(this.btnDeserializeXML_Click);
            // 
            // btnDeserializeBinary
            // 
            this.btnDeserializeBinary.Name = "btnDeserializeBinary";
            this.btnDeserializeBinary.Size = new System.Drawing.Size(133, 26);
            this.btnDeserializeBinary.Text = "Binary";
            this.btnDeserializeBinary.Click += new System.EventHandler(this.btnDeserializeBinary_Click);
            // 
            // btnDeserializeJSON
            // 
            this.btnDeserializeJSON.Name = "btnDeserializeJSON";
            this.btnDeserializeJSON.Size = new System.Drawing.Size(133, 26);
            this.btnDeserializeJSON.Text = "JSON";
            this.btnDeserializeJSON.Click += new System.EventHandler(this.btnDeserializeJSON_Click);
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.MinimumWidth = 6;
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.Width = 125;
            // 
            // FirstNameColumn
            // 
            this.FirstNameColumn.HeaderText = "First Name";
            this.FirstNameColumn.MinimumWidth = 6;
            this.FirstNameColumn.Name = "FirstNameColumn";
            this.FirstNameColumn.Width = 125;
            // 
            // LastNameColumn
            // 
            this.LastNameColumn.HeaderText = "Last Name";
            this.LastNameColumn.MinimumWidth = 6;
            this.LastNameColumn.Name = "LastNameColumn";
            this.LastNameColumn.Width = 125;
            // 
            // PhoneNumberColumn
            // 
            this.PhoneNumberColumn.HeaderText = "Phone Number";
            this.PhoneNumberColumn.MinimumWidth = 6;
            this.PhoneNumberColumn.Name = "PhoneNumberColumn";
            this.PhoneNumberColumn.Width = 125;
            // 
            // EmailColumn
            // 
            this.EmailColumn.HeaderText = "Email";
            this.EmailColumn.MinimumWidth = 6;
            this.EmailColumn.Name = "EmailColumn";
            this.EmailColumn.Width = 125;
            // 
            // ValueColumn
            // 
            this.ValueColumn.HeaderText = "Value";
            this.ValueColumn.MinimumWidth = 6;
            this.ValueColumn.Name = "ValueColumn";
            this.ValueColumn.Width = 125;
            // 
            // DateTimeColumn
            // 
            this.DateTimeColumn.HeaderText = "Date";
            this.DateTimeColumn.MinimumWidth = 6;
            this.DateTimeColumn.Name = "DateTimeColumn";
            this.DateTimeColumn.Width = 125;
            // 
            // DepartmentColumn
            // 
            this.DepartmentColumn.HeaderText = "Department";
            this.DepartmentColumn.MinimumWidth = 6;
            this.DepartmentColumn.Name = "DepartmentColumn";
            this.DepartmentColumn.Width = 125;
            // 
            // SalesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 471);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.SalesDGV);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SalesListForm";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.SalesListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesDGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SalesDGV;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serializationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSerializeXML;
        private System.Windows.Forms.ToolStripMenuItem btnSerializeBinary;
        private System.Windows.Forms.ToolStripMenuItem deserializationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnDeserializeXML;
        private System.Windows.Forms.ToolStripMenuItem btnDeserializeBinary;
        private System.Windows.Forms.ToolStripMenuItem btnSerializeTextFile;
        private System.Windows.Forms.ToolStripMenuItem btnSerializeJSON;
        private System.Windows.Forms.ToolStripMenuItem btnDeserializeJSON;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentColumn;
    }
}