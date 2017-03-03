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
    public partial class editusers : Form
    {
        public static OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=I:\\cafenet project c#\\Cafe net.mdb");
        public editusers()
        {
            InitializeComponent();
        }

        private void bttclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=I:\\cafenet project c#\\Cafe net.mdb");
            OleDbCommand cm = new OleDbCommand("update tblusers set name='" + txtname.Text + "',family='" + textfamily.Text + "',serialnumber=" + txtsh.Text + " where id=" + txtid.Text, service.conn);
            service.conn.Open();
            cm.ExecuteNonQuery();
            service.conn.Close();
            Close();
           
        }

        private void editusers_Load(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * from tblusers where id=" + txtid.Text, service.conn);

            DataTable dt = new DataTable();
            service.conn.Open();
            da.Fill(dt);
            service.conn.Close();
            if (dt.Rows.Count > 0)
            {
                txtname.Text = dt.Rows[0]["name"].ToString();
                txtsh.Text = dt.Rows[0]["serialnumber"].ToString();
                textfamily.Text = dt.Rows[0]["family"].ToString();
            }
            else MessageBox.Show("کاربری پیدا نشد");
            
            
        }
    }
}
