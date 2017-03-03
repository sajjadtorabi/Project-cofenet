namespace cafenet
{
    partial class addservice
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
            this.bttclose = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtservice = new System.Windows.Forms.TextBox();
            this.textcost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bttclose
            // 
            this.bttclose.Location = new System.Drawing.Point(147, 132);
            this.bttclose.Name = "bttclose";
            this.bttclose.Size = new System.Drawing.Size(75, 33);
            this.bttclose.TabIndex = 5;
            this.bttclose.Text = "صرف نظر";
            this.bttclose.UseVisualStyleBackColor = true;
            this.bttclose.Click += new System.EventHandler(this.button1_Click);
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(23, 132);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(75, 33);
            this.btadd.TabIndex = 4;
            this.btadd.Text = "اضافه کردن";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "شماره خدمت:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "نام خدمت:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "قیمت:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(93, 39);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(129, 20);
            this.txtid.TabIndex = 1;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // txtservice
            // 
            this.txtservice.Location = new System.Drawing.Point(93, 66);
            this.txtservice.Name = "txtservice";
            this.txtservice.Size = new System.Drawing.Size(129, 20);
            this.txtservice.TabIndex = 2;
            this.txtservice.TextChanged += new System.EventHandler(this.txtservice_TextChanged);
            // 
            // textcost
            // 
            this.textcost.Location = new System.Drawing.Point(93, 96);
            this.textcost.Name = "textcost";
            this.textcost.Size = new System.Drawing.Size(129, 20);
            this.textcost.TabIndex = 3;
            this.textcost.TextChanged += new System.EventHandler(this.textcost_TextChanged);
            // 
            // addservice
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
            this.Name = "addservice";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "اضافه کردن خدمت";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttclose;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtservice;
        private System.Windows.Forms.TextBox textcost;
    }
}