namespace LoginApplication
{
    partial class FormCreateAccount
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
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.txtCreateUsername = new System.Windows.Forms.TextBox();
            this.lblCreateUsername = new System.Windows.Forms.Label();
            this.txtCreatePassword = new System.Windows.Forms.TextBox();
            this.lblCreatePassword = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblAddInformationOne = new System.Windows.Forms.Label();
            this.lblAddInformationTwo = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginTitle.Location = new System.Drawing.Point(151, 78);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(151, 51);
            this.lblLoginTitle.TabIndex = 1;
            this.lblLoginTitle.Text = "Create";
            // 
            // txtCreateUsername
            // 
            this.txtCreateUsername.Location = new System.Drawing.Point(13, 225);
            this.txtCreateUsername.Name = "txtCreateUsername";
            this.txtCreateUsername.Size = new System.Drawing.Size(435, 31);
            this.txtCreateUsername.TabIndex = 2;
            this.txtCreateUsername.TextChanged += new System.EventHandler(this.TxtCreateUsername_TextChanged);
            // 
            // lblCreateUsername
            // 
            this.lblCreateUsername.AutoSize = true;
            this.lblCreateUsername.Location = new System.Drawing.Point(13, 194);
            this.lblCreateUsername.Name = "lblCreateUsername";
            this.lblCreateUsername.Size = new System.Drawing.Size(180, 25);
            this.lblCreateUsername.TabIndex = 3;
            this.lblCreateUsername.Text = "Create Username";
            // 
            // txtCreatePassword
            // 
            this.txtCreatePassword.Location = new System.Drawing.Point(13, 321);
            this.txtCreatePassword.Name = "txtCreatePassword";
            this.txtCreatePassword.Size = new System.Drawing.Size(435, 31);
            this.txtCreatePassword.TabIndex = 4;
            this.txtCreatePassword.TextChanged += new System.EventHandler(this.TxtCreatePassword_TextChanged);
            // 
            // lblCreatePassword
            // 
            this.lblCreatePassword.AutoSize = true;
            this.lblCreatePassword.Location = new System.Drawing.Point(13, 290);
            this.lblCreatePassword.Name = "lblCreatePassword";
            this.lblCreatePassword.Size = new System.Drawing.Size(176, 25);
            this.lblCreatePassword.TabIndex = 5;
            this.lblCreatePassword.Text = "Create Password";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 466);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(435, 51);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblAddInformationOne
            // 
            this.lblAddInformationOne.AutoSize = true;
            this.lblAddInformationOne.Location = new System.Drawing.Point(13, 359);
            this.lblAddInformationOne.Name = "lblAddInformationOne";
            this.lblAddInformationOne.Size = new System.Drawing.Size(209, 25);
            this.lblAddInformationOne.TabIndex = 7;
            this.lblAddInformationOne.Text = "At least 6 characters";
            // 
            // lblAddInformationTwo
            // 
            this.lblAddInformationTwo.AutoSize = true;
            this.lblAddInformationTwo.Location = new System.Drawing.Point(13, 394);
            this.lblAddInformationTwo.Name = "lblAddInformationTwo";
            this.lblAddInformationTwo.Size = new System.Drawing.Size(225, 25);
            this.lblAddInformationTwo.TabIndex = 8;
            this.lblAddInformationTwo.Text = "At least 1 capital letter";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(13, 532);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(435, 51);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FormCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 599);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblAddInformationTwo);
            this.Controls.Add(this.lblAddInformationOne);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblCreatePassword);
            this.Controls.Add(this.txtCreatePassword);
            this.Controls.Add(this.lblCreateUsername);
            this.Controls.Add(this.txtCreateUsername);
            this.Controls.Add(this.lblLoginTitle);
            this.Name = "FormCreateAccount";
            this.Text = "FormCreateAccount";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCreateAccount_FormClosed);
            this.Load += new System.EventHandler(this.FormCreateAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.TextBox txtCreateUsername;
        private System.Windows.Forms.Label lblCreateUsername;
        private System.Windows.Forms.TextBox txtCreatePassword;
        private System.Windows.Forms.Label lblCreatePassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblAddInformationOne;
        private System.Windows.Forms.Label lblAddInformationTwo;
        private System.Windows.Forms.Button btnCancel;
    }
}