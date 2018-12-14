namespace project1
{
    partial class FormAddGenre
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonAddGenre = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(9, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(92, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Название жанра";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(9, 35);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(92, 13);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "Описание жанра";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(107, 6);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(210, 20);
            this.textBoxTitle.TabIndex = 2;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(107, 32);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(210, 173);
            this.textBoxDescription.TabIndex = 3;
            // 
            // buttonAddGenre
            // 
            this.buttonAddGenre.Location = new System.Drawing.Point(12, 232);
            this.buttonAddGenre.Name = "buttonAddGenre";
            this.buttonAddGenre.Size = new System.Drawing.Size(100, 45);
            this.buttonAddGenre.TabIndex = 4;
            this.buttonAddGenre.Text = "Добавить жанр";
            this.buttonAddGenre.UseVisualStyleBackColor = true;
            this.buttonAddGenre.Click += new System.EventHandler(this.buttonAddGenre_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(127, 232);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 45);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Отменить добавление";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormAddGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(339, 287);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAddGenre);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelTitle);
            this.MaximizeBox = false;
            this.Name = "FormAddGenre";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление нового жанра";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddGenre_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonAddGenre;
        private System.Windows.Forms.Button buttonBack;
    }
}