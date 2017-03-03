using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cafenet
{
    public partial class Rusers : Form
    {
        public Rusers()
        {
            InitializeComponent();
        }

        private void Rusers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Cafe_netDataSet.tblusers' table. You can move, or remove it, as needed.
            this.tblusersTableAdapter.Fill(this.Cafe_netDataSet.tblusers);
            // TODO: This line of code loads data into the 'Cafe_netDataSet.tblservice' table. You can move, or remove it, as needed.
            this.tblserviceTableAdapter.Fill(this.Cafe_netDataSet.tblservice);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
