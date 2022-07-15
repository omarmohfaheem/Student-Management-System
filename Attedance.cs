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
	public partial class Attedance : Form
	{
        int reset = 0; // to reset the checkList
        int instID;
		Controller controllerObj;
		public Attedance(int ID)
		{
			InitializeComponent();
			controllerObj = new Controller();
            instID = ID;
            DataTable dt2 = controllerObj.Welcome(ID);
            string name = dt2.Rows[0]["FirstName"].ToString();
            label1.Text = name;
        }

		private void returnbutton_Click(object sender, EventArgs e)
		{
			this.Hide();
			InstructorView d1 = new InstructorView(instID);
			d1.Show();
		}

		private void showlist_Click(object sender, EventArgs e)
		{
            checkedListBox1.Items.Clear();
            int result = 0;
            bool Parsed = int.TryParse(CourseID.Text, out result);
            if (Parsed)
            {
                if (int.Parse(CourseID.Text) >= 0)
                {
                    DataTable dt = controllerObj.SELECTSTUDENTLIST(instID, int.Parse(CourseID.Text));
                    if (dt != null)
                    {
                        reset = dt.Rows.Count;
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            string text = dt.Rows[i]["FName"].ToString();
                            string text2 = dt.Rows[i]["StudentID"].ToString();
                            checkedListBox1.Items.Add(text + text2, false);
                        }
                    }
                    else
                    {

                        MessageBox.Show("Sorry this is not your course!");
                        checkedListBox1.Items.Clear();
                    }
                }
                else MessageBox.Show("Please enter a positive integer!");
            }
            else MessageBox.Show("Please enter a Course!");
        }

		private void sumbit_Click(object sender, EventArgs e)
		{
            bool Exist = false;
            DataTable dt = controllerObj.SELECTSTUDENTLIST(instID, int.Parse(CourseID.Text));
            DataTable dt2 = controllerObj.SelectAttendance();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                bool check = checkedListBox1.GetItemChecked(i);

                if (check)
                {
                    if (dt2 != null)
                    {
                        for (int j = 0; j < dt2.Rows.Count; j++)
                        {
                            if (int.Parse(dt2.Rows[j]["StudentID"].ToString()) == int.Parse(dt2.Rows[i]["StudentID"].ToString()) && int.Parse(dt2.Rows[j]["CourseID"].ToString()) == int.Parse(CourseID.Text) && int.Parse(Week.Text) == int.Parse(dt2.Rows[j]["Week"].ToString()))
                            {
                                Exist = true;
                            }

                        }
                        if (!Exist)
                        {
                            controllerObj.AddAttendnace(dt.Rows[i]["StudentID"].ToString(), int.Parse(CourseID.Text), 'N', int.Parse(Week.Text));
                            MessageBox.Show("successfully inserted");
                        }
                        else
                            MessageBox.Show("This attendance record already exits!");
                    }
                    else
                    {
                        controllerObj.AddAttendnace(dt.Rows[i]["StudentID"].ToString(), int.Parse(CourseID.Text), 'N', int.Parse(Week.Text));
                        MessageBox.Show("successfully inserted");
                    }
                }

            }
        }
	}
}
