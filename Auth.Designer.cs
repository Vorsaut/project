namespace project
{
    partial class Auth
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
            this.signUpButton = new System.Windows.Forms.Button();
            this.panelWindow = new System.Windows.Forms.Panel();
            this.labelConnStatus = new System.Windows.Forms.Label();
            this.buttonConnStatus = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelAuthorization = new System.Windows.Forms.Label();
            this.panelWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.signUpButton.FlatAppearance.BorderSize = 2;
            this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signUpButton.Location = new System.Drawing.Point(197, 204);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(84, 25);
            this.signUpButton.TabIndex = 0;
            this.signUpButton.Text = "Войти";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // panelWindow
            // 
            this.panelWindow.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelWindow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelWindow.BackgroundImage")));
            this.panelWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelWindow.Controls.Add(this.labelConnStatus);
            this.panelWindow.Controls.Add(this.buttonConnStatus);
            this.panelWindow.Controls.Add(this.textBoxPassword);
            this.panelWindow.Controls.Add(this.textBoxLogin);
            this.panelWindow.Controls.Add(this.labelAuthorization);
            this.panelWindow.Controls.Add(this.signUpButton);
            this.panelWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWindow.Location = new System.Drawing.Point(0, 0);
            this.panelWindow.Name = "panelWindow";
            this.panelWindow.Size = new System.Drawing.Size(484, 361);
            this.panelWindow.TabIndex = 1;
            // 
            // labelConnStatus
            // 
            this.labelConnStatus.AutoSize = true;
            this.labelConnStatus.Location = new System.Drawing.Point(26, 339);
            this.labelConnStatus.Name = "labelConnStatus";
            this.labelConnStatus.Size = new System.Drawing.Size(114, 13);
            this.labelConnStatus.TabIndex = 5;
            this.labelConnStatus.Text = "Статус подключения:";
            // 
            // buttonConnStatus
            // 
            this.buttonConnStatus.Location = new System.Drawing.Point(6, 339);
            this.buttonConnStatus.Name = "buttonConnStatus";
            this.buttonConnStatus.Size = new System.Drawing.Size(14, 14);
            this.buttonConnStatus.TabIndex = 4;
            this.buttonConnStatus.UseVisualStyleBackColor = true;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(143, 178);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(207, 20);
            this.textBoxPassword.TabIndex = 3;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(143, 152);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(207, 20);
            this.textBoxLogin.TabIndex = 2;
            // 
            // labelAuthorization
            // 
            this.labelAuthorization.BackColor = System.Drawing.Color.Transparent;
            this.labelAuthorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuthorization.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelAuthorization.Location = new System.Drawing.Point(183, 129);
            this.labelAuthorization.Name = "labelAuthorization";
            this.labelAuthorization.Size = new System.Drawing.Size(120, 20);
            this.labelAuthorization.TabIndex = 1;
            this.labelAuthorization.Text = "Авторизация";
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.panelWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Auth";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Auth_Load);
            this.panelWindow.ResumeLayout(false);
            this.panelWindow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Panel panelWindow;
        private System.Windows.Forms.Label labelAuthorization;
        private System.Windows.Forms.Label labelConnStatus;
        private System.Windows.Forms.Button buttonConnStatus;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
    }
}

