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
    public partial class addlogin : Form
    {
        public addlogin()
        {
            InitializeComponent();
        }

        private void btadd_Click(object sender, EventArgs e)
        {

            // string sql = "insert into login(username,upass)VALUES('" + txtuname.Text + "','" + txtupass.Text + "')";
            //OleDbCommand cm = new OleDbCommand(sql, service.conn );
            //service.conn.Open();
            //cm.ExecuteNonQuery();
            //service.conn.Close();


            //Close();
        }

        private void bttclose_Click(object sender, EventArgs e)
        {
            //Close();
        }
    }
}
