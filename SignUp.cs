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
	public partial class SignUp : Form
	{
		Controller controllerObj;
		public SignUp()
		{
			InitializeComponent();
			controllerObj = new Controller();
		}

		private void exitbutton_Click(object sender, EventArgs e)
		{
			Login l1 = new Login();
			l1.Show();
			this.Hide();
		}

		private void checkboxshow_CheckedChanged(object sender, EventArgs e)
		{
			if (checkboxshow.Checked)
				passwordtextbox.PasswordChar = '\0';
			else
				passwordtextbox.PasswordChar = '●';
		}

		private void signupbutton_Click(object sender, EventArgs e)
		{
			//Validation
			if (usernametextbox.Text == "" || passwordtextbox.Text == "")
			{
				MessageBox.Show("Please fill all fields!", "Missing data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			int result = controllerObj.CreateNewUser(usernametextbox.Text,passwordtextbox.Text);
			if (result == 0)
			{
				MessageBox.Show("Cannot create a user!", "Creation failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				MessageBox.Show("User created successfully!");
			}
		}
	}
}
