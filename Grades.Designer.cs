
namespace Student_Management_System_Project
{
	partial class Grades
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
			this.gradeslist = new System.Windows.Forms.DataGridView();
			this.studentidcombobox = new System.Windows.Forms.ComboBox();
			this.coursecredithourstextbox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.courseidtextbox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.coursenamecombobox = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.addcourse = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.nametextbox = new System.Windows.Forms.TextBox();
			this.gradecombobox = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.totalcr = new System.Windows.Forms.Button();
			this.assigngrade = new System.Windows.Forms.Button();
			this.warn = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.returnbutton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gradeslist)).BeginInit();
			this.SuspendLayout();
			// 
			// gradeslist
			// 
			this.gradeslist.AllowUserToAddRows = false;
			this.gradeslist.AllowUserToDeleteRows = false;
			this.gradeslist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gradeslist.BackgroundColor = System.Drawing.Color.Silver;
			this.gradeslist.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.gradeslist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gradeslist.Location = new System.Drawing.Point(554, 128);
			this.gradeslist.Margin = new System.Windows.Forms.Padding(4);
			this.gradeslist.Name = "gradeslist";
			this.gradeslist.ReadOnly = true;
			this.gradeslist.RowHeadersWidth = 51;
			this.gradeslist.Size = new System.Drawing.Size(442, 297);
			this.gradeslist.TabIndex = 127;
			this.gradeslist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeslist_CellContentClick);
			// 
			// studentidcombobox
			// 
			this.studentidcombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.studentidcombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.studentidcombobox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.studentidcombobox.FormattingEnabled = true;
			this.studentidcombobox.Location = new System.Drawing.Point(273, 128);
			this.studentidcombobox.Margin = new System.Windows.Forms.Padding(4);
			this.studentidcombobox.Name = "studentidcombobox";
			this.studentidcombobox.Size = new System.Drawing.Size(201, 31);
			this.studentidcombobox.TabIndex = 149;
			this.studentidcombobox.SelectedIndexChanged += new System.EventHandler(this.studentidcombobox_SelectedIndexChanged);
			// 
			// coursecredithourstextbox
			// 
			this.coursecredithourstextbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.coursecredithourstextbox.Location = new System.Drawing.Point(273, 368);
			this.coursecredithourstextbox.Margin = new System.Windows.Forms.Padding(4);
			this.coursecredithourstextbox.MaxLength = 4;
			this.coursecredithourstextbox.Name = "coursecredithourstextbox";
			this.coursecredithourstextbox.ReadOnly = true;
			this.coursecredithourstextbox.Size = new System.Drawing.Size(201, 30);
			this.coursecredithourstextbox.TabIndex = 148;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Teal;
			this.label5.Location = new System.Drawing.Point(31, 340);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(188, 96);
			this.label5.TabIndex = 147;
			this.label5.Text = "Total \r\nCredit Hours \r\nfor a Student:";
			// 
			// courseidtextbox
			// 
			this.courseidtextbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.courseidtextbox.Location = new System.Drawing.Point(273, 297);
			this.courseidtextbox.Margin = new System.Windows.Forms.Padding(4);
			this.courseidtextbox.MaxLength = 4;
			this.courseidtextbox.Name = "courseidtextbox";
			this.courseidtextbox.ReadOnly = true;
			this.courseidtextbox.Size = new System.Drawing.Size(201, 30);
			this.courseidtextbox.TabIndex = 146;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Teal;
			this.label1.Location = new System.Drawing.Point(36, 295);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(158, 32);
			this.label1.TabIndex = 145;
			this.label1.Text = "Course ID :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Teal;
			this.label3.Location = new System.Drawing.Point(26, 128);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(163, 32);
			this.label3.TabIndex = 144;
			this.label3.Text = "Student ID :";
			// 
			// coursenamecombobox
			// 
			this.coursenamecombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.coursenamecombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.coursenamecombobox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.coursenamecombobox.FormattingEnabled = true;
			this.coursenamecombobox.Location = new System.Drawing.Point(273, 242);
			this.coursenamecombobox.Margin = new System.Windows.Forms.Padding(4);
			this.coursenamecombobox.Name = "coursenamecombobox";
			this.coursenamecombobox.Size = new System.Drawing.Size(201, 31);
			this.coursenamecombobox.TabIndex = 151;
			this.coursenamecombobox.SelectedIndexChanged += new System.EventHandler(this.coursenamecombobox_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Teal;
			this.label4.Location = new System.Drawing.Point(31, 239);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(203, 32);
			this.label4.TabIndex = 150;
			this.label4.Text = "Course Name:";
			// 
			// addcourse
			// 
			this.addcourse.AutoSize = true;
			this.addcourse.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addcourse.ForeColor = System.Drawing.Color.DimGray;
			this.addcourse.Location = new System.Drawing.Point(390, 18);
			this.addcourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.addcourse.Name = "addcourse";
			this.addcourse.Size = new System.Drawing.Size(270, 40);
			this.addcourse.TabIndex = 153;
			this.addcourse.Text = "Student Grades";
			this.addcourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Teal;
			this.panel1.ForeColor = System.Drawing.Color.Teal;
			this.panel1.Location = new System.Drawing.Point(-150, 76);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1368, 6);
			this.panel1.TabIndex = 152;
			// 
			// nametextbox
			// 
			this.nametextbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nametextbox.Location = new System.Drawing.Point(273, 184);
			this.nametextbox.Margin = new System.Windows.Forms.Padding(4);
			this.nametextbox.MaxLength = 4;
			this.nametextbox.Name = "nametextbox";
			this.nametextbox.ReadOnly = true;
			this.nametextbox.Size = new System.Drawing.Size(201, 30);
			this.nametextbox.TabIndex = 154;
			// 
			// gradecombobox
			// 
			this.gradecombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.gradecombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.gradecombobox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gradecombobox.FormattingEnabled = true;
			this.gradecombobox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "U",
            "W"});
			this.gradecombobox.Location = new System.Drawing.Point(273, 448);
			this.gradecombobox.Margin = new System.Windows.Forms.Padding(4);
			this.gradecombobox.Name = "gradecombobox";
			this.gradecombobox.Size = new System.Drawing.Size(201, 31);
			this.gradecombobox.TabIndex = 156;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Teal;
			this.label2.Location = new System.Drawing.Point(31, 448);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(108, 32);
			this.label2.TabIndex = 155;
			this.label2.Text = "Grade:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Teal;
			this.label6.Location = new System.Drawing.Point(26, 184);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(216, 32);
			this.label6.TabIndex = 157;
			this.label6.Text = "Student Name :";
			// 
			// totalcr
			// 
			this.totalcr.BackColor = System.Drawing.Color.Teal;
			this.totalcr.FlatAppearance.BorderSize = 0;
			this.totalcr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.totalcr.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.totalcr.ForeColor = System.Drawing.Color.White;
			this.totalcr.Location = new System.Drawing.Point(742, 439);
			this.totalcr.Margin = new System.Windows.Forms.Padding(4);
			this.totalcr.Name = "totalcr";
			this.totalcr.Size = new System.Drawing.Size(254, 80);
			this.totalcr.TabIndex = 158;
			this.totalcr.Text = "Total Credit \r\nHours";
			this.totalcr.UseVisualStyleBackColor = false;
			this.totalcr.Click += new System.EventHandler(this.totalcr_Click);
			// 
			// assigngrade
			// 
			this.assigngrade.BackColor = System.Drawing.Color.Teal;
			this.assigngrade.FlatAppearance.BorderSize = 0;
			this.assigngrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.assigngrade.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.assigngrade.ForeColor = System.Drawing.Color.White;
			this.assigngrade.Location = new System.Drawing.Point(273, 490);
			this.assigngrade.Margin = new System.Windows.Forms.Padding(4);
			this.assigngrade.Name = "assigngrade";
			this.assigngrade.Size = new System.Drawing.Size(215, 41);
			this.assigngrade.TabIndex = 159;
			this.assigngrade.Text = "Assign Grade";
			this.assigngrade.UseVisualStyleBackColor = false;
			this.assigngrade.Click += new System.EventHandler(this.assigngrade_Click);
			// 
			// warn
			// 
			this.warn.AutoSize = true;
			this.warn.ForeColor = System.Drawing.Color.Red;
			this.warn.Location = new System.Drawing.Point(845, 524);
			this.warn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.warn.Name = "warn";
			this.warn.Size = new System.Drawing.Size(151, 17);
			this.warn.TabIndex = 160;
			this.warn.Text = "*CHECK STUDENT ID*";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.ForeColor = System.Drawing.Color.Red;
			this.label7.Location = new System.Drawing.Point(254, 535);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(246, 17);
			this.label7.TabIndex = 161;
			this.label7.Text = "*CHECK STUDENT ID AND COURSE*";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Teal;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(256, 567);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(244, 41);
			this.button1.TabIndex = 163;
			this.button1.Text = "Course Statistics";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
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
			this.returnbutton.Location = new System.Drawing.Point(2, 589);
			this.returnbutton.Margin = new System.Windows.Forms.Padding(4);
			this.returnbutton.Name = "returnbutton";
			this.returnbutton.Size = new System.Drawing.Size(80, 144);
			this.returnbutton.TabIndex = 162;
			this.returnbutton.UseVisualStyleBackColor = false;
			this.returnbutton.Click += new System.EventHandler(this.returnbutton_Click);
			// 
			// Grades
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(1072, 661);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.returnbutton);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.warn);
			this.Controls.Add(this.assigngrade);
			this.Controls.Add(this.totalcr);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.gradecombobox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.nametextbox);
			this.Controls.Add(this.addcourse);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.coursenamecombobox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.studentidcombobox);
			this.Controls.Add(this.coursecredithourstextbox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.courseidtextbox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.gradeslist);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Grades";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Grades";
			this.Load += new System.EventHandler(this.Grades_Load);
			((System.ComponentModel.ISupportInitialize)(this.gradeslist)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView gradeslist;
		private System.Windows.Forms.ComboBox studentidcombobox;
		private System.Windows.Forms.TextBox coursecredithourstextbox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox courseidtextbox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox coursenamecombobox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label addcourse;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox nametextbox;
		private System.Windows.Forms.ComboBox gradecombobox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button totalcr;
		private System.Windows.Forms.Button assigngrade;
		private System.Windows.Forms.Label warn;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button returnbutton;
		private System.Windows.Forms.Button button1;
	}
}