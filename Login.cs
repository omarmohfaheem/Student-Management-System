using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Student_Management_System_Project
{
	public partial class Login : Form
	{
		int id; // for saving the ID of the instructor
		Controller controllerObj;
		public Login()
		{
			InitializeComponent();
			controllerObj = new Controller();
			id = 0;
		}

		private void loginbutton_Click(object sender, EventArgs e)
		{
			//Validation
			if (usernametextbox.Text == "" || passwordtextbox.Text == "")
			{
				MessageBox.Show("Please fill all fields!", "Missing data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			
			/////////////
			//
			DataTable dt = controllerObj.CheckUser(usernametextbox.Text, passwordtextbox.Text);
			if (dt!=null)
			{
				Dashboard d1 = new Dashboard();
				if (dt.Rows[0]["type"].ToString()=="Admin")
				{
					
					d1.Show();
					this.Hide();
				}
				else
				{
					DataTable dt2 = controllerObj.GetHisID(usernametextbox.Text);
					id = int.Parse(dt2.Rows[0]["InstructorID"].ToString());
					InstructorView u1 = new InstructorView(id);
					u1.Show();
					this.Hide();
				}
			}
			else
			{
				MessageBox.Show("Wrong username or password!", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			}
		}



		private void clearbutton_Click(object sender, EventArgs e)
		{
			usernametextbox.Clear();
			passwordtextbox.Clear();
			usernametextbox.Select();
		}

		private void checkboxshow_CheckedChanged(object sender, EventArgs e)
		{
			if (checkboxshow.Checked)
				passwordtextbox.PasswordChar = '\0';
			else
				passwordtextbox.PasswordChar = '●';
		}

		private void exitbutton_Click(object sender, EventArgs e)
		{
			Application.Exit();
			controllerObj.TerminateConnection();
		}

		private void signupbutton_Click(object sender, EventArgs e)
		{
			SignUp s1 = new SignUp();
			s1.Show();
			this.Hide();
		}

		private void Login_Load(object sender, EventArgs e)
		{
			usernametextbox.Select();
		}
	}
}

