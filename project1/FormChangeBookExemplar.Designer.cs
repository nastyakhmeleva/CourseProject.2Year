namespace project1
{
    partial class FormChangeBookExemplar
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
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.buttonAddStore = new System.Windows.Forms.Button();
            this.buttonAddSeries = new System.Windows.Forms.Button();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.comboBoxStore = new System.Windows.Forms.ComboBox();
            this.comboBoxSeries = new System.Windows.Forms.ComboBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelSeries = new System.Windows.Forms.Label();
            this.labelStore = new System.Windows.Forms.Label();
            this.labelBookDescription = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonChangeInfo = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelGenreDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(151, 81);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(140, 20);
            this.textBoxYear.TabIndex = 81;
            // 
            // buttonAddStore
            // 
            this.buttonAddStore.Location = new System.Drawing.Point(297, 160);
            this.buttonAddStore.Name = "buttonAddStore";
            this.buttonAddStore.Size = new System.Drawing.Size(150, 23);
            this.buttonAddStore.TabIndex = 80;
            this.buttonAddStore.Text = "Добавить новый магазин";
            this.buttonAddStore.UseVisualStyleBackColor = true;
            this.buttonAddStore.Click += new System.EventHandler(this.buttonAddStore_Click);
            // 
            // buttonAddSeries
            // 
            this.buttonAddSeries.Location = new System.Drawing.Point(297, 107);
            this.buttonAddSeries.Name = "buttonAddSeries";
            this.buttonAddSeries.Size = new System.Drawing.Size(150, 23);
            this.buttonAddSeries.TabIndex = 79;
            this.buttonAddSeries.Text = "Добавить новую серию";
            this.buttonAddSeries.UseVisualStyleBackColor = true;
            this.buttonAddSeries.Click += new System.EventHandler(this.buttonAddSeries_Click);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(151, 134);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(140, 20);
            this.textBoxNumber.TabIndex = 78;
            // 
            // comboBoxStore
            // 
            this.comboBoxStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStore.FormattingEnabled = true;
            this.comboBoxStore.Location = new System.Drawing.Point(151, 160);
            this.comboBoxStore.Name = "comboBoxStore";
            this.comboBoxStore.Size = new System.Drawing.Size(140, 21);
            this.comboBoxStore.TabIndex = 77;
            // 
            // comboBoxSeries
            // 
            this.comboBoxSeries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSeries.FormattingEnabled = true;
            this.comboBoxSeries.Location = new System.Drawing.Point(151, 107);
            this.comboBoxSeries.Name = "comboBoxSeries";
            this.comboBoxSeries.Size = new System.Drawing.Size(140, 21);
            this.comboBoxSeries.TabIndex = 76;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(9, 137);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(66, 13);
            this.labelNumber.TabIndex = 75;
            this.labelNumber.Text = "Количество";
            // 
            // labelSeries
            // 
            this.labelSeries.AutoSize = true;
            this.labelSeries.Location = new System.Drawing.Point(9, 110);
            this.labelSeries.Name = "labelSeries";
            this.labelSeries.Size = new System.Drawing.Size(38, 13);
            this.labelSeries.TabIndex = 74;
            this.labelSeries.Text = "Серия";
            // 
            // labelStore
            // 
            this.labelStore.AutoSize = true;
            this.labelStore.Location = new System.Drawing.Point(9, 163);
            this.labelStore.Name = "labelStore";
            this.labelStore.Size = new System.Drawing.Size(51, 13);
            this.labelStore.TabIndex = 73;
            this.labelStore.Text = "Магазин";
            // 
            // labelBookDescription
            // 
            this.labelBookDescription.AutoSize = true;
            this.labelBookDescription.Location = new System.Drawing.Point(576, 9);
            this.labelBookDescription.MaximumSize = new System.Drawing.Size(300, 0);
            this.labelBookDescription.Name = "labelBookDescription";
            this.labelBookDescription.Size = new System.Drawing.Size(35, 13);
            this.labelBookDescription.TabIndex = 72;
            this.labelBookDescription.Text = "label6";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(149, 55);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(35, 13);
            this.labelGenre.TabIndex = 71;
            this.labelGenre.Text = "label5";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(149, 32);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(35, 13);
            this.labelAuthor.TabIndex = 70;
            this.labelAuthor.Text = "label4";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(149, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(35, 13);
            this.labelTitle.TabIndex = 69;
            this.labelTitle.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Автор";
            // 
            // buttonChangeInfo
            // 
            this.buttonChangeInfo.Location = new System.Drawing.Point(12, 220);
            this.buttonChangeInfo.Name = "buttonChangeInfo";
            this.buttonChangeInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonChangeInfo.Size = new System.Drawing.Size(100, 45);
            this.buttonChangeInfo.TabIndex = 67;
            this.buttonChangeInfo.Text = "Изменить информацию";
            this.buttonChangeInfo.UseVisualStyleBackColor = true;
            this.buttonChangeInfo.Click += new System.EventHandler(this.buttonChangeInfo_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(127, 220);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 45);
            this.buttonBack.TabIndex = 66;
            this.buttonBack.Text = "Отменить изменение";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "Описание книги";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Жанр";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Год публикации книги";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Название книги";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 82;
            this.label6.Text = "Описание жанра";
            // 
            // labelGenreDescription
            // 
            this.labelGenreDescription.AutoSize = true;
            this.labelGenreDescription.Location = new System.Drawing.Point(576, 116);
            this.labelGenreDescription.MaximumSize = new System.Drawing.Size(300, 0);
            this.labelGenreDescription.Name = "labelGenreDescription";
            this.labelGenreDescription.Size = new System.Drawing.Size(35, 13);
            this.labelGenreDescription.TabIndex = 83;
            this.labelGenreDescription.Text = "label6";
            // 
            // FormChangeBookExemplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(884, 286);
            this.Controls.Add(this.labelGenreDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.buttonAddStore);
            this.Controls.Add(this.buttonAddSeries);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.comboBoxStore);
            this.Controls.Add(this.comboBoxSeries);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelSeries);
            this.Controls.Add(this.labelStore);
            this.Controls.Add(this.labelBookDescription);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonChangeInfo);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormChangeBookExemplar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение информации об экземпляре книги";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormChangeBookExemplar_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Button buttonAddStore;
        private System.Windows.Forms.Button buttonAddSeries;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.ComboBox comboBoxStore;
        private System.Windows.Forms.ComboBox comboBoxSeries;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelSeries;
        private System.Windows.Forms.Label labelStore;
        private System.Windows.Forms.Label labelBookDescription;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonChangeInfo;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelGenreDescription;
    }
}