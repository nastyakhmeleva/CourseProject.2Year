namespace project1
{
    partial class FormAddCountry
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.buttonAddCountry = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название страны";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(112, 6);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(210, 20);
            this.textBoxTitle.TabIndex = 1;
            // 
            // buttonAddCountry
            // 
            this.buttonAddCountry.Location = new System.Drawing.Point(12, 53);
            this.buttonAddCountry.Name = "buttonAddCountry";
            this.buttonAddCountry.Size = new System.Drawing.Size(100, 45);
            this.buttonAddCountry.TabIndex = 2;
            this.buttonAddCountry.Text = "Добавить страну";
            this.buttonAddCountry.UseVisualStyleBackColor = true;
            this.buttonAddCountry.Click += new System.EventHandler(this.buttonAddCountry_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(127, 53);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 45);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Отменить добавление";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormAddCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(352, 142);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAddCountry);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormAddCountry";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление новой страны";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddCountry_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button buttonAddCountry;
        private System.Windows.Forms.Button buttonBack;
    }
}