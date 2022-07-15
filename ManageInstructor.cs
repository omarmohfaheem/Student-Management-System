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
	public partial class ManageInstructor : Form
	{
		Controller controllerObj;
		public ManageInstructor()
		{
			InitializeComponent();
			controllerObj = new Controller();
			DataTable dt = controllerObj.Room();
			room.DataSource = dt;
			room.Refresh();
			DataTable dt1 = controllerObj.InstructorCourse();
			instructors.DataSource = dt1;
			instructors.Refresh();
			instructors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			room.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			///////////////////////////////////////////
			DataTable c1 = controllerObj.SelectInstID();
			instidcombobox.DataSource = c1;
			instidcombobox.DisplayMember = "InstructorID";
			DataTable c2 = controllerObj.SelectCourseID();
			cidcombobox.DataSource = c2;
			cidcombobox.DisplayMember = "CourseID";
			DataTable c3 = controllerObj.SelectBName();
			buildingnamecombobox.DataSource = c3;
			buildingnamecombobox.DisplayMember = "BuildingName";
			DataTable c4 = controllerObj.SelectDepName();
			depcombobox.DataSource = c4;
			depcombobox.DisplayMember = "DepartmentName";
		}

		private void returnbutton_Click(object sender, EventArgs e)
		{
			this.Hide();
			Dashboard d1 = new Dashboard();
			d1.Show();
		}

		private void room_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			roomnumbercombobox.Text = room.SelectedRows[0].Cells[0].Value.ToString().Trim();
			levelnumbercombobox.Text = room.SelectedRows[0].Cells[1].Value.ToString().Trim();
			buildingnamecombobox.Text = room.SelectedRows[0].Cells[3].Value.ToString().Trim();
		}

		private void ManageInstructor_Load(object sender, EventArgs e)
		{
			instructors.EnableHeadersVisualStyles = false;
			instructors.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			instructors.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
			instructors.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9, FontStyle.Bold);
			room.EnableHeadersVisualStyles = false;
			room.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			room.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
			room.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9, FontStyle.Bold);
			for (int i = 0; i < instructors.Columns.Count; i++)
			{
				instructors.Columns[i].DefaultCellStyle.Font = new Font("Century Gothic", 7, FontStyle.Bold);
			}
			for (int i = 0; i < room.Columns.Count; i++)
			{
				room.Columns[i].DefaultCellStyle.Font = new Font("Century Gothic", 7, FontStyle.Bold);
			}
		}

		private void instructors_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			instidcombobox.Text = instructors.SelectedRows[0].Cells[1].Value.ToString().Trim();
			cidcombobox.Text = instructors.SelectedRows[0].Cells[2].Value.ToString().Trim();
		}

		private void depcheckbox_CheckedChanged(object sender, EventArgs e)
		{
			if (depcheckbox.Checked)
			{
				depcombobox.Visible = true;
			}
			else {
				depcombobox.Visible = false;
			}

		}
		private void teach_Click(object sender, EventArgs e)
		{
			int result = controllerObj.InsertTeaches(Int32.Parse(instidcombobox.Text), Int32.Parse(cidcombobox.Text), Int32.Parse(roomnumbercombobox.Text),
				Int32.Parse(levelnumbercombobox.Text), buildingnamecombobox.Text);
			if (result == 0)
			{
				MessageBox.Show("Cannot register instructor to teach course");
			}
			else
			{
				MessageBox.Show("The course is been teached by instructor successfully!");
			}
		}

		private void leave_Click(object sender, EventArgs e)
		{
			int result = controllerObj.LeaveCourseInst(Int32.Parse(instidcombobox.Text), Int32.Parse(cidcombobox.Text));
			if (result == 0)
			{
				MessageBox.Show("Cannot leave course");
			}
			else
			{
				MessageBox.Show("Instructor left course!");
			}
		}

		private void deleteinstructor_Click(object sender, EventArgs e)
		{
			DialogResult answer = MessageBox.Show("Are you sure you want to delete instructor", "Instructor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (answer == DialogResult.Yes)
			{
				int result = controllerObj.DeleteInstructor(Int32.Parse(instidcombobox.Text));
				if (result == 0)
				{
					MessageBox.Show("Cannot delete instructor");
				}
				else
				{
					MessageBox.Show("Instructor deleted successfully!");
				}
			}
		
		}
		private void managebutton_Click(object sender, EventArgs e)
		{
			if (depcheckbox.Checked)
			{
				DataTable d = controllerObj.SelectDepID(depcombobox.Text);
				string id = d.Rows[0]["DepartmentID"].ToString();
				int result = controllerObj.UpdateDepartment(depcombobox.Text, Int32.Parse(id), Int32.Parse(instidcombobox.Text));
				if (result == 0)
				{
					MessageBox.Show("Department Cannot be managed");
				}
				else
				{
					MessageBox.Show("Instructor is managing department successfully!");
				}

			}
			else { MessageBox.Show("Please Check the Prerequisite box!", "Missing data", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
		}
	}
}
