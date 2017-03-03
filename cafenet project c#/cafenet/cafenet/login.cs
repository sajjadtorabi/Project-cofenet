using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cafenet
{
    public partial class login : Form
    {
        public static OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=I:\\cafenet project c#\\Cafe net.mdb");
        public login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = loginBindingSource.Find("username",usernameTextBox.Text);
            int y = loginBindingSource.Find("upass", upassTextBox.Text);
            if (x!=-1 && y!=-1 && x==y)
            {
                login.ActiveForm.Hide();
                menu f = new menu();
                f.ShowDialog();
            }
            else
            {

                MessageBox.Show("نام کاربري يا رمز عبور اشتباه است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTextBox.Clear();
                upassTextBox.Clear();
                usernameTextBox.Focus();
            }
        }

        private static DataTable gettable(string sql)
        {
            throw new NotImplementedException();
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            usernameTextBox.Clear();
            upassTextBox.Clear();
        }

        private void loginBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loginBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cafe_netDataSet);

        }

        private void login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafe_netDataSet.login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.cafe_netDataSet.login);
            usernameTextBox.Clear();
            upassTextBox.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
