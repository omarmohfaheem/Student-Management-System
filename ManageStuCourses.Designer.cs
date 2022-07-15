
namespace Student_Management_System_Project
{
	partial class ManageStuCourses
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
			this.showall = new System.Windows.Forms.Button();
			this.nametextbox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.stucourse = new System.Windows.Forms.DataGridView();
			this.loginpanel2 = new System.Windows.Forms.Panel();
			this.addcourse = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.courseidtextbox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.coursecredithourstextbox = new System.Windows.Forms.TextBox();
			this.Drop = new System.Windows.Forms.Button();
			this.Search = new System.Windows.Forms.Button();
			this.coursenamecombobox = new System.Windows.Forms.ComboBox();
			this.warn = new System.Windows.Forms.Label();
			this.studentidcombobox = new System.Windows.Forms.ComboBox();
			this.returnbutton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.stucourse)).BeginInit();
			this.SuspendLayout();
			// 
			// showall
			// 
			this.showall.BackColor = System.Drawing.Color.Teal;
			this.showall.FlatAppearance.BorderSize = 0;
			this.showall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.showall.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.showall.ForeColor = System.Drawing.Color.White;
			this.showall.Location = new System.Drawing.Point(920, 484);
			this.showall.Name = "showall";
			this.showall.Size = new System.Drawing.Size(108, 42);
			this.showall.TabIndex = 127;
			this.showall.Text = "Show All";
			this.showall.UseVisualStyleBackColor = false;
			this.showall.Click += new System.EventHandler(this.showall_Click);
			// 
			// nametextbox
			// 
			this.nametextbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nametextbox.Location = new System.Drawing.Point(220, 200);
			this.nametextbox.MaxLength = 4;
			this.nametextbox.Name = "nametextbox";
			this.nametextbox.ReadOnly = true;
			this.nametextbox.Size = new System.Drawing.Size(152, 26);
			this.nametextbox.TabIndex = 124;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Teal;
			this.label4.Location = new System.Drawing.Point(38, 247);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(158, 25);
			this.label4.TabIndex = 122;
			this.label4.Text = "Course Name:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Teal;
			this.label3.Location = new System.Drawing.Point(38, 141);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(127, 25);
			this.label3.TabIndex = 117;
			this.label3.Text = "Student ID :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Teal;
			this.label2.Location = new System.Drawing.Point(38, 195);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(169, 25);
			this.label2.TabIndex = 116;
			this.label2.Text = "Student Name :";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.Teal;
			this.label11.Location = new System.Drawing.Point(689, 99);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(270, 32);
			this.label11.TabIndex = 114;
			this.label11.Text = "Students Registered";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Teal;
			this.panel1.ForeColor = System.Drawing.Color.Teal;
			this.panel1.Location = new System.Drawing.Point(43, 58);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1026, 5);
			this.panel1.TabIndex = 132;
			// 
			// stucourse
			// 
			this.stucourse.AllowUserToAddRows = false;
			this.stucourse.AllowUserToDeleteRows = false;
			this.stucourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.stucourse.BackgroundColor = System.Drawing.Color.Silver;
			this.stucourse.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.stucourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.stucourse.Location = new System.Drawing.Point(557, 143);
			this.stucourse.Name = "stucourse";
			this.stucourse.ReadOnly = true;
			this.stucourse.Size = new System.Drawing.Size(512, 313);
			this.stucourse.TabIndex = 126;
			this.stucourse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stucourse_CellContentClick);
			// 
			// loginpanel2
			// 
			this.loginpanel2.BackColor = System.Drawing.Color.Teal;
			this.loginpanel2.Location = new System.Drawing.Point(533, 99);
			this.loginpanel2.Name = "loginpanel2";
			this.loginpanel2.Size = new System.Drawing.Size(4, 500);
			this.loginpanel2.TabIndex = 133;
			// 
			// addcourse
			// 
			this.addcourse.AutoSize = true;
			this.addcourse.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addcourse.ForeColor = System.Drawing.Color.DimGray;
			this.addcourse.Location = new System.Drawing.Point(420, 14);
			this.addcourse.Name = "addcourse";
			this.addcourse.Size = new System.Drawing.Size(224, 32);
			this.addcourse.TabIndex = 134;
			this.addcourse.Text = "Student Courses";
			this.addcourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Teal;
			this.label1.Location = new System.Drawing.Point(38, 304);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 25);
			this.label1.TabIndex = 135;
			this.label1.Text = "Course ID :";
			// 
			// courseidtextbox
			// 
			this.courseidtextbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.courseidtextbox.Location = new System.Drawing.Point(220, 303);
			this.courseidtextbox.MaxLength = 4;
			this.courseidtextbox.Name = "courseidtextbox";
			this.courseidtextbox.ReadOnly = true;
			this.courseidtextbox.Size = new System.Drawing.Size(152, 26);
			this.courseidtextbox.TabIndex = 136;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Teal;
			this.label5.Location = new System.Drawing.Point(38, 346);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(147, 50);
			this.label5.TabIndex = 137;
			this.label5.Text = "Course \r\nCredit Hours :";
			// 
			// coursecredithourstextbox
			// 
			this.coursecredithourstextbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.coursecredithourstextbox.Location = new System.Drawing.Point(220, 370);
			this.coursecredithourstextbox.MaxLength = 4;
			this.coursecredithourstextbox.Name = "coursecredithourstextbox";
			this.coursecredithourstextbox.ReadOnly = true;
			this.coursecredithourstextbox.Size = new System.Drawing.Size(152, 26);
			this.coursecredithourstextbox.TabIndex = 138;
			// 
			// Drop
			// 
			this.Drop.BackColor = System.Drawing.Color.Teal;
			this.Drop.FlatAppearance.BorderSize = 0;
			this.Drop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Drop.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Drop.ForeColor = System.Drawing.Color.White;
			this.Drop.Location = new System.Drawing.Point(220, 441);
			this.Drop.Name = "Drop";
			this.Drop.Size = new System.Drawing.Size(150, 42);
			this.Drop.TabIndex = 140;
			this.Drop.Text = "Drop Course";
			this.Drop.UseVisualStyleBackColor = false;
			this.Drop.Click += new System.EventHandler(this.Drop_Click);
			// 
			// Search
			// 
			this.Search.BackColor = System.Drawing.Color.Teal;
			this.Search.FlatAppearance.BorderSize = 0;
			this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Search.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Search.ForeColor = System.Drawing.Color.White;
			this.Search.Location = new System.Drawing.Point(920, 532);
			this.Search.Name = "Search";
			this.Search.Size = new System.Drawing.Size(108, 42);
			this.Search.TabIndex = 139;
			this.Search.Text = "Search";
			this.Search.UseVisualStyleBackColor = false;
			this.Search.Click += new System.EventHandler(this.Search_Click);
			// 
			// coursenamecombobox
			// 
			this.coursenamecombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.coursenamecombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.coursenamecombobox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.coursenamecombobox.FormattingEnabled = true;
			this.coursenamecombobox.Location = new System.Drawing.Point(220, 249);
			this.coursenamecombobox.Name = "coursenamecombobox";
			this.coursenamecombobox.Size = new System.Drawing.Size(152, 26);
			this.coursenamecombobox.TabIndex = 141;
			this.coursenamecombobox.SelectedIndexChanged += new System.EventHandler(this.coursenamecombobox_SelectedIndexChanged);
			// 
			// warn
			// 
			this.warn.AutoSize = true;
			this.warn.ForeColor = System.Drawing.Color.Red;
			this.warn.Location = new System.Drawing.Point(857, 577);
			this.warn.Name = "warn";
			this.warn.Size = new System.Drawing.Size(228, 13);
			this.warn.TabIndex = 142;
			this.warn.Text = "*CHECK STUDENT ID AND COURSE NAME*";
			// 
			// studentidcombobox
			// 
			this.studentidcombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.studentidcombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.studentidcombobox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.studentidcombobox.FormattingEnabled = true;
			this.studentidcombobox.Location = new System.Drawing.Point(220, 141);
			this.studentidcombobox.Name = "studentidcombobox";
			this.studentidcombobox.Size = new System.Drawing.Size(152, 26);
			this.studentidcombobox.TabIndex = 143;
			this.studentidcombobox.SelectedIndexChanged += new System.EventHandler(this.studentidcombobox_SelectedIndexChanged);
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
			this.returnbutton.Location = new System.Drawing.Point(-1, 603);
			this.returnbutton.Name = "returnbutton";
			this.returnbutton.Size = new System.Drawing.Size(54, 52);
			this.returnbutton.TabIndex = 144;
			this.returnbutton.UseVisualStyleBackColor = false;
			this.returnbutton.Click += new System.EventHandler(this.returnbutton_Click);
			// 
			// ManageStuCourses
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(1085, 651);
			this.Controls.Add(this.returnbutton);
			this.Controls.Add(this.studentidcombobox);
			this.Controls.Add(this.warn);
			this.Controls.Add(this.coursenamecombobox);
			this.Controls.Add(this.Drop);
			this.Controls.Add(this.Search);
			this.Controls.Add(this.coursecredithourstextbox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.courseidtextbox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.addcourse);
			this.Controls.Add(this.loginpanel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.showall);
			this.Controls.Add(this.stucourse);
			this.Controls.Add(this.nametextbox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label11);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ManageStuCourses";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "2";
			this.Load += new System.EventHandler(this.ManageCourseGrade_Load);
			((System.ComponentModel.ISupportInitialize)(this.stucourse)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button showall;
		private System.Windows.Forms.TextBox nametextbox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView stucourse;
		private System.Windows.Forms.Panel loginpanel2;
		private System.Windows.Forms.Label addcourse;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox courseidtextbox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox coursecredithourstextbox;
		private System.Windows.Forms.Button Drop;
		private System.Windows.Forms.Button Search;
		private System.Windows.Forms.ComboBox coursenamecombobox;
		private System.Windows.Forms.Label warn;
		private System.Windows.Forms.ComboBox studentidcombobox;
		private System.Windows.Forms.Button returnbutton;
	}
}