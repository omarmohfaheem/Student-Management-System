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
	public partial class Department : Form
	{
		Controller controllerObj;
		public Department()
		{
			InitializeComponent();
			controllerObj = new Controller();
			DataTable dt = controllerObj.SelectInstID();
			instidcombobox.DataSource = dt;
			instidcombobox.DisplayMember = "InstructorID";
			instidcombobox.Refresh();
			departmentlist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			DataTable dt2 = controllerObj.Departments();
			departmentlist.DataSource = dt2;
			departmentlist.Refresh();
		}

		private void returnbutton_Click(object sender, EventArgs e)
		{
			this.Hide();
			Dashboard d1 = new Dashboard();
			d1.Show();
		}

		private void Department_Load(object sender, EventArgs e)
		{
			departmentlist.EnableHeadersVisualStyles = false;
			departmentlist.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			departmentlist.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
			departmentlist.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold);
		
		}

		private void clearbutton_Click(object sender, EventArgs e)
		{
			depnametextbox.Clear();
			deptidtextbox.Clear();
			instidcombobox.SelectedItem = null;
		}

		private void departmentlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			depnametextbox.Text = departmentlist.SelectedRows[0].Cells[0].Value.ToString().Trim();
			deptidtextbox.Text = departmentlist.SelectedRows[0].Cells[1].Value.ToString().Trim();
			instidcombobox.Text = departmentlist.SelectedRows[0].Cells[2].Value.ToString().Trim();
		}

		private void savebutton_Click(object sender, EventArgs e)
		{
			int result = controllerObj.InsertDepartment(depnametextbox.Text, Int32.Parse(deptidtextbox.Text), Int32.Parse(instidcombobox.Text));
			if (result == 0)
			{
				MessageBox.Show("No departments are added");
			}
			else
			{
				MessageBox.Show("The department is added successfully!");
				DataTable dt = controllerObj.SelectDepartment();
				departmentlist.DataSource = dt;
				departmentlist.Refresh();
			}
		}

		private void updatebutton_Click(object sender, EventArgs e)
		{
			int result = controllerObj.UpdateDepartment(depnametextbox.Text, Int32.Parse(deptidtextbox.Text), Int32.Parse(instidcombobox.Text));
			if (result == 0)
			{
				MessageBox.Show("No departments are updated");
			}
			else
			{
				MessageBox.Show("The department is updated successfully!");
				DataTable dt = controllerObj.SelectDepartment();
				departmentlist.DataSource = dt;
				departmentlist.Refresh();
			}
			
		}

		private void deletebutton_Click(object sender, EventArgs e)
		{
			DialogResult answer = MessageBox.Show("Are you sure you want to delete instructor", "Instructor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (answer == DialogResult.Yes)
			{
				int result = controllerObj.DeleteDepartment(Int32.Parse(deptidtextbox.Text));
				if (result == 0)
				{
					MessageBox.Show("No departments are deleted");
				}
				else
				{
					MessageBox.Show("The department is deleted successfully!");
					DataTable dt = controllerObj.SelectDepartment();
					departmentlist.DataSource = dt;
					departmentlist.Refresh();
				}
			}
		}
	}
}
