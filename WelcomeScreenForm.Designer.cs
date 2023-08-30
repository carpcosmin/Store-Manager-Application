namespace Project
{
    partial class WelcomeScreenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeScreenForm));
            this.BtnOrders = new System.Windows.Forms.Button();
            this.BtnDeptInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnOrders
            // 
            this.BtnOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOrders.Location = new System.Drawing.Point(60, 99);
            this.BtnOrders.Name = "BtnOrders";
            this.BtnOrders.Size = new System.Drawing.Size(163, 78);
            this.BtnOrders.TabIndex = 1;
            this.BtnOrders.Text = "Sales";
            this.BtnOrders.UseVisualStyleBackColor = true;
            this.BtnOrders.Click += new System.EventHandler(this.BtnOrders_Click);
            // 
            // BtnDeptInfo
            // 
            this.BtnDeptInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeptInfo.Location = new System.Drawing.Point(333, 99);
            this.BtnDeptInfo.Name = "BtnDeptInfo";
            this.BtnDeptInfo.Size = new System.Drawing.Size(163, 78);
            this.BtnDeptInfo.TabIndex = 2;
            this.BtnDeptInfo.Text = "Departments Info";
            this.BtnDeptInfo.UseVisualStyleBackColor = true;
            this.BtnDeptInfo.Click += new System.EventHandler(this.BtnDeptInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to Shop and Go";
            // 
            // WelcomeScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 226);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnDeptInfo);
            this.Controls.Add(this.BtnOrders);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WelcomeScreenForm";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnOrders;
        private System.Windows.Forms.Button BtnDeptInfo;
        private System.Windows.Forms.Label label1;
    }
}

