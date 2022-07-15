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
	public partial class Edit : Form
	{
		int instID;
		Controller controllerObj;
		public Edit(int ID)
		{
			InitializeComponent();
			controllerObj = new Controller();
			instID = ID;
		}

		private void returnbutton_Click(object sender, EventArgs e)
		{
			this.Hide();
			InstructorView d1 = new InstructorView(instID);
			d1.Show();
		}

		private void Drop_Click(object sender, EventArgs e)
		{
			{
				bool check = false;
				string name = "test";
				DataTable dt = controllerObj.GetUserName(instID);
				if (dt != null)
				{
					name = dt.Rows[0]["username"].ToString();
				}
				DataTable dt4 = controllerObj.UpdatingUserNameCheck();
				if (dt4 != null)
				{
					for (int i = 0; i < dt4.Rows.Count; i++)
					{
						if (usernametextbox.Text == dt4.Rows[i]["username"].ToString().Trim())
						{
							check = true;
							break;
						}
					}
				}
				if (!check)
				{
					int result = controllerObj.UpdateInst(name, passwordtextbox.Text, usernametextbox.Text);
					if (result == 0)
					{
						MessageBox.Show("Update failed");
					}
					else
					{
						MessageBox.Show("Username and password updated successfully!");
					}

				}
				else
					MessageBox.Show("Username already exists!");

			}
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
