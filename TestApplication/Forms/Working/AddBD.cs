using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TestApplication
{
    public partial class AddBD : BaseForm
    {
        public AddBD()
        {
            InitializeComponent();
        }

        private void bAddBD_Click(object sender, EventArgs e)
        {
            if (tbNameBD.Text.Trim() != "")
            {
                if (Directory.GetFiles(@"./database", "*.db").Select(x => Path.GetFileNameWithoutExtension(x)).ToArray().Contains(tbNameBD.Text.Trim()))
                {
                    MessageBox.Show("Данная база данных уже существует");
                    tbNameBD.Clear();
                    return;
                }
                Employees employees = new Employees(tbNameBD.Text.Trim() + ".db");
                employees.Fill();
                employees.AddEntry("admin", default(DateTime), "superuser", 0);

                Login login = new Login(tbNameBD.Text.Trim() + ".db");
                login.Fill();
                login.AddEntry("admin", "admin");

                MessageBox.Show("База данных успешно создана");
            }
            else
                MessageBox.Show("Все необходимые поля должны быть заполнены");
            tbNameBD.Clear();
        }
    }
}
