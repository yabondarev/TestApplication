using System;
using System.Windows.Forms;

namespace TestApplication
{
    public partial class SignIn : Form
    {
        public static string dbname;
        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            if (dbname != null)
            {
                miConnect.Text = "Отключиться от БД";
                miNameBD.Text = "База данных: " + dbname;

                ERepository.Reset();
                LRepository.Reset();

                LItem logins = new LItem();
                foreach (LItem employee in logins)
                {
                    cbLogin.Items.Add(employee.ToString());
                }
            }
        }

        private void bSignIn_Click(object sender, EventArgs e)
        {
            if (cbLogin.Text != "" && tbPassword.Text != "")
            {
                LItem logins = new LItem();
                foreach (LItem employee in logins)
                {
                    if (cbLogin.Text == employee.ToString() && tbPassword.Text == employee.Password())
                    {
                        Hide();
                        BaseForm baseForm = new BaseForm(employee.GetHashCode());
                        baseForm.ShowDialog();
                        Close();
                        return;
                    }
                }
                MessageBox.Show("Вы ввели неправильные данные");
                tbPassword.Text = "";
            }
            else
                MessageBox.Show("Все поля должны быть заполнены");
        }

        private void miConnect_Click(object sender, EventArgs e)
        {
            if (dbname == null)
            {
                Hide();
                ConnectBD connect = new ConnectBD();
                connect.ShowDialog();
                Close();
            }
            else
            {
                dbname = null;
                Hide();
                SignIn signin = new SignIn();
                signin.ShowDialog();
                Close();
            }
        }
    }
}
