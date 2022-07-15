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
	public partial class Manage_Courses : Form
	{
		Controller controllerObj;
		int i = 0;

		public Manage_Courses()
		{		
			InitializeComponent();
			controllerObj = new Controller();
			preqlabel.Visible = false;
			courses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			preqtable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			DataTable dt = controllerObj.CourseName();
			preqcombobox.DataSource = dt;
			preqcombobox.DisplayMember = "CourseName";
			DataTable dt2 = controllerObj.CourseName();
			cnamesearch.DataSource = dt2;
			cnamesearch.DisplayMember = "CourseName";
			DataTable dt1 = controllerObj.SelectDepName();
			depcombobox.DataSource = dt1;
			depcombobox.DisplayMember = "DepartmentName";
		}
		private void returnbutton_Click(object sender, EventArgs e)
		{
			this.Hide();
			Dashboard d1 = new Dashboard();
			d1.Show();
		}

		private void Manage_Courses_Load(object sender, EventArgs e)
		{
			courses.EnableHeadersVisualStyles = false;
			courses.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			courses.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
			courses.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9, FontStyle.Bold);
			preqtable.EnableHeadersVisualStyles = false;
			preqtable.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			preqtable.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
			preqtable.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9, FontStyle.Bold);
			for (int i = 0; i < courses.Columns.Count; i++)
			{
				courses.Columns[i].DefaultCellStyle.Font = new Font("Century Gothic", 7, FontStyle.Bold);
			}
		}

		private void courses_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (i == 0)
			{
				coursenametextbox.Text = courses.SelectedRows[0].Cells[0].Value.ToString().Trim();
				courseidtextbox.Text = courses.SelectedRows[0].Cells[1].Value.ToString().Trim();
				credithourstextbox.Text = courses.SelectedRows[0].Cells[2].Value.ToString().Trim();
				daycombobox.Text = courses.SelectedRows[0].Cells[3].Value.ToString().Trim();
				starthour.Text = courses.SelectedRows[0].Cells[4].Value.ToString().Trim();
				endhour.Text = courses.SelectedRows[0].Cells[5].Value.ToString().Trim();
				depcombobox.Text = courses.SelectedRows[0].Cells[6].Value.ToString().Trim();
			}
			if (i == 1)
			{
				coursenametextbox.Text = courses.SelectedRows[0].Cells[1].Value.ToString().Trim();
				courseidtextbox.Text = courses.SelectedRows[0].Cells[0].Value.ToString().Trim();
				credithourstextbox.Text = courses.SelectedRows[0].Cells[2].Value.ToString().Trim();
				depcombobox.Text = courses.SelectedRows[0].Cells[3].Value.ToString().Trim();
				DataTable d = controllerObj.GetDay(coursenametextbox.Text);
				string day = d.Rows[0]["Day"].ToString();
				DataTable d1 = controllerObj.GetStart(coursenametextbox.Text);
				string st = d1.Rows[0]["StartHour"].ToString();
				DataTable d2 = controllerObj.GetEnd(coursenametextbox.Text);
				string end = d2.Rows[0]["EndHour"].ToString();
				daycombobox.Text = day;
				starthour.Text = st;
				endhour.Text = end;
			}
			if (i == 2)
			{
				coursenametextbox.Text = courses.SelectedRows[0].Cells[0].Value.ToString().Trim();
				courseidtextbox.Text = courses.SelectedRows[0].Cells[1].Value.ToString().Trim();
				credithourstextbox.Text = courses.SelectedRows[0].Cells[2].Value.ToString().Trim();
				daycombobox.Text = courses.SelectedRows[0].Cells[3].Value.ToString().Trim();
				starthour.Text = courses.SelectedRows[0].Cells[4].Value.ToString().Trim();
				endhour.Text = courses.SelectedRows[0].Cells[5].Value.ToString().Trim();
				depcombobox.Text = courses.SelectedRows[0].Cells[6].Value.ToString().Trim();
			}
		}

		private void preqcheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (preqcheckBox.Checked == true)
			{
				preqlabel.Visible =true;
				preqtable.Visible = true;
				preqcombobox.Visible = true;
				DataTable dt = controllerObj.Prerequisite();
				preqtable.DataSource = dt;
				preqtable.Refresh();
			}

			else
			{
				preqlabel.Visible = false;
				preqcombobox.Visible = false;
				preqtable.Visible = false;
			}
		}

		private void Filter_Click(object sender, EventArgs e)
		{
			i = 1;
			DataTable dt = controllerObj.SelectCourseDep(depcombobox.Text);
			courses.DataSource = dt;
			courses.Refresh();
		
		}

		private void preqtable_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			coursenametextbox.Text = preqtable.SelectedRows[0].Cells[1].Value.ToString().Trim();
			courseidtextbox.Text = preqtable.SelectedRows[0].Cells[0].Value.ToString().Trim();
			preqcombobox.Text = preqtable.SelectedRows[0].Cells[3].Value.ToString().Trim();
		}

		private void show_Click(object sender, EventArgs e)
		{
			i = 0;
			DataTable dt = controllerObj.ShowAllCourses();
			courses.DataSource = dt;
			courses.Refresh();
		}

		private void search_Click(object sender, EventArgs e)
		{
			i = 2;
			DataTable dt = controllerObj.ShowAllCoursesbyname(cnamesearch.Text);
			courses.DataSource = dt;
			courses.Refresh();
		}

		private void preqbutton_Click(object sender, EventArgs e)
		{
			if (preqcombobox.Text == "")
			{
				MessageBox.Show("Please Enter the data correctly!", "Missing data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (preqcheckBox.Checked == true)
			{
				DataTable d = controllerObj.GetPrerequisiteID(preqcombobox.Text);
				string pid = d.Rows[0]["PreqID"].ToString();
				int result = controllerObj.AddPreq(Int32.Parse(courseidtextbox.Text),Int32.Parse(pid));
				if (result == 0)
				{
					MessageBox.Show("Cannot Add Prerequisite");
				}
				else
				{
					MessageBox.Show("Prerequisite Added Successfully!");
					DataTable dt = controllerObj.Prerequisite();
					preqtable.DataSource = dt;
					preqtable.Refresh();
				}
			}
			else {
				MessageBox.Show("Please Check the Prerequisite box!", "Missing data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void updatecoursetime_Click(object sender, EventArgs e)
		{
			if (daycombobox.Text == "" || depcombobox.Text == "")
			{
				MessageBox.Show("Please Enter the data correctly!", "Missing data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			int result = controllerObj.UpdateCourse(daycombobox.Text, starthour.Value,endhour.Value,Int32.Parse(courseidtextbox.Text));
			if (result == 0)
			{
				MessageBox.Show("Cannot Update Course Time");
			}
			else
			{
				MessageBox.Show("Course Time Updated Successfully!");
			}
		}

		private void deletecourse_Click(object sender, EventArgs e)
		{
			if (daycombobox.Text == "" || depcombobox.Text == "") {
				MessageBox.Show("Please Enter the data correctly!", "Missing data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			DialogResult answer = MessageBox.Show("Are you sure you want to delete instructor", "Instructor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (answer == DialogResult.Yes)
			{
				int result = controllerObj.DeleteCourse(Int32.Parse(courseidtextbox.Text));
				if (result == 0)
				{
					MessageBox.Show("Cannot Delete Course ");
				}
				else
				{
					MessageBox.Show("Course Deleted Successfully!");
				}
			}
		}

		private void coursenametextbox_KeyDown(object sender, KeyEventArgs e)
		{

		}

		private void coursenametextbox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
			{
				e.Handled = true; // Do not write the key pressed in the text box 
				MessageBox.Show("No any numbers or special characters are allowed in this field", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void courseidtextbox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true; // Do not write the key pressed in the text box 
				MessageBox.Show("No any letters or special characters are allowed in the this field", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
