namespace project1
{
    partial class FormAuthorization
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
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.buttonAuthorization = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Location = new System.Drawing.Point(64, 90);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(88, 38);
            this.buttonRegistration.TabIndex = 10;
            this.buttonRegistration.Text = "Регистрация";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Логин";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(12, 64);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(140, 20);
            this.textBoxPassword.TabIndex = 6;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(12, 25);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(140, 20);
            this.textBoxLogin.TabIndex = 5;
            // 
            // buttonAuthorization
            // 
            this.buttonAuthorization.Location = new System.Drawing.Point(12, 90);
            this.buttonAuthorization.Name = "buttonAuthorization";
            this.buttonAuthorization.Size = new System.Drawing.Size(46, 38);
            this.buttonAuthorization.TabIndex = 9;
            this.buttonAuthorization.Text = "Вход";
            this.buttonAuthorization.UseVisualStyleBackColor = true;
            this.buttonAuthorization.Click += new System.EventHandler(this.buttonAuthorization_Click);
            // 
            // FormAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(174, 153);
            this.Controls.Add(this.buttonAuthorization);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.MaximizeBox = false;
            this.Name = "FormAuthorization";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Button buttonAuthorization;
    }
}