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
	
	public partial class Dashboard : Form
	{
		public Dashboard()
		{
			InitializeComponent();
			Design();
		}
		private void Design()
		{
			Stusubmenu.Visible = false;
			Coursesubmenu.Visible = false;
			instructorsubmenu.Visible = false;
			profile.Visible = false;
		}
		private void ShowSubMenu(Panel submenu)
		{
			if (submenu.Visible == false)
			{
				HideSubMenu();
				submenu.Visible = true;
			}
			else
				submenu.Visible = false;
		}
		private void HideSubMenu()
		{
			if (Stusubmenu.Visible == true)
				Stusubmenu.Visible = false;
			if (Coursesubmenu.Visible == true)
				Coursesubmenu.Visible = false;
			if (instructorsubmenu.Visible == true)
				instructorsubmenu.Visible = false;
			if (profile.Visible == true)
				profile.Visible = false;

		}
		private void logoutbutton_Click(object sender, EventArgs e)
		{
			Login l1 = new Login();
			l1.Show();
			this.Hide();
		}
		private void Students_Click(object sender, EventArgs e)
		{
			ShowSubMenu(Stusubmenu);
		}

		private void addstudentbtn_Click(object sender, EventArgs e)
		{
			AddStudent a = new AddStudent();
			a.Show();
			this.Hide();
		}

		private void managestudentbtn_Click(object sender, EventArgs e)
		{
			ManageStudents m = new ManageStudents();
			m.Show();
			this.Hide();
		}
		private void registercoursebtn_Click(object sender, EventArgs e)
		{
			RegisterCourse r = new RegisterCourse();
			r.Show();
			this.Hide();
		}
		private void registeractivitybtn_Click(object sender, EventArgs e)
		{
			ManageActivity m = new ManageActivity();
			m.Show();
			this.Hide();
		}

		private void Courses_Click(object sender, EventArgs e)
		{
			ShowSubMenu(Coursesubmenu);
		}

		private void Instructors_Click(object sender, EventArgs e)
		{
			ShowSubMenu(instructorsubmenu);
		}

		private void Departments_Click(object sender, EventArgs e)
		{
			Department d1 = new Department();
			d1.Show();
			this.Hide();
		}

		private void addcoursebtn_Click(object sender, EventArgs e)
		{
			Course c1 = new Course();
			c1.Show();
			this.Hide();
		}

		private void Dashboard_Load(object sender, EventArgs e)
		{

		}

		private void managecourse_Click(object sender, EventArgs e)
		{
			ManageStuCourses m = new ManageStuCourses();
			m.Show();
			this.Hide();
		}

		private void managecoursesbtn_Click(object sender, EventArgs e)
		{
			Manage_Courses m = new Manage_Courses();
			m.Show();
			this.Hide();
		}

		private void addinstructorbutton_Click(object sender, EventArgs e)
		{
			Instructor i = new Instructor();
			i.Show();
			this.Hide();
		}

		private void manageinstructorsbtn_Click(object sender, EventArgs e)
		{
			ManageInstructor i = new ManageInstructor();
			i.Show();
			this.Hide();
		}

		private void exitbutton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void settings_Click(object sender, EventArgs e)
		{
			ShowSubMenu(profile);
		}

		private void Fees_Click(object sender, EventArgs e)
		{
			Fees f = new Fees();
			f.Show();
			this.Hide();
		}

		private void Grades_Click(object sender, EventArgs e)
		{
			Grades g = new Grades();
			g.Show();
			this.Hide();
		}

		private void BuldingRoom_Click(object sender, EventArgs e)
		{
			Building_Room b = new Building_Room();
			b.Show();
			this.Hide();
		}

		private void ActivityEvent_Click(object sender, EventArgs e)
		{
			Activity_Event a = new Activity_Event();
			a.Show();
			this.Hide();
		}

		private void addnewuser_Click(object sender, EventArgs e)
		{
			NewUser N = new NewUser();
			N.Show();
			this.Hide();
		}

		private void editprofile_Click(object sender, EventArgs e)
		{
			Profile p = new Profile();
			p.Show();
			this.Hide();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			trans p = new trans();
			p.Show();
			this.Hide();
		}
	}
	}

