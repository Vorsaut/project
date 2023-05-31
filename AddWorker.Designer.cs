namespace project
{
    partial class AddWorker
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
            this.fioText = new System.Windows.Forms.TextBox();
            this.postCombo = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.ageText = new System.Windows.Forms.TextBox();
            this.genderText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fioText
            // 
            this.fioText.Location = new System.Drawing.Point(12, 40);
            this.fioText.Name = "fioText";
            this.fioText.Size = new System.Drawing.Size(247, 20);
            this.fioText.TabIndex = 0;
            // 
            // postCombo
            // 
            this.postCombo.FormattingEnabled = true;
            this.postCombo.Location = new System.Drawing.Point(12, 66);
            this.postCombo.Name = "postCombo";
            this.postCombo.Size = new System.Drawing.Size(247, 21);
            this.postCombo.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 93);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(247, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // ageText
            // 
            this.ageText.Location = new System.Drawing.Point(265, 40);
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(67, 20);
            this.ageText.TabIndex = 5;
            // 
            // genderText
            // 
            this.genderText.Location = new System.Drawing.Point(338, 40);
            this.genderText.Name = "genderText";
            this.genderText.Size = new System.Drawing.Size(100, 20);
            this.genderText.TabIndex = 6;
            this.genderText.TextChanged += new System.EventHandler(this.genderText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Должность";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Возраст";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Пол";
            // 
            // AddWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(445, 235);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.genderText);
            this.Controls.Add(this.ageText);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.postCombo);
            this.Controls.Add(this.fioText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddWorker";
            this.Text = "AddWorker";
            this.Load += new System.EventHandler(this.AddWorker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fioText;
        private System.Windows.Forms.ComboBox postCombo;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox ageText;
        private System.Windows.Forms.TextBox genderText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}