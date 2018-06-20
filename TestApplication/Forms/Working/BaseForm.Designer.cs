namespace TestApplication
{
    partial class BaseForm
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.miAddEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.miEmployeeSalary = new System.Windows.Forms.ToolStripMenuItem();
            this.miSignIn = new System.Windows.Forms.ToolStripMenuItem();
            this.miNameBD = new System.Windows.Forms.ToolStripMenuItem();
            this.miName = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddBD = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miEmployeeSalary,
            this.miAddEmployee,
            this.miSignIn,
            this.miNameBD,
            this.miName,
            this.miAddBD});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(848, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            // 
            // miAddEmployee
            // 
            this.miAddEmployee.Name = "miAddEmployee";
            this.miAddEmployee.Size = new System.Drawing.Size(137, 20);
            this.miAddEmployee.Text = "Добавить сотрудника";
            this.miAddEmployee.Click += new System.EventHandler(this.miAddEmployee_Click);
            // 
            // miEmployeeSalary
            // 
            this.miEmployeeSalary.Name = "miEmployeeSalary";
            this.miEmployeeSalary.Size = new System.Drawing.Size(107, 20);
            this.miEmployeeSalary.Text = "Узнать зарплату";
            this.miEmployeeSalary.Click += new System.EventHandler(this.miEmployeeSalary_Click);
            // 
            // miSignIn
            // 
            this.miSignIn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.miSignIn.Name = "miSignIn";
            this.miSignIn.Size = new System.Drawing.Size(54, 20);
            this.miSignIn.Text = "Выйти";
            this.miSignIn.Click += new System.EventHandler(this.miSignIn_Click);
            // 
            // miNameBD
            // 
            this.miNameBD.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.miNameBD.Name = "miNameBD";
            this.miNameBD.Size = new System.Drawing.Size(12, 20);
            // 
            // miName
            // 
            this.miName.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.miName.Name = "miName";
            this.miName.Size = new System.Drawing.Size(12, 20);
            this.miName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // miAddBD
            // 
            this.miAddBD.Name = "miAddBD";
            this.miAddBD.Size = new System.Drawing.Size(89, 20);
            this.miAddBD.Text = "Добавить БД";
            this.miAddBD.Click += new System.EventHandler(this.miAddBD_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 268);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Домашняя страница";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem miAddEmployee;
        private System.Windows.Forms.ToolStripMenuItem miEmployeeSalary;
        private System.Windows.Forms.ToolStripMenuItem miSignIn;
        private System.Windows.Forms.ToolStripMenuItem miName;
        private System.Windows.Forms.ToolStripMenuItem miNameBD;
        private System.Windows.Forms.ToolStripMenuItem miAddBD;
    }
}