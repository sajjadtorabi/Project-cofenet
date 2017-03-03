namespace cafenet
{
    partial class editusers
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
            this.textfamily = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtsh = new System.Windows.Forms.TextBox();
            this.btadd = new System.Windows.Forms.Button();
            this.bttclose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textfamily
            // 
            this.textfamily.Location = new System.Drawing.Point(99, 117);
            this.textfamily.Name = "textfamily";
            this.textfamily.Size = new System.Drawing.Size(129, 20);
            this.textfamily.TabIndex = 19;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(99, 87);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(129, 20);
            this.txtname.TabIndex = 18;
            // 
            // txtsh
            // 
            this.txtsh.Location = new System.Drawing.Point(99, 60);
            this.txtsh.Name = "txtsh";
            this.txtsh.Size = new System.Drawing.Size(129, 20);
            this.txtsh.TabIndex = 17;
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(29, 154);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(75, 33);
            this.btadd.TabIndex = 20;
            this.btadd.Text = "ویرایش کردن";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // bttclose
            // 
            this.bttclose.Location = new System.Drawing.Point(153, 154);
            this.bttclose.Name = "bttclose";
            this.bttclose.Size = new System.Drawing.Size(75, 33);
            this.bttclose.TabIndex = 21;
            this.bttclose.Text = "صرف نظر";
            this.bttclose.UseVisualStyleBackColor = true;
            this.bttclose.Click += new System.EventHandler(this.bttclose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "نام خانوادگی:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "نام :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "شماره شناسنامه:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(99, 34);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(129, 20);
            this.txtid.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "شماره کاربری:";
            // 
            // editusers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(254, 208);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textfamily);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtsh);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.bttclose);
            this.Name = "editusers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ویرایش کاربران";
            this.Load += new System.EventHandler(this.editusers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textfamily;
        private System.Windows.Forms.TextBox txtname;
        public System.Windows.Forms.TextBox txtsh;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button bttclose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
    }
}