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
    public partial class addservice : Form
    {
        public static OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=I:\\cafenet project c#\\Cafe net.mdb");
        public addservice()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string sql = "insert into tblservice(service,cost)VALUES('" + txtservice.Text + "','" + textcost.Text + "')";
            OleDbCommand cm = new OleDbCommand(sql ,conn );
            conn.Open();
            cm.ExecuteNonQuery();
            conn.Close();

            
             Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Close();
        }

        private void txtservice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textcost_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
