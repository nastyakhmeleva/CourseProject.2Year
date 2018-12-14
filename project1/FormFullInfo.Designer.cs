namespace project1
{
    partial class FormFullInfo
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
            this.dataGridViewFull = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Series = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoverType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Store = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonExport = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelGenreDescription = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelBookDescription = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSearching = new System.Windows.Forms.Button();
            this.textBoxSearching = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFull)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewFull
            // 
            this.dataGridViewFull.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFull.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Year,
            this.Series,
            this.CoverType,
            this.Number,
            this.Store,
            this.Address});
            this.dataGridViewFull.Location = new System.Drawing.Point(155, 155);
            this.dataGridViewFull.MultiSelect = false;
            this.dataGridViewFull.Name = "dataGridViewFull";
            this.dataGridViewFull.ReadOnly = true;
            this.dataGridViewFull.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFull.Size = new System.Drawing.Size(817, 344);
            this.dataGridViewFull.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // Year
            // 
            this.Year.HeaderText = "Год публикации";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            this.Year.Width = 70;
            // 
            // Series
            // 
            this.Series.HeaderText = "Серия";
            this.Series.Name = "Series";
            this.Series.ReadOnly = true;
            this.Series.Width = 135;
            // 
            // CoverType
            // 
            this.CoverType.HeaderText = "Тип обложки";
            this.CoverType.Name = "CoverType";
            this.CoverType.ReadOnly = true;
            this.CoverType.Width = 85;
            // 
            // Number
            // 
            this.Number.HeaderText = "Количество";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 70;
            // 
            // Store
            // 
            this.Store.HeaderText = "Магазин";
            this.Store.Name = "Store";
            this.Store.ReadOnly = true;
            this.Store.Width = 174;
            // 
            // Address
            // 
            this.Address.HeaderText = "Адрес";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 190;
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(9, 155);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(140, 25);
            this.buttonExport.TabIndex = 11;
            this.buttonExport.Text = "Экспорт в Excel";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(99, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(35, 13);
            this.labelTitle.TabIndex = 36;
            this.labelTitle.Text = "label7";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(99, 32);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(35, 13);
            this.labelAuthor.TabIndex = 35;
            this.labelAuthor.Text = "label7";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(99, 55);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(35, 13);
            this.labelGenre.TabIndex = 34;
            this.labelGenre.Text = "label7";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Жанр";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Автор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Название";
            // 
            // labelGenreDescription
            // 
            this.labelGenreDescription.AutoSize = true;
            this.labelGenreDescription.Location = new System.Drawing.Point(801, 9);
            this.labelGenreDescription.MaximumSize = new System.Drawing.Size(200, 0);
            this.labelGenreDescription.Name = "labelGenreDescription";
            this.labelGenreDescription.Size = new System.Drawing.Size(35, 13);
            this.labelGenreDescription.TabIndex = 30;
            this.labelGenreDescription.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(703, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Описание жанра";
            // 
            // labelBookDescription
            // 
            this.labelBookDescription.AutoSize = true;
            this.labelBookDescription.Location = new System.Drawing.Point(443, 9);
            this.labelBookDescription.MaximumSize = new System.Drawing.Size(260, 0);
            this.labelBookDescription.Name = "labelBookDescription";
            this.labelBookDescription.Size = new System.Drawing.Size(35, 13);
            this.labelBookDescription.TabIndex = 28;
            this.labelBookDescription.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Описание книги";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonReset);
            this.groupBox1.Controls.Add(this.buttonSearching);
            this.groupBox1.Controls.Add(this.textBoxSearching);
            this.groupBox1.Location = new System.Drawing.Point(9, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 103);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(0, 74);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(140, 25);
            this.buttonReset.TabIndex = 28;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSearching
            // 
            this.buttonSearching.Location = new System.Drawing.Point(0, 45);
            this.buttonSearching.Name = "buttonSearching";
            this.buttonSearching.Size = new System.Drawing.Size(140, 25);
            this.buttonSearching.TabIndex = 13;
            this.buttonSearching.Text = "Поиск";
            this.buttonSearching.UseVisualStyleBackColor = true;
            this.buttonSearching.Click += new System.EventHandler(this.buttonSearching_Click);
            // 
            // textBoxSearching
            // 
            this.textBoxSearching.Location = new System.Drawing.Point(0, 19);
            this.textBoxSearching.Name = "textBoxSearching";
            this.textBoxSearching.Size = new System.Drawing.Size(140, 20);
            this.textBoxSearching.TabIndex = 16;
            // 
            // FormFullInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1004, 511);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelGenreDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelBookDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.dataGridViewFull);
            this.MaximizeBox = false;
            this.Name = "FormFullInfo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Полная информация о книге";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFullInfo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFull)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFull;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelGenreDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelBookDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSearching;
        private System.Windows.Forms.TextBox textBoxSearching;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Series;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoverType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Store;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}