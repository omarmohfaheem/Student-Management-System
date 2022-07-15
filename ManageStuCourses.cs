using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System_Project
{
	public partial class ManageStuCourses : Form
	{
		Controller controllerObj;

		public ManageStuCourses()
		{
			InitializeComponent();
			controllerObj = new Controller();
			DataTable dt1 = controllerObj.CourseName();
			coursenamecombobox.DataSource = dt1;
			coursenamecombobox.DisplayMember = "CourseName";
			DataTable s1 = controllerObj.SelectSID();
			studentidcombobox.DataSource = s1;
			studentidcombobox.DisplayMember = "StudentID";
			stucourse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		}

		private void stucourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
			nametextbox.Text = stucourse.SelectedRows[0].Cells[0].Value.ToString().Trim();
			studentidcombobox.Text = stucourse.SelectedRows[0].Cells[1].Value.ToString().Trim();
			coursenamecombobox.Text = stucourse.SelectedRows[0].Cells[2].Value.ToString().Trim();
			DataTable dt = controllerObj.CourseID(coursenamecombobox.Text);
			DataTable dt2 = controllerObj.CourseCreditHours(coursenamecombobox.Text);
			string id = dt.Rows[0]["CourseID"].ToString();
			string cr = dt2.Rows[0]["CreditHours"].ToString();
			courseidtextbox.Text = id;
			coursecredithourstextbox.Text = cr;
		}

		private void ManageCourseGrade_Load(object sender, EventArgs e)
		{
			stucourse.EnableHeadersVisualStyles = false;
			stucourse.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			stucourse.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
			stucourse.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9, FontStyle.Bold);
			for (int i = 0; i < stucourse.Columns.Count; i++)
			{
				stucourse.Columns[i].DefaultCellStyle.Font = new Font("Century Gothic", 7, FontStyle.Bold);
			}

		}

		private void coursenamecombobox_SelectedIndexChanged(object sender, EventArgs e)
		{

			DataTable dt = controllerObj.CourseName();
			DataTable dt2 = controllerObj.CourseID();
			DataTable dt3 = controllerObj.CourseCreditHours();
			courseidtextbox.Text = dt2.Rows[0]["CourseID"].ToString();
			coursecredithourstextbox.Text = dt3.Rows[0]["CreditHours"].ToString();
			for (int i = 0; i < dt.Rows.Count; i++)
			{
				if (coursenamecombobox.Text == dt.Rows[i]["CourseName"].ToString())
				{
					courseidtextbox.Text = dt2.Rows[i]["CourseID"].ToString();
					coursecredithourstextbox.Text = dt3.Rows[i]["CreditHours"].ToString();
				}
			}
		}

		private void studentidcombobox_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataTable dt = controllerObj.SelectSID();
			DataTable dt2 = controllerObj.SelectStudentName();
			nametextbox.Text = dt2.Rows[0]["Name"].ToString();
			for (int i = 0; i < dt.Rows.Count; i++)
			{
				if (studentidcombobox.Text == dt.Rows[i]["StudentID"].ToString())
					nametextbox.Text = dt2.Rows[i]["Name"].ToString();
			}
		}

		private void returnbutton_Click(object sender, EventArgs e)
		{
			this.Hide();
			Dashboard d1 = new Dashboard();
			d1.Show();
		}

		private void showall_Click(object sender, EventArgs e)
		{
			DataTable dt3 = controllerObj.CourseStu();
			stucourse.DataSource = dt3;
			stucourse.Refresh();
			for (int i = 0; i < stucourse.Columns.Count; i++)
			{
				stucourse.Columns[i].DefaultCellStyle.Font = new Font("Century Gothic", 7, FontStyle.Bold);
			}
		}

		private void Search_Click(object sender, EventArgs e)
		{
			if (studentidcombobox.Text=="" || coursenamecombobox.Text=="")
			{
				MessageBox.Show("Please Enter the data correctly!", "Missing data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			DataTable dt3 = controllerObj.CourseStuFilter(Int32.Parse(studentidcombobox.Text),coursenamecombobox.Text);
			stucourse.DataSource = dt3;
			stucourse.Refresh();
			for (int i = 0; i < stucourse.Columns.Count; i++)
			{
				stucourse.Columns[i].DefaultCellStyle.Font = new Font("Century Gothic", 7, FontStyle.Bold);
			}
		}

		private void Drop_Click(object sender, EventArgs e)
		{
			DialogResult answer = MessageBox.Show("Are you sure you want to drop the course for this student", "Drop Course", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (answer == DialogResult.Yes)
			{
				int result = controllerObj.DropCourse(Int32.Parse(studentidcombobox.Text), Int32.Parse(courseidtextbox.Text));
				if (result == 0)
				{
					MessageBox.Show("Cannot Drop Course");
				}
				else
				{
					MessageBox.Show("Course Dropped!");
					DataTable dt3 = controllerObj.CourseStu();
					stucourse.DataSource = dt3;
					stucourse.Refresh();
				}
			}
		

		}
	}
}

