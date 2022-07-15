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
	public partial class RegisterCourse : Form
	{
		Controller controllerObj;

		public RegisterCourse()
		{
			InitializeComponent();
			controllerObj = new Controller();
			/// Comboboxes////
			DataTable c1 = controllerObj.SelectSID();
			sidcombbox.DataSource = c1;
			sidcombbox.DisplayMember = "StudentID";
			DataTable c2 = controllerObj.SelectDepName();
			depcombobox.DataSource = c2;
			depcombobox.DisplayMember = "DepartmentName";
			DataTable c3 = controllerObj.SelectCourseID();
			cidcombobox.DataSource = c3;
			cidcombobox.DisplayMember = "CourseID";
			DataTable c4 = controllerObj.SelectRoomnumber();
			roomnumbercombobox.DataSource = c4;
			roomnumbercombobox.DisplayMember = "RoomNumber";
			DataTable c6 = controllerObj.SelectBName();
			buildingnamecombobox.DataSource = c6;
			buildingnamecombobox.DisplayMember = "BuildingName";
			//////////////////////////////
			coursesav.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			DataTable dt1 = controllerObj.Room();
			room.DataSource = dt1;
			room.Refresh();
		}


		private void RegisterCourse_Load(object sender, EventArgs e)
		{
			coursesav.EnableHeadersVisualStyles = false;
			coursesav.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			coursesav.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
			coursesav.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9, FontStyle.Bold);
			for (int i = 0; i < coursesav.Columns.Count; i++)
			{
				coursesav.Columns[i].DefaultCellStyle.Font = new Font("Century Gothic", 7, FontStyle.Bold);
			}
			room.EnableHeadersVisualStyles = false;
			room.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			room.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
			room.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9, FontStyle.Bold);
			for (int i = 0; i < room.Columns.Count; i++)
			{
				room.Columns[i].DefaultCellStyle.Font = new Font("Century Gothic", 7, FontStyle.Bold);
			}
		}

		private void filterbutton_Click(object sender, EventArgs e)
		{
			DataTable dt = controllerObj.RegisterCourseDep(depcombobox.Text);
			coursesav.DataSource = dt;
			coursesav.Refresh();
			for (int i = 0; i < coursesav.Columns.Count; i++)
			{
				coursesav.Columns[i].DefaultCellStyle.Font = new Font("Century Gothic", 7, FontStyle.Bold);
			}
		}

		private void showall_Click(object sender, EventArgs e)
		{
			DataTable dt = controllerObj.RegisterCourse();
			coursesav.DataSource = dt;
			coursesav.Refresh();
			for (int i = 0; i < coursesav.Columns.Count; i++)
			{
				coursesav.Columns[i].DefaultCellStyle.Font = new Font("Century Gothic", 7, FontStyle.Bold);
			}

		}

		private void registerbutton_Click(object sender, EventArgs e)
		{
			if (levelnumbercombobox.Text == "")
			{
				MessageBox.Show("Please Enter the data correctly!", "Missing data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			int result = controllerObj.InsertTakes(Int32.Parse(sidcombbox.Text), Int32.Parse(roomnumbercombobox.Text),Int32.Parse(levelnumbercombobox.Text),
				buildingnamecombobox.Text,Int32.Parse(cidcombobox.Text));
			if (result == 0)
			{
				MessageBox.Show("Cannot Register Student");
			}
			else
			{
				MessageBox.Show("The student is registered successfully!");
			}
		}

		private void returnbutton_Click(object sender, EventArgs e)
		{
			this.Hide();
			Dashboard d1 = new Dashboard();
			d1.Show();
		}

		private void coursesav_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			cidcombobox.Text = coursesav.SelectedRows[0].Cells[0].Value.ToString().Trim();
			roomnumbercombobox.Text = coursesav.SelectedRows[0].Cells[2].Value.ToString().Trim();
			levelnumbercombobox.Text = coursesav.SelectedRows[0].Cells[3].Value.ToString().Trim();
			buildingnamecombobox.Text = coursesav.SelectedRows[0].Cells[4].Value.ToString().Trim();
		}

		private void room_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}
	}
}
