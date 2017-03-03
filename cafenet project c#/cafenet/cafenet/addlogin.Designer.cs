namespace cafenet
{
    partial class addlogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtupass = new System.Windows.Forms.TextBox();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btadd = new System.Windows.Forms.Button();
            this.bttclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtupass
            // 
            this.txtupass.Location = new System.Drawing.Point(100, 93);
            this.txtupass.Name = "txtupass";
            this.txtupass.Size = new System.Drawing.Size(129, 20);
            this.txtupass.TabIndex = 11;
            // 
            // txtuname
            // 
            this.txtuname.Location = new System.Drawing.Point(100, 63);
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(129, 20);
            this.txtuname.TabIndex = 10;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(100, 36);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(129, 20);
            this.txtid.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "رمز عبور :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "نام کاربری :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "شماره کاربر:";
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(30, 129);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(75, 33);
            this.btadd.TabIndex = 12;
            this.btadd.Text = "اضافه کردن";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // bttclose
            // 
            this.bttclose.Location = new System.Drawing.Point(154, 129);
            this.bttclose.Name = "bttclose";
            this.bttclose.Size = new System.Drawing.Size(75, 33);
            this.bttclose.TabIndex = 13;
            this.bttclose.Text = "صرف نظر";
            this.bttclose.UseVisualStyleBackColor = true;
            this.bttclose.Click += new System.EventHandler(this.bttclose_Click);
            // 
            // addlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(254, 208);
            this.Controls.Add(this.txtupass);
            this.Controls.Add(this.txtuname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.bttclose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addlogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "اضافه کردن کاربر";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtupass;
        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button bttclose;
    }
}