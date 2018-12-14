namespace project1
{
    partial class FormAddStore
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelSity = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.labelHouse = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxHouse = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAddStore = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.buttonAddCity = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(9, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(109, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Название магазина";
            // 
            // labelSity
            // 
            this.labelSity.AutoSize = true;
            this.labelSity.Location = new System.Drawing.Point(59, 22);
            this.labelSity.Name = "labelSity";
            this.labelSity.Size = new System.Drawing.Size(37, 13);
            this.labelSity.TabIndex = 3;
            this.labelSity.Text = "Город";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(59, 49);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(39, 13);
            this.labelStreet.TabIndex = 4;
            this.labelStreet.Text = "Улица";
            // 
            // labelHouse
            // 
            this.labelHouse.AutoSize = true;
            this.labelHouse.Location = new System.Drawing.Point(59, 76);
            this.labelHouse.Name = "labelHouse";
            this.labelHouse.Size = new System.Drawing.Size(30, 13);
            this.labelHouse.TabIndex = 5;
            this.labelHouse.Text = "Дом";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(124, 6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(210, 20);
            this.textBoxName.TabIndex = 8;
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(112, 46);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(210, 20);
            this.textBoxStreet.TabIndex = 11;
            // 
            // textBoxHouse
            // 
            this.textBoxHouse.Location = new System.Drawing.Point(112, 73);
            this.textBoxHouse.Name = "textBoxHouse";
            this.textBoxHouse.Size = new System.Drawing.Size(210, 20);
            this.textBoxHouse.TabIndex = 12;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(124, 167);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 45);
            this.buttonBack.TabIndex = 13;
            this.buttonBack.Text = "Отменить добавление";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAddStore
            // 
            this.buttonAddStore.Location = new System.Drawing.Point(12, 167);
            this.buttonAddStore.Name = "buttonAddStore";
            this.buttonAddStore.Size = new System.Drawing.Size(100, 45);
            this.buttonAddStore.TabIndex = 14;
            this.buttonAddStore.Text = "Добавить магазин";
            this.buttonAddStore.UseVisualStyleBackColor = true;
            this.buttonAddStore.Click += new System.EventHandler(this.buttonAddStore_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxCity);
            this.groupBox1.Controls.Add(this.labelSity);
            this.groupBox1.Controls.Add(this.textBoxHouse);
            this.groupBox1.Controls.Add(this.labelStreet);
            this.groupBox1.Controls.Add(this.textBoxStreet);
            this.groupBox1.Controls.Add(this.labelHouse);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 110);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Адрес";
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(112, 19);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(210, 21);
            this.comboBoxCity.TabIndex = 14;
            // 
            // buttonAddCity
            // 
            this.buttonAddCity.Location = new System.Drawing.Point(371, 51);
            this.buttonAddCity.Name = "buttonAddCity";
            this.buttonAddCity.Size = new System.Drawing.Size(150, 23);
            this.buttonAddCity.TabIndex = 17;
            this.buttonAddCity.Text = "Добавить новый город";
            this.buttonAddCity.UseVisualStyleBackColor = true;
            this.buttonAddCity.Click += new System.EventHandler(this.buttonAddCity_Click);
            // 
            // FormAddStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(564, 245);
            this.Controls.Add(this.buttonAddCity);
            this.Controls.Add(this.buttonAddStore);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelName);
            this.MaximizeBox = false;
            this.Name = "FormAddStore";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление нового магазина";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddStore_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSity;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.Label labelHouse;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.TextBox textBoxHouse;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAddStore;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.Button buttonAddCity;
    }
}