
namespace GradingSystemProject
{
    partial class StudentViewForm
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
            this.txtStudent = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.Label();
            this.btnExportReport = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lstTeacherCourse = new System.Windows.Forms.ListView();
            this.colCourse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTeacher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAttendance = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.lblWritten = new System.Windows.Forms.Label();
            this.lblPractical = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStudent
            // 
            this.txtStudent.AutoSize = true;
            this.txtStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudent.ForeColor = System.Drawing.Color.Green;
            this.txtStudent.Location = new System.Drawing.Point(12, 10);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.Size = new System.Drawing.Size(257, 29);
            this.txtStudent.TabIndex = 0;
            this.txtStudent.Text = "Hello, <StudentName>";
            // 
            // txtClass
            // 
            this.txtClass.AutoSize = true;
            this.txtClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClass.ForeColor = System.Drawing.Color.Green;
            this.txtClass.Location = new System.Drawing.Point(12, 56);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(238, 29);
            this.txtClass.TabIndex = 0;
            this.txtClass.Text = "Class: <ClassName>";
            // 
            // btnExportReport
            // 
            this.btnExportReport.ForeColor = System.Drawing.Color.Green;
            this.btnExportReport.Location = new System.Drawing.Point(436, 211);
            this.btnExportReport.Name = "btnExportReport";
            this.btnExportReport.Size = new System.Drawing.Size(142, 37);
            this.btnExportReport.TabIndex = 4;
            this.btnExportReport.Text = "Export Report";
            this.btnExportReport.UseVisualStyleBackColor = true;
            this.btnExportReport.Click += new System.EventHandler(this.btnExportReport_Click_1);
            // 
            // btnLogout
            // 
            this.btnLogout.ForeColor = System.Drawing.Color.Green;
            this.btnLogout.Location = new System.Drawing.Point(436, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(142, 37);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lstTeacherCourse
            // 
            this.lstTeacherCourse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCourse,
            this.colTeacher});
            this.lstTeacherCourse.FullRowSelect = true;
            this.lstTeacherCourse.GridLines = true;
            this.lstTeacherCourse.HideSelection = false;
            this.lstTeacherCourse.Location = new System.Drawing.Point(13, 291);
            this.lstTeacherCourse.MultiSelect = false;
            this.lstTeacherCourse.Name = "lstTeacherCourse";
            this.lstTeacherCourse.Size = new System.Drawing.Size(583, 302);
            this.lstTeacherCourse.TabIndex = 5;
            this.lstTeacherCourse.UseCompatibleStateImageBehavior = false;
            this.lstTeacherCourse.View = System.Windows.Forms.View.Details;
            this.lstTeacherCourse.SelectedIndexChanged += new System.EventHandler(this.lstTeacherCourse_SelectedIndexChanged);
            // 
            // colCourse
            // 
            this.colCourse.Text = "Course";
            this.colCourse.Width = 280;
            // 
            // colTeacher
            // 
            this.colTeacher.Text = "Teacher";
            this.colTeacher.Width = 299;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(14, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Attendance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(14, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Project:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(14, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Written Exam:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(14, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Practical Exam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(14, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Final Exam:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(14, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Average:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(232, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Result:";
            // 
            // lblAttendance
            // 
            this.lblAttendance.AutoSize = true;
            this.lblAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendance.ForeColor = System.Drawing.Color.Green;
            this.lblAttendance.Location = new System.Drawing.Point(142, 108);
            this.lblAttendance.Name = "lblAttendance";
            this.lblAttendance.Size = new System.Drawing.Size(78, 20);
            this.lblAttendance.TabIndex = 7;
            this.lblAttendance.Text = "<grade>";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject.ForeColor = System.Drawing.Color.Green;
            this.lblProject.Location = new System.Drawing.Point(142, 135);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(78, 20);
            this.lblProject.TabIndex = 7;
            this.lblProject.Text = "<grade>";
            // 
            // lblWritten
            // 
            this.lblWritten.AutoSize = true;
            this.lblWritten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWritten.ForeColor = System.Drawing.Color.Green;
            this.lblWritten.Location = new System.Drawing.Point(142, 162);
            this.lblWritten.Name = "lblWritten";
            this.lblWritten.Size = new System.Drawing.Size(78, 20);
            this.lblWritten.TabIndex = 7;
            this.lblWritten.Text = "<grade>";
            // 
            // lblPractical
            // 
            this.lblPractical.AutoSize = true;
            this.lblPractical.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPractical.ForeColor = System.Drawing.Color.Green;
            this.lblPractical.Location = new System.Drawing.Point(142, 189);
            this.lblPractical.Name = "lblPractical";
            this.lblPractical.Size = new System.Drawing.Size(78, 20);
            this.lblPractical.TabIndex = 7;
            this.lblPractical.Text = "<grade>";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinal.ForeColor = System.Drawing.Color.Green;
            this.lblFinal.Location = new System.Drawing.Point(142, 216);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(78, 20);
            this.lblFinal.TabIndex = 7;
            this.lblFinal.Text = "<grade>";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.ForeColor = System.Drawing.Color.Green;
            this.lblAverage.Location = new System.Drawing.Point(142, 243);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(78, 20);
            this.lblAverage.TabIndex = 7;
            this.lblAverage.Text = "<grade>";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Green;
            this.lblResult.Location = new System.Drawing.Point(304, 243);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(79, 20);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "<result>";
            // 
            // StudentViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 605);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.lblPractical);
            this.Controls.Add(this.lblWritten);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblAttendance);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstTeacherCourse);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnExportReport);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtStudent);
            this.Name = "StudentViewForm";
            this.Text = "<StudentName> | Grading System";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtStudent;
        private System.Windows.Forms.Label txtClass;
        private System.Windows.Forms.Button btnExportReport;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ListView lstTeacherCourse;
        private System.Windows.Forms.ColumnHeader colCourse;
        private System.Windows.Forms.ColumnHeader colTeacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAttendance;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Label lblWritten;
        private System.Windows.Forms.Label lblPractical;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblResult;
    }
}