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
    public partial class Editlogin : Form
    {
        public Editlogin()
        {
            InitializeComponent();
        }

        private void Editlogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafe_netDataSet3.login' table. You can move, or remove it, as needed.
            //     this.loginTableAdapter1.Fill(this.cafe_netDataSet3.login);
            // TODO: This line of code loads data into the 'cafe_netDataSet2.login' table. You can move, or remove it, as needed.
            //this.loginTableAdapter.Fill(this.cafe_netDataSet2.login);
            //OleDbDataAdapter da = new OleDbDataAdapter("SELECT * from login", service.conn);

            //DataTable dt = new DataTable();
            //service.conn.Open();
            //da.Fill(dt);
            //service.conn.Close();
            //dataGridView1.DataSource = dt;
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            //addlogin f = new addlogin();
            //f.ShowDialog();
            //Editlogin_Load(sender, e);
        }

        private void btedit_Click(object sender, EventArgs e)
        {
 //editlogins f=new editlogins  ();
            //f.ShowDialog();
            //Editlogin_Load(sender, e);
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            //  if (MessageBox.Show("آیا مطمین هستید واقعا؟!!", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            //return;
            //string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //OleDbCommand cm = new OleDbCommand("delete from login where id=" + id, service.conn);
            //service.conn.Open();
            //cm.ExecuteNonQuery();
            //service.conn.Close();
            //Editlogin_Load(sender, e);
        }
    }
}
