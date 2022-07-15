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
	public partial class Grades : Form
	{
		Controller controllerObj;
		public Grades()
		{
			InitializeComponent();
			controllerObj = new Controller();
			DataTable dt1 = controllerObj.CourseName();
			coursenamecombobox.DataSource = dt1;
			coursenamecombobox.DisplayMember = "CourseName";
			DataTable s1 = controllerObj.SelectSID();
			studentidcombobox.DataSource = s1;
			studentidcombobox.DisplayMember = "StudentID";
			DataTable dt3 = controllerObj.STUCOURSE();
			gradeslist.DataSource = dt3;
			gradeslist.Refresh();
			gradeslist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		}

		private void coursenamecombobox_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataTable dt = controllerObj.CourseName();
			DataTable dt2 = controllerObj.CourseID();
			courseidtextbox.Text = dt2.Rows[0]["CourseID"].ToString();
			for (int i = 0; i < dt.Rows.Count; i++)
			{
				if (coursenamecombobox.Text == dt.Rows[i]["CourseName"].ToString())
				{
					courseidtextbox.Text = dt2.Rows[i]["CourseID"].ToString();
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

		private void Grades_Load(object sender, EventArgs e)
		{
			gradeslist.EnableHeadersVisualStyles = false;
			gradeslist.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			gradeslist.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
			gradeslist.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9, FontStyle.Bold);
			for (int i = 0; i < gradeslist.Columns.Count; i++)
			{
				gradeslist.Columns[i].DefaultCellStyle.Font = new Font("Century Gothic", 7, FontStyle.Bold);
			}
		}

		private void gradeslist_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			nametextbox.Text = gradeslist.SelectedRows[0].Cells[1].Value.ToString().Trim();
			studentidcombobox.Text = gradeslist.SelectedRows[0].Cells[0].Value.ToString().Trim();
			coursenamecombobox.Text = gradeslist.SelectedRows[0].Cells[2].Value.ToString().Trim();
			DataTable dt = controllerObj.CourseID(coursenamecombobox.Text);
			string id = dt.Rows[0]["CourseID"].ToString();
			courseidtextbox.Text = id;
		}

		private void totalcr_Click(object sender, EventArgs e)
		{
			DataTable dt = controllerObj.TotalCredits(Int32.Parse(studentidcombobox.Text));
			if (dt == null)
			{
				coursecredithourstextbox.Text = "0";
			}
			else
			{
				string cr = dt.Rows[0]["TotalCreditHours"].ToString();
				coursecredithourstextbox.Text = cr;
			}
		}

		private void assigngrade_Click(object sender, EventArgs e)
		{
			if (gradecombobox.Text == "") {
				{
					MessageBox.Show("Please Enter the data correctly!", "Missing data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
			}
			int result = controllerObj.InsertGrade(Int32.Parse(studentidcombobox.Text), Int32.Parse(courseidtextbox.Text),char.Parse(gradecombobox.Text));
			if (result == 0)
			{
				MessageBox.Show("The insertion of a new Grade failed");
			}
			else
			{
				MessageBox.Show("Grade added for student successfully!");
			}
		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			coursereport c = new coursereport();
			c.Show();
			this.Hide();
		}
	}
}
