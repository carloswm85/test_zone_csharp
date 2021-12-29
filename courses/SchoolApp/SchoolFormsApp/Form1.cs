using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolLibrary;

namespace SchoolFormsApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			var testSchool = new School();
			testSchool.Name = txtName.Text;
			testSchool.Address = txtAddress.Text;
			testSchool.City = txtCity.Text;
			testSchool.State = txtState.Text;
			testSchool.Zip = txtZip.Text;
			testSchool.PhoneNumber = txtPhone.Text;

			try
            {
			testSchool.TwitterAddress = txtTwitter.Text;

            } catch (Exception ex)
            {
				MessageBox.Show(ex.Message);
            }

			MessageBox.Show(testSchool.ToString());

			var student = new Student();
			var teacher = new Teacher(); // TODO: for testing only, remove later
			
		}

        private void button2_Click(object sender, EventArgs e)
        {
			var student = new Student();
			var gp = student.ComputeGradeAverage();
			MessageBox.Show("The student's grade is " + gp);
		}

        private void btnTestTeacher_Click(object sender, EventArgs e)
        {
			var teacher = new Teacher();
			var gp = teacher.ComputeGradeAverage();
			MessageBox.Show("The grade is " + gp);
        }
    }
}
