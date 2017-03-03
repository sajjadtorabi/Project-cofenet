namespace cafenet
{
    partial class Editlogin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.btedit = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cafe_netDataSet3 = new cafenet.Cafe_netDataSet3();
            this.cafe_netDataSet2 = new cafenet.Cafe_netDataSet2();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginTableAdapter = new cafenet.Cafe_netDataSet2TableAdapters.loginTableAdapter();
            this.loginTableAdapter1 = new cafenet.Cafe_netDataSet3TableAdapters.loginTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafe_netDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafe_netDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "بازگشت ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btedit
            // 
            this.btedit.Location = new System.Drawing.Point(15, 117);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(69, 43);
            this.btedit.TabIndex = 5;
            this.btedit.Text = "ویرایش";
            this.btedit.UseVisualStyleBackColor = true;
            this.btedit.Click += new System.EventHandler(this.btedit_Click);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(15, 68);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(69, 43);
            this.btdelete.TabIndex = 6;
            this.btdelete.Text = "حذف";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(15, 19);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(69, 43);
            this.btadd.TabIndex = 3;
            this.btadd.Text = "افزودن";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.upassDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loginBindingSource1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(94, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(365, 208);
            this.dataGridView1.TabIndex = 2;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "نام کاربری";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // upassDataGridViewTextBoxColumn
            // 
            this.upassDataGridViewTextBoxColumn.DataPropertyName = "upass";
            this.upassDataGridViewTextBoxColumn.HeaderText = "رمز عبور";
            this.upassDataGridViewTextBoxColumn.Name = "upassDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "شماره کاربر";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // loginBindingSource1
            // 
            this.loginBindingSource1.DataMember = "login";
            this.loginBindingSource1.DataSource = this.cafe_netDataSet3;
            // 
            // cafe_netDataSet3
            // 
            this.cafe_netDataSet3.DataSetName = "Cafe_netDataSet3";
            this.cafe_netDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cafe_netDataSet2
            // 
            this.cafe_netDataSet2.DataSetName = "Cafe_netDataSet2";
            this.cafe_netDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "login";
            this.loginBindingSource.DataSource = this.cafe_netDataSet2;
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // loginTableAdapter1
            // 
            this.loginTableAdapter1.ClearBeforeFill = true;
            // 
            // Editlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(520, 254);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btedit);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Editlogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تغییر رمز عبور";
            this.Load += new System.EventHandler(this.Editlogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafe_netDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafe_netDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btedit;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Cafe_netDataSet2 cafe_netDataSet2;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private Cafe_netDataSet2TableAdapters.loginTableAdapter loginTableAdapter;
        private Cafe_netDataSet3 cafe_netDataSet3;
        private System.Windows.Forms.BindingSource loginBindingSource1;
        private Cafe_netDataSet3TableAdapters.loginTableAdapter loginTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn upassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}