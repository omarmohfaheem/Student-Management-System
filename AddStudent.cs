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
	public partial class AddStudent : Form
	{
		Controller controllerObj;
		public AddStudent()
		{
			InitializeComponent();
			controllerObj = new Controller();
			DataTable dt = controllerObj.SelectDepName();
			depnamecombobox.DisplayMember = "DepartmentName";
			depnamecombobox.DataSource = dt;
		}

		private void savebutton_Click(object sender, EventArgs e)
		{
			// Missing Data

			if (fnametextbox.Text == "" || lnametextbox.Text == "" || minittextbox.Text == "" || idtextbox.Text == "" ||
				phonetextbox.Text == "" || classcombobox.Text == "" ||
				depnamecombobox.SelectedItem == null || (!(maleradiobutton.Checked) && !(femaleradiobutton.Checked)))
			{
				MessageBox.Show("Please Enter the data correctly!", "Missing data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			DataTable d = controllerObj.SelectDepID(depnamecombobox.Text);
			string id = d.Rows[0]["DepartmentID"].ToString();
			//code
			string select = null;
			if (maleradiobutton.Checked)
				select = "M";
			else if (femaleradiobutton.Checked)
				select = "F";
			///////////////////////////////////////////
			StringBuilder err = new StringBuilder("");
			DataTable dt1 = controllerObj.StudentTable();
			Object data = Validation.StuIDExists(idtextbox.Text.ToString(), dt1, err);
			if (data == null)
			{
				MessageBox.Show(err.ToString());
				MessageBox.Show("Failed to save student!", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				int result = controllerObj.InsertStudent(fnametextbox.Text, char.Parse(minittextbox.Text), lnametextbox.Text,
				Int32.Parse(idtextbox.Text), select, dobstudent.Value, phonetextbox.Text, Int32.Parse(id), classcombobox.Text);
				if (result == 0)
					MessageBox.Show("Failed to save student!", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
					MessageBox.Show("The student is saved successfully!", "Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
				string[] row = new string[] {fnametextbox.Text,minittextbox.Text,lnametextbox.Text,idtextbox.Text,"",dobstudent.Text,
				phonetextbox.Text,depnamecombobox.Text,classcombobox.Text};
				if (maleradiobutton.Checked)
					row[4] = maleradiobutton.Text;
				if (femaleradiobutton.Checked)
					row[4] = femaleradiobutton.Text;
				newstds.Rows.Add(row);
			}
		}

		private void returnbutton_Click(object sender, EventArgs e)
		{
			this.Hide();
			Dashboard d1 = new Dashboard();
			d1.Show();
		}

		private void AddStudent_Load(object sender, EventArgs e)
		{
			newstds.EnableHeadersVisualStyles = false;
			newstds.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			newstds.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
			newstds.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9, FontStyle.Bold);
			for (int i = 0; i < newstds.Columns.Count; i++)
			{
				newstds.Columns[i].DefaultCellStyle.Font = new Font("Century Gothic", 7, FontStyle.Bold);
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
			depnamecombobox.Text = null;
			classcombobox.Text = null;
			dobstudent.Value = System.DateTime.Now;
			fnametextbox.Select();
		}

		private void fnametextbox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
			{
				e.Handled = true; // Do not write the key pressed in the text box 
				MessageBox.Show("No any numbers or special characters are allowed in this field", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

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
