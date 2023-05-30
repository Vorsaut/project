namespace project
{
    partial class MainWindow
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.vacationsButton = new System.Windows.Forms.Button();
            this.workerButton = new System.Windows.Forms.Button();
            this.panelFront = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panelMenu.Controls.Add(this.vacationsButton);
            this.panelMenu.Controls.Add(this.workerButton);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(153, 500);
            this.panelMenu.TabIndex = 0;
            // 
            // vacationsButton
            // 
            this.vacationsButton.BackColor = System.Drawing.Color.DarkSalmon;
            this.vacationsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.vacationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vacationsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vacationsButton.Location = new System.Drawing.Point(0, 68);
            this.vacationsButton.Name = "vacationsButton";
            this.vacationsButton.Size = new System.Drawing.Size(153, 62);
            this.vacationsButton.TabIndex = 2;
            this.vacationsButton.Text = "Отпуска";
            this.vacationsButton.UseVisualStyleBackColor = false;
            this.vacationsButton.Click += new System.EventHandler(this.vacationsButton_Click);
            // 
            // workerButton
            // 
            this.workerButton.BackColor = System.Drawing.Color.DarkSalmon;
            this.workerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.workerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workerButton.Location = new System.Drawing.Point(0, 0);
            this.workerButton.Name = "workerButton";
            this.workerButton.Size = new System.Drawing.Size(153, 68);
            this.workerButton.TabIndex = 0;
            this.workerButton.Text = "Сотрудники";
            this.workerButton.UseVisualStyleBackColor = false;
            this.workerButton.Click += new System.EventHandler(this.workersButton_Click);
            // 
            // panelFront
            // 
            this.panelFront.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFront.Location = new System.Drawing.Point(153, 0);
            this.panelFront.Name = "panelFront";
            this.panelFront.Size = new System.Drawing.Size(867, 500);
            this.panelFront.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 500);
            this.Controls.Add(this.panelFront);
            this.Controls.Add(this.panelMenu);
            this.Name = "MainWindow";
            this.Text = "App name";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button workerButton;
        private System.Windows.Forms.Panel panelFront;
        private System.Windows.Forms.Button vacationsButton;
    }
}