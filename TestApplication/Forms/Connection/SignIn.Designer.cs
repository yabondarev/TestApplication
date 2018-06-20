namespace TestApplication
{
    partial class SignIn
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
            this.lLogin = new System.Windows.Forms.Label();
            this.gbSignIn = new System.Windows.Forms.GroupBox();
            this.bSignIn = new System.Windows.Forms.Button();
            this.lPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.cbLogin = new System.Windows.Forms.ComboBox();
            this.menuSI = new System.Windows.Forms.MenuStrip();
            this.miConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.miNameBD = new System.Windows.Forms.ToolStripMenuItem();
            this.gbSignIn.SuspendLayout();
            this.menuSI.SuspendLayout();
            this.SuspendLayout();
            // 
            // lLogin
            // 
            this.lLogin.Location = new System.Drawing.Point(55, 47);
            this.lLogin.Name = "lLogin";
            this.lLogin.Size = new System.Drawing.Size(73, 16);
            this.lLogin.TabIndex = 0;
            this.lLogin.Text = "Ваше имя:";
            // 
            // gbSignIn
            // 
            this.gbSignIn.Controls.Add(this.bSignIn);
            this.gbSignIn.Controls.Add(this.lPassword);
            this.gbSignIn.Controls.Add(this.tbPassword);
            this.gbSignIn.Controls.Add(this.cbLogin);
            this.gbSignIn.Controls.Add(this.lLogin);
            this.gbSignIn.Location = new System.Drawing.Point(28, 40);
            this.gbSignIn.Name = "gbSignIn";
            this.gbSignIn.Size = new System.Drawing.Size(400, 177);
            this.gbSignIn.TabIndex = 0;
            this.gbSignIn.TabStop = false;
            this.gbSignIn.Text = "Данные для входа";
            // 
            // bSignIn
            // 
            this.bSignIn.Location = new System.Drawing.Point(52, 124);
            this.bSignIn.Name = "bSignIn";
            this.bSignIn.Size = new System.Drawing.Size(300, 25);
            this.bSignIn.TabIndex = 4;
            this.bSignIn.Text = "Войти";
            this.bSignIn.UseVisualStyleBackColor = true;
            this.bSignIn.Click += new System.EventHandler(this.bSignIn_Click);
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(68, 87);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(60, 16);
            this.lPassword.TabIndex = 3;
            this.lPassword.Text = "Пароль:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(134, 84);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(218, 22);
            this.tbPassword.TabIndex = 2;
            // 
            // cbLogin
            // 
            this.cbLogin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLogin.FormattingEnabled = true;
            this.cbLogin.Location = new System.Drawing.Point(134, 44);
            this.cbLogin.Name = "cbLogin";
            this.cbLogin.Size = new System.Drawing.Size(219, 24);
            this.cbLogin.TabIndex = 1;
            // 
            // menuSI
            // 
            this.menuSI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miConnect,
            this.miNameBD});
            this.menuSI.Location = new System.Drawing.Point(0, 0);
            this.menuSI.Name = "menuSI";
            this.menuSI.Size = new System.Drawing.Size(458, 24);
            this.menuSI.TabIndex = 1;
            this.menuSI.Text = "menu";
            // 
            // miConnect
            // 
            this.miConnect.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.miConnect.Name = "miConnect";
            this.miConnect.Size = new System.Drawing.Size(128, 20);
            this.miConnect.Text = "Подключиться к БД";
            this.miConnect.Click += new System.EventHandler(this.miConnect_Click);
            // 
            // miNameBD
            // 
            this.miNameBD.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.miNameBD.Name = "miNameBD";
            this.miNameBD.Size = new System.Drawing.Size(12, 20);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 244);
            this.Controls.Add(this.gbSignIn);
            this.Controls.Add(this.menuSI);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuSI;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма входа";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.gbSignIn.ResumeLayout(false);
            this.gbSignIn.PerformLayout();
            this.menuSI.ResumeLayout(false);
            this.menuSI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lLogin;
        private System.Windows.Forms.GroupBox gbSignIn;
        private System.Windows.Forms.Button bSignIn;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.ComboBox cbLogin;
        private System.Windows.Forms.MenuStrip menuSI;
        private System.Windows.Forms.ToolStripMenuItem miConnect;
        private System.Windows.Forms.ToolStripMenuItem miNameBD;
    }
}