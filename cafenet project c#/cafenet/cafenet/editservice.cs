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
    public partial class editservice : Form
    {
        public editservice()
        {
            InitializeComponent();
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            OleDbCommand cm = new OleDbCommand("update tblservice set service='" + txtservice.Text + "',cost='" + textcost.Text + "' where id=" + txtid.Text, service.conn);
            service.conn.Open();
            cm.ExecuteNonQuery();
            service.conn.Close();
            Close();
        }

        private void bttclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void editservice_Load(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * from tblservice where id="+txtid.Text, service.conn );

            DataTable dt = new DataTable();
            service.conn.Open();
            da.Fill(dt);
            service.conn.Close();
            if (dt.Rows.Count > 0)
            {
                txtservice.Text = dt.Rows[0]["service"].ToString();
                textcost.Text = dt.Rows[0]["cost"].ToString();
            }
            else MessageBox.Show("خدمتی پیدا نشد");
           
        }
    }
}
