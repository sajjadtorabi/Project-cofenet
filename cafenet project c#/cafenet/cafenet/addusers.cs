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
    public partial class addusers : Form
    {
        public addusers()
        {
            InitializeComponent();
        }

        private void bttclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            OleDbConnection conn=new OleDbConnection ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=I:\\cafenet project c#\\Cafe net.mdb");
            string sql = "insert into tblusers(serialnumber,name,family)VALUES(" + txtsh.Text + ",'" + txtname.Text + "','" + textfamily.Text + "')";
            OleDbCommand cm = new OleDbCommand(sql, conn);
            conn.Open();
            cm.ExecuteNonQuery();
            conn.Close();
            


            Close();
        }
    }
}
