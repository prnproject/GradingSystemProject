using BAL;
using DTO;
using Microsoft.VisualBasic;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        TeachingManager teachingManager = new TeachingManager();
        SubjectManager subjectManager = new SubjectManager();
		GradeManager gradeManager = new GradeManager();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtName.Text = comboBox1.SelectedItem.ToString();
			TextBox12.Text = "";
			TextBox3.Text = "";
			TextBox4.Text = "";
			TextBox5.Text = "";
			TextBox6.Text = "";
			TextBox7.Text = "";
			TextBox8.Text = "";
			TextBox9.Text = "";
			TextBox10.Text = "";
			TextBox11.Text = "";
			TextBox12.Text = "";
			TextBox13.Text = "";
			TextBox14.Text = "";
			TextBox15.Text = "";
			TextBox16.Text = "";
			TextBox17.Text = "";
			TextBox18.Text = "";
			TextBox19.Text = "";


		}

		private void Form1_Load(object sender, EventArgs e)
        {
            List<Subject> subject = subjectManager.subject();
            foreach (Subject sb in subject)
            {
                comboBox2.Items.Add(sb.SubjectName);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
			int a = default(int);
			decimal b = new decimal();

			if (Information.IsNumeric(TextBox3.Text))
			{
				if (int.Parse(TextBox3.Text) <= 20)
				{
					a = (int)((double.Parse(TextBox3.Text) * 100) / 20);
					TextBox4.Text = a.ToString();
					b = (decimal)(a * 0.1);
					TextBox5.Text = b.ToString();
				}
				else
				{
					MessageBox.Show("Please Enter value equal to 20 and below!");
				}
			}
			if (Information.IsNumeric(TextBox6.Text))
			{

				if (int.Parse(TextBox6.Text) <= 50)
				{
					int c = default(int);
					decimal d = new decimal();
					c = (int)((double.Parse(TextBox6.Text) * 100) / 50);
					TextBox7.Text = c.ToString();
					d = (decimal)(c * 0.1);
					TextBox8.Text = d.ToString();

				}
				else
				{
					MessageBox.Show("Please Enter value equal to 50 and below!");


				}
			}

			if (Information.IsNumeric(TextBox9.Text))
			{
				if (int.Parse(TextBox9.Text) <= 50)
				{
					int g = default(int);
					decimal f = new decimal();
					g = (int)((double.Parse(TextBox9.Text) * 100) / 50);
					TextBox10.Text = g.ToString();
					f = (decimal)(g * 0.2);
					TextBox11.Text = f.ToString();

				}
				else
				{
					MessageBox.Show("Please Enter value equal to 50 and below!");


				}
			}
			if (Information.IsNumeric(TextBox12.Text))
			{
				if (int.Parse(TextBox12.Text) <= 100)
				{
					int g = default(int);
					decimal f = new decimal();
					g = (int)((double.Parse(TextBox12.Text) * 100) / 100);
					TextBox13.Text = g.ToString();
					f = (decimal)(g * 0.3);
					TextBox14.Text = f.ToString();

				}
				else
				{
					MessageBox.Show("Please Enter value equal to 100 and below!");


				}
			}

			if (Information.IsNumeric(TextBox15.Text))
			{
				if (int.Parse(TextBox15.Text) <= 100)
				{
					int j = default(int);
					decimal f1 = new decimal();
					j = (int)((double.Parse(TextBox15.Text) * 100) / 100);
					TextBox16.Text = j.ToString();
					f1 = (decimal)(j * 0.3);
					TextBox17.Text = f1.ToString();

				}
				else
				{
					MessageBox.Show("Please Enter value equal to 100 and below!");


				}
			}

			decimal adal = new decimal();
			adal = (decimal)(Conversion.Val(TextBox5.Text) + Conversion.Val(TextBox8.Text) + Conversion.Val(TextBox11.Text) + Conversion.Val(TextBox14.Text) + Conversion.Val(TextBox17.Text));

			TextBox18.Text = adal.ToString();

			if (Conversion.Val(TextBox18.Text) <= 74)
			{

				TextBox19.Text = "Failed";
				TextBox19.ForeColor = Color.Red;
			}
			else
			{
				TextBox19.Text = "Passed";
				TextBox19.ForeColor = Color.Black;


			}


		}

        private void Button11_Click(object sender, EventArgs e)
        {
	
			TextBox12.Text = "";
			TextBox3.Text = "";
			TextBox4.Text = "";
			TextBox5.Text = "";
			TextBox6.Text = "";
			TextBox7.Text = "";
			TextBox8.Text = "";
			TextBox9.Text = "";
			TextBox10.Text = "";
			TextBox11.Text = "";
			TextBox12.Text = "";
			TextBox13.Text = "";
			TextBox14.Text = "";
			TextBox15.Text = "";
			TextBox16.Text = "";
			TextBox17.Text = "";
			TextBox18.Text = "";
			TextBox19.Text = "";


		}

     //   private void Button4_Click(object sender, EventArgs e)
     //   {
		//	gradeManager.SaveGrade(int.Parse(TextBox3.Text,)
      //  }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
			List<String> classID = teachingManager.getClass(comboBox2.SelectedIndex.ToString());
			comboBox1.Items.AddRange(classID.ToArray());
        }
    }
}
