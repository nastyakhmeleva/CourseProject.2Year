namespace project1
{
    partial class FormAdminMainMenu
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
            this.dataGridViewB = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonSearching = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.textBoxSearching = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewB
            // 
            this.dataGridViewB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.Author,
            this.Genre});
            this.dataGridViewB.Location = new System.Drawing.Point(155, 9);
            this.dataGridViewB.MultiSelect = false;
            this.dataGridViewB.Name = "dataGridViewB";
            this.dataGridViewB.ReadOnly = true;
            this.dataGridViewB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewB.Size = new System.Drawing.Size(817, 487);
            this.dataGridViewB.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 74;
            // 
            // Title
            // 
            this.Title.HeaderText = "Название";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 200;
            // 
            // Author
            // 
            this.Author.HeaderText = "Автор";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            this.Author.Width = 300;
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Жанр";
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            this.Genre.Width = 200;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(9, 40);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(140, 25);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(9, 98);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(140, 25);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(9, 69);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(140, 25);
            this.buttonChange.TabIndex = 3;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonSearching
            // 
            this.buttonSearching.Location = new System.Drawing.Point(0, 45);
            this.buttonSearching.Name = "buttonSearching";
            this.buttonSearching.Size = new System.Drawing.Size(140, 25);
            this.buttonSearching.TabIndex = 4;
            this.buttonSearching.Text = "Поиск";
            this.buttonSearching.UseVisualStyleBackColor = true;
            this.buttonSearching.Click += new System.EventHandler(this.buttonSearching_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(9, 9);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(140, 25);
            this.buttonInfo.TabIndex = 5;
            this.buttonInfo.Text = "Информация";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(9, 127);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(140, 25);
            this.buttonExport.TabIndex = 6;
            this.buttonExport.Text = "Экспорт в Excel";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // textBoxSearching
            // 
            this.textBoxSearching.Location = new System.Drawing.Point(0, 19);
            this.textBoxSearching.Name = "textBoxSearching";
            this.textBoxSearching.Size = new System.Drawing.Size(140, 20);
            this.textBoxSearching.TabIndex = 9;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(0, 74);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(140, 25);
            this.buttonReset.TabIndex = 10;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxSearching);
            this.groupBox1.Controls.Add(this.buttonReset);
            this.groupBox1.Controls.Add(this.buttonSearching);
            this.groupBox1.Location = new System.Drawing.Point(9, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 104);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // FormAdminMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewB);
            this.MaximizeBox = false;
            this.Name = "FormAdminMainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню администратора";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdminMainMenu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewB;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonSearching;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.TextBox textBoxSearching;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
    }
}