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
    public partial class users : Form
    {
        public users()
        {
            InitializeComponent();
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            addusers f = new addusers();
            f.ShowDialog();
            users_Load(sender, e);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafe_netDataSet1.tblusers' table. You can move, or remove it, as needed.
            this.tblusersTableAdapter.Fill(this.cafe_netDataSet1.tblusers);
            
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * from tblusers", service.conn );

            DataTable dt = new DataTable();
            service.conn.Open();
            da.Fill(dt);
            service.conn.Close();
            dataGridView1.DataSource = dt;
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مطمین هستید واقعا؟!!", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            OleDbCommand cm = new OleDbCommand("delete from tblusers where id=" + id, service.conn);
            service.conn.Open();
            cm.ExecuteNonQuery();
            service.conn.Close();
            users_Load(sender, e);
        }

        private void btedit_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            editusers f = new editusers();
            f.txtid.Text = id;
            f.ShowDialog();
            
            users_Load(sender, e);
        }
    }
}
