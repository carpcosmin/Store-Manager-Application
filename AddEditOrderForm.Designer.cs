namespace Project
{
    partial class AddEditOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditOrderForm));
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.OrderDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ValueField = new System.Windows.Forms.NumericUpDown();
            this.FNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.LNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.EmailErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ValueErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.DeptComboBox = new System.Windows.Forms.ComboBox();
            this.DeptErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PhoneNoLabel = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ValueField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FNameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LNameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeptErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNumberErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(13, 13);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(75, 16);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(13, 51);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(75, 16);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(110, 48);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(121, 22);
            this.LastNameTextBox.TabIndex = 3;
            this.LastNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.LastNameTextBox_Validating);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(13, 88);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(44, 16);
            this.EmailLabel.TabIndex = 4;
            this.EmailLabel.Text = "Email:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(110, 85);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(121, 22);
            this.EmailTextBox.TabIndex = 5;
            this.EmailTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.EmailTextBox_Validating);
            // 
            // BtnOK
            // 
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.Location = new System.Drawing.Point(402, 148);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 8;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(497, 148);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 9;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(345, 88);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(45, 16);
            this.ValueLabel.TabIndex = 12;
            this.ValueLabel.Text = "Value:";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(110, 10);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(121, 22);
            this.FirstNameTextBox.TabIndex = 1;
            this.FirstNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.FirstNameTextBox_Validating);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(13, 127);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(39, 16);
            this.DateLabel.TabIndex = 16;
            this.DateLabel.Text = "Date:";
            // 
            // OrderDateTimePicker
            // 
            this.OrderDateTimePicker.Location = new System.Drawing.Point(110, 122);
            this.OrderDateTimePicker.Name = "OrderDateTimePicker";
            this.OrderDateTimePicker.Size = new System.Drawing.Size(208, 22);
            this.OrderDateTimePicker.TabIndex = 17;
            // 
            // ValueField
            // 
            this.ValueField.Location = new System.Drawing.Point(452, 82);
            this.ValueField.Name = "ValueField";
            this.ValueField.Size = new System.Drawing.Size(120, 22);
            this.ValueField.TabIndex = 18;
            this.ValueField.Validating += new System.ComponentModel.CancelEventHandler(this.ValueField_Validating);
            // 
            // FNameErrorProvider
            // 
            this.FNameErrorProvider.ContainerControl = this;
            // 
            // LNameErrorProvider
            // 
            this.LNameErrorProvider.ContainerControl = this;
            // 
            // EmailErrorProvider
            // 
            this.EmailErrorProvider.ContainerControl = this;
            // 
            // ValueErrorProvider
            // 
            this.ValueErrorProvider.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Department:";
            // 
            // DeptComboBox
            // 
            this.DeptComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeptComboBox.FormattingEnabled = true;
            this.DeptComboBox.Location = new System.Drawing.Point(451, 45);
            this.DeptComboBox.Name = "DeptComboBox";
            this.DeptComboBox.Size = new System.Drawing.Size(121, 24);
            this.DeptComboBox.TabIndex = 21;
            this.DeptComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.DepartmentTextBox_Validating);
            // 
            // DeptErrorProvider
            // 
            this.DeptErrorProvider.ContainerControl = this;
            // 
            // PhoneNoLabel
            // 
            this.PhoneNoLabel.AutoSize = true;
            this.PhoneNoLabel.Location = new System.Drawing.Point(345, 13);
            this.PhoneNoLabel.Name = "PhoneNoLabel";
            this.PhoneNoLabel.Size = new System.Drawing.Size(100, 16);
            this.PhoneNoLabel.TabIndex = 22;
            this.PhoneNoLabel.Text = "Phone Number:";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(451, 10);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(121, 22);
            this.PhoneNumberTextBox.TabIndex = 23;
            this.PhoneNumberTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.PhoneNumberTextBox_Validating);
            // 
            // PhoneNumberErrorProvider
            // 
            this.PhoneNumberErrorProvider.ContainerControl = this;
            // 
            // AddEditOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 183);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.PhoneNoLabel);
            this.Controls.Add(this.DeptComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ValueField);
            this.Controls.Add(this.OrderDateTimePicker);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.FirstNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEditOrderForm";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.AddEditOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ValueField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FNameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LNameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeptErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNumberErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.DateTimePicker OrderDateTimePicker;
        private System.Windows.Forms.NumericUpDown ValueField;
        private System.Windows.Forms.ErrorProvider FNameErrorProvider;
        private System.Windows.Forms.ErrorProvider LNameErrorProvider;
        private System.Windows.Forms.ErrorProvider EmailErrorProvider;
        private System.Windows.Forms.ErrorProvider ValueErrorProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DeptComboBox;
        private System.Windows.Forms.ErrorProvider DeptErrorProvider;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label PhoneNoLabel;
        private System.Windows.Forms.ErrorProvider PhoneNumberErrorProvider;
    }
}