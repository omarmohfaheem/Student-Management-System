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
	public partial class NewUser : Form
	{
		Controller controllerObj;
		public NewUser()
		{
			InitializeComponent();
			controllerObj = new Controller();
		}

		private void returnbutton_Click(object sender, EventArgs e)
		{
			this.Hide();
			Dashboard d1 = new Dashboard();
			d1.Show();
		}

		private void addnewuserbutton_Click(object sender, EventArgs e)
		{
			//Validation
			if (usernametextbox.Text == "" || passwordtextbox.Text == "")
			{
				MessageBox.Show("Please fill all fields!", "Missing data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			StringBuilder err = new StringBuilder("");
			DataTable dt1 = controllerObj.UserType();
			Object data = Validation.UsernameExists(usernametextbox.Text.ToString(), dt1, err);
			if (data == null)
			{
				MessageBox.Show(err.ToString());
				MessageBox.Show("Failed to Add New Admin!", "Add New User", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				int result = controllerObj.AddNewUser(usernametextbox.Text, passwordtextbox.Text);
				if (result == 0)
				{
					MessageBox.Show("Cannot create a user!", "Creation failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					MessageBox.Show("User created successfully!");
					usernametextbox.Clear();
					passwordtextbox.Clear();
				}
			}

		}

		private void returnbutton_Click_1(object sender, EventArgs e)
		{
			this.Hide();
			Dashboard d1 = new Dashboard();
			d1.Show();
		}


			private void checkboxshow_CheckedChanged(object sender, EventArgs e)
			{
				if (checkboxshow.Checked)
					passwordtextbox.PasswordChar = '\0';
				else
					passwordtextbox.PasswordChar = '●';
			}
	}
}
