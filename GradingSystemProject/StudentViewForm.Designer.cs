
namespace GradingSystemProject
{
    partial class btnLogout
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
            this.dgvGrade = new System.Windows.Forms.DataGridView();
            this.txtClass = new System.Windows.Forms.Label();
            this.cboSubject = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExportReport = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStudent
            // 
            this.txtStudent.AutoSize = true;
            this.txtStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudent.Location = new System.Drawing.Point(33, 37);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.Size = new System.Drawing.Size(257, 29);
            this.txtStudent.TabIndex = 0;
            this.txtStudent.Text = "Hello, <StudentName>";
            // 
            // dgvGrade
            // 
            this.dgvGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrade.Location = new System.Drawing.Point(17, 254);
            this.dgvGrade.Name = "dgvGrade";
            this.dgvGrade.RowHeadersWidth = 51;
            this.dgvGrade.RowTemplate.Height = 24;
            this.dgvGrade.Size = new System.Drawing.Size(899, 342);
            this.dgvGrade.TabIndex = 1;
            // 
            // txtClass
            // 
            this.txtClass.AutoSize = true;
            this.txtClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClass.Location = new System.Drawing.Point(33, 83);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(238, 29);
            this.txtClass.TabIndex = 0;
            this.txtClass.Text = "Class: <ClassName>";
            // 
            // cboSubject
            // 
            this.cboSubject.BackColor = System.Drawing.SystemColors.Window;
            this.cboSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboSubject.FormattingEnabled = true;
            this.cboSubject.Location = new System.Drawing.Point(20, 211);
            this.cboSubject.Name = "cboSubject";
            this.cboSubject.Size = new System.Drawing.Size(273, 24);
            this.cboSubject.TabIndex = 2;
            this.cboSubject.SelectedIndexChanged += new System.EventHandler(this.cboSubject_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Choose Sujbect to view Grade:";
            // 
            // btnExportReport
            // 
            this.btnExportReport.Location = new System.Drawing.Point(772, 211);
            this.btnExportReport.Name = "btnExportReport";
            this.btnExportReport.Size = new System.Drawing.Size(142, 37);
            this.btnExportReport.TabIndex = 4;
            this.btnExportReport.Text = "Export Report";
            this.btnExportReport.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(774, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 605);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnExportReport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboSubject);
            this.Controls.Add(this.dgvGrade);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtStudent);
            this.Name = "btnLogout";
            this.Text = "<StudentName> | Grading System";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtStudent;
        private System.Windows.Forms.DataGridView dgvGrade;
        private System.Windows.Forms.Label txtClass;
        private System.Windows.Forms.ComboBox cboSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExportReport;
        private System.Windows.Forms.Button button2;
    }
}