
namespace Student_Management_System_Project
{
	partial class Manage_Courses
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
			this.daycombobox = new System.Windows.Forms.ComboBox();
			this.endhour = new System.Windows.Forms.DateTimePicker();
			this.show = new System.Windows.Forms.Button();
			this.courses = new System.Windows.Forms.DataGridView();
			this.starthour = new System.Windows.Forms.DateTimePicker();
			this.courseidtextbox = new System.Windows.Forms.TextBox();
			this.coursenametextbox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.addcourse = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.preqcheckBox = new System.Windows.Forms.CheckBox();
			this.preqcombobox = new System.Windows.Forms.ComboBox();
			this.Filter = new System.Windows.Forms.Button();
			this.updatecoursetime = new System.Windows.Forms.Button();
			this.warn = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.depcombobox = new System.Windows.Forms.ComboBox();
			this.deletecourse = new System.Windows.Forms.Button();
			this.preqbutton = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.preqtable = new System.Windows.Forms.DataGridView();
			this.preqlabel = new System.Windows.Forms.Label();
			this.search = new System.Windows.Forms.Button();
			this.cnamesearch = new System.Windows.Forms.ComboBox();
			this.credithourstextbox = new System.Windows.Forms.TextBox();
			this.returnbutton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.courses)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.preqtable)).BeginInit();
			this.SuspendLayout();
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
			this.daycombobox.Location = new System.Drawing.Point(272, 274);
			this.daycombobox.Margin = new System.Windows.Forms.Padding(4);
			this.daycombobox.Name = "daycombobox";
			this.daycombobox.Size = new System.Drawing.Size(187, 31);
			this.daycombobox.TabIndex = 135;
			// 
			// endhour
			// 
			this.endhour.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.endhour.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.endhour.Location = new System.Drawing.Point(272, 383);
			this.endhour.Margin = new System.Windows.Forms.Padding(4);
			this.endhour.MaxDate = new System.DateTime(2022, 2, 1, 0, 0, 0, 0);
			this.endhour.Name = "endhour";
			this.endhour.Size = new System.Drawing.Size(187, 30);
			this.endhour.TabIndex = 133;
			this.endhour.Value = new System.DateTime(2021, 12, 29, 0, 0, 0, 0);
			// 
			// show
			// 
			this.show.BackColor = System.Drawing.Color.Teal;
			this.show.FlatAppearance.BorderSize = 0;
			this.show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.show.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.show.ForeColor = System.Drawing.Color.White;
			this.show.Location = new System.Drawing.Point(965, 529);
			this.show.Margin = new System.Windows.Forms.Padding(4);
			this.show.Name = "show";
			this.show.Size = new System.Drawing.Size(268, 52);
			this.show.TabIndex = 131;
			this.show.Text = "Show All Courses";
			this.show.UseVisualStyleBackColor = false;
			this.show.Click += new System.EventHandler(this.show_Click);
			// 
			// courses
			// 
			this.courses.AllowUserToAddRows = false;
			this.courses.AllowUserToDeleteRows = false;
			this.courses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.courses.BackgroundColor = System.Drawing.Color.Silver;
			this.courses.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.courses.Location = new System.Drawing.Point(751, 178);
			this.courses.Margin = new System.Windows.Forms.Padding(4);
			this.courses.Name = "courses";
			this.courses.ReadOnly = true;
			this.courses.RowHeadersWidth = 51;
			this.courses.Size = new System.Drawing.Size(679, 324);
			this.courses.TabIndex = 130;
			this.courses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courses_CellContentClick);
			// 
			// starthour
			// 
			this.starthour.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.starthour.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.starthour.Location = new System.Drawing.Point(272, 329);
			this.starthour.Margin = new System.Windows.Forms.Padding(4);
			this.starthour.MaxDate = new System.DateTime(2022, 2, 1, 0, 0, 0, 0);
			this.starthour.Name = "starthour";
			this.starthour.Size = new System.Drawing.Size(187, 30);
			this.starthour.TabIndex = 129;
			this.starthour.Value = new System.DateTime(2021, 12, 29, 0, 0, 0, 0);
			// 
			// courseidtextbox
			// 
			this.courseidtextbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.courseidtextbox.Location = new System.Drawing.Point(272, 166);
			this.courseidtextbox.Margin = new System.Windows.Forms.Padding(4);
			this.courseidtextbox.MaxLength = 4;
			this.courseidtextbox.Name = "courseidtextbox";
			this.courseidtextbox.ReadOnly = true;
			this.courseidtextbox.Size = new System.Drawing.Size(187, 30);
			this.courseidtextbox.TabIndex = 128;
			this.courseidtextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.courseidtextbox_KeyPress);
			// 
			// coursenametextbox
			// 
			this.coursenametextbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.coursenametextbox.Location = new System.Drawing.Point(272, 112);
			this.coursenametextbox.Margin = new System.Windows.Forms.Padding(4);
			this.coursenametextbox.MaxLength = 15;
			this.coursenametextbox.Name = "coursenametextbox";
			this.coursenametextbox.ReadOnly = true;
			this.coursenametextbox.Size = new System.Drawing.Size(187, 30);
			this.coursenametextbox.TabIndex = 127;
			this.coursenametextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.coursenametextbox_KeyDown);
			this.coursenametextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.coursenametextbox_KeyPress);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Teal;
			this.label4.Location = new System.Drawing.Point(49, 272);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 32);
			this.label4.TabIndex = 126;
			this.label4.Text = "Day :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Teal;
			this.label6.Location = new System.Drawing.Point(49, 380);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(147, 32);
			this.label6.TabIndex = 125;
			this.label6.Text = "End Hour :";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Teal;
			this.label7.Location = new System.Drawing.Point(49, 326);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(156, 32);
			this.label7.TabIndex = 124;
			this.label7.Text = "Start Hour :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Teal;
			this.label5.Location = new System.Drawing.Point(49, 218);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(190, 32);
			this.label5.TabIndex = 122;
			this.label5.Text = "Credit Hours :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Teal;
			this.label3.Location = new System.Drawing.Point(49, 164);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(158, 32);
			this.label3.TabIndex = 121;
			this.label3.Text = "Course ID :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Teal;
			this.label2.Location = new System.Drawing.Point(49, 110);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(211, 32);
			this.label2.TabIndex = 120;
			this.label2.Text = "Course Name :";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.Teal;
			this.label11.Location = new System.Drawing.Point(981, 75);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(207, 40);
			this.label11.TabIndex = 117;
			this.label11.Text = "Courses List";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// addcourse
			// 
			this.addcourse.AutoSize = true;
			this.addcourse.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addcourse.ForeColor = System.Drawing.Color.DimGray;
			this.addcourse.Location = new System.Drawing.Point(583, 16);
			this.addcourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.addcourse.Name = "addcourse";
			this.addcourse.Size = new System.Drawing.Size(298, 40);
			this.addcourse.TabIndex = 115;
			this.addcourse.Text = "Manage Courses";
			this.addcourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Teal;
			this.panel1.ForeColor = System.Drawing.Color.Teal;
			this.panel1.Location = new System.Drawing.Point(25, 66);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1400, 5);
			this.panel1.TabIndex = 114;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Teal;
			this.label1.Location = new System.Drawing.Point(49, 434);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(186, 32);
			this.label1.TabIndex = 136;
			this.label1.Text = "Department :";
			// 
			// preqcheckBox
			// 
			this.preqcheckBox.AutoSize = true;
			this.preqcheckBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.preqcheckBox.ForeColor = System.Drawing.Color.Teal;
			this.preqcheckBox.Location = new System.Drawing.Point(49, 489);
			this.preqcheckBox.Margin = new System.Windows.Forms.Padding(4);
			this.preqcheckBox.Name = "preqcheckBox";
			this.preqcheckBox.Size = new System.Drawing.Size(187, 36);
			this.preqcheckBox.TabIndex = 138;
			this.preqcheckBox.Text = "Prerequisite";
			this.preqcheckBox.UseVisualStyleBackColor = true;
			this.preqcheckBox.CheckedChanged += new System.EventHandler(this.preqcheckBox_CheckedChanged);
			// 
			// preqcombobox
			// 
			this.preqcombobox.DisplayMember = "DepID";
			this.preqcombobox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.preqcombobox.FormattingEnabled = true;
			this.preqcombobox.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday"});
			this.preqcombobox.Location = new System.Drawing.Point(272, 492);
			this.preqcombobox.Margin = new System.Windows.Forms.Padding(4);
			this.preqcombobox.Name = "preqcombobox";
			this.preqcombobox.Size = new System.Drawing.Size(187, 31);
			this.preqcombobox.TabIndex = 139;
			this.preqcombobox.Visible = false;
			// 
			// Filter
			// 
			this.Filter.BackColor = System.Drawing.Color.Teal;
			this.Filter.FlatAppearance.BorderSize = 0;
			this.Filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Filter.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Filter.ForeColor = System.Drawing.Color.White;
			this.Filter.Location = new System.Drawing.Point(1241, 529);
			this.Filter.Margin = new System.Windows.Forms.Padding(4);
			this.Filter.Name = "Filter";
			this.Filter.Size = new System.Drawing.Size(169, 52);
			this.Filter.TabIndex = 140;
			this.Filter.Text = "Filter";
			this.Filter.UseVisualStyleBackColor = false;
			this.Filter.Click += new System.EventHandler(this.Filter_Click);
			// 
			// updatecoursetime
			// 
			this.updatecoursetime.BackColor = System.Drawing.Color.Teal;
			this.updatecoursetime.FlatAppearance.BorderSize = 0;
			this.updatecoursetime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.updatecoursetime.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.updatecoursetime.ForeColor = System.Drawing.Color.White;
			this.updatecoursetime.Location = new System.Drawing.Point(49, 558);
			this.updatecoursetime.Margin = new System.Windows.Forms.Padding(4);
			this.updatecoursetime.Name = "updatecoursetime";
			this.updatecoursetime.Size = new System.Drawing.Size(268, 75);
			this.updatecoursetime.TabIndex = 141;
			this.updatecoursetime.Text = "Update Course Time";
			this.updatecoursetime.UseVisualStyleBackColor = false;
			this.updatecoursetime.Click += new System.EventHandler(this.updatecoursetime_Click);
			// 
			// warn
			// 
			this.warn.AutoSize = true;
			this.warn.ForeColor = System.Drawing.Color.Red;
			this.warn.Location = new System.Drawing.Point(1187, 676);
			this.warn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.warn.Name = "warn";
			this.warn.Size = new System.Drawing.Size(0, 17);
			this.warn.TabIndex = 142;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.ForeColor = System.Drawing.Color.Red;
			this.label8.Location = new System.Drawing.Point(1297, 585);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(112, 17);
			this.label8.TabIndex = 143;
			this.label8.Text = "*By Department*";
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
			this.depcombobox.Location = new System.Drawing.Point(272, 437);
			this.depcombobox.Margin = new System.Windows.Forms.Padding(4);
			this.depcombobox.Name = "depcombobox";
			this.depcombobox.Size = new System.Drawing.Size(187, 31);
			this.depcombobox.TabIndex = 137;
			// 
			// deletecourse
			// 
			this.deletecourse.BackColor = System.Drawing.Color.Teal;
			this.deletecourse.FlatAppearance.BorderSize = 0;
			this.deletecourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deletecourse.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deletecourse.ForeColor = System.Drawing.Color.White;
			this.deletecourse.Location = new System.Drawing.Point(49, 654);
			this.deletecourse.Margin = new System.Windows.Forms.Padding(4);
			this.deletecourse.Name = "deletecourse";
			this.deletecourse.Size = new System.Drawing.Size(268, 52);
			this.deletecourse.TabIndex = 144;
			this.deletecourse.Text = "Delete Course";
			this.deletecourse.UseVisualStyleBackColor = false;
			this.deletecourse.Click += new System.EventHandler(this.deletecourse_Click);
			// 
			// preqbutton
			// 
			this.preqbutton.BackColor = System.Drawing.Color.Teal;
			this.preqbutton.FlatAppearance.BorderSize = 0;
			this.preqbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.preqbutton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.preqbutton.ForeColor = System.Drawing.Color.White;
			this.preqbutton.Location = new System.Drawing.Point(49, 726);
			this.preqbutton.Margin = new System.Windows.Forms.Padding(4);
			this.preqbutton.Name = "preqbutton";
			this.preqbutton.Size = new System.Drawing.Size(268, 52);
			this.preqbutton.TabIndex = 145;
			this.preqbutton.Text = "Add Prerequisite";
			this.preqbutton.UseVisualStyleBackColor = false;
			this.preqbutton.Click += new System.EventHandler(this.preqbutton_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.ForeColor = System.Drawing.Color.Red;
			this.label9.Location = new System.Drawing.Point(151, 793);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(164, 17);
			this.label9.TabIndex = 146;
			this.label9.Text = "*Check Prerequisite Box*";
			// 
			// preqtable
			// 
			this.preqtable.AllowUserToAddRows = false;
			this.preqtable.AllowUserToDeleteRows = false;
			this.preqtable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.preqtable.BackgroundColor = System.Drawing.Color.Silver;
			this.preqtable.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.preqtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.preqtable.Location = new System.Drawing.Point(747, 654);
			this.preqtable.Margin = new System.Windows.Forms.Padding(4);
			this.preqtable.Name = "preqtable";
			this.preqtable.ReadOnly = true;
			this.preqtable.RowHeadersWidth = 51;
			this.preqtable.Size = new System.Drawing.Size(715, 283);
			this.preqtable.TabIndex = 147;
			this.preqtable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.preqtable_CellContentClick);
			// 
			// preqlabel
			// 
			this.preqlabel.AutoSize = true;
			this.preqlabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.preqlabel.ForeColor = System.Drawing.Color.Teal;
			this.preqlabel.Location = new System.Drawing.Point(957, 610);
			this.preqlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.preqlabel.Name = "preqlabel";
			this.preqlabel.Size = new System.Drawing.Size(280, 40);
			this.preqlabel.TabIndex = 148;
			this.preqlabel.Text = "Prerequisites List";
			this.preqlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// search
			// 
			this.search.BackColor = System.Drawing.Color.Teal;
			this.search.FlatAppearance.BorderSize = 0;
			this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.search.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.search.ForeColor = System.Drawing.Color.White;
			this.search.Location = new System.Drawing.Point(1224, 119);
			this.search.Margin = new System.Windows.Forms.Padding(4);
			this.search.Name = "search";
			this.search.Size = new System.Drawing.Size(169, 52);
			this.search.TabIndex = 149;
			this.search.Text = "Search";
			this.search.UseVisualStyleBackColor = false;
			this.search.Click += new System.EventHandler(this.search_Click);
			// 
			// cnamesearch
			// 
			this.cnamesearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cnamesearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cnamesearch.DisplayMember = "DepID";
			this.cnamesearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cnamesearch.FormattingEnabled = true;
			this.cnamesearch.Location = new System.Drawing.Point(989, 133);
			this.cnamesearch.Margin = new System.Windows.Forms.Padding(4);
			this.cnamesearch.Name = "cnamesearch";
			this.cnamesearch.Size = new System.Drawing.Size(187, 31);
			this.cnamesearch.TabIndex = 150;
			// 
			// credithourstextbox
			// 
			this.credithourstextbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.credithourstextbox.Location = new System.Drawing.Point(272, 220);
			this.credithourstextbox.Margin = new System.Windows.Forms.Padding(4);
			this.credithourstextbox.MaxLength = 4;
			this.credithourstextbox.Name = "credithourstextbox";
			this.credithourstextbox.ReadOnly = true;
			this.credithourstextbox.Size = new System.Drawing.Size(187, 30);
			this.credithourstextbox.TabIndex = 151;
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
			this.returnbutton.Location = new System.Drawing.Point(-4, 824);
			this.returnbutton.Margin = new System.Windows.Forms.Padding(4);
			this.returnbutton.Name = "returnbutton";
			this.returnbutton.Size = new System.Drawing.Size(72, 64);
			this.returnbutton.TabIndex = 118;
			this.returnbutton.UseVisualStyleBackColor = false;
			this.returnbutton.Click += new System.EventHandler(this.returnbutton_Click);
			// 
			// Manage_Courses
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(1547, 974);
			this.Controls.Add(this.credithourstextbox);
			this.Controls.Add(this.cnamesearch);
			this.Controls.Add(this.search);
			this.Controls.Add(this.preqlabel);
			this.Controls.Add(this.preqtable);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.preqbutton);
			this.Controls.Add(this.deletecourse);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.warn);
			this.Controls.Add(this.updatecoursetime);
			this.Controls.Add(this.Filter);
			this.Controls.Add(this.preqcombobox);
			this.Controls.Add(this.preqcheckBox);
			this.Controls.Add(this.depcombobox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.daycombobox);
			this.Controls.Add(this.endhour);
			this.Controls.Add(this.show);
			this.Controls.Add(this.courses);
			this.Controls.Add(this.starthour);
			this.Controls.Add(this.courseidtextbox);
			this.Controls.Add(this.coursenametextbox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.returnbutton);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.addcourse);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Manage_Courses";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Manage_Courses";
			this.Load += new System.EventHandler(this.Manage_Courses_Load);
			((System.ComponentModel.ISupportInitialize)(this.courses)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.preqtable)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox daycombobox;
		private System.Windows.Forms.DateTimePicker endhour;
		private System.Windows.Forms.Button show;
		private System.Windows.Forms.DataGridView courses;
		private System.Windows.Forms.DateTimePicker starthour;
		private System.Windows.Forms.TextBox courseidtextbox;
		private System.Windows.Forms.TextBox coursenametextbox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button returnbutton;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label addcourse;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox preqcheckBox;
		private System.Windows.Forms.ComboBox preqcombobox;
		private System.Windows.Forms.Button Filter;
		private System.Windows.Forms.Button updatecoursetime;
		private System.Windows.Forms.Label warn;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox depcombobox;
		private System.Windows.Forms.Button deletecourse;
		private System.Windows.Forms.Button preqbutton;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DataGridView preqtable;
		private System.Windows.Forms.Label preqlabel;
		private System.Windows.Forms.Button search;
		private System.Windows.Forms.ComboBox cnamesearch;
		private System.Windows.Forms.TextBox credithourstextbox;
	}
}