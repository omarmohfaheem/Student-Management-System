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
	public partial class Profile : Form
	{
		Controller controllerObj;
	
		public Profile()
		{
			InitializeComponent();
			controllerObj = new Controller();
		}

		private void checkboxshow_CheckedChanged(object sender, EventArgs e)
		{
			if (checkboxshow.Checked)
				passwordtextbox.PasswordChar = '\0';
			else
				passwordtextbox.PasswordChar = '●';
		}

		private void newpasscheckbox_CheckedChanged(object sender, EventArgs e)
		{
			if (newpasscheckbox.Checked)
				newpasswordtextbox.PasswordChar = '\0';
			else
				newpasswordtextbox.PasswordChar = '●';
		}

		private void addnewuserbutton_Click(object sender, EventArgs e)
		{
			int result = controllerObj.UpdatePassword(usernametextbox.Text, passwordtextbox.Text,newpasswordtextbox.Text);
			if (result == 0)
			{
				MessageBox.Show("Wrong username or password");
			}
			else
			{
				MessageBox.Show("Password changed successfully!");
				usernametextbox.Clear();
				passwordtextbox.Clear();
				newpasswordtextbox.Clear();
			}
		
		}

		private void returnbutton_Click(object sender, EventArgs e)
		{
			this.Hide();
			Dashboard d1 = new Dashboard();
			d1.Show();
		}
	}
}
