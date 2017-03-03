namespace cafenet
{
    partial class Rservice
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.Cafe_netDataSet = new cafenet.Cafe_netDataSet();
            this.tblserviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblserviceTableAdapter = new cafenet.Cafe_netDataSetTableAdapters.tblserviceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Cafe_netDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblserviceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.tblserviceBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "cafenet.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(84, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(646, 269);
            this.reportViewer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "بازگشت";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cafe_netDataSet
            // 
            this.Cafe_netDataSet.DataSetName = "Cafe_netDataSet";
            this.Cafe_netDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblserviceBindingSource
            // 
            this.tblserviceBindingSource.DataMember = "tblservice";
            this.tblserviceBindingSource.DataSource = this.Cafe_netDataSet;
            // 
            // tblserviceTableAdapter
            // 
            this.tblserviceTableAdapter.ClearBeforeFill = true;
            // 
            // Rservice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 293);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Rservice";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "گزارش خدمات";
            this.Load += new System.EventHandler(this.Rservice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Cafe_netDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblserviceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource tblserviceBindingSource;
        private Cafe_netDataSet Cafe_netDataSet;
        private Cafe_netDataSetTableAdapters.tblserviceTableAdapter tblserviceTableAdapter;
    }
}