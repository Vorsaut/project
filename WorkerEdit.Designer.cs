namespace project
{
    partial class WorkerEdit
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
            this.editButton = new System.Windows.Forms.Button();
            this.ageText = new System.Windows.Forms.TextBox();
            this.expText = new System.Windows.Forms.TextBox();
            this.salaryText = new System.Windows.Forms.TextBox();
            this.postCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textFIO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Transparent;
            this.editButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editButton.Location = new System.Drawing.Point(0, 238);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(588, 64);
            this.editButton.TabIndex = 0;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // ageText
            // 
            this.ageText.Location = new System.Drawing.Point(134, 34);
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(100, 20);
            this.ageText.TabIndex = 1;
            // 
            // expText
            // 
            this.expText.Location = new System.Drawing.Point(367, 34);
            this.expText.Name = "expText";
            this.expText.Size = new System.Drawing.Size(100, 20);
            this.expText.TabIndex = 3;
            // 
            // salaryText
            // 
            this.salaryText.Location = new System.Drawing.Point(473, 34);
            this.salaryText.Name = "salaryText";
            this.salaryText.Size = new System.Drawing.Size(100, 20);
            this.salaryText.TabIndex = 4;
            // 
            // postCombo
            // 
            this.postCombo.FormattingEnabled = true;
            this.postCombo.Location = new System.Drawing.Point(240, 34);
            this.postCombo.Name = "postCombo";
            this.postCombo.Size = new System.Drawing.Size(121, 21);
            this.postCombo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Возраст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Должность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Стаж";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Зарплата";
            // 
            // textFIO
            // 
            this.textFIO.Location = new System.Drawing.Point(28, 35);
            this.textFIO.Name = "textFIO";
            this.textFIO.Size = new System.Drawing.Size(100, 20);
            this.textFIO.TabIndex = 10;
            this.textFIO.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ФИО";
            // 
            // WorkerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(588, 302);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textFIO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.postCombo);
            this.Controls.Add(this.salaryText);
            this.Controls.Add(this.expText);
            this.Controls.Add(this.ageText);
            this.Controls.Add(this.editButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "WorkerEdit";
            this.Text = "WorkerEdit";
            this.Load += new System.EventHandler(this.WorkerEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox ageText;
        private System.Windows.Forms.TextBox expText;
        private System.Windows.Forms.TextBox salaryText;
        private System.Windows.Forms.ComboBox postCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textFIO;
        private System.Windows.Forms.Label label5;
    }
}