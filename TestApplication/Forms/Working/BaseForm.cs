using System;
using System.Windows.Forms;

namespace TestApplication
{
    public partial class BaseForm : Form
    {
        public static ETree employee = new ETree();
        public BaseForm()
        {
            InitializeComponent();
        }
        public BaseForm(int id)
        {
            InitializeComponent();
            BaseForm.employee.Line = ERepository.table[id - 1];
        }
        private void BaseForm_Load(object sender, EventArgs e)
        {
            miNameBD.Text = "База данных: " + SignIn.dbname;
            miName.Text = "Вы вошли как: " + employee.ToString();
        }
        private void miSignIn_Click(object sender, EventArgs e)
        {
            Hide();
            SignIn signin = new SignIn();
            signin.ShowDialog();
            Close();
        }
        private void miAddEmployee_Click(object sender, EventArgs e)
        {
            if (employee.Post() != "Employee")
            {
                Hide();
                AddEmployee addemployee = new AddEmployee();
                addemployee.ShowDialog();
                Close();
            }
            else
                MessageBox.Show("Сотрудник группы 'Employee' не может добавлять других сотрудников");
        }

        private void miEmployeeSalary_Click(object sender, EventArgs e)
        {
            Hide();
            CalculateSalary calculate = new CalculateSalary();
            calculate.ShowDialog();
            Close();
        }

        private void miAddBD_Click(object sender, EventArgs e)
        {
            if (employee.Post() == "superuser")
            {
                Hide();
                AddBD addbd = new AddBD();
                addbd.ShowDialog();
                Close();
            }
            else
                MessageBox.Show("Добавлять базу данных может только superuser");
        }
    }
}
