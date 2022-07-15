
namespace Student_Management_System_Project
{
	partial class ManageInstructor
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
			this.buildingnamecombobox = new System.Windows.Forms.ComboBox();
			this.levelnumbercombobox = new System.Windows.Forms.ComboBox();
			this.roomnumbercombobox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cidcombobox = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.instidcombobox = new System.Windows.Forms.ComboBox();
			this.depcombobox = new System.Windows.Forms.ComboBox();
			this.depcheckbox = new System.Windows.Forms.CheckBox();
			this.inst = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.instructors = new System.Windows.Forms.DataGridView();
			this.room = new System.Windows.Forms.DataGridView();
			this.label9 = new System.Windows.Forms.Label();
			this.managebutton = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.teach = new System.Windows.Forms.Button();
			this.leave = new System.Windows.Forms.Button();
			this.deleteinstructor = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.instructors)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.room)).BeginInit();
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
			this.returnbutton.Image = global::Student_Management_System_Project.Properties.Resources.output_onlinepngtools__1_1;
			this.returnbutton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.returnbutton.Location = new System.Drawing.Point(1, 737);
			this.returnbutton.Margin = new System.Windows.Forms.Padding(4);
			this.returnbutton.Name = "returnbutton";
			this.returnbutton.Size = new System.Drawing.Size(72, 64);
			this.returnbutton.TabIndex = 74;
			this.returnbutton.UseVisualStyleBackColor = false;
			this.returnbutton.Click += new System.EventHandler(this.returnbutton_Click);
			// 
			// buildingnamecombobox
			// 
			this.buildingnamecombobox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buildingnamecombobox.FormattingEnabled = true;
			this.buildingnamecombobox.Location = new System.Drawing.Point(263, 323);
			this.buildingnamecombobox.Margin = new System.Windows.Forms.Padding(4);
			this.buildingnamecombobox.Name = "buildingnamecombobox";
			this.buildingnamecombobox.Size = new System.Drawing.Size(160, 31);
			this.buildingnamecombobox.TabIndex = 129;
			// 
			// levelnumbercombobox
			// 
			this.levelnumbercombobox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.levelnumbercombobox.FormattingEnabled = true;
			this.levelnumbercombobox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
			this.levelnumbercombobox.Location = new System.Drawing.Point(263, 263);
			this.levelnumbercombobox.Margin = new System.Windows.Forms.Padding(4);
			this.levelnumbercombobox.Name = "levelnumbercombobox";
			this.levelnumbercombobox.Size = new System.Drawing.Size(160, 31);
			this.levelnumbercombobox.TabIndex = 128;
			// 
			// roomnumbercombobox
			// 
			this.roomnumbercombobox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.roomnumbercombobox.FormattingEnabled = true;
			this.roomnumbercombobox.Items.AddRange(new object[] {
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
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
			this.roomnumbercombobox.Location = new System.Drawing.Point(263, 203);
			this.roomnumbercombobox.Margin = new System.Windows.Forms.Padding(4);
			this.roomnumbercombobox.Name = "roomnumbercombobox";
			this.roomnumbercombobox.Size = new System.Drawing.Size(160, 31);
			this.roomnumbercombobox.TabIndex = 127;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Teal;
			this.label1.Location = new System.Drawing.Point(33, 320);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(221, 32);
			this.label1.TabIndex = 126;
			this.label1.Text = "Building Name :";
			// 
			// cidcombobox
			// 
			this.cidcombobox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cidcombobox.FormattingEnabled = true;
			this.cidcombobox.Location = new System.Drawing.Point(227, 143);
			this.cidcombobox.Margin = new System.Windows.Forms.Padding(4);
			this.cidcombobox.Name = "cidcombobox";
			this.cidcombobox.Size = new System.Drawing.Size(160, 31);
			this.cidcombobox.TabIndex = 125;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Teal;
			this.label6.Location = new System.Drawing.Point(27, 203);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(219, 32);
			this.label6.TabIndex = 124;
			this.label6.Text = "Room Number :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Teal;
			this.label3.Location = new System.Drawing.Point(27, 260);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(211, 32);
			this.label3.TabIndex = 123;
			this.label3.Text = "Level Number :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Teal;
			this.label2.Location = new System.Drawing.Point(27, 140);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(158, 32);
			this.label2.TabIndex = 122;
			this.label2.Text = "Course ID :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Teal;
			this.label4.Location = new System.Drawing.Point(27, 80);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(186, 32);
			this.label4.TabIndex = 130;
			this.label4.Text = "Instructor ID :";
			// 
			// instidcombobox
			// 
			this.instidcombobox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.instidcombobox.FormattingEnabled = true;
			this.instidcombobox.Location = new System.Drawing.Point(227, 83);
			this.instidcombobox.Margin = new System.Windows.Forms.Padding(4);
			this.instidcombobox.Name = "instidcombobox";
			this.instidcombobox.Size = new System.Drawing.Size(160, 31);
			this.instidcombobox.TabIndex = 131;
			// 
			// depcombobox
			// 
			this.depcombobox.DisplayMember = "DepID";
			this.depcombobox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.depcombobox.FormattingEnabled = true;
			this.depcombobox.Location = new System.Drawing.Point(263, 395);
			this.depcombobox.Margin = new System.Windows.Forms.Padding(4);
			this.depcombobox.Name = "depcombobox";
			this.depcombobox.Size = new System.Drawing.Size(160, 31);
			this.depcombobox.TabIndex = 141;
			this.depcombobox.Visible = false;
			// 
			// depcheckbox
			// 
			this.depcheckbox.AutoSize = true;
			this.depcheckbox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.depcheckbox.ForeColor = System.Drawing.Color.Teal;
			this.depcheckbox.Location = new System.Drawing.Point(39, 374);
			this.depcheckbox.Margin = new System.Windows.Forms.Padding(4);
			this.depcheckbox.Name = "depcheckbox";
			this.depcheckbox.Size = new System.Drawing.Size(192, 68);
			this.depcheckbox.TabIndex = 140;
			this.depcheckbox.Text = "Manages\r\nDepartment";
			this.depcheckbox.UseVisualStyleBackColor = true;
			this.depcheckbox.CheckedChanged += new System.EventHandler(this.depcheckbox_CheckedChanged);
			// 
			// inst
			// 
			this.inst.AutoSize = true;
			this.inst.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inst.ForeColor = System.Drawing.Color.DimGray;
			this.inst.Location = new System.Drawing.Point(577, 9);
			this.inst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.inst.Name = "inst";
			this.inst.Size = new System.Drawing.Size(332, 40);
			this.inst.TabIndex = 143;
			this.inst.Text = "Manage Instructors";
			this.inst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Teal;
			this.panel1.ForeColor = System.Drawing.Color.Teal;
			this.panel1.Location = new System.Drawing.Point(24, 53);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1150, 5);
			this.panel1.TabIndex = 142;
			// 
			// instructors
			// 
			this.instructors.AllowUserToAddRows = false;
			this.instructors.AllowUserToDeleteRows = false;
			this.instructors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.instructors.BackgroundColor = System.Drawing.Color.Silver;
			this.instructors.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.instructors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.instructors.Location = new System.Drawing.Point(617, 106);
			this.instructors.Margin = new System.Windows.Forms.Padding(4);
			this.instructors.Name = "instructors";
			this.instructors.ReadOnly = true;
			this.instructors.RowHeadersWidth = 51;
			this.instructors.Size = new System.Drawing.Size(510, 313);
			this.instructors.TabIndex = 144;
			this.instructors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.instructors_CellContentClick);
			// 
			// room
			// 
			this.room.AllowUserToAddRows = false;
			this.room.AllowUserToDeleteRows = false;
			this.room.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.room.BackgroundColor = System.Drawing.Color.Silver;
			this.room.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.room.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.room.Location = new System.Drawing.Point(625, 465);
			this.room.Margin = new System.Windows.Forms.Padding(4);
			this.room.Name = "room";
			this.room.ReadOnly = true;
			this.room.RowHeadersWidth = 51;
			this.room.Size = new System.Drawing.Size(508, 287);
			this.room.TabIndex = 145;
			this.room.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.room_CellContentClick);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.ForeColor = System.Drawing.Color.Red;
			this.label9.Location = new System.Drawing.Point(109, 717);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(224, 17);
			this.label9.TabIndex = 148;
			this.label9.Text = "*Check Manages Department Box*";
			// 
			// managebutton
			// 
			this.managebutton.BackColor = System.Drawing.Color.Teal;
			this.managebutton.FlatAppearance.BorderSize = 0;
			this.managebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.managebutton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.managebutton.ForeColor = System.Drawing.Color.White;
			this.managebutton.Location = new System.Drawing.Point(24, 661);
			this.managebutton.Margin = new System.Windows.Forms.Padding(4);
			this.managebutton.Name = "managebutton";
			this.managebutton.Size = new System.Drawing.Size(309, 52);
			this.managebutton.TabIndex = 147;
			this.managebutton.Text = "Manage Department";
			this.managebutton.UseVisualStyleBackColor = false;
			this.managebutton.Click += new System.EventHandler(this.managebutton_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.Teal;
			this.label11.Location = new System.Drawing.Point(731, 420);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(339, 40);
			this.label11.TabIndex = 149;
			this.label11.Text = "Available Locations";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// teach
			// 
			this.teach.BackColor = System.Drawing.Color.Teal;
			this.teach.FlatAppearance.BorderSize = 0;
			this.teach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.teach.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.teach.ForeColor = System.Drawing.Color.White;
			this.teach.Location = new System.Drawing.Point(24, 482);
			this.teach.Margin = new System.Windows.Forms.Padding(4);
			this.teach.Name = "teach";
			this.teach.Size = new System.Drawing.Size(207, 52);
			this.teach.TabIndex = 150;
			this.teach.Text = "Teach Course";
			this.teach.UseVisualStyleBackColor = false;
			this.teach.Click += new System.EventHandler(this.teach_Click);
			// 
			// leave
			// 
			this.leave.BackColor = System.Drawing.Color.Teal;
			this.leave.FlatAppearance.BorderSize = 0;
			this.leave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.leave.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.leave.ForeColor = System.Drawing.Color.White;
			this.leave.Location = new System.Drawing.Point(24, 541);
			this.leave.Margin = new System.Windows.Forms.Padding(4);
			this.leave.Name = "leave";
			this.leave.Size = new System.Drawing.Size(207, 52);
			this.leave.TabIndex = 151;
			this.leave.Text = "Leave Course";
			this.leave.UseVisualStyleBackColor = false;
			this.leave.Click += new System.EventHandler(this.leave_Click);
			// 
			// deleteinstructor
			// 
			this.deleteinstructor.BackColor = System.Drawing.Color.Teal;
			this.deleteinstructor.FlatAppearance.BorderSize = 0;
			this.deleteinstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deleteinstructor.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deleteinstructor.ForeColor = System.Drawing.Color.White;
			this.deleteinstructor.Location = new System.Drawing.Point(24, 601);
			this.deleteinstructor.Margin = new System.Windows.Forms.Padding(4);
			this.deleteinstructor.Name = "deleteinstructor";
			this.deleteinstructor.Size = new System.Drawing.Size(251, 52);
			this.deleteinstructor.TabIndex = 152;
			this.deleteinstructor.Text = "Delete Instructor";
			this.deleteinstructor.UseVisualStyleBackColor = false;
			this.deleteinstructor.Click += new System.EventHandler(this.deleteinstructor_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Teal;
			this.label5.Location = new System.Drawing.Point(612, 62);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(531, 40);
			this.label5.TabIndex = 153;
			this.label5.Text = "Courses Teached by Instructors";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ManageInstructor
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(1217, 785);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.deleteinstructor);
			this.Controls.Add(this.leave);
			this.Controls.Add(this.teach);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.managebutton);
			this.Controls.Add(this.room);
			this.Controls.Add(this.instructors);
			this.Controls.Add(this.inst);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.depcombobox);
			this.Controls.Add(this.depcheckbox);
			this.Controls.Add(this.instidcombobox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.buildingnamecombobox);
			this.Controls.Add(this.levelnumbercombobox);
			this.Controls.Add(this.roomnumbercombobox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cidcombobox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.returnbutton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ManageInstructor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ManageInstructor";
			this.Load += new System.EventHandler(this.ManageInstructor_Load);
			((System.ComponentModel.ISupportInitialize)(this.instructors)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.room)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button returnbutton;
		private System.Windows.Forms.ComboBox buildingnamecombobox;
		private System.Windows.Forms.ComboBox levelnumbercombobox;
		private System.Windows.Forms.ComboBox roomnumbercombobox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cidcombobox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox instidcombobox;
		private System.Windows.Forms.ComboBox depcombobox;
		private System.Windows.Forms.CheckBox depcheckbox;
		private System.Windows.Forms.Label inst;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView instructors;
		private System.Windows.Forms.DataGridView room;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button managebutton;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button teach;
		private System.Windows.Forms.Button leave;
		private System.Windows.Forms.Button deleteinstructor;
		private System.Windows.Forms.Label label5;
	}
}