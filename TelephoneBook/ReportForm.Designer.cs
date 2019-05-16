namespace TelephoneBook
{
    partial class ReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PhonebookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PhoneBookDataSet = new TelephoneBook.PhoneBookDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PhonebookTableAdapter = new TelephoneBook.PhoneBookDataSetTableAdapters.PhonebookTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PhonebookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneBookDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PhonebookBindingSource
            // 
            this.PhonebookBindingSource.DataMember = "Phonebook";
            this.PhonebookBindingSource.DataSource = this.PhoneBookDataSet;
            // 
            // PhoneBookDataSet
            // 
            this.PhoneBookDataSet.DataSetName = "PhoneBookDataSet";
            this.PhoneBookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PhonebookBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TelephoneBook.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // PhonebookTableAdapter
            // 
            this.PhonebookTableAdapter.ClearBeforeFill = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PhonebookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneBookDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PhonebookBindingSource;
        private PhoneBookDataSet PhoneBookDataSet;
        private PhoneBookDataSetTableAdapters.PhonebookTableAdapter PhonebookTableAdapter;
    }
}