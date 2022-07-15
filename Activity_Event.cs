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
	public partial class Activity_Event : Form
	{
		Controller controllerObj;

		public Activity_Event()
		{
			InitializeComponent();
			controllerObj = new Controller();
			activitylist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			eventlist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			DataTable dt = controllerObj.Activity();
			activitylist.DataSource = dt;
			activitylist.Refresh();
			DataTable dt1 = controllerObj.Events();
			eventlist.DataSource = dt1;
			eventlist.Refresh();
		}



		private void Activity_Event_Load(object sender, EventArgs e)
		{
			activitylist.EnableHeadersVisualStyles = false;
			activitylist.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			activitylist.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
			activitylist.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold);
			eventlist.EnableHeadersVisualStyles = false;
			eventlist.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			eventlist.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
			eventlist.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold);

		}
		private void activitylist_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			idtextbox.Text = activitylist.SelectedRows[0].Cells[0].Value.ToString().Trim();
			typetextbox.Text = activitylist.SelectedRows[0].Cells[1].Value.ToString().Trim();
		}

		private void eventlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			eidtextbox.Text = eventlist.SelectedRows[0].Cells[0].Value.ToString().Trim();
			etypetextbox.Text = eventlist.SelectedRows[0].Cells[1].Value.ToString().Trim();
			startdate.Text = eventlist.SelectedRows[0].Cells[2].Value.ToString().Trim();
			enddate.Text = eventlist.SelectedRows[0].Cells[3].Value.ToString().Trim();
		}
		private void returnbutton_Click(object sender, EventArgs e)
		{
			this.Hide();
			Dashboard d1 = new Dashboard();
			d1.Show();
		}

		private void saveacbutton_Click(object sender, EventArgs e)
		{
			int result = controllerObj.AddActivity(Int32.Parse(idtextbox.Text), typetextbox.Text); 
			if (result == 0)
			{
				MessageBox.Show("The insertion of a new activity failed");
			}
			else
			{
				MessageBox.Show("Activity inserted successfully!");
			}
		}

		private void saveevbutton2_Click(object sender, EventArgs e)
		{
			int result = controllerObj.AddEvent(Int32.Parse(eidtextbox.Text), etypetextbox.Text, startdate.Value, enddate.Value); ;
			if (result == 0)
			{
				MessageBox.Show("The insertion of a new Event failed");
			}
			else
			{
				MessageBox.Show("Event inserted successfully!");
			}
		}
	}
}
