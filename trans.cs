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
	public partial class trans : Form
	{
		Controller controllerObj;
		public trans()
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

		private void Drop_Click(object sender, EventArgs e)
		{
			bool exist = false;
			DataTable dt4 = controllerObj.SELECTSTUDENTLIST2();
			int num;

			bool check = int.TryParse(StudentID.Text, out num);
			if (check)
			{
				if (dt4 != null)
				{
					for (int i = 0; i < dt4.Rows.Count; i++)
					{
						if (StudentID.Text == dt4.Rows[i]["StudentID"].ToString().Trim())
						{
							exist = true;
							break;

						}
					}
				}
				if (exist)
				{
					DataTable Dt5 = controllerObj.SelectTranscript(int.Parse(StudentID.Text));
					TranscriptDataTable.DataSource = Dt5;
					TranscriptDataTable.Refresh();


				}
				else MessageBox.Show("Student doesn't exist, enter valid ID");
			}
			else MessageBox.Show("please enter only numbers!");
		}
	}
}
