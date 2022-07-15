
namespace Student_Management_System_Project
{
	partial class Attedance
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
			this.CourseID = new System.Windows.Forms.TextBox();
			this.showlist = new System.Windows.Forms.Button();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.sumbit = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.Week = new System.Windows.Forms.ComboBox();
			this.returnbutton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// CourseID
			// 
			this.CourseID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CourseID.Location = new System.Drawing.Point(205, 122);
			this.CourseID.Name = "CourseID";
			this.CourseID.Size = new System.Drawing.Size(100, 28);
			this.CourseID.TabIndex = 151;
			// 
			// showlist
			// 
			this.showlist.BackColor = System.Drawing.Color.Teal;
			this.showlist.FlatAppearance.BorderSize = 0;
			this.showlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.showlist.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.showlist.ForeColor = System.Drawing.Color.White;
			this.showlist.Location = new System.Drawing.Point(324, 112);
			this.showlist.Name = "showlist";
			this.showlist.Size = new System.Drawing.Size(155, 39);
			this.showlist.TabIndex = 150;
			this.showlist.Text = "Show Studentlist";
			this.showlist.UseVisualStyleBackColor = false;
			this.showlist.Click += new System.EventHandler(this.showlist_Click);
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Location = new System.Drawing.Point(121, 158);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(692, 257);
			this.checkedListBox1.TabIndex = 149;
			// 
			// sumbit
			// 
			this.sumbit.BackColor = System.Drawing.Color.Teal;
			this.sumbit.FlatAppearance.BorderSize = 0;
			this.sumbit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.sumbit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sumbit.ForeColor = System.Drawing.Color.White;
			this.sumbit.Location = new System.Drawing.Point(583, 423);
			this.sumbit.Name = "sumbit";
			this.sumbit.Size = new System.Drawing.Size(230, 72);
			this.sumbit.TabIndex = 148;
			this.sumbit.Text = "Submit Attendance";
			this.sumbit.UseVisualStyleBackColor = false;
			this.sumbit.Click += new System.EventHandler(this.sumbit_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DimGray;
			this.label1.Location = new System.Drawing.Point(382, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(176, 40);
			this.label1.TabIndex = 147;
			this.label1.Text = "Welcome";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Teal;
			this.panel1.ForeColor = System.Drawing.Color.Teal;
			this.panel1.Location = new System.Drawing.Point(-258, 59);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1368, 6);
			this.panel1.TabIndex = 154;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Teal;
			this.label3.Location = new System.Drawing.Point(597, 95);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 32);
			this.label3.TabIndex = 118;
			this.label3.Text = "Week";
			// 
			// Week
			// 
			this.Week.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Week.FormattingEnabled = true;
			this.Week.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
			this.Week.Location = new System.Drawing.Point(583, 130);
			this.Week.Name = "Week";
			this.Week.Size = new System.Drawing.Size(121, 27);
			this.Week.TabIndex = 155;
			// 
			// returnbutton
			// 
			this.returnbutton.BackColor = System.Drawing.Color.Silver;
			this.returnbutton.FlatAppearance.BorderSize = 0;
			this.returnbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
			this.returnbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.returnbutton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.returnbutton.ForeColor = System.Drawing.Color.White;
			this.returnbutton.Image = global::Student_Management_System_Project.Properties.Resources.output_onlinepngtools__1_1;
			this.returnbutton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.returnbutton.Location = new System.Drawing.Point(2, 483);
			this.returnbutton.Margin = new System.Windows.Forms.Padding(4);
			this.returnbutton.Name = "returnbutton";
			this.returnbutton.Size = new System.Drawing.Size(72, 47);
			this.returnbutton.TabIndex = 146;
			this.returnbutton.UseVisualStyleBackColor = false;
			this.returnbutton.Click += new System.EventHandler(this.returnbutton_Click);
			// 
			// Attedance
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(930, 538);
			this.Controls.Add(this.Week);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.CourseID);
			this.Controls.Add(this.showlist);
			this.Controls.Add(this.checkedListBox1);
			this.Controls.Add(this.sumbit);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.returnbutton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Attedance";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Attedance";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button returnbutton;
		private System.Windows.Forms.TextBox CourseID;
		private System.Windows.Forms.Button showlist;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private System.Windows.Forms.Button sumbit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox Week;
	}
}