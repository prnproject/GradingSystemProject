using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradingSystemProject
{
    public partial class btnLogout : Form
    {
        public btnLogout()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        string conn = "Data Source=LAPTOP-B9VMSNC3SQLEXPRESS;Initial Catalog=GradingSystem;Persist Security Info=True;User ID=sa;Password=123";
        SqlDataAdapter adapter;
        DataSet dataSet;
        private void Form2_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("Select * From Grade;select CourseName from Course",conn);
            dataSet = new DataSet();
            adapter.Fill(dataSet);
        }

        private void btnExportReport_Click(object sender, EventArgs e)
        {
            dgvGrade.DataSource = dataSet.Tables[0];

        }
        public string UserID;
        public string ClassID;

        private void txt_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, " + Student.studentName);
            txtStudent.Text = "Hello, " + Student.studentName;
            MessageBox.Show("Class: " + Student.studentClassId);
            txtClass.Text = "Class: " + Student.studentClassID;
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cboSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboSubject.DataSource = dataSet.Tables[1];
        }
    }
}
