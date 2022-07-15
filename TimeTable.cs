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
	public partial class TimeTable : Form
	{
		int instID;
		Controller controllerObj;
		public TimeTable(int instructorID)
		{
			InitializeComponent();
			controllerObj = new Controller();
			instID = instructorID;
		}

		private void returnbutton_Click(object sender, EventArgs e)
		{
			this.Hide();
			InstructorView d1 = new InstructorView(instID);
			d1.Show();
		}

		private void TimeTable_Load(object sender, EventArgs e)
		{
            DataTable dt = controllerObj.getTimeTable(instID);
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string day = dt.Rows[i]["Day"].ToString().Trim();
                    string startHour = dt.Rows[i]["STARTHOUR"].ToString();
                    string CourseID = dt.Rows[i]["CourseID"].ToString();
                    string BuildingID = dt.Rows[i]["BuildingID"].ToString();
                    string LevelNumber = dt.Rows[i]["LevelNumber"].ToString();
                    string RoomNumber = dt.Rows[i]["RoomNumber"].ToString();
                    int CouID = int.Parse(CourseID);

                    if (day == "Sunday")
                    {
                        if (startHour == "08:00:00")
                        {
                            X11.Show();
                            Y11.Show();
                            X11.Text = CourseID;
                            Y11.Text = BuildingID + LevelNumber + RoomNumber;
                        }

                        if (startHour == "11:00:00")
                        {
                            X21.Show();
                            Y21.Show();
                            X21.Text = CourseID;
                            Y21.Text = BuildingID + LevelNumber + RoomNumber;
                        }

                        if (startHour == "01:00:00")
                        {
                            X31.Show();
                            Y31.Show();
                            X31.Text = CourseID;
                            Y31.Text = BuildingID + LevelNumber + RoomNumber;
                        }

                        if (startHour == "03:00:00")
                        {
                            X41.Show();
                            Y41.Show();
                            X41.Text = CourseID;
                            Y41.Text = BuildingID + LevelNumber + RoomNumber;
                        }


                        if (startHour == "05:00:00")
                        {
                            X51.Show();
                            Y51.Show();
                            X51.Text = CourseID;
                            Y51.Text = BuildingID + LevelNumber + RoomNumber;
                        }

                    }


                    else if (day == "Monday")
                    {
                        if (startHour == "08:00:00")
                        {
                            X12.Show();
                            Y12.Show();
                            X12.Text = CourseID;
                            Y12.Text = BuildingID + LevelNumber + RoomNumber;
                        }


                        if (startHour == "11:00:00")
                        {
                            X22.Show();
                            Y22.Show();
                            X22.Text = CourseID;
                            Y22.Text = BuildingID + LevelNumber + RoomNumber;
                        }


                        if (startHour == "01:00:00")
                        {
                            X32.Show();
                            Y32.Show();
                            X32.Text = CourseID;
                            Y32.Text = BuildingID + LevelNumber + RoomNumber;
                        }


                        if (startHour == "03:00:00")
                        {
                            X42.Show();
                            Y42.Show();
                            X42.Text = CourseID;
                            Y42.Text = BuildingID + LevelNumber + RoomNumber;
                        }


                        if (startHour == "05:00:00")
                        {
                            X52.Show();
                            Y52.Show();
                            X52.Text = CourseID;
                            Y52.Text = BuildingID + LevelNumber + RoomNumber;
                        }
                    }




                    else if (day == "Tuesday")
                    {
                        if (startHour == "08:00:00")
                        {
                            X13.Show();
                            Y13.Show();
                            X13.Text = CourseID;
                            Y11.Text = BuildingID + LevelNumber + RoomNumber;
                        }

                        if (startHour == "11:00:00")
                        {
                            X23.Show();
                            Y23.Show();
                            X23.Text = CourseID;
                            Y23.Text = BuildingID + LevelNumber + RoomNumber;
                        }


                        if (startHour == "01:00:00")
                        {
                            X33.Show();
                            Y33.Show();
                            X33.Text = CourseID;
                            Y33.Text = BuildingID + LevelNumber + RoomNumber;
                        }


                        if (startHour == "03:00:00")
                        {
                            X43.Show();
                            Y43.Show();
                            X43.Text = CourseID;
                            Y43.Text = BuildingID + LevelNumber + RoomNumber;
                        }


                        if (startHour == "05:00:00")
                        {
                            X53.Show();
                            Y53.Show();
                            X53.Text = CourseID;
                            Y53.Text = BuildingID + LevelNumber + RoomNumber;
                        }
                    }


                    else if (day == "Thuresday")
                    {
                        if (startHour == "08:00:00")
                        {
                            X15.Show();
                            Y15.Show();
                            X15.Text = CourseID;
                            Y15.Text = BuildingID + LevelNumber + RoomNumber;
                        }

                        if (startHour == "11:00:00")
                        {
                            X25.Show();
                            Y25.Show();
                            X25.Text = CourseID;
                            Y25.Text = BuildingID + LevelNumber + RoomNumber;
                        }


                        if (startHour == "01:00:00")
                        {
                            X35.Show();
                            Y35.Show();
                            X35.Text = CourseID;
                            Y35.Text = BuildingID + LevelNumber + RoomNumber;
                        }


                        if (startHour == "03:00:00")
                        {
                            X45.Show();
                            Y45.Show();
                            X45.Text = CourseID;
                            Y45.Text = BuildingID + LevelNumber + RoomNumber;
                        }


                        if (startHour == "05:00:00")
                        {
                            X55.Show();
                            Y55.Show();
                            X55.Text = CourseID;
                            Y55.Text = BuildingID + LevelNumber + RoomNumber;
                        }
                    }

                    else if (day == "Wednesday")
                    {
                        if (startHour == "08:00:00")
                        {
                            X14.Show();
                            Y14.Show();
                            X14.Text = CourseID;
                            Y14.Text = BuildingID + LevelNumber + RoomNumber;
                        }

                        if (startHour == "11:00:00")
                        {
                            X24.Show();
                            Y24.Show();
                            X24.Text = CourseID;
                            Y24.Text = BuildingID + LevelNumber + RoomNumber;
                        }


                        if (startHour == "01:00:00")
                        {
                            X34.Show();
                            Y34.Show();
                            X34.Text = CourseID;
                            Y34.Text = BuildingID + LevelNumber + RoomNumber;
                        }


                        if (startHour == "03:00:00")
                        {
                            X44.Show();
                            Y44.Show();
                            X44.Text = CourseID;
                            Y44.Text = BuildingID + LevelNumber + RoomNumber;
                        }


                        if (startHour == "05:00:00")
                        {
                            X54.Show();
                            Y54.Show();
                            X54.Text = CourseID;
                            Y54.Text = BuildingID + LevelNumber + RoomNumber;
                        }
                    }

                }



            }
 
    }
	}
}
