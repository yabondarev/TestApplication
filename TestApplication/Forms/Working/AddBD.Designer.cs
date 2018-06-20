namespace TestApplication
{
    partial class AddBD
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
            this.gbAddBD = new System.Windows.Forms.GroupBox();
            this.bAddBD = new System.Windows.Forms.Button();
            this.lNameBD = new System.Windows.Forms.Label();
            this.tbNameBD = new System.Windows.Forms.TextBox();
            this.gbAddBD.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAddBD
            // 
            this.gbAddBD.Controls.Add(this.bAddBD);
            this.gbAddBD.Controls.Add(this.lNameBD);
            this.gbAddBD.Controls.Add(this.tbNameBD);
            this.gbAddBD.Location = new System.Drawing.Point(28, 60);
            this.gbAddBD.Name = "gbAddBD";
            this.gbAddBD.Size = new System.Drawing.Size(792, 175);
            this.gbAddBD.TabIndex = 1;
            this.gbAddBD.TabStop = false;
            this.gbAddBD.Text = "Данные базы данных";
            // 
            // bAddBD
            // 
            this.bAddBD.Location = new System.Drawing.Point(538, 78);
            this.bAddBD.Name = "bAddBD";
            this.bAddBD.Size = new System.Drawing.Size(135, 26);
            this.bAddBD.TabIndex = 2;
            this.bAddBD.Text = "Добавить ";
            this.bAddBD.UseVisualStyleBackColor = true;
            this.bAddBD.Click += new System.EventHandler(this.bAddBD_Click);
            // 
            // lNameBD
            // 
            this.lNameBD.AutoSize = true;
            this.lNameBD.Location = new System.Drawing.Point(95, 83);
            this.lNameBD.Name = "lNameBD";
            this.lNameBD.Size = new System.Drawing.Size(163, 16);
            this.lNameBD.TabIndex = 1;
            this.lNameBD.Text = "Название базы данных:";
            // 
            // tbNameBD
            // 
            this.tbNameBD.Location = new System.Drawing.Point(264, 80);
            this.tbNameBD.Name = "tbNameBD";
            this.tbNameBD.Size = new System.Drawing.Size(268, 22);
            this.tbNameBD.TabIndex = 0;
            // 
            // AddBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 268);
            this.Controls.Add(this.gbAddBD);
            this.Name = "AddBD";
            this.Text = "Добавление базы данных";
            this.Controls.SetChildIndex(this.gbAddBD, 0);
            this.gbAddBD.ResumeLayout(false);
            this.gbAddBD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddBD;
        private System.Windows.Forms.TextBox tbNameBD;
        private System.Windows.Forms.Button bAddBD;
        private System.Windows.Forms.Label lNameBD;
    }
}