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
	public partial class FeesReport : Form
	{
		Controller controllerObj;
		public FeesReport()
		{
			InitializeComponent();
			controllerObj = new Controller();

		}

		private void returnbutton_Click(object sender, EventArgs e)
		{
			this.Hide();
			Fees d1 = new Fees();
			d1.Show();
		}

		private void searchbutton_Click(object sender, EventArgs e)
		{
			DataTable dt;
			FeesPrint report = new FeesPrint();
			if (studentidtextbox.Text == "")
			{
				dt = controllerObj.SelectStudentsfees();
				report.SetDataSource(dt);
				crystalReportViewer1.ReportSource = report;
				crystalReportViewer1.Refresh();
			}
			else
			{
				dt = controllerObj.SelectStudentsfees(Int32.Parse(studentidtextbox.Text));
				report.SetDataSource(dt);
				crystalReportViewer1.ReportSource = report;
				crystalReportViewer1.Refresh();
			}
		}
	}

}
