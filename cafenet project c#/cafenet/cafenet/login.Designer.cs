namespace cafenet
{
    partial class login
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label upassLabel;
            this.btreset = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cafe_netDataSet = new cafenet.Cafe_netDataSet();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginTableAdapter = new cafenet.Cafe_netDataSetTableAdapters.loginTableAdapter();
            this.tableAdapterManager = new cafenet.Cafe_netDataSetTableAdapters.TableAdapterManager();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.upassTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            usernameLabel = new System.Windows.Forms.Label();
            upassLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cafe_netDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btreset
            // 
            this.btreset.Location = new System.Drawing.Point(125, 101);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(75, 40);
            this.btreset.TabIndex = 0;
            this.btreset.Text = "دوباره سازی";
            this.btreset.UseVisualStyleBackColor = true;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 0;
            this.button2.Text = "ورود";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cafe_netDataSet
            // 
            this.cafe_netDataSet.DataSetName = "Cafe_netDataSet";
            this.cafe_netDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "login";
            this.loginBindingSource.DataSource = this.cafe_netDataSet;
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.loginTableAdapter = this.loginTableAdapter;
            this.tableAdapterManager.tblserviceTableAdapter = null;
            this.tableAdapterManager.tblusersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = cafenet.Cafe_netDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(55, 28);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(61, 13);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "نام کاربری:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource, "username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(125, 25);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 4;
            // 
            // upassLabel
            // 
            upassLabel.AutoSize = true;
            upassLabel.Location = new System.Drawing.Point(63, 54);
            upassLabel.Name = "upassLabel";
            upassLabel.Size = new System.Drawing.Size(53, 13);
            upassLabel.TabIndex = 5;
            upassLabel.Text = "رمز عبور :";
            // 
            // upassTextBox
            // 
            this.upassTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource, "upass", true));
            this.upassTextBox.Location = new System.Drawing.Point(125, 51);
            this.upassTextBox.Name = "upassTextBox";
            this.upassTextBox.PasswordChar = '*';
            this.upassTextBox.Size = new System.Drawing.Size(100, 20);
            this.upassTextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "خروج";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 161);
            this.Controls.Add(this.button1);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(upassLabel);
            this.Controls.Add(this.upassTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btreset);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "صفحه ورود";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cafe_netDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.Button button2;
        private Cafe_netDataSet cafe_netDataSet;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private Cafe_netDataSetTableAdapters.loginTableAdapter loginTableAdapter;
        private Cafe_netDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox upassTextBox;
        private System.Windows.Forms.Button button1;
    }
}