
using System;

namespace GradingSystemProject
{
    partial class TeacherViewForm
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
            this.Label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtAttendancePercent = new System.Windows.Forms.TextBox();
            this.txtAttendanceEG = new System.Windows.Forms.TextBox();
            this.txtAttendanceGrade = new System.Windows.Forms.TextBox();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtProjectGrade = new System.Windows.Forms.TextBox();
            this.txtProjectPercent = new System.Windows.Forms.TextBox();
            this.txtProjectEG = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtWrittenQuizPercent = new System.Windows.Forms.TextBox();
            this.txtWrittenQuizGrade = new System.Windows.Forms.TextBox();
            this.txtWrittenQuizEG = new System.Windows.Forms.TextBox();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtFinalExamGrade = new System.Windows.Forms.TextBox();
            this.txtFinalExamPercent = new System.Windows.Forms.TextBox();
            this.txtFinalExamEG = new System.Windows.Forms.TextBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtPracticalQuizGrade = new System.Windows.Forms.TextBox();
            this.txtPracticalQuizPercent = new System.Windows.Forms.TextBox();
            this.txtPracticalQuizEG = new System.Windows.Forms.TextBox();
            this.GroupBox6 = new System.Windows.Forms.GroupBox();
            this.txtAverageGrade = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.bntCompute = new System.Windows.Forms.Button();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.cboCourse = new System.Windows.Forms.ComboBox();
            this.lstStudent = new System.Windows.Forms.ListView();
            this.colStudentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStudentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStudentPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStudentMail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Green;
            this.Label1.Location = new System.Drawing.Point(23, 65);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(100, 20);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "FullName: ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 63);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(191, 22);
            this.txtName.TabIndex = 99;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.txtAttendancePercent);
            this.GroupBox1.Controls.Add(this.txtAttendanceEG);
            this.GroupBox1.Controls.Add(this.txtAttendanceGrade);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(27, 109);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(443, 92);
            this.GroupBox1.TabIndex = 27;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Attendance        20            EG         10%";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Green;
            this.Label3.Location = new System.Drawing.Point(19, 27);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(58, 18);
            this.Label3.TabIndex = 10;
            this.Label3.Text = "Score:";
            // 
            // txtAttendancePercent
            // 
            this.txtAttendancePercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAttendancePercent.Location = new System.Drawing.Point(224, 23);
            this.txtAttendancePercent.Margin = new System.Windows.Forms.Padding(4);
            this.txtAttendancePercent.Name = "txtAttendancePercent";
            this.txtAttendancePercent.ReadOnly = true;
            this.txtAttendancePercent.Size = new System.Drawing.Size(60, 24);
            this.txtAttendancePercent.TabIndex = 99;
            // 
            // txtAttendanceEG
            // 
            this.txtAttendanceEG.AcceptsTab = true;
            this.txtAttendanceEG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAttendanceEG.Location = new System.Drawing.Point(155, 23);
            this.txtAttendanceEG.Margin = new System.Windows.Forms.Padding(4);
            this.txtAttendanceEG.Name = "txtAttendanceEG";
            this.txtAttendanceEG.ReadOnly = true;
            this.txtAttendanceEG.Size = new System.Drawing.Size(60, 24);
            this.txtAttendanceEG.TabIndex = 99;
            // 
            // txtAttendanceGrade
            // 
            this.txtAttendanceGrade.Location = new System.Drawing.Point(85, 23);
            this.txtAttendanceGrade.Margin = new System.Windows.Forms.Padding(4);
            this.txtAttendanceGrade.Name = "txtAttendanceGrade";
            this.txtAttendanceGrade.Size = new System.Drawing.Size(60, 24);
            this.txtAttendanceGrade.TabIndex = 1;
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.Label6);
            this.GroupBox4.Controls.Add(this.txtProjectGrade);
            this.GroupBox4.Controls.Add(this.txtProjectPercent);
            this.GroupBox4.Controls.Add(this.txtProjectEG);
            this.GroupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox4.Location = new System.Drawing.Point(494, 109);
            this.GroupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox4.Size = new System.Drawing.Size(443, 92);
            this.GroupBox4.TabIndex = 28;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Project              100            EG         30%";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.Green;
            this.Label6.Location = new System.Drawing.Point(20, 27);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(58, 18);
            this.Label6.TabIndex = 22;
            this.Label6.Text = "Score:";
            // 
            // txtProjectGrade
            // 
            this.txtProjectGrade.Location = new System.Drawing.Point(87, 23);
            this.txtProjectGrade.Margin = new System.Windows.Forms.Padding(4);
            this.txtProjectGrade.Name = "txtProjectGrade";
            this.txtProjectGrade.Size = new System.Drawing.Size(60, 24);
            this.txtProjectGrade.TabIndex = 1;
            // 
            // txtProjectPercent
            // 
            this.txtProjectPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtProjectPercent.Location = new System.Drawing.Point(225, 23);
            this.txtProjectPercent.Margin = new System.Windows.Forms.Padding(4);
            this.txtProjectPercent.Name = "txtProjectPercent";
            this.txtProjectPercent.ReadOnly = true;
            this.txtProjectPercent.Size = new System.Drawing.Size(60, 24);
            this.txtProjectPercent.TabIndex = 99;
            // 
            // txtProjectEG
            // 
            this.txtProjectEG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtProjectEG.Location = new System.Drawing.Point(156, 23);
            this.txtProjectEG.Margin = new System.Windows.Forms.Padding(4);
            this.txtProjectEG.Name = "txtProjectEG";
            this.txtProjectEG.ReadOnly = true;
            this.txtProjectEG.Size = new System.Drawing.Size(60, 24);
            this.txtProjectEG.TabIndex = 99;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.txtWrittenQuizPercent);
            this.GroupBox2.Controls.Add(this.txtWrittenQuizGrade);
            this.GroupBox2.Controls.Add(this.txtWrittenQuizEG);
            this.GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(27, 209);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Size = new System.Drawing.Size(443, 92);
            this.GroupBox2.TabIndex = 29;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Written Quiz      50            EG        10%";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Green;
            this.Label4.Location = new System.Drawing.Point(19, 27);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(58, 18);
            this.Label4.TabIndex = 14;
            this.Label4.Text = "Score:";
            // 
            // txtWrittenQuizPercent
            // 
            this.txtWrittenQuizPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtWrittenQuizPercent.Location = new System.Drawing.Point(224, 23);
            this.txtWrittenQuizPercent.Margin = new System.Windows.Forms.Padding(4);
            this.txtWrittenQuizPercent.Name = "txtWrittenQuizPercent";
            this.txtWrittenQuizPercent.ReadOnly = true;
            this.txtWrittenQuizPercent.Size = new System.Drawing.Size(60, 24);
            this.txtWrittenQuizPercent.TabIndex = 99;
            // 
            // txtWrittenQuizGrade
            // 
            this.txtWrittenQuizGrade.Location = new System.Drawing.Point(85, 23);
            this.txtWrittenQuizGrade.Margin = new System.Windows.Forms.Padding(4);
            this.txtWrittenQuizGrade.Name = "txtWrittenQuizGrade";
            this.txtWrittenQuizGrade.Size = new System.Drawing.Size(60, 24);
            this.txtWrittenQuizGrade.TabIndex = 1;
            // 
            // txtWrittenQuizEG
            // 
            this.txtWrittenQuizEG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtWrittenQuizEG.Location = new System.Drawing.Point(155, 23);
            this.txtWrittenQuizEG.Margin = new System.Windows.Forms.Padding(4);
            this.txtWrittenQuizEG.Name = "txtWrittenQuizEG";
            this.txtWrittenQuizEG.ReadOnly = true;
            this.txtWrittenQuizEG.Size = new System.Drawing.Size(60, 24);
            this.txtWrittenQuizEG.TabIndex = 99;
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.Label7);
            this.GroupBox5.Controls.Add(this.txtFinalExamGrade);
            this.GroupBox5.Controls.Add(this.txtFinalExamPercent);
            this.GroupBox5.Controls.Add(this.txtFinalExamEG);
            this.GroupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox5.Location = new System.Drawing.Point(494, 209);
            this.GroupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox5.Size = new System.Drawing.Size(443, 92);
            this.GroupBox5.TabIndex = 30;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "Final Exam   100             EG        30%";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.Green;
            this.Label7.Location = new System.Drawing.Point(20, 27);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(58, 18);
            this.Label7.TabIndex = 26;
            this.Label7.Text = "Score:";
            // 
            // txtFinalExamGrade
            // 
            this.txtFinalExamGrade.Location = new System.Drawing.Point(87, 23);
            this.txtFinalExamGrade.Margin = new System.Windows.Forms.Padding(4);
            this.txtFinalExamGrade.Name = "txtFinalExamGrade";
            this.txtFinalExamGrade.Size = new System.Drawing.Size(60, 24);
            this.txtFinalExamGrade.TabIndex = 1;
            // 
            // txtFinalExamPercent
            // 
            this.txtFinalExamPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtFinalExamPercent.Location = new System.Drawing.Point(232, 23);
            this.txtFinalExamPercent.Margin = new System.Windows.Forms.Padding(4);
            this.txtFinalExamPercent.Name = "txtFinalExamPercent";
            this.txtFinalExamPercent.ReadOnly = true;
            this.txtFinalExamPercent.Size = new System.Drawing.Size(60, 24);
            this.txtFinalExamPercent.TabIndex = 99;
            // 
            // txtFinalExamEG
            // 
            this.txtFinalExamEG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtFinalExamEG.Location = new System.Drawing.Point(159, 23);
            this.txtFinalExamEG.Margin = new System.Windows.Forms.Padding(4);
            this.txtFinalExamEG.Name = "txtFinalExamEG";
            this.txtFinalExamEG.ReadOnly = true;
            this.txtFinalExamEG.Size = new System.Drawing.Size(60, 24);
            this.txtFinalExamEG.TabIndex = 99;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.Label5);
            this.GroupBox3.Controls.Add(this.txtPracticalQuizGrade);
            this.GroupBox3.Controls.Add(this.txtPracticalQuizPercent);
            this.GroupBox3.Controls.Add(this.txtPracticalQuizEG);
            this.GroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.Location = new System.Drawing.Point(27, 311);
            this.GroupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox3.Size = new System.Drawing.Size(443, 92);
            this.GroupBox3.TabIndex = 31;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Practical Quiz    50            EG         20%";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Green;
            this.Label5.Location = new System.Drawing.Point(19, 27);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(58, 18);
            this.Label5.TabIndex = 18;
            this.Label5.Text = "Score:";
            // 
            // txtPracticalQuizGrade
            // 
            this.txtPracticalQuizGrade.Location = new System.Drawing.Point(85, 23);
            this.txtPracticalQuizGrade.Margin = new System.Windows.Forms.Padding(4);
            this.txtPracticalQuizGrade.Name = "txtPracticalQuizGrade";
            this.txtPracticalQuizGrade.Size = new System.Drawing.Size(61, 24);
            this.txtPracticalQuizGrade.TabIndex = 1;
            // 
            // txtPracticalQuizPercent
            // 
            this.txtPracticalQuizPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPracticalQuizPercent.Location = new System.Drawing.Point(225, 23);
            this.txtPracticalQuizPercent.Margin = new System.Windows.Forms.Padding(4);
            this.txtPracticalQuizPercent.Name = "txtPracticalQuizPercent";
            this.txtPracticalQuizPercent.ReadOnly = true;
            this.txtPracticalQuizPercent.Size = new System.Drawing.Size(60, 24);
            this.txtPracticalQuizPercent.TabIndex = 99;
            // 
            // txtPracticalQuizEG
            // 
            this.txtPracticalQuizEG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPracticalQuizEG.Location = new System.Drawing.Point(156, 23);
            this.txtPracticalQuizEG.Margin = new System.Windows.Forms.Padding(4);
            this.txtPracticalQuizEG.Name = "txtPracticalQuizEG";
            this.txtPracticalQuizEG.ReadOnly = true;
            this.txtPracticalQuizEG.Size = new System.Drawing.Size(60, 24);
            this.txtPracticalQuizEG.TabIndex = 99;
            // 
            // GroupBox6
            // 
            this.GroupBox6.Controls.Add(this.txtAverageGrade);
            this.GroupBox6.Controls.Add(this.Label9);
            this.GroupBox6.Controls.Add(this.txtRemarks);
            this.GroupBox6.Controls.Add(this.Label8);
            this.GroupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox6.Location = new System.Drawing.Point(494, 311);
            this.GroupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox6.Size = new System.Drawing.Size(443, 92);
            this.GroupBox6.TabIndex = 32;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "TOTAL AVARAGE COMPUTED";
            // 
            // txtAverageGrade
            // 
            this.txtAverageGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAverageGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAverageGrade.Location = new System.Drawing.Point(25, 50);
            this.txtAverageGrade.Margin = new System.Windows.Forms.Padding(4);
            this.txtAverageGrade.Name = "txtAverageGrade";
            this.txtAverageGrade.ReadOnly = true;
            this.txtAverageGrade.Size = new System.Drawing.Size(115, 29);
            this.txtAverageGrade.TabIndex = 29;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.Color.Green;
            this.Label9.Location = new System.Drawing.Point(155, 27);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(81, 18);
            this.Label9.TabIndex = 30;
            this.Label9.Text = "Remarks:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(159, 50);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ReadOnly = true;
            this.txtRemarks.Size = new System.Drawing.Size(129, 29);
            this.txtRemarks.TabIndex = 30;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.Green;
            this.Label8.Location = new System.Drawing.Point(21, 27);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(124, 18);
            this.Label8.TabIndex = 29;
            this.Label8.Text = "Average Grade:";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Green;
            this.btnDelete.Location = new System.Drawing.Point(560, 422);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 33);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Green;
            this.btnSave.Location = new System.Drawing.Point(367, 422);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 33);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.ForeColor = System.Drawing.Color.Green;
            this.btnClearAll.Location = new System.Drawing.Point(30, 421);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(95, 33);
            this.btnClearAll.TabIndex = 35;
            this.btnClearAll.Text = "&Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // bntCompute
            // 
            this.bntCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCompute.ForeColor = System.Drawing.Color.Green;
            this.bntCompute.Location = new System.Drawing.Point(190, 421);
            this.bntCompute.Margin = new System.Windows.Forms.Padding(4);
            this.bntCompute.Name = "bntCompute";
            this.bntCompute.Size = new System.Drawing.Size(112, 33);
            this.bntCompute.TabIndex = 34;
            this.bntCompute.Text = "C&ompute";
            this.bntCompute.UseVisualStyleBackColor = true;
            this.bntCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // cboClass
            // 
            this.cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(710, 556);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(227, 24);
            this.cboClass.TabIndex = 0;
            this.cboClass.SelectedIndexChanged += new System.EventHandler(this.cboClass_SelectedIndexChanged);
            // 
            // cboCourse
            // 
            this.cboCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCourse.FormattingEnabled = true;
            this.cboCourse.Location = new System.Drawing.Point(710, 502);
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.Size = new System.Drawing.Size(227, 24);
            this.cboCourse.TabIndex = 0;
            this.cboCourse.SelectedIndexChanged += new System.EventHandler(this.cboCourse_SelectedIndexChanged);
            // 
            // lstStudent
            // 
            this.lstStudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colStudentID,
            this.colStudentName,
            this.colStudentPhoneNumber,
            this.colStudentMail});
            this.lstStudent.FullRowSelect = true;
            this.lstStudent.GridLines = true;
            this.lstStudent.HideSelection = false;
            this.lstStudent.Location = new System.Drawing.Point(30, 474);
            this.lstStudent.MultiSelect = false;
            this.lstStudent.Name = "lstStudent";
            this.lstStudent.Size = new System.Drawing.Size(659, 164);
            this.lstStudent.TabIndex = 41;
            this.lstStudent.UseCompatibleStateImageBehavior = false;
            this.lstStudent.View = System.Windows.Forms.View.Details;
            this.lstStudent.SelectedIndexChanged += new System.EventHandler(this.lstStudent_SelectedIndexChanged);
            // 
            // colStudentID
            // 
            this.colStudentID.Text = "Student ID";
            this.colStudentID.Width = 73;
            // 
            // colStudentName
            // 
            this.colStudentName.Text = "Student Name";
            this.colStudentName.Width = 200;
            // 
            // colStudentPhoneNumber
            // 
            this.colStudentPhoneNumber.Text = "Phone Number";
            this.colStudentPhoneNumber.Width = 120;
            // 
            // colStudentMail
            // 
            this.colStudentMail.Text = "Mail";
            this.colStudentMail.Width = 262;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(707, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Course:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(707, 536);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 17);
            this.label10.TabIndex = 42;
            this.label10.Text = "Class:";
            // 
            // TeacherViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 650);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstStudent);
            this.Controls.Add(this.cboCourse);
            this.Controls.Add(this.cboClass);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.bntCompute);
            this.Controls.Add(this.GroupBox6);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox5);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Label1);
            this.Name = "TeacherViewForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtAttendanceGrade;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtProjectGrade;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtWrittenQuizGrade;
        internal System.Windows.Forms.GroupBox GroupBox5;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtFinalExamGrade;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtPracticalQuizGrade;
        internal System.Windows.Forms.GroupBox GroupBox6;
        internal System.Windows.Forms.TextBox txtAverageGrade;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtRemarks;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnClearAll;
        internal System.Windows.Forms.Button bntCompute;
        internal System.Windows.Forms.TextBox txtAttendancePercent;
        internal System.Windows.Forms.TextBox txtAttendanceEG;
        internal System.Windows.Forms.TextBox txtProjectPercent;
        internal System.Windows.Forms.TextBox txtProjectEG;
        internal System.Windows.Forms.TextBox txtWrittenQuizPercent;
        internal System.Windows.Forms.TextBox txtWrittenQuizEG;
        internal System.Windows.Forms.TextBox txtFinalExamPercent;
        internal System.Windows.Forms.TextBox txtFinalExamEG;
        internal System.Windows.Forms.TextBox txtPracticalQuizPercent;
        internal System.Windows.Forms.TextBox txtPracticalQuizEG;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.ComboBox cboCourse;
        private System.Windows.Forms.ListView lstStudent;
        private System.Windows.Forms.ColumnHeader colStudentID;
        private System.Windows.Forms.ColumnHeader colStudentName;
        private System.Windows.Forms.ColumnHeader colStudentPhoneNumber;
        private System.Windows.Forms.ColumnHeader colStudentMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
    }
}