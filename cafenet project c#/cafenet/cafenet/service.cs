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
    public partial class service : Form
    {
        public static OleDbConnection conn=new OleDbConnection ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=I:\\cafenet project c#\\Cafe net.mdb");
        public service()
        {
            InitializeComponent();
        }

        private void service_Load(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * from tblservice", conn);

            DataTable dt = new DataTable();
            conn.Open();
            da.Fill(dt);
            conn.Close();
            dataGridView1.DataSource = dt;
            
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            addservice f = new addservice();

            f.ShowDialog();
            service_Load(sender, e);
            
        }

        private void service_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مطمین هستید واقعا؟!!", "هشدار", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) != DialogResult.Yes)
                return;
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            OleDbCommand cm = new OleDbCommand("delete from tblservice where id=" + id, conn);
            conn.Open();
            cm.ExecuteNonQuery();
            conn.Close();
            service_Load(sender, e);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btedit_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            editservice f = new editservice();
            f.txtid.Text = id;
            f.ShowDialog();
            service_Load(sender, e);
        }
    }
}
