namespace project1
{
    partial class FormAddSeries
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
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.comboBoxCoverType = new System.Windows.Forms.ComboBox();
            this.buttonAddSeries = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип обложки";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(92, 6);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(210, 20);
            this.textBoxTitle.TabIndex = 2;
            // 
            // comboBoxCoverType
            // 
            this.comboBoxCoverType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCoverType.FormattingEnabled = true;
            this.comboBoxCoverType.Items.AddRange(new object[] {
            "Мягкая",
            "Твердая"});
            this.comboBoxCoverType.Location = new System.Drawing.Point(93, 32);
            this.comboBoxCoverType.Name = "comboBoxCoverType";
            this.comboBoxCoverType.Size = new System.Drawing.Size(210, 21);
            this.comboBoxCoverType.TabIndex = 3;
            // 
            // buttonAddSeries
            // 
            this.buttonAddSeries.Location = new System.Drawing.Point(12, 85);
            this.buttonAddSeries.Name = "buttonAddSeries";
            this.buttonAddSeries.Size = new System.Drawing.Size(100, 45);
            this.buttonAddSeries.TabIndex = 4;
            this.buttonAddSeries.Text = "Добавить серию";
            this.buttonAddSeries.UseVisualStyleBackColor = true;
            this.buttonAddSeries.Click += new System.EventHandler(this.buttonAddSeries_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(127, 85);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 45);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Отменить добавление";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormAddSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(327, 149);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAddSeries);
            this.Controls.Add(this.comboBoxCoverType);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormAddSeries";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление новой серии книги";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddSeries_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.ComboBox comboBoxCoverType;
        private System.Windows.Forms.Button buttonAddSeries;
        private System.Windows.Forms.Button buttonBack;
    }
}