namespace TestApplication
{
    partial class ConnectBD
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
            this.gbConnect = new System.Windows.Forms.GroupBox();
            this.lBD = new System.Windows.Forms.Label();
            this.bConnect = new System.Windows.Forms.Button();
            this.cbBD = new System.Windows.Forms.ComboBox();
            this.gbConnect.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConnect
            // 
            this.gbConnect.Controls.Add(this.lBD);
            this.gbConnect.Controls.Add(this.bConnect);
            this.gbConnect.Controls.Add(this.cbBD);
            this.gbConnect.Location = new System.Drawing.Point(28, 40);
            this.gbConnect.Name = "gbConnect";
            this.gbConnect.Size = new System.Drawing.Size(400, 177);
            this.gbConnect.TabIndex = 0;
            this.gbConnect.TabStop = false;
            this.gbConnect.Text = "Данные для подключения";
            // 
            // lBD
            // 
            this.lBD.AutoSize = true;
            this.lBD.Location = new System.Drawing.Point(40, 65);
            this.lBD.Name = "lBD";
            this.lBD.Size = new System.Drawing.Size(94, 16);
            this.lBD.TabIndex = 2;
            this.lBD.Text = "База данных:";
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(43, 102);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(316, 25);
            this.bConnect.TabIndex = 1;
            this.bConnect.Text = "Подключиться";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // cbBD
            // 
            this.cbBD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBD.FormattingEnabled = true;
            this.cbBD.Location = new System.Drawing.Point(140, 62);
            this.cbBD.Name = "cbBD";
            this.cbBD.Size = new System.Drawing.Size(219, 24);
            this.cbBD.TabIndex = 0;
            // 
            // ConnectBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 244);
            this.Controls.Add(this.gbConnect);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConnectBD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подключение к базе данных";
            this.Load += new System.EventHandler(this.ConnectBD_Load);
            this.gbConnect.ResumeLayout(false);
            this.gbConnect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConnect;
        private System.Windows.Forms.ComboBox cbBD;
        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.Label lBD;
    }
}