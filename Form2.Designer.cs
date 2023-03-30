namespace project
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.vacationsButton = new System.Windows.Forms.Button();
            this.workerButton = new System.Windows.Forms.Button();
            this.panelFront = new System.Windows.Forms.Panel();
            this.pasportButton = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DarkGray;
            this.panelMenu.Controls.Add(this.pasportButton);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.vacationsButton);
            this.panelMenu.Controls.Add(this.workerButton);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(153, 500);
            this.panelMenu.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(0, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // vacationsButton
            // 
            this.vacationsButton.BackColor = System.Drawing.Color.LightGray;
            this.vacationsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.vacationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vacationsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vacationsButton.Location = new System.Drawing.Point(0, 68);
            this.vacationsButton.Name = "vacationsButton";
            this.vacationsButton.Size = new System.Drawing.Size(153, 68);
            this.vacationsButton.TabIndex = 2;
            this.vacationsButton.Text = "Отпуска";
            this.vacationsButton.UseVisualStyleBackColor = false;
            // 
            // workerButton
            // 
            this.workerButton.BackColor = System.Drawing.Color.LightGray;
            this.workerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.workerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workerButton.Location = new System.Drawing.Point(0, 0);
            this.workerButton.Name = "workerButton";
            this.workerButton.Size = new System.Drawing.Size(153, 68);
            this.workerButton.TabIndex = 0;
            this.workerButton.Text = "Сотрудники";
            this.workerButton.UseVisualStyleBackColor = false;
            this.workerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelFront
            // 
            this.panelFront.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFront.Location = new System.Drawing.Point(153, 0);
            this.panelFront.Name = "panelFront";
            this.panelFront.Size = new System.Drawing.Size(867, 500);
            this.panelFront.TabIndex = 1;
            // 
            // pasportButton
            // 
            this.pasportButton.Location = new System.Drawing.Point(4, 143);
            this.pasportButton.Name = "pasportButton";
            this.pasportButton.Size = new System.Drawing.Size(75, 23);
            this.pasportButton.TabIndex = 3;
            this.pasportButton.Text = "button2";
            this.pasportButton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 500);
            this.Controls.Add(this.panelFront);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button workerButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelFront;
        private System.Windows.Forms.Button vacationsButton;
        private System.Windows.Forms.Button pasportButton;
    }
}