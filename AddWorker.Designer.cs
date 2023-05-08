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
            this.qualificationText = new System.Windows.Forms.TextBox();
            this.educationText = new System.Windows.Forms.TextBox();
            this.postCombo = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fioText
            // 
            this.fioText.Location = new System.Drawing.Point(34, 60);
            this.fioText.Name = "fioText";
            this.fioText.Size = new System.Drawing.Size(247, 20);
            this.fioText.TabIndex = 0;
            // 
            // qualificationText
            // 
            this.qualificationText.Location = new System.Drawing.Point(428, 60);
            this.qualificationText.Name = "qualificationText";
            this.qualificationText.Size = new System.Drawing.Size(100, 20);
            this.qualificationText.TabIndex = 1;
            // 
            // educationText
            // 
            this.educationText.Location = new System.Drawing.Point(534, 60);
            this.educationText.Name = "educationText";
            this.educationText.Size = new System.Drawing.Size(100, 20);
            this.educationText.TabIndex = 2;
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
            this.addButton.Location = new System.Drawing.Point(34, 126);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(165, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.postCombo);
            this.Controls.Add(this.educationText);
            this.Controls.Add(this.qualificationText);
            this.Controls.Add(this.fioText);
            this.Name = "AddWorker";
            this.Text = "AddWorker";
            this.Load += new System.EventHandler(this.AddWorker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fioText;
        private System.Windows.Forms.TextBox qualificationText;
        private System.Windows.Forms.TextBox educationText;
        private System.Windows.Forms.ComboBox postCombo;
        private System.Windows.Forms.Button addButton;
    }
}