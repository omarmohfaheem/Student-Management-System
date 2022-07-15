
namespace Student_Management_System_Project
{
	partial class InstructorView
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
			this.panelSideMenu = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.timetable = new System.Windows.Forms.Button();
			this.attendance = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.editprofile = new System.Windows.Forms.Button();
			this.InstructorName = new System.Windows.Forms.Label();
			this.Welcome = new System.Windows.Forms.Label();
			this.logoutbutton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panelSideMenu.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panelSideMenu
			// 
			this.panelSideMenu.AutoScroll = true;
			this.panelSideMenu.BackColor = System.Drawing.Color.Teal;
			this.panelSideMenu.Controls.Add(this.editprofile);
			this.panelSideMenu.Controls.Add(this.button2);
			this.panelSideMenu.Controls.Add(this.panel3);
			this.panelSideMenu.Controls.Add(this.timetable);
			this.panelSideMenu.Controls.Add(this.attendance);
			this.panelSideMenu.Controls.Add(this.panel2);
			this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
			this.panelSideMenu.Margin = new System.Windows.Forms.Padding(4);
			this.panelSideMenu.Name = "panelSideMenu";
			this.panelSideMenu.Size = new System.Drawing.Size(350, 527);
			this.panelSideMenu.TabIndex = 42;
			// 
			// button2
			// 
			this.button2.Dock = System.Windows.Forms.DockStyle.Top;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(0, 256);
			this.button2.Margin = new System.Windows.Forms.Padding(4);
			this.button2.Name = "button2";
			this.button2.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
			this.button2.Size = new System.Drawing.Size(350, 10);
			this.button2.TabIndex = 57;
			this.button2.Text = "Activities and Events";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.UseVisualStyleBackColor = true;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.logoutbutton);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 469);
			this.panel3.Margin = new System.Windows.Forms.Padding(4);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(350, 58);
			this.panel3.TabIndex = 52;
			// 
			// timetable
			// 
			this.timetable.Dock = System.Windows.Forms.DockStyle.Top;
			this.timetable.FlatAppearance.BorderSize = 0;
			this.timetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.timetable.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.timetable.ForeColor = System.Drawing.Color.White;
			this.timetable.Location = new System.Drawing.Point(0, 201);
			this.timetable.Margin = new System.Windows.Forms.Padding(4);
			this.timetable.Name = "timetable";
			this.timetable.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
			this.timetable.Size = new System.Drawing.Size(350, 55);
			this.timetable.TabIndex = 46;
			this.timetable.Text = "Time Table";
			this.timetable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.timetable.UseVisualStyleBackColor = true;
			this.timetable.Click += new System.EventHandler(this.timetable_Click);
			// 
			// attendance
			// 
			this.attendance.Dock = System.Windows.Forms.DockStyle.Top;
			this.attendance.FlatAppearance.BorderSize = 0;
			this.attendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.attendance.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.attendance.ForeColor = System.Drawing.Color.White;
			this.attendance.Location = new System.Drawing.Point(0, 146);
			this.attendance.Margin = new System.Windows.Forms.Padding(4);
			this.attendance.Name = "attendance";
			this.attendance.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
			this.attendance.Size = new System.Drawing.Size(350, 55);
			this.attendance.TabIndex = 44;
			this.attendance.Text = "Students Attendance";
			this.attendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.attendance.UseVisualStyleBackColor = true;
			this.attendance.Click += new System.EventHandler(this.attendance_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(350, 146);
			this.panel2.TabIndex = 0;
			// 
			// editprofile
			// 
			this.editprofile.Dock = System.Windows.Forms.DockStyle.Top;
			this.editprofile.FlatAppearance.BorderSize = 0;
			this.editprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.editprofile.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.editprofile.ForeColor = System.Drawing.Color.White;
			this.editprofile.Location = new System.Drawing.Point(0, 266);
			this.editprofile.Margin = new System.Windows.Forms.Padding(4);
			this.editprofile.Name = "editprofile";
			this.editprofile.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
			this.editprofile.Size = new System.Drawing.Size(350, 55);
			this.editprofile.TabIndex = 58;
			this.editprofile.Text = "Edit Profile";
			this.editprofile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.editprofile.UseVisualStyleBackColor = true;
			this.editprofile.Click += new System.EventHandler(this.editprofile_Click);
			// 
			// InstructorName
			// 
			this.InstructorName.AutoSize = true;
			this.InstructorName.Font = new System.Drawing.Font("Century Gothic", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.InstructorName.ForeColor = System.Drawing.Color.DimGray;
			this.InstructorName.Location = new System.Drawing.Point(562, 74);
			this.InstructorName.Name = "InstructorName";
			this.InstructorName.Size = new System.Drawing.Size(343, 49);
			this.InstructorName.TabIndex = 20;
			this.InstructorName.Text = "InstructorName";
			// 
			// Welcome
			// 
			this.Welcome.AutoSize = true;
			this.Welcome.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Welcome.ForeColor = System.Drawing.Color.Teal;
			this.Welcome.Location = new System.Drawing.Point(557, 34);
			this.Welcome.Name = "Welcome";
			this.Welcome.Size = new System.Drawing.Size(176, 40);
			this.Welcome.TabIndex = 19;
			this.Welcome.Text = "Welcome";
			// 
			// logoutbutton
			// 
			this.logoutbutton.BackColor = System.Drawing.Color.Transparent;
			this.logoutbutton.FlatAppearance.BorderSize = 0;
			this.logoutbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
			this.logoutbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.logoutbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.logoutbutton.ForeColor = System.Drawing.Color.White;
			this.logoutbutton.Image = global::Student_Management_System_Project.Properties.Resources.output_onlinepngtools__6_1;
			this.logoutbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.logoutbutton.Location = new System.Drawing.Point(4, 9);
			this.logoutbutton.Margin = new System.Windows.Forms.Padding(4);
			this.logoutbutton.Name = "logoutbutton";
			this.logoutbutton.Size = new System.Drawing.Size(153, 43);
			this.logoutbutton.TabIndex = 18;
			this.logoutbutton.Text = "           Logout";
			this.logoutbutton.UseVisualStyleBackColor = false;
			this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.Image = global::Student_Management_System_Project.Properties.Resources.driving_instructor;
			this.pictureBox1.Location = new System.Drawing.Point(97, 7);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(147, 132);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 19;
			this.pictureBox1.TabStop = false;
			// 
			// InstructorView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(963, 527);
			this.Controls.Add(this.InstructorName);
			this.Controls.Add(this.Welcome);
			this.Controls.Add(this.panelSideMenu);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "InstructorView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "InstructorView";
			this.panelSideMenu.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panelSideMenu;
		private System.Windows.Forms.Button editprofile;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button logoutbutton;
		private System.Windows.Forms.Button timetable;
		private System.Windows.Forms.Button attendance;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label InstructorName;
		private System.Windows.Forms.Label Welcome;
	}
}