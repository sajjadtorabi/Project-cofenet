namespace cafenet
{
    partial class users
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
            this.cafenetDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafe_netDataSet = new cafenet.Cafe_netDataSet();
            this.tblusersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btedit = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cafe_netDataSet1 = new cafenet.Cafe_netDataSet1();
            this.tblusersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblusersTableAdapter = new cafenet.Cafe_netDataSet1TableAdapters.tblusersTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cafenetDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafe_netDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblusersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafe_netDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblusersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cafenetDataSetBindingSource
            // 
            this.cafenetDataSetBindingSource.DataSource = this.cafe_netDataSet;
            this.cafenetDataSetBindingSource.Position = 0;
            // 
            // cafe_netDataSet
            // 
            this.cafe_netDataSet.DataSetName = "Cafe_netDataSet";
            this.cafe_netDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblusersBindingSource
            // 
            this.tblusersBindingSource.DataMember = "tblusers";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "بازگشت ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btedit
            // 
            this.btedit.Location = new System.Drawing.Point(12, 116);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(69, 43);
            this.btedit.TabIndex = 5;
            this.btedit.Text = "ویرایش";
            this.btedit.UseVisualStyleBackColor = true;
            this.btedit.Click += new System.EventHandler(this.btedit_Click);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(12, 67);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(69, 43);
            this.btdelete.TabIndex = 2;
            this.btdelete.Text = "حذف";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(12, 18);
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.DataSource = this.tblusersBindingSource1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(103, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 271);
            this.dataGridView1.TabIndex = 6;
            // 
            // cafe_netDataSet1
            // 
            this.cafe_netDataSet1.DataSetName = "Cafe_netDataSet1";
            this.cafe_netDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblusersBindingSource1
            // 
            this.tblusersBindingSource1.DataMember = "tblusers";
            this.tblusersBindingSource1.DataSource = this.cafe_netDataSet1;
            // 
            // tblusersTableAdapter
            // 
            this.tblusersTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "شماره کاربر";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "serialnumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "شماره شناسنامه";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn3.HeaderText = "نام";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "family";
            this.dataGridViewTextBoxColumn4.HeaderText = "نام خانوادگی";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(558, 314);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btedit);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btadd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "users";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "کاربران";
            this.Load += new System.EventHandler(this.users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cafenetDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafe_netDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblusersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafe_netDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblusersBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btedit;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btadd;
        
        private System.Windows.Forms.BindingSource tblusersBindingSource;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familyDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cafenetDataSetBindingSource;
        private Cafe_netDataSet cafe_netDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Cafe_netDataSet1 cafe_netDataSet1;
        private System.Windows.Forms.BindingSource tblusersBindingSource1;
        private Cafe_netDataSet1TableAdapters.tblusersTableAdapter tblusersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}