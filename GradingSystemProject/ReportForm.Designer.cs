
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.CourseGradeReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GradingSystemDataSet = new GradingSystemProject.GradingSystemDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CourseGradeReportTableAdapter = new GradingSystemProject.GradingSystemDataSetTableAdapters.CourseGradeReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CourseGradeReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GradingSystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // CourseGradeReportBindingSource
            // 
            this.CourseGradeReportBindingSource.DataMember = "CourseGradeReport";
            this.CourseGradeReportBindingSource.DataSource = this.GradingSystemDataSet;
            // 
            // GradingSystemDataSet
            // 
            this.GradingSystemDataSet.DataSetName = "GradingSystemDataSet";
            this.GradingSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.CourseGradeReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GradingSystemProject.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 11);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1487, 449);
            this.reportViewer1.TabIndex = 0;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CourseGradeReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GradingSystemDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CourseGradeReportBindingSource;
        private GradingSystemDataSet GradingSystemDataSet;
        private GradingSystemDataSetTableAdapters.CourseGradeReportTableAdapter CourseGradeReportTableAdapter;
    }
}