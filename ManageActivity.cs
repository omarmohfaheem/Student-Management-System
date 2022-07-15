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
	public partial class ManageActivity : Form
	{
		Controller controllerObj;
		public ManageActivity()
		{
			InitializeComponent();
			controllerObj = new Controller();
			DataTable c1 = controllerObj.SelectSID();
			stuidcombbox.DataSource = c1;
			stuidcombbox.DisplayMember = "StudentID";
			DataTable c2 = controllerObj.SelectActivity();
			activitytypecombbox.DataSource = c2;
			activitytypecombbox.DisplayMember = "ActivityType";
			DataTable dt = controllerObj.SelectStudentActivity();
			studac.DataSource = dt;
			studac.Refresh();
			studac.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		}

		private void ManageActivity_Load(object sender, EventArgs e)
		{
			studac.EnableHeadersVisualStyles = false;
			studac.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			studac.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
			studac.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9, FontStyle.Bold);
			for (int i = 0; i < studac.Columns.Count; i++)
			{
				studac.Columns[i].DefaultCellStyle.Font = new Font("Century Gothic", 7, FontStyle.Bold);
			}
		}

		private void stuidcombbox_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataTable dt = controllerObj.SelectSID();
			DataTable dt2 = controllerObj.SelectStudentName();
		
			for (int i = 0; i < dt.Rows.Count; i++)
			{
				if (stuidcombbox.Text == dt.Rows[i]["StudentID"].ToString())
					stunametextbox.Text = dt2.Rows[i]["Name"].ToString() ;
			}
			
		}

		private void activitybtn_Click(object sender, EventArgs e)
		{
			DataTable d = controllerObj.SelectActivity(activitytypecombbox.Text);
			string id = d.Rows[0]["ActivityId"].ToString();
			int result = controllerObj.InsertParticipate(Int32.Parse(stuidcombbox.Text), Int32.Parse(id));
			if (result == 0)
			{
				MessageBox.Show("Cannot Join Activity ");
			}
			else
			{
				MessageBox.Show("Activity joined successfully!");
			}
			DataTable dt = controllerObj.SelectStudentActivity();
			studac.DataSource = dt;
			studac.Refresh();
		}

		private void leavebutton_Click(object sender, EventArgs e)
		{
			DataTable d = controllerObj.SelectActivity(activitytypecombbox.Text);
			string id = d.Rows[0]["ActivityId"].ToString();
			int result = controllerObj.DeleteParticipate(Int32.Parse(stuidcombbox.Text), Int32.Parse(id));
			if (result == 0)
			{
				MessageBox.Show("Cannot Leave Activity");
			}
			else
			{
				MessageBox.Show("Activity Left!");
			}
			DataTable dt = controllerObj.SelectStudentActivity();
			studac.DataSource = dt;
			studac.Refresh();
		}

		private void studac_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataTable dt = controllerObj.SelectSID();
			DataTable dt2 = controllerObj.SelectStudentName();
			stunametextbox.Text = studac.SelectedRows[0].Cells[0].Value.ToString().Trim();
			activitytypecombbox.Text = studac.SelectedRows[0].Cells[1].Value.ToString().Trim();
			for (int i = 0; i < dt2.Rows.Count; i++)
			{
				if (stunametextbox.Text == dt2.Rows[i]["Name"].ToString())
					stuidcombbox.Text = dt.Rows[i]["StudentID"].ToString();
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
