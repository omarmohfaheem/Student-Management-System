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
	public partial class Course : Form
	{
		Controller controllerObj;
		public Course()
		{
			InitializeComponent();
			controllerObj = new Controller();
			DataTable dt1 = controllerObj.SelectDepName();
			depcombobox.DataSource = dt1;
			depcombobox.DisplayMember = "DepartmentName";
			courselist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		}

		private void Course_Load(object sender, EventArgs e)
		{
			courselist.EnableHeadersVisualStyles = false;
			courselist.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			courselist.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
			courselist.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold);
		}


		private void clearbutton_Click(object sender, EventArgs e)
		{
			coursenametextbox.Clear();
			courseidtextbox.Clear();
			credithourscombobox = null;
			daycombobox = null;
			starthour.Text = "00:00:00";
			endhour.Text = "00:00:00";
		}

		private void returnbutton_Click(object sender, EventArgs e)
		{
			this.Hide();
			Dashboard d1 = new Dashboard();
			d1.Show();
		}

		private void courselist_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			coursenametextbox.Text = courselist.SelectedRows[0].Cells[0].Value.ToString().Trim();
			courseidtextbox.Text = courselist.SelectedRows[0].Cells[1].Value.ToString().Trim();
			credithourscombobox.Text = courselist.SelectedRows[0].Cells[2].Value.ToString().Trim();
			daycombobox.Text = courselist.SelectedRows[0].Cells[3].Value.ToString().Trim();
			starthour.Text = courselist.SelectedRows[0].Cells[4].Value.ToString().Trim();
			endhour.Text= courselist.SelectedRows[0].Cells[5].Value.ToString().Trim();
		}

		private void savebutton_Click(object sender, EventArgs e)
		{
			DataTable d = controllerObj.SelectDepID(depcombobox.Text);
			string id = d.Rows[0]["DepartmentID"].ToString();
			StringBuilder err = new StringBuilder("");
			DataTable dt1 = controllerObj.Courses();
			Object data = Validation.CourseIDExists(courseidtextbox.Text.ToString(), dt1, err);
			if (data == null)
			{
				MessageBox.Show(err.ToString());
				MessageBox.Show("Failed to add new Course!", "Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (courseidtextbox.Text == "" || courseidtextbox.Text == "" || credithourscombobox.SelectedItem == null || daycombobox.SelectedItem==null ||depcombobox.SelectedItem==null)
					MessageBox.Show("Please Enter the data correctly!", "Missing data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				int result = controllerObj.InsertCourse(Int32.Parse(courseidtextbox.Text), coursenametextbox.Text, Int32.Parse(credithourscombobox.Text), starthour.Value, endhour.Value, daycombobox.Text);
				int result1 = controllerObj.InsertBelongsTo(Int32.Parse(courseidtextbox.Text), Int32.Parse(id));
				if (result == 0 && result1==0)
				{
					MessageBox.Show("Cannot Add a new Course");
				}
				else
				{
					MessageBox.Show("The Course is added successfully!");
					string[] row = new string[] { coursenametextbox.Text, courseidtextbox.Text,depcombobox.Text, credithourscombobox.Text, daycombobox.Text, starthour.Text, endhour.Text };
					courselist.Rows.Add(row);
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

