namespace TestApplication
{
    partial class CalculateSalary
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
            this.gbCalculateSalary = new System.Windows.Forms.GroupBox();
            this.lSalary = new System.Windows.Forms.Label();
            this.bSalaryEmployee = new System.Windows.Forms.Button();
            this.bSalaryAll = new System.Windows.Forms.Button();
            this.lDate = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.lEmployee = new System.Windows.Forms.Label();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.gbCalculateSalary.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCalculateSalary
            // 
            this.gbCalculateSalary.Controls.Add(this.lSalary);
            this.gbCalculateSalary.Controls.Add(this.bSalaryEmployee);
            this.gbCalculateSalary.Controls.Add(this.bSalaryAll);
            this.gbCalculateSalary.Controls.Add(this.lDate);
            this.gbCalculateSalary.Controls.Add(this.dtDate);
            this.gbCalculateSalary.Controls.Add(this.lEmployee);
            this.gbCalculateSalary.Controls.Add(this.cbEmployee);
            this.gbCalculateSalary.Location = new System.Drawing.Point(28, 60);
            this.gbCalculateSalary.Name = "gbCalculateSalary";
            this.gbCalculateSalary.Size = new System.Drawing.Size(792, 175);
            this.gbCalculateSalary.TabIndex = 1;
            this.gbCalculateSalary.TabStop = false;
            this.gbCalculateSalary.Text = "Данные для расчета зарплаты";
            // 
            // lSalary
            // 
            this.lSalary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lSalary.Location = new System.Drawing.Point(599, 100);
            this.lSalary.Name = "lSalary";
            this.lSalary.Size = new System.Drawing.Size(148, 26);
            this.lSalary.TabIndex = 6;
            this.lSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bSalaryEmployee
            // 
            this.bSalaryEmployee.Location = new System.Drawing.Point(49, 100);
            this.bSalaryEmployee.Name = "bSalaryEmployee";
            this.bSalaryEmployee.Size = new System.Drawing.Size(268, 26);
            this.bSalaryEmployee.TabIndex = 5;
            this.bSalaryEmployee.Text = "Узнать зарплату сотрудника";
            this.bSalaryEmployee.UseVisualStyleBackColor = true;
            this.bSalaryEmployee.Click += new System.EventHandler(this.bSalaryEmployee_Click);
            // 
            // bSalaryAll
            // 
            this.bSalaryAll.Location = new System.Drawing.Point(324, 100);
            this.bSalaryAll.Name = "bSalaryAll";
            this.bSalaryAll.Size = new System.Drawing.Size(268, 26);
            this.bSalaryAll.TabIndex = 4;
            this.bSalaryAll.Text = "Узнать зарплату офиса";
            this.bSalaryAll.UseVisualStyleBackColor = true;
            this.bSalaryAll.Click += new System.EventHandler(this.bSalaryAll_Click);
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Location = new System.Drawing.Point(430, 67);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(43, 16);
            this.lDate.TabIndex = 3;
            this.lDate.Text = "Дата:";
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(479, 64);
            this.dtDate.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.dtDate.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(268, 22);
            this.dtDate.TabIndex = 2;
            this.dtDate.Value = new System.DateTime(2018, 6, 19, 0, 43, 4, 0);
            // 
            // lEmployee
            // 
            this.lEmployee.AutoSize = true;
            this.lEmployee.Location = new System.Drawing.Point(48, 66);
            this.lEmployee.Name = "lEmployee";
            this.lEmployee.Size = new System.Drawing.Size(82, 16);
            this.lEmployee.TabIndex = 1;
            this.lEmployee.Text = "Сотрудник:";
            // 
            // cbEmployee
            // 
            this.cbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(136, 63);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(268, 24);
            this.cbEmployee.TabIndex = 0;
            // 
            // CalculateSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 268);
            this.Controls.Add(this.gbCalculateSalary);
            this.Name = "CalculateSalary";
            this.Text = "Расчет зарплаты";
            this.Load += new System.EventHandler(this.CalculateSalary_Load);
            this.Controls.SetChildIndex(this.gbCalculateSalary, 0);
            this.gbCalculateSalary.ResumeLayout(false);
            this.gbCalculateSalary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCalculateSalary;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.Label lEmployee;
        private System.Windows.Forms.Button bSalaryAll;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label lSalary;
        private System.Windows.Forms.Button bSalaryEmployee;
    }
}