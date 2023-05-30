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
            this.SuspendLayout();
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(41, 138);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 0;
            this.editButton.Text = "button1";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // ageText
            // 
            this.ageText.Location = new System.Drawing.Point(16, 32);
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(100, 20);
            this.ageText.TabIndex = 1;
            // 
            // expText
            // 
            this.expText.Location = new System.Drawing.Point(358, 34);
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
            this.postCombo.Location = new System.Drawing.Point(122, 33);
            this.postCombo.Name = "postCombo";
            this.postCombo.Size = new System.Drawing.Size(121, 21);
            this.postCombo.TabIndex = 5;
            // 
            // WorkerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 333);
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
    }
}