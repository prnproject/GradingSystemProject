using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradingSystemProject
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        public String StudentID { get; set; }
        private void ReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GradingSystemDataSet.CourseGradeReport' table. You can move, or remove it, as needed.
            this.CourseGradeReportTableAdapter.Fill(this.GradingSystemDataSet.CourseGradeReport);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("StudentID", StudentID));
            this.reportViewer1.RefreshReport();
        }
    }
}
