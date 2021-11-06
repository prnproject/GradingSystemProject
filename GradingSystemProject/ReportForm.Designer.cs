
namespace GradingSystemProject
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GradingSystemDataSet = new GradingSystemProject.GradingSystemDataSet();
            this.CourseGradeReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CourseGradeReportTableAdapter = new GradingSystemProject.GradingSystemDataSetTableAdapters.CourseGradeReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GradingSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CourseGradeReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CourseGradeReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GradingSystemProject.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 11);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1487, 449);
            this.reportViewer1.TabIndex = 0;
            // 
            // GradingSystemDataSet
            // 
            this.GradingSystemDataSet.DataSetName = "GradingSystemDataSet";
            this.GradingSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CourseGradeReportBindingSource
            // 
            this.CourseGradeReportBindingSource.DataMember = "CourseGradeReport";
            this.CourseGradeReportBindingSource.DataSource = this.GradingSystemDataSet;
            // 
            // CourseGradeReportTableAdapter
            // 
            this.CourseGradeReportTableAdapter.ClearBeforeFill = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 472);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GradingSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CourseGradeReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CourseGradeReportBindingSource;
        private GradingSystemDataSet GradingSystemDataSet;
        private GradingSystemDataSetTableAdapters.CourseGradeReportTableAdapter CourseGradeReportTableAdapter;
    }
}