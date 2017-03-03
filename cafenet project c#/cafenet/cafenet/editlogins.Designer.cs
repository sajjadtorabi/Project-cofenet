namespace cafenet
{
    partial class editlogins
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
            this.textcost = new System.Windows.Forms.TextBox();
            this.txtservice = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btadd = new System.Windows.Forms.Button();
            this.bttclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textcost
            // 
            this.textcost.Location = new System.Drawing.Point(99, 98);
            this.textcost.Name = "textcost";
            this.textcost.Size = new System.Drawing.Size(129, 20);
            this.textcost.TabIndex = 19;
            // 
            // txtservice
            // 
            this.txtservice.Location = new System.Drawing.Point(99, 68);
            this.txtservice.Name = "txtservice";
            this.txtservice.Size = new System.Drawing.Size(129, 20);
            this.txtservice.TabIndex = 18;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(99, 41);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(129, 20);
            this.txtid.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "رمز عبور :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "نام کاربری :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "شماره کاربر:";
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(29, 135);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(75, 33);
            this.btadd.TabIndex = 20;
            this.btadd.Text = "ویرایش کردن";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // bttclose
            // 
            this.bttclose.Location = new System.Drawing.Point(153, 135);
            this.bttclose.Name = "bttclose";
            this.bttclose.Size = new System.Drawing.Size(75, 33);
            this.bttclose.TabIndex = 21;
            this.bttclose.Text = "صرف نظر";
            this.bttclose.UseVisualStyleBackColor = true;
            this.bttclose.Click += new System.EventHandler(this.bttclose_Click);
            // 
            // editlogins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(254, 208);
            this.Controls.Add(this.textcost);
            this.Controls.Add(this.txtservice);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.bttclose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editlogins";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تغییر نام و پسورد";
            this.Load += new System.EventHandler(this.editlogins_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textcost;
        private System.Windows.Forms.TextBox txtservice;
        public System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button bttclose;
    }
}