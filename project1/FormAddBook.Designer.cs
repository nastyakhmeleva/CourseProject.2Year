namespace project1
{
    partial class FormAddBook
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
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.labelBookDescription = new System.Windows.Forms.Label();
            this.textBoxBookDescription = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAuthor = new System.Windows.Forms.ComboBox();
            this.buttonAddAuthor = new System.Windows.Forms.Button();
            this.buttonAddGenre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(157, 6);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(210, 20);
            this.textBoxTitle.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(9, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(89, 13);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Название книги";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(9, 62);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(36, 13);
            this.labelGenre.TabIndex = 13;
            this.labelGenre.Text = "Жанр";
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(156, 59);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(210, 21);
            this.comboBoxGenre.TabIndex = 15;
            // 
            // labelBookDescription
            // 
            this.labelBookDescription.AutoSize = true;
            this.labelBookDescription.Location = new System.Drawing.Point(9, 89);
            this.labelBookDescription.Name = "labelBookDescription";
            this.labelBookDescription.Size = new System.Drawing.Size(89, 13);
            this.labelBookDescription.TabIndex = 18;
            this.labelBookDescription.Text = "Описание книги";
            // 
            // textBoxBookDescription
            // 
            this.textBoxBookDescription.Location = new System.Drawing.Point(156, 86);
            this.textBoxBookDescription.Multiline = true;
            this.textBoxBookDescription.Name = "textBoxBookDescription";
            this.textBoxBookDescription.Size = new System.Drawing.Size(350, 110);
            this.textBoxBookDescription.TabIndex = 21;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(127, 219);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 45);
            this.buttonBack.TabIndex = 26;
            this.buttonBack.Text = "Отменить добавление";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(12, 219);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonAddBook.Size = new System.Drawing.Size(100, 45);
            this.buttonAddBook.TabIndex = 27;
            this.buttonAddBook.Text = "Добавить книгу";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Автор";
            // 
            // comboBoxAuthor
            // 
            this.comboBoxAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAuthor.FormattingEnabled = true;
            this.comboBoxAuthor.Location = new System.Drawing.Point(156, 32);
            this.comboBoxAuthor.Name = "comboBoxAuthor";
            this.comboBoxAuthor.Size = new System.Drawing.Size(210, 21);
            this.comboBoxAuthor.TabIndex = 32;
            // 
            // buttonAddAuthor
            // 
            this.buttonAddAuthor.Location = new System.Drawing.Point(372, 32);
            this.buttonAddAuthor.Name = "buttonAddAuthor";
            this.buttonAddAuthor.Size = new System.Drawing.Size(150, 21);
            this.buttonAddAuthor.TabIndex = 33;
            this.buttonAddAuthor.Text = "Добавить нового автора";
            this.buttonAddAuthor.UseVisualStyleBackColor = true;
            this.buttonAddAuthor.Click += new System.EventHandler(this.buttonAddAuthor_Click);
            // 
            // buttonAddGenre
            // 
            this.buttonAddGenre.Location = new System.Drawing.Point(372, 59);
            this.buttonAddGenre.Name = "buttonAddGenre";
            this.buttonAddGenre.Size = new System.Drawing.Size(150, 21);
            this.buttonAddGenre.TabIndex = 34;
            this.buttonAddGenre.Text = "Добавить новый жанр";
            this.buttonAddGenre.UseVisualStyleBackColor = true;
            this.buttonAddGenre.Click += new System.EventHandler(this.buttonAddGenre_Click);
            // 
            // FormAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(544, 291);
            this.Controls.Add(this.buttonAddGenre);
            this.Controls.Add(this.buttonAddAuthor);
            this.Controls.Add(this.comboBoxAuthor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxBookDescription);
            this.Controls.Add(this.labelBookDescription);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxTitle);
            this.MaximizeBox = false;
            this.Name = "FormAddBook";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление новой книги";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddBook_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.Label labelBookDescription;
        private System.Windows.Forms.TextBox textBoxBookDescription;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAuthor;
        private System.Windows.Forms.Button buttonAddAuthor;
        private System.Windows.Forms.Button buttonAddGenre;
    }
}