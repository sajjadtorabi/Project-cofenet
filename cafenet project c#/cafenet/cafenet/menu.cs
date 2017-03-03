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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void سرویسهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            service f = new service();
            f.MdiParent = this;
            f.Show();
            pictureBox1.Visible = false;
        }

        private void menu_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("از برنامه میخواهید خارج شوید؟", "!!!هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) != DialogResult.Yes)
                return;
            Application.Exit();
        }

        private void دربارهماToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboute f = new aboute();
            f.MdiParent = this;
            f.Show();
            pictureBox1.Visible = false;
        }

        private void افزودنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addservice  f = new addservice ();
            f.MdiParent = this;
            f.Show();
            pictureBox1.Visible = false;
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            service f = new service();
            f.MdiParent = this;
            f.Show();
            pictureBox1.Visible = false;
        }

        private void ویرایشToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            service f = new service();
            f.MdiParent = this;
            f.Show();
            pictureBox1.Visible = false;
        }

        private void کاربرانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            users f = new users();
            f.MdiParent = this;
            f.Show();
            pictureBox1.Visible = false;
        }

        private void افزودنToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addusers f = new addusers();
            f.MdiParent = this;
            f.Show();
            pictureBox1.Visible = false;
        }

        private void حذفToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            users f = new users();
            f.MdiParent = this;
            f.Show();
            pictureBox1.Visible = false;
        }

        private void ویرایشToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            users f = new users();
            f.MdiParent = this;
            f.Show();
            pictureBox1.Visible = false;
        }

        private void منوToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void سرویسهاToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Rservice f = new Rservice();
            f.MdiParent = this;
            f.Show();
            pictureBox1.Visible = false;
        }

        private void کاربرانToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Rusers  f = new Rusers ();
            f.MdiParent = this;
            f.Show();
            pictureBox1.Visible = false;
        }

        private void تغییررمزعبورToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editlogin f=new Editlogin() ;
            f.MdiParent = this;
            f.Show();
            pictureBox1.Visible = false;

        }
    }
}
