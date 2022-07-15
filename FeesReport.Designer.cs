
namespace Student_Management_System_Project
{
	partial class FeesReport
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.returnbutton = new System.Windows.Forms.Button();
			this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.FeesPrint1 = new Student_Management_System_Project.FeesPrint();
			this.searchbutton = new System.Windows.Forms.Button();
			this.studentidtextbox = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// returnbutton
			// 
			this.returnbutton.BackColor = System.Drawing.Color.Silver;
			this.returnbutton.FlatAppearance.BorderSize = 0;
			this.returnbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
			this.returnbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.returnbutton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.returnbutton.ForeColor = System.Drawing.Color.White;
			this.returnbutton.Image = global::Student_Management_System_Project.Properties.Resources.output_onlinepngtools__1_2;
			this.returnbutton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.returnbutton.Location = new System.Drawing.Point(8, 545);
			this.returnbutton.Margin = new System.Windows.Forms.Padding(4);
			this.returnbutton.Name = "returnbutton";
			this.returnbutton.Size = new System.Drawing.Size(71, 69);
			this.returnbutton.TabIndex = 86;
			this.returnbutton.UseVisualStyleBackColor = false;
			this.returnbutton.Click += new System.EventHandler(this.returnbutton_Click);
			// 
			// crystalReportViewer1
			// 
			this.crystalReportViewer1.ActiveViewIndex = 0;
			this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
			this.crystalReportViewer1.Location = new System.Drawing.Point(35, 94);
			this.crystalReportViewer1.Name = "crystalReportViewer1";
			this.crystalReportViewer1.ReportSource = this.FeesPrint1;
			this.crystalReportViewer1.Size = new System.Drawing.Size(982, 444);
			this.crystalReportViewer1.TabIndex = 87;
			// 
			// searchbutton
			// 
			this.searchbutton.BackColor = System.Drawing.Color.Teal;
			this.searchbutton.FlatAppearance.BorderSize = 0;
			this.searchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.searchbutton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchbutton.ForeColor = System.Drawing.Color.White;
			this.searchbutton.Location = new System.Drawing.Point(389, 32);
			this.searchbutton.Margin = new System.Windows.Forms.Padding(4);
			this.searchbutton.Name = "searchbutton";
			this.searchbutton.Size = new System.Drawing.Size(133, 52);
			this.searchbutton.TabIndex = 89;
			this.searchbutton.Text = "Search";
			this.searchbutton.UseVisualStyleBackColor = false;
			this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
			// 
			// studentidtextbox
			// 
			this.studentidtextbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.studentidtextbox.Location = new System.Drawing.Point(200, 46);
			this.studentidtextbox.Margin = new System.Windows.Forms.Padding(4);
			this.studentidtextbox.MaxLength = 13;
			this.studentidtextbox.Name = "studentidtextbox";
			this.studentidtextbox.Size = new System.Drawing.Size(181, 30);
			this.studentidtextbox.TabIndex = 90;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Teal;
			this.label8.Location = new System.Drawing.Point(29, 43);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(163, 32);
			this.label8.TabIndex = 91;
			this.label8.Text = "Student ID :";
			// 
			// FeesReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(1057, 607);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.studentidtextbox);
			this.Controls.Add(this.searchbutton);
			this.Controls.Add(this.crystalReportViewer1);
			this.Controls.Add(this.returnbutton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FeesReport";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FeesReport";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button returnbutton;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
		private FeesPrint FeesPrint1;
		private System.Windows.Forms.Button searchbutton;
		private System.Windows.Forms.TextBox studentidtextbox;
		private System.Windows.Forms.Label label8;
	}
}