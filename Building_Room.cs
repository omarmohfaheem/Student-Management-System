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
	public partial class Building_Room : Form
	{
		Controller controllerObj;
	
		public Building_Room()
		{
			InitializeComponent();
			controllerObj = new Controller();
			DataTable dt = controllerObj.SelectBID();
			DataTable dt1 = controllerObj.SelectBName();
			bidcombobox.DataSource = dt;
			bidcombobox.DisplayMember = "BuildingID";
			bnamecombobox.DataSource = dt1;
			bnamecombobox.DisplayMember = "BuildingName";
			DataTable dt4 = controllerObj.Room();
			roomlist.DataSource = dt4;
			roomlist.Refresh();
		}

		private void Building_Room_Load(object sender, EventArgs e)
		{
			roomlist.EnableHeadersVisualStyles = false;
			roomlist.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			roomlist.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
			roomlist.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold);
		}

		private void returnbutton_Click(object sender, EventArgs e)
		{
			this.Hide();
			Dashboard d1 = new Dashboard();
			d1.Show();
		}

		private void savebutton_Click(object sender, EventArgs e)
		{
			int result = controllerObj.AddBuilding(typetextbox.Text,Int32.Parse(idtextbox.Text));
			if (result == 0)
			{
				MessageBox.Show("The insertion of a new Building failed");
			}
			else
			{
				MessageBox.Show("New Building Added!");
			}
		}

		private void savebutton2_Click(object sender, EventArgs e)
		{
			int result = controllerObj.AddRoom(Int32.Parse(rnumber.Text), Int32.Parse(lnumber.Text),Int32.Parse(bidcombobox.Text),bnamecombobox.Text);
			if (result == 0)
			{
				MessageBox.Show("The insertion of a new room failed");
			}
			else
			{
				MessageBox.Show("New Room Added!");
			}
		}

		private void bnamecombobox_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataTable dt2 = controllerObj.SelectBName();
			DataTable dt = controllerObj.Buildings();

			for (int i = 0; i < dt2.Rows.Count; i++)
			{
				if (bnamecombobox.Text == dt2.Rows[i]["BuildingName"].ToString())
					bidcombobox.Text = dt.Rows[i]["BuildingID"].ToString();
			}
		}

		private void bidcombobox_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataTable dt2 = controllerObj.SelectBName();
			DataTable dt = controllerObj.Buildings();

			for (int i = 0; i < dt.Rows.Count; i++)
			{
				if (bidcombobox.Text == dt.Rows[i]["BuildingID"].ToString())
					bnamecombobox.Text = dt2.Rows[i]["BuildingName"].ToString();
			}
		}
	}
}
