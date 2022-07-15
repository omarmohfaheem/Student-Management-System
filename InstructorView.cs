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
	public partial class InstructorView : Form
	{
		int InstructorID;
		Controller controllerObj;
		public InstructorView(int ID)
		{
			InitializeComponent();
			controllerObj = new Controller();
			InstructorID = ID;
			DataTable dt2 = controllerObj.Welcome(ID);
			string name = dt2.Rows[0]["FirstName"].ToString();
			InstructorName.Text = name;
		}
		public InstructorView()
		{
			InitializeComponent();
		}

		private void logoutbutton_Click(object sender, EventArgs e)
		{
			Login l1 = new Login();
			l1.Show();
			this.Hide();
		}

		private void timetable_Click(object sender, EventArgs e)
		{
			TimeTable t = new TimeTable(InstructorID);
			t.Show();
			this.Hide();
		}

		private void attendance_Click(object sender, EventArgs e)
		{
			Attedance a = new Attedance(InstructorID);
			a.Show();
			this.Hide();
		}

		private void editprofile_Click(object sender, EventArgs e)
		{
			Edit e1 = new Edit(InstructorID);
			e1.Show();
			this.Hide();
		}
	}
}
