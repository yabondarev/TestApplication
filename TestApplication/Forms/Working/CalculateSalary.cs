using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestApplication
{
    public partial class CalculateSalary : BaseForm
    {
        public CalculateSalary()
        {
            InitializeComponent();
        }

        private void CalculateSalary_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> employees = new Dictionary<int, string>();

            employees.Add(employee.GetHashCode(), employee.ToString());

            ETree all = new ETree();
            foreach (ETree child in all)
            {
                if (employee.Post() == "superuser" && child.Post() != "superuser")
                    employees.Add(child.GetHashCode(), child.ToString());
                else if (ETree.IsDescendant(employee, child))
                    employees.Add(child.GetHashCode(), child.ToString());
            }

            cbEmployee.DataSource = new BindingSource(employees, null);
            cbEmployee.DisplayMember = "Value";
            cbEmployee.ValueMember = "Key";
        }

        private void bSalaryEmployee_Click(object sender, EventArgs e)
        {
            if (cbEmployee.Text != "")
                lSalary.Text = SRepository.CalculateSalaryEmployee((int)cbEmployee.SelectedValue, dtDate.Value).ToString();
        }

        private void bSalaryAll_Click(object sender, EventArgs e)
        {
            if (employee.Post() == "superuser")
                lSalary.Text = SRepository.TotalCalculateSalary(dtDate.Value).ToString();
            else
                MessageBox.Show("Посмотреть зарплату офиса может только superuser");
        }
    }
}
