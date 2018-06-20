using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestApplication
{
    public partial class AddEmployee : BaseForm
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> chiefs = new Dictionary<int, string>();

            chiefs.Add(0, "");
            if (employee.Post() != "superuser")
                chiefs.Add(employee.GetHashCode(), employee.ToString());

            ETree all = new ETree();
            foreach (ETree child in all)
            {
                if (employee.Post() == "superuser" && child.Post() != "superuser" && child.Post() != "Employee")
                    chiefs.Add(child.GetHashCode(), child.ToString());
                else if (ETree.IsDescendant(employee, child) && child.Post() != "Employee")
                    chiefs.Add(child.GetHashCode(), child.ToString());
            }

            cbChief.DataSource = new BindingSource(chiefs, null);
            cbChief.DisplayMember = "Value";
            cbChief.ValueMember = "Key";

            Dictionary<string, int> posts = new Dictionary<string, int>
            {
                { "Employee", 5000 },
                { "Manager", 10000 },
                { "Salesman", 20000 }
            };

            cbPost.DataSource = new BindingSource(posts, null);
            cbPost.DisplayMember = "Key";
            cbPost.ValueMember = "Value";
        }

        private void bAddEmployee_Click(object sender, EventArgs e)
        {
            if (tbFIO.Text.Trim() != "" && cbPost.Text.Trim() != "" && tbPassword.Text.Trim() != "")
            {
                ETree all = new ETree();
                foreach (ETree child in all)
                {
                    if(child.ToString() == tbFIO.Text.Trim())
                    {
                        MessageBox.Show("Данный сотрудник уже существует в базе данных");
                        tbFIO.Clear();
                        cbPost.Text = "";
                        cbChief.Text = "";
                        tbPassword.Clear();
                        return;
                    }
                }

                if (cbChief.Text == "")
                    ERepository.AddEntry(tbFIO.Text.Trim(), dtDate.Value, cbPost.Text, (int)cbPost.SelectedValue);
                else
                    ERepository.AddEntry(tbFIO.Text.Trim(), dtDate.Value, cbPost.Text, (int)cbPost.SelectedValue, (int)cbChief.SelectedValue);
                LRepository.AddEntry(tbFIO.Text.Trim(), tbPassword.Text.Trim());
                MessageBox.Show("Сотрудник успешно добавлен");
            }
            else
                MessageBox.Show("Все необходимые поля должны быть заполнены");

            tbFIO.Clear();
            cbPost.Text = "";
            cbChief.Text = "";
            tbPassword.Clear();
            ERepository.Reset();
        }
    }
}
