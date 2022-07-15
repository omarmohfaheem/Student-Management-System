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
	public partial class Fees : Form
	{
		Controller controllerObj;
		public Fees()
		{
			InitializeComponent();
			controllerObj = new Controller();
			DataTable dt = controllerObj.SelectSID();
			stuidcombobox.DataSource = dt;
			stuidcombobox.DisplayMember = "StudentID";
			DataTable dt1 = controllerObj.SelectDepName();
			departmentname.DataSource = dt1;
			departmentname.DisplayMember = "DepartmentName";
		}
		private void Fees_Load(object sender, EventArgs e)
		{

		}

		private void Printbutton_Click(object sender, EventArgs e)
		{
			FeesReport report = new FeesReport();
			report.Show();
		}

		private void returnbutton_Click(object sender, EventArgs e)
		{
			this.Hide();
			Dashboard d1 = new Dashboard();
			d1.Show();
		}

		private void paybutton_Click(object sender, EventArgs e)
		{
			if (payidtextbox.Text=="" || amounttextbox.Text=="" || yearcombobox.Text=="" || stuidcombobox.Text=="" )
			{
				MessageBox.Show("Please Enter the data correctly!", "Missing data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			int result = controllerObj.Pay(Int32.Parse(payidtextbox.Text), Int32.Parse(amounttextbox.Text), yearcombobox.Text,
				Int32.Parse(stuidcombobox.Text), payment.Value);
			if (result == 0)
			{
				MessageBox.Show("Cannot pay fees");
			}
			else
			{
				MessageBox.Show("Fees paid successfully!");
			}
		}
	}
}
