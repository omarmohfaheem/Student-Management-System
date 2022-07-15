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
	public partial class Instructor : Form
	{
		Controller controllerObj;
		public Instructor()
		{
			InitializeComponent();
			controllerObj = new Controller();
			instructorlist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		}

		private void instructorlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			fnametextbox.Text = instructorlist.SelectedRows[0].Cells[0].Value.ToString().Trim();
			minittextbox.Text = instructorlist.SelectedRows[0].Cells[1].Value.ToString().Trim();
			lnametextbox.Text = instructorlist.SelectedRows[0].Cells[2].Value.ToString().Trim();
			idtextbox.Text = instructorlist.SelectedRows[0].Cells[3].Value.ToString().Trim();
			//usernametextbox.Text = instructorlist.SelectedRows[0].Cells[4].Value.ToString().Trim();
			if (instructorlist.SelectedRows[0].Cells[4].Value.ToString() == "M")
				maleradiobutton.Checked = true;
			else if (instructorlist.SelectedRows[0].Cells[4].Value.ToString() == "F")
				femaleradiobutton.Checked = true;
			salarytextbox.Text = instructorlist.SelectedRows[0].Cells[5].Value.ToString().Trim();
		}

		private void Instructor_Load(object sender, EventArgs e)
		{
			instructorlist.EnableHeadersVisualStyles = false;
			instructorlist.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			instructorlist.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
			instructorlist.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold);
			fnametextbox.Select();
		}

		private void returnbutton_Click(object sender, EventArgs e)
		{
			this.Hide();
			Dashboard d1 = new Dashboard();
			d1.Show();
		}

		private void clearbutton_Click(object sender, EventArgs e)
		{
			fnametextbox.Clear();
			minittextbox.Clear();
			lnametextbox.Clear();
			idtextbox.Clear();
			maleradiobutton.Checked = false;
			femaleradiobutton.Checked = false;
			salarytextbox.Clear();
			usernametextbox.Clear();
			fnametextbox.Select();
		}

		private void savebutton_Click(object sender, EventArgs e)
		{
			string select = null;
			if (maleradiobutton.Checked)
				select = "M";
			else if (femaleradiobutton.Checked)
				select = "F";
			///////////////////////////////////////////
			StringBuilder err = new StringBuilder("");
			DataTable dt1 = controllerObj.InstructorTable();
			Object data = Validation.InstIDExists(idtextbox.Text.ToString(), dt1, err);
			if (data == null)
			{
				MessageBox.Show(err.ToString());
				MessageBox.Show("Failed to save Instructor!", "Instructor", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				int result2 = controllerObj.InsertUser(usernametextbox.Text);
				if (result2 == 0) { MessageBox.Show("Failed to save Instructor!", "Instructor", MessageBoxButtons.OK, MessageBoxIcon.Error); }
				else
				{
					int result = controllerObj.InsertInstructor(Int32.Parse(idtextbox.Text), fnametextbox.Text, char.Parse(minittextbox.Text), lnametextbox.Text, select, Int32.Parse(salarytextbox.Text), usernametextbox.Text);

					if (result == 0)
						MessageBox.Show("Failed to save Instructor!", "Instructor", MessageBoxButtons.OK, MessageBoxIcon.Error);
					else
					{
						MessageBox.Show("The instructor is saved successfully!", "Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
						string[] row = new string[] { fnametextbox.Text, minittextbox.Text, lnametextbox.Text, idtextbox.Text, usernametextbox.Text, "", salarytextbox.Text };
						if (maleradiobutton.Checked)
							row[5] = "M";
						if (femaleradiobutton.Checked)
							row[5] = "F";
						instructorlist.Rows.Add(row);
					}
				}
			}
			
		}
	}
}
