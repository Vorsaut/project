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
            this.codeText = new System.Windows.Forms.TextBox();
            this.dateText = new System.Windows.Forms.TextBox();
            this.postCombo = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.ageText = new System.Windows.Forms.TextBox();
            this.genderText = new System.Windows.Forms.TextBox();
            this.numberpasportText = new System.Windows.Forms.TextBox();
            this.liveplaceText = new System.Windows.Forms.TextBox();
            this.snilsText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fioText
            // 
            this.fioText.Location = new System.Drawing.Point(34, 60);
            this.fioText.Name = "fioText";
            this.fioText.Size = new System.Drawing.Size(247, 20);
            this.fioText.TabIndex = 0;
            // 
            // codeText
            // 
            this.codeText.Location = new System.Drawing.Point(428, 60);
            this.codeText.Name = "codeText";
            this.codeText.Size = new System.Drawing.Size(104, 20);
            this.codeText.TabIndex = 1;
            // 
            // dateText
            // 
            this.dateText.Location = new System.Drawing.Point(538, 61);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(100, 20);
            this.dateText.TabIndex = 2;
            // 
            // postCombo
            // 
            this.postCombo.FormattingEnabled = true;
            this.postCombo.Location = new System.Drawing.Point(287, 60);
            this.postCombo.Name = "postCombo";
            this.postCombo.Size = new System.Drawing.Size(135, 21);
            this.postCombo.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(34, 241);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(165, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // ageText
            // 
            this.ageText.Location = new System.Drawing.Point(34, 143);
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(146, 20);
            this.ageText.TabIndex = 5;
            // 
            // genderText
            // 
            this.genderText.Location = new System.Drawing.Point(186, 143);
            this.genderText.Name = "genderText";
            this.genderText.Size = new System.Drawing.Size(100, 20);
            this.genderText.TabIndex = 6;
            // 
            // numberpasportText
            // 
            this.numberpasportText.Location = new System.Drawing.Point(292, 143);
            this.numberpasportText.Name = "numberpasportText";
            this.numberpasportText.Size = new System.Drawing.Size(100, 20);
            this.numberpasportText.TabIndex = 7;
            // 
            // liveplaceText
            // 
            this.liveplaceText.Location = new System.Drawing.Point(398, 143);
            this.liveplaceText.Name = "liveplaceText";
            this.liveplaceText.Size = new System.Drawing.Size(100, 20);
            this.liveplaceText.TabIndex = 8;
            // 
            // snilsText
            // 
            this.snilsText.Location = new System.Drawing.Point(504, 143);
            this.snilsText.Name = "snilsText";
            this.snilsText.Size = new System.Drawing.Size(100, 20);
            this.snilsText.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Должность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Код подразделения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Серия и номер";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(538, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Дата выдачи";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Возраст";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(183, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Пол";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(398, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Место жительства";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(507, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Снилс";
            // 
            // AddWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.snilsText);
            this.Controls.Add(this.liveplaceText);
            this.Controls.Add(this.numberpasportText);
            this.Controls.Add(this.genderText);
            this.Controls.Add(this.ageText);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.postCombo);
            this.Controls.Add(this.dateText);
            this.Controls.Add(this.codeText);
            this.Controls.Add(this.fioText);
            this.Name = "AddWorker";
            this.Text = "AddWorker";
            this.Load += new System.EventHandler(this.AddWorker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fioText;
        private System.Windows.Forms.TextBox codeText;
        private System.Windows.Forms.TextBox dateText;
        private System.Windows.Forms.ComboBox postCombo;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox ageText;
        private System.Windows.Forms.TextBox genderText;
        private System.Windows.Forms.TextBox numberpasportText;
        private System.Windows.Forms.TextBox liveplaceText;
        private System.Windows.Forms.TextBox snilsText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}