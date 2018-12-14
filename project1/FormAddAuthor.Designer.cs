namespace project1
{
    partial class FormAddAuthor
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.buttonAddAuthor = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.buttonAddCountry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Страна";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(83, 32);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(210, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(83, 6);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(210, 20);
            this.textBoxSurname.TabIndex = 4;
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Location = new System.Drawing.Point(83, 58);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(210, 20);
            this.textBoxSecondName.TabIndex = 6;
            // 
            // buttonAddAuthor
            // 
            this.buttonAddAuthor.Location = new System.Drawing.Point(12, 161);
            this.buttonAddAuthor.Name = "buttonAddAuthor";
            this.buttonAddAuthor.Size = new System.Drawing.Size(100, 45);
            this.buttonAddAuthor.TabIndex = 8;
            this.buttonAddAuthor.Text = "Добавить автора";
            this.buttonAddAuthor.UseVisualStyleBackColor = true;
            this.buttonAddAuthor.Click += new System.EventHandler(this.buttonAddAuthor_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(128, 161);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 45);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.Text = "Отменить добавление";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(83, 84);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(211, 21);
            this.comboBoxCountry.TabIndex = 10;
            // 
            // buttonAddCountry
            // 
            this.buttonAddCountry.Location = new System.Drawing.Point(146, 111);
            this.buttonAddCountry.Name = "buttonAddCountry";
            this.buttonAddCountry.Size = new System.Drawing.Size(148, 21);
            this.buttonAddCountry.TabIndex = 11;
            this.buttonAddCountry.Text = "Добавить новую страну";
            this.buttonAddCountry.UseVisualStyleBackColor = true;
            this.buttonAddCountry.Click += new System.EventHandler(this.buttonAddCountry_Click);
            // 
            // FormAddAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(324, 231);
            this.Controls.Add(this.buttonAddCountry);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAddAuthor);
            this.Controls.Add(this.textBoxSecondName);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormAddAuthor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление нового автора";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddAuthor_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.Button buttonAddAuthor;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Button buttonAddCountry;
    }
}