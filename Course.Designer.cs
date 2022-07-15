
namespace Student_Management_System_Project
{
	partial class Course
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.addcourse = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.coursenametextbox = new System.Windows.Forms.TextBox();
			this.courseidtextbox = new System.Windows.Forms.TextBox();
			this.starthour = new System.Windows.Forms.DateTimePicker();
			this.clearbutton = new System.Windows.Forms.Button();
			this.savebutton = new System.Windows.Forms.Button();
			this.endhour = new System.Windows.Forms.DateTimePicker();
			this.credithourscombobox = new System.Windows.Forms.ComboBox();
			this.daycombobox = new System.Windows.Forms.ComboBox();
			this.courselist = new System.Windows.Forms.DataGridView();
			this.cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dep = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.crhours = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.day = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.starth = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.endhr = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.depcombobox = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.returnbutton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.courselist)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Teal;
			this.panel1.ForeColor = System.Drawing.Color.Teal;
			this.panel1.Location = new System.Drawing.Point(16, 97);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1200, 5);
			this.panel1.TabIndex = 2;
			// 
			// addcourse
			// 
			this.addcourse.AutoSize = true;
			this.addcourse.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addcourse.ForeColor = System.Drawing.Color.DimGray;
			this.addcourse.Location = new System.Drawing.Point(447, 28);
			this.addcourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.addcourse.Name = "addcourse";
			this.addcourse.Size = new System.Drawing.Size(312, 40);
			this.addcourse.TabIndex = 28;
			this.addcourse.Text = "Add New Courses";
			this.addcourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.Teal;
			this.label11.Location = new System.Drawing.Point(645, 128);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(356, 40);
			this.label11.TabIndex = 57;
			this.label11.Text = "New Added Courses";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Teal;
			this.label5.Location = new System.Drawing.Point(31, 270);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(190, 32);
			this.label5.TabIndex = 62;
			this.label5.Text = "Credit Hours :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Teal;
			this.label3.Location = new System.Drawing.Point(31, 220);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 32);
			this.label3.TabIndex = 61;
			this.label3.Text = "ID :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Teal;
			this.label2.Location = new System.Drawing.Point(31, 171);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(211, 32);
			this.label2.TabIndex = 60;
			this.label2.Text = "Course Name :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(67, 177);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 17);
			this.label1.TabIndex = 59;
			this.label1.Text = "label1";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Teal;
			this.label4.Location = new System.Drawing.Point(31, 322);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 32);
			this.label4.TabIndex = 66;
			this.label4.Text = "Day :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Teal;
			this.label6.Location = new System.Drawing.Point(31, 421);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(147, 32);
			this.label6.TabIndex = 65;
			this.label6.Text = "End Hour :";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Teal;
			this.label7.Location = new System.Drawing.Point(31, 372);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(156, 32);
			this.label7.TabIndex = 64;
			this.label7.Text = "Start Hour :";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(67, 379);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(46, 17);
			this.label8.TabIndex = 63;
			this.label8.Text = "label8";
			// 
			// coursenametextbox
			// 
			this.coursenametextbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.coursenametextbox.Location = new System.Drawing.Point(257, 174);
			this.coursenametextbox.Margin = new System.Windows.Forms.Padding(4);
			this.coursenametextbox.MaxLength = 15;
			this.coursenametextbox.Name = "coursenametextbox";
			this.coursenametextbox.Size = new System.Drawing.Size(201, 30);
			this.coursenametextbox.TabIndex = 67;
			this.coursenametextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.coursenametextbox_KeyDown);
			this.coursenametextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.coursenametextbox_KeyPress);
			// 
			// courseidtextbox
			// 
			this.courseidtextbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.courseidtextbox.Location = new System.Drawing.Point(99, 223);
			this.courseidtextbox.Margin = new System.Windows.Forms.Padding(4);
			this.courseidtextbox.MaxLength = 4;
			this.courseidtextbox.Name = "courseidtextbox";
			this.courseidtextbox.Size = new System.Drawing.Size(201, 30);
			this.courseidtextbox.TabIndex = 68;
			this.courseidtextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.courseidtextbox_KeyPress);
			// 
			// starthour
			// 
			this.starthour.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.starthour.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.starthour.Location = new System.Drawing.Point(200, 370);
			this.starthour.Margin = new System.Windows.Forms.Padding(4);
			this.starthour.MaxDate = new System.DateTime(2022, 2, 1, 0, 0, 0, 0);
			this.starthour.Name = "starthour";
			this.starthour.Size = new System.Drawing.Size(160, 30);
			this.starthour.TabIndex = 70;
			this.starthour.Value = new System.DateTime(2021, 12, 29, 0, 0, 0, 0);
			// 
			// clearbutton
			// 
			this.clearbutton.BackColor = System.Drawing.Color.Teal;
			this.clearbutton.FlatAppearance.BorderSize = 0;
			this.clearbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.clearbutton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clearbutton.ForeColor = System.Drawing.Color.White;
			this.clearbutton.Location = new System.Drawing.Point(908, 601);
			this.clearbutton.Margin = new System.Windows.Forms.Padding(4);
			this.clearbutton.Name = "clearbutton";
			this.clearbutton.Size = new System.Drawing.Size(100, 52);
			this.clearbutton.TabIndex = 75;
			this.clearbutton.Text = "Clear";
			this.clearbutton.UseVisualStyleBackColor = false;
			this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
			// 
			// savebutton
			// 
			this.savebutton.BackColor = System.Drawing.Color.Teal;
			this.savebutton.FlatAppearance.BorderSize = 0;
			this.savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.savebutton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.savebutton.ForeColor = System.Drawing.Color.White;
			this.savebutton.Location = new System.Drawing.Point(800, 601);
			this.savebutton.Margin = new System.Windows.Forms.Padding(4);
			this.savebutton.Name = "savebutton";
			this.savebutton.Size = new System.Drawing.Size(100, 52);
			this.savebutton.TabIndex = 74;
			this.savebutton.Text = "Save";
			this.savebutton.UseVisualStyleBackColor = false;
			this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
			// 
			// endhour
			// 
			this.endhour.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.endhour.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.endhour.Location = new System.Drawing.Point(200, 420);
			this.endhour.Margin = new System.Windows.Forms.Padding(4);
			this.endhour.MaxDate = new System.DateTime(2022, 2, 1, 0, 0, 0, 0);
			this.endhour.Name = "endhour";
			this.endhour.Size = new System.Drawing.Size(160, 30);
			this.endhour.TabIndex = 78;
			this.endhour.Value = new System.DateTime(2021, 12, 29, 0, 0, 0, 0);
			// 
			// credithourscombobox
			// 
			this.credithourscombobox.DisplayMember = "DepID";
			this.credithourscombobox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.credithourscombobox.FormattingEnabled = true;
			this.credithourscombobox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
			this.credithourscombobox.Location = new System.Drawing.Point(235, 272);
			this.credithourscombobox.Margin = new System.Windows.Forms.Padding(4);
			this.credithourscombobox.Name = "credithourscombobox";
			this.credithourscombobox.Size = new System.Drawing.Size(89, 31);
			this.credithourscombobox.TabIndex = 112;
			// 
			// daycombobox
			// 
			this.daycombobox.DisplayMember = "DepID";
			this.daycombobox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.daycombobox.FormattingEnabled = true;
			this.daycombobox.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday"});
			this.daycombobox.Location = new System.Drawing.Point(125, 322);
			this.daycombobox.Margin = new System.Windows.Forms.Padding(4);
			this.daycombobox.Name = "daycombobox";
			this.daycombobox.Size = new System.Drawing.Size(187, 31);
			this.daycombobox.TabIndex = 113;
			// 
			// courselist
			// 
			this.courselist.AllowUserToAddRows = false;
			this.courselist.AllowUserToDeleteRows = false;
			this.courselist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.courselist.BackgroundColor = System.Drawing.Color.Silver;
			this.courselist.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.courselist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.courselist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cname,
            this.cid,
            this.dep,
            this.crhours,
            this.day,
            this.starth,
            this.endhr});
			this.courselist.Location = new System.Drawing.Point(484, 171);
			this.courselist.Margin = new System.Windows.Forms.Padding(4);
			this.courselist.Name = "courselist";
			this.courselist.ReadOnly = true;
			this.courselist.RowHeadersWidth = 51;
			this.courselist.Size = new System.Drawing.Size(732, 404);
			this.courselist.TabIndex = 73;
			this.courselist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courselist_CellContentClick);
			// 
			// cname
			// 
			this.cname.HeaderText = "Course Name";
			this.cname.MinimumWidth = 6;
			this.cname.Name = "cname";
			this.cname.ReadOnly = true;
			// 
			// cid
			// 
			this.cid.HeaderText = "Course ID";
			this.cid.MinimumWidth = 6;
			this.cid.Name = "cid";
			this.cid.ReadOnly = true;
			// 
			// dep
			// 
			this.dep.HeaderText = "Department";
			this.dep.MinimumWidth = 6;
			this.dep.Name = "dep";
			this.dep.ReadOnly = true;
			// 
			// crhours
			// 
			this.crhours.HeaderText = "Credit Hours";
			this.crhours.MinimumWidth = 6;
			this.crhours.Name = "crhours";
			this.crhours.ReadOnly = true;
			// 
			// day
			// 
			this.day.HeaderText = "Day";
			this.day.MinimumWidth = 6;
			this.day.Name = "day";
			this.day.ReadOnly = true;
			// 
			// starth
			// 
			this.starth.HeaderText = "Start Hour";
			this.starth.MinimumWidth = 6;
			this.starth.Name = "starth";
			this.starth.ReadOnly = true;
			// 
			// endhr
			// 
			this.endhr.HeaderText = "End Hour";
			this.endhr.MinimumWidth = 6;
			this.endhr.Name = "endhr";
			this.endhr.ReadOnly = true;
			// 
			// depcombobox
			// 
			this.depcombobox.DisplayMember = "DepID";
			this.depcombobox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.depcombobox.FormattingEnabled = true;
			this.depcombobox.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday"});
			this.depcombobox.Location = new System.Drawing.Point(232, 469);
			this.depcombobox.Margin = new System.Windows.Forms.Padding(4);
			this.depcombobox.Name = "depcombobox";
			this.depcombobox.Size = new System.Drawing.Size(187, 31);
			this.depcombobox.TabIndex = 139;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Teal;
			this.label9.Location = new System.Drawing.Point(31, 469);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(186, 32);
			this.label9.TabIndex = 138;
			this.label9.Text = "Department :";
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
			this.returnbutton.Location = new System.Drawing.Point(0, 608);
			this.returnbutton.Margin = new System.Windows.Forms.Padding(4);
			this.returnbutton.Name = "returnbutton";
			this.returnbutton.Size = new System.Drawing.Size(72, 64);
			this.returnbutton.TabIndex = 58;
			this.returnbutton.UseVisualStyleBackColor = false;
			this.returnbutton.Click += new System.EventHandler(this.returnbutton_Click);
			// 
			// Course
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(1248, 667);
			this.Controls.Add(this.depcombobox);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.daycombobox);
			this.Controls.Add(this.credithourscombobox);
			this.Controls.Add(this.endhour);
			this.Controls.Add(this.clearbutton);
			this.Controls.Add(this.savebutton);
			this.Controls.Add(this.courselist);
			this.Controls.Add(this.starthour);
			this.Controls.Add(this.courseidtextbox);
			this.Controls.Add(this.coursenametextbox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.returnbutton);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.addcourse);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Course";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Course";
			this.Load += new System.EventHandler(this.Course_Load);
			((System.ComponentModel.ISupportInitialize)(this.courselist)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label addcourse;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button returnbutton;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox coursenametextbox;
		private System.Windows.Forms.TextBox courseidtextbox;
		private System.Windows.Forms.DateTimePicker starthour;
		private System.Windows.Forms.Button clearbutton;
		private System.Windows.Forms.Button savebutton;
		private System.Windows.Forms.DateTimePicker endhour;
		private System.Windows.Forms.ComboBox credithourscombobox;
		private System.Windows.Forms.ComboBox daycombobox;
		private System.Windows.Forms.DataGridView courselist;
		private System.Windows.Forms.ComboBox depcombobox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DataGridViewTextBoxColumn cname;
		private System.Windows.Forms.DataGridViewTextBoxColumn cid;
		private System.Windows.Forms.DataGridViewTextBoxColumn dep;
		private System.Windows.Forms.DataGridViewTextBoxColumn crhours;
		private System.Windows.Forms.DataGridViewTextBoxColumn day;
		private System.Windows.Forms.DataGridViewTextBoxColumn starth;
		private System.Windows.Forms.DataGridViewTextBoxColumn endhr;
	}
}