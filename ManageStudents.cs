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
	public partial class ManageStudents : Form
	{
		Controller controllerObj;
		public ManageStudents()
		{
			InitializeComponent();
			controllerObj = new Controller();
			DataTable dt = controllerObj.SelectDepName();
			DataTable dt2 = controllerObj.StudentTable();
			studentlist.DataSource = dt2;
			studentlist.Refresh();
			depidcombobox.DataSource = dt;
			depidcombobox.DisplayMember = "DepartmentName";
			depidcombobox.Refresh();
			DataTable dt3 = controllerObj.SelectSID();
			studentidcombobox.DisplayMember = "StudentID";
			studentidcombobox.DataSource = dt3;
			studentidcombobox.Refresh();
			studentlist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		}

		private void returnbutton_Click(object sender, EventArgs e)
		{
			this.Hide();
			Dashboard d1 = new Dashboard();
			d1.Show();
		}

		private void studentlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			fnametextbox.Text = studentlist.SelectedRows[0].Cells[0].Value.ToString().Trim();
			minittextbox.Text = studentlist.SelectedRows[0].Cells[1].Value.ToString().Trim();
			lnametextbox.Text = studentlist.SelectedRows[0].Cells[2].Value.ToString().Trim();
			idtextbox.Text = studentlist.SelectedRows[0].Cells[3].Value.ToString().Trim();
			if (studentlist.SelectedRows[0].Cells[4].Value.ToString() == "M")
				maleradiobutton.Checked = true;
			else if (studentlist.SelectedRows[0].Cells[4].Value.ToString() == "F")
				femaleradiobutton.Checked = true;
			dobstudent.Text = studentlist.SelectedRows[0].Cells[5].Value.ToString().Trim();
			phonetextbox.Text = studentlist.SelectedRows[0].Cells[6].Value.ToString().Trim();
			depidcombobox.Text = studentlist.SelectedRows[0].Cells[7].Value.ToString().Trim();
			classcombobox.Text = studentlist.SelectedRows[0].Cells[8].Value.ToString().Trim();
		}

		private void Student_Load(object sender, EventArgs e)
		{
			studentlist.EnableHeadersVisualStyles = false;
			studentlist.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			studentlist.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
			studentlist.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9, FontStyle.Bold);
			for (int i = 0; i < studentlist.Columns.Count; i++)
			{
				studentlist.Columns[i].DefaultCellStyle.Font = new Font("Century Gothic", 7, FontStyle.Bold);
			}
			fnametextbox.Select();
		}

		private void clearbutton_Click(object sender, EventArgs e)
		{
			fnametextbox.Clear();
			minittextbox.Clear();
			lnametextbox.Clear();
			idtextbox.Clear();
			maleradiobutton.Checked = false;
			femaleradiobutton.Checked = false;
			phonetextbox.Clear();
			depidcombobox.Text = null;
			classcombobox.Text = null;
			fnametextbox.Select();
			dobstudent.Value = System.DateTime.Now;
		}

		private void updatebutton_Click(object sender, EventArgs e)
		{
			if (fnametextbox.Text == "" || lnametextbox.Text == "" || minittextbox.Text == "" || idtextbox.Text == "" ||
			phonetextbox.Text == "" || classcombobox.Text == "" ||
			depidcombobox.SelectedItem == null || (!(maleradiobutton.Checked) && !(femaleradiobutton.Checked)))
			{
				MessageBox.Show("Please Enter the data correctly!", "Missing data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			DataTable d = controllerObj.SelectDepID(depidcombobox.Text);
				string id = d.Rows[0]["DepartmentID"].ToString();
				string select = null;
				if (maleradiobutton.Checked)
					select = "M";
				else if (femaleradiobutton.Checked)
					select = "F";
				int result = controllerObj.UpdateStudent(fnametextbox.Text, char.Parse(minittextbox.Text), lnametextbox.Text,
					select, dobstudent.Value, phonetextbox.Text, Int32.Parse(id), classcombobox.Text, Int32.Parse(idtextbox.Text));
				DataTable dt = controllerObj.StudentTable();
				studentlist.DataSource = dt;
				studentlist.Refresh();
				if (result == 0)
				{
					MessageBox.Show("Failed to update student");
				}
				else
				{
					MessageBox.Show("The student is updated successfully!");
				}
		}

		private void searchbutton_Click(object sender, EventArgs e)
		{
			DataTable dt;
			if (studentidcombobox.Text == "")
			{
				dt = controllerObj.StudentTable();
				studentlist.DataSource = dt;
				studentlist.Refresh(); ;
			}
			else
			{
				dt = controllerObj.SelectStudentswithID(Int32.Parse(studentidcombobox.Text));
				studentlist.DataSource = dt;
				studentlist.Refresh();
			}
		}

		private void deletebutton_Click(object sender, EventArgs e)
		{
			if (fnametextbox.Text == "" || lnametextbox.Text == "" || minittextbox.Text == "" || idtextbox.Text == "" ||
			phonetextbox.Text == "" || classcombobox.Text == "" ||
			depidcombobox.SelectedItem == null || (!(maleradiobutton.Checked) && !(femaleradiobutton.Checked)))
			{
				MessageBox.Show("Please Enter the data correctly!", "Missing data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			DialogResult answer = MessageBox.Show("Are you sure you want to delete this row", "Delete row", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (answer == DialogResult.Yes)
			{
				int result = controllerObj.DeleteStudent(Int32.Parse(idtextbox.Text));
				DataTable dt = controllerObj.StudentTable();
				studentlist.DataSource = dt;
				studentlist.Refresh();
				if (result == 0)
				{
					MessageBox.Show("Cannot delete student");
				}
				else
				{
					MessageBox.Show("The student is deleted successfully!");
				}
			}
			DataTable dt3 = controllerObj.SelectSID();
			studentidcombobox.DisplayMember = "StudentID";
			studentidcombobox.DataSource = dt3;
			studentidcombobox.Refresh();
		}

		private void fnametextbox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
			{
				e.Handled = true; // Do not write the key pressed in the text box 
				MessageBox.Show("No any numbers or special characters are allowed in this field", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void minittextbox_KeyDown(object sender, KeyEventArgs e)
		{

		}

		private void minittextbox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
			{
				e.Handled = true; // Do not write the key pressed in the text box 
				MessageBox.Show("No any numbers or special characters are allowed in this field", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void lnametextbox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
			{
				e.Handled = true; // Do not write the key pressed in the text box 
				MessageBox.Show("No any numbers or special characters are allowed in this field", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void idtextbox_TextChanged(object sender, EventArgs e)
		{

		}

		private void idtextbox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true; // Do not write the key pressed in the text box 
				MessageBox.Show("No any letters or special characters are allowed in the this field", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void phonetextbox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true; // Do not write the key pressed in the text box 
				MessageBox.Show("No any letters or special characters are allowed in the this field", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
