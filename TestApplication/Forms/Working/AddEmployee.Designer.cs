namespace TestApplication
{
    partial class AddEmployee
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
            this.gbAddEmployee = new System.Windows.Forms.GroupBox();
            this.bAddEmployee = new System.Windows.Forms.Button();
            this.lPassword = new System.Windows.Forms.Label();
            this.lChief = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.cbChief = new System.Windows.Forms.ComboBox();
            this.lPost = new System.Windows.Forms.Label();
            this.lDateWork = new System.Windows.Forms.Label();
            this.lFIO = new System.Windows.Forms.Label();
            this.cbPost = new System.Windows.Forms.ComboBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.tbFIO = new System.Windows.Forms.TextBox();
            this.gbAddEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAddEmployee
            // 
            this.gbAddEmployee.Controls.Add(this.bAddEmployee);
            this.gbAddEmployee.Controls.Add(this.lPassword);
            this.gbAddEmployee.Controls.Add(this.lChief);
            this.gbAddEmployee.Controls.Add(this.tbPassword);
            this.gbAddEmployee.Controls.Add(this.cbChief);
            this.gbAddEmployee.Controls.Add(this.lPost);
            this.gbAddEmployee.Controls.Add(this.lDateWork);
            this.gbAddEmployee.Controls.Add(this.lFIO);
            this.gbAddEmployee.Controls.Add(this.cbPost);
            this.gbAddEmployee.Controls.Add(this.dtDate);
            this.gbAddEmployee.Controls.Add(this.tbFIO);
            this.gbAddEmployee.Location = new System.Drawing.Point(28, 60);
            this.gbAddEmployee.Name = "gbAddEmployee";
            this.gbAddEmployee.Size = new System.Drawing.Size(792, 175);
            this.gbAddEmployee.TabIndex = 1;
            this.gbAddEmployee.TabStop = false;
            this.gbAddEmployee.Text = "Данные сотрудника";
            // 
            // bAddEmployee
            // 
            this.bAddEmployee.Location = new System.Drawing.Point(417, 113);
            this.bAddEmployee.Name = "bAddEmployee";
            this.bAddEmployee.Size = new System.Drawing.Size(356, 27);
            this.bAddEmployee.TabIndex = 10;
            this.bAddEmployee.Text = "Добавить сотрудника";
            this.bAddEmployee.UseVisualStyleBackColor = true;
            this.bAddEmployee.Click += new System.EventHandler(this.bAddEmployee_Click);
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(438, 78);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(60, 16);
            this.lPassword.TabIndex = 9;
            this.lPassword.Text = "Пароль:";
            // 
            // lChief
            // 
            this.lChief.AutoSize = true;
            this.lChief.Location = new System.Drawing.Point(415, 38);
            this.lChief.Name = "lChief";
            this.lChief.Size = new System.Drawing.Size(83, 16);
            this.lChief.TabIndex = 8;
            this.lChief.Text = "Начальник:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(504, 75);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(268, 22);
            this.tbPassword.TabIndex = 7;
            // 
            // cbChief
            // 
            this.cbChief.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChief.FormattingEnabled = true;
            this.cbChief.Location = new System.Drawing.Point(504, 35);
            this.cbChief.Name = "cbChief";
            this.cbChief.Size = new System.Drawing.Size(268, 24);
            this.cbChief.TabIndex = 6;
            // 
            // lPost
            // 
            this.lPost.AutoSize = true;
            this.lPost.Location = new System.Drawing.Point(42, 118);
            this.lPost.Name = "lPost";
            this.lPost.Size = new System.Drawing.Size(82, 16);
            this.lPost.TabIndex = 5;
            this.lPost.Text = "Должность:";
            // 
            // lDateWork
            // 
            this.lDateWork.AutoSize = true;
            this.lDateWork.Location = new System.Drawing.Point(12, 78);
            this.lDateWork.Name = "lDateWork";
            this.lDateWork.Size = new System.Drawing.Size(112, 16);
            this.lDateWork.TabIndex = 4;
            this.lDateWork.Text = "Начало работы:";
            // 
            // lFIO
            // 
            this.lFIO.AutoSize = true;
            this.lFIO.Location = new System.Drawing.Point(85, 38);
            this.lFIO.Name = "lFIO";
            this.lFIO.Size = new System.Drawing.Size(42, 16);
            this.lFIO.TabIndex = 3;
            this.lFIO.Text = "ФИО:";
            // 
            // cbPost
            // 
            this.cbPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPost.FormattingEnabled = true;
            this.cbPost.Location = new System.Drawing.Point(130, 115);
            this.cbPost.Name = "cbPost";
            this.cbPost.Size = new System.Drawing.Size(268, 24);
            this.cbPost.TabIndex = 2;
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(130, 75);
            this.dtDate.MaxDate = new System.DateTime(2018, 6, 19, 0, 50, 14, 0);
            this.dtDate.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(268, 22);
            this.dtDate.TabIndex = 1;
            this.dtDate.Value = new System.DateTime(2018, 6, 19, 0, 0, 0, 0);
            // 
            // tbFIO
            // 
            this.tbFIO.Location = new System.Drawing.Point(130, 35);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(268, 22);
            this.tbFIO.TabIndex = 0;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 268);
            this.Controls.Add(this.gbAddEmployee);
            this.Name = "AddEmployee";
            this.Text = "Добавить сотрудника";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.Controls.SetChildIndex(this.gbAddEmployee, 0);
            this.gbAddEmployee.ResumeLayout(false);
            this.gbAddEmployee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddEmployee;
        private System.Windows.Forms.ComboBox cbPost;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.TextBox tbFIO;
        private System.Windows.Forms.Label lPost;
        private System.Windows.Forms.Label lDateWork;
        private System.Windows.Forms.Label lFIO;
        private System.Windows.Forms.Button bAddEmployee;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.Label lChief;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.ComboBox cbChief;
    }
}