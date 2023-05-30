namespace project
{
    partial class EditVacation
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
            this.windowPanel = new System.Windows.Forms.Panel();
            this.editDataButton = new System.Windows.Forms.Button();
            this.vacationSetButton = new System.Windows.Forms.Button();
            this.fioComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // windowPanel
            // 
            this.windowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.windowPanel.BackColor = System.Drawing.Color.LightGray;
            this.windowPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.windowPanel.Location = new System.Drawing.Point(0, 37);
            this.windowPanel.Name = "windowPanel";
            this.windowPanel.Size = new System.Drawing.Size(612, 215);
            this.windowPanel.TabIndex = 0;
            // 
            // editDataButton
            // 
            this.editDataButton.BackColor = System.Drawing.Color.Transparent;
            this.editDataButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.editDataButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.editDataButton.FlatAppearance.BorderSize = 0;
            this.editDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editDataButton.Location = new System.Drawing.Point(0, 0);
            this.editDataButton.Name = "editDataButton";
            this.editDataButton.Size = new System.Drawing.Size(179, 37);
            this.editDataButton.TabIndex = 1;
            this.editDataButton.Text = "Редактировать данные";
            this.editDataButton.UseVisualStyleBackColor = false;
            this.editDataButton.Click += new System.EventHandler(this.editData_Click);
            // 
            // vacationSetButton
            // 
            this.vacationSetButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.vacationSetButton.BackColor = System.Drawing.Color.Transparent;
            this.vacationSetButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.vacationSetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.vacationSetButton.Location = new System.Drawing.Point(179, 0);
            this.vacationSetButton.Name = "vacationSetButton";
            this.vacationSetButton.Size = new System.Drawing.Size(179, 37);
            this.vacationSetButton.TabIndex = 2;
            this.vacationSetButton.Text = "Выставить отпуск";
            this.vacationSetButton.UseVisualStyleBackColor = false;
            this.vacationSetButton.Click += new System.EventHandler(this.vacationSet_Click);
            // 
            // fioComboBox
            // 
            this.fioComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.fioComboBox.FormattingEnabled = true;
            this.fioComboBox.Location = new System.Drawing.Point(479, 9);
            this.fioComboBox.Name = "fioComboBox";
            this.fioComboBox.Size = new System.Drawing.Size(121, 21);
            this.fioComboBox.TabIndex = 3;
            this.fioComboBox.TextChanged += new System.EventHandler(this.fioComboBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ФИО";
            // 
            // EditVacation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 252);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fioComboBox);
            this.Controls.Add(this.vacationSetButton);
            this.Controls.Add(this.editDataButton);
            this.Controls.Add(this.windowPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditVacation";
            this.Text = "EditVacation";
            this.Load += new System.EventHandler(this.EditVacation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel windowPanel;
        private System.Windows.Forms.Button editDataButton;
        private System.Windows.Forms.Button vacationSetButton;
        public System.Windows.Forms.ComboBox fioComboBox;
        private System.Windows.Forms.Label label1;
    }
}