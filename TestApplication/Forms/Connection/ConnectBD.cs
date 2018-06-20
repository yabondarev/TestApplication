using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TestApplication
{
    public partial class ConnectBD : Form
    {
        public ConnectBD()
        {
            InitializeComponent();
        }

        private void ConnectBD_Load(object sender, EventArgs e)
        {
            cbBD.Items.AddRange(Directory.GetFiles(@"./database", "*.db").Select(x => Path.GetFileName(x)).ToArray());
        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            if (cbBD.Text != "")
            {
                SignIn.dbname = cbBD.Text;
                Hide();
                SignIn signin = new SignIn();
                signin.ShowDialog();
                Close();
            }
            else
                MessageBox.Show("Все поля должны быть заполнены");
        }
    }
}
