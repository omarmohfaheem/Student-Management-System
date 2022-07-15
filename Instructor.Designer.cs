
namespace Student_Management_System_Project
{
	partial class Instructor
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
			this.label11 = new System.Windows.Forms.Label();
			this.clearbutton = new System.Windows.Forms.Button();
			this.savebutton = new System.Windows.Forms.Button();
			this.instructorlist = new System.Windows.Forms.DataGridView();
			this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.minit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.uname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.femaleradiobutton = new System.Windows.Forms.RadioButton();
			this.maleradiobutton = new System.Windows.Forms.RadioButton();
			this.salarytextbox = new System.Windows.Forms.TextBox();
			this.idtextbox = new System.Windows.Forms.TextBox();
			this.lnametextbox = new System.Windows.Forms.TextBox();
			this.minittextbox = new System.Windows.Forms.TextBox();
			this.fnametextbox = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.studentregister = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.returnbutton = new System.Windows.Forms.Button();
			this.usernametextbox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.instructorlist)).BeginInit();
			this.SuspendLayout();
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.Teal;
			this.label11.Location = new System.Drawing.Point(795, 140);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(390, 40);
			this.label11.TabIndex = 86;
			this.label11.Text = "New Added Instructors";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// clearbutton
			// 
			this.clearbutton.BackColor = System.Drawing.Color.Teal;
			this.clearbutton.FlatAppearance.BorderSize = 0;
			this.clearbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.clearbutton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clearbutton.ForeColor = System.Drawing.Color.White;
			this.clearbutton.Location = new System.Drawing.Point(1055, 656);
			this.clearbutton.Margin = new System.Windows.Forms.Padding(4);
			this.clearbutton.Name = "clearbutton";
			this.clearbutton.Size = new System.Drawing.Size(100, 52);
			this.clearbutton.TabIndex = 85;
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
			this.savebutton.Location = new System.Drawing.Point(947, 656);
			this.savebutton.Margin = new System.Windows.Forms.Padding(4);
			this.savebutton.Name = "savebutton";
			this.savebutton.Size = new System.Drawing.Size(100, 52);
			this.savebutton.TabIndex = 84;
			this.savebutton.Text = "Save";
			this.savebutton.UseVisualStyleBackColor = false;
			this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
			// 
			// instructorlist
			// 
			this.instructorlist.AllowUserToAddRows = false;
			this.instructorlist.AllowUserToDeleteRows = false;
			this.instructorlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.instructorlist.BackgroundColor = System.Drawing.Color.Silver;
			this.instructorlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.instructorlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.instructorlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fname,
            this.minit,
            this.lname,
            this.ID,
            this.uname,
            this.gender,
            this.salary});
			this.instructorlist.GridColor = System.Drawing.Color.Silver;
			this.instructorlist.Location = new System.Drawing.Point(487, 191);
			this.instructorlist.Margin = new System.Windows.Forms.Padding(4);
			this.instructorlist.Name = "instructorlist";
			this.instructorlist.ReadOnly = true;
			this.instructorlist.RowHeadersWidth = 51;
			this.instructorlist.Size = new System.Drawing.Size(892, 438);
			this.instructorlist.TabIndex = 83;
			this.instructorlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.instructorlist_CellContentClick);
			// 
			// fname
			// 
			this.fname.HeaderText = "First Name";
			this.fname.MinimumWidth = 6;
			this.fname.Name = "fname";
			this.fname.ReadOnly = true;
			// 
			// minit
			// 
			this.minit.HeaderText = "Middle Initial";
			this.minit.MinimumWidth = 6;
			this.minit.Name = "minit";
			this.minit.ReadOnly = true;
			// 
			// lname
			// 
			this.lname.HeaderText = "Last Name";
			this.lname.MinimumWidth = 6;
			this.lname.Name = "lname";
			this.lname.ReadOnly = true;
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.MinimumWidth = 6;
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			// 
			// uname
			// 
			this.uname.HeaderText = "Username";
			this.uname.MinimumWidth = 6;
			this.uname.Name = "uname";
			this.uname.ReadOnly = true;
			// 
			// gender
			// 
			this.gender.HeaderText = "Gender";
			this.gender.MinimumWidth = 6;
			this.gender.Name = "gender";
			this.gender.ReadOnly = true;
			// 
			// salary
			// 
			this.salary.HeaderText = "Salary";
			this.salary.MinimumWidth = 6;
			this.salary.Name = "salary";
			this.salary.ReadOnly = true;
			// 
			// femaleradiobutton
			// 
			this.femaleradiobutton.AutoSize = true;
			this.femaleradiobutton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.femaleradiobutton.ForeColor = System.Drawing.Color.Teal;
			this.femaleradiobutton.Location = new System.Drawing.Point(260, 468);
			this.femaleradiobutton.Margin = new System.Windows.Forms.Padding(4);
			this.femaleradiobutton.Name = "femaleradiobutton";
			this.femaleradiobutton.Size = new System.Drawing.Size(91, 23);
			this.femaleradiobutton.TabIndex = 81;
			this.femaleradiobutton.TabStop = true;
			this.femaleradiobutton.Text = "Female";
			this.femaleradiobutton.UseVisualStyleBackColor = true;
			// 
			// maleradiobutton
			// 
			this.maleradiobutton.AutoSize = true;
			this.maleradiobutton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.maleradiobutton.ForeColor = System.Drawing.Color.Teal;
			this.maleradiobutton.Location = new System.Drawing.Point(181, 468);
			this.maleradiobutton.Margin = new System.Windows.Forms.Padding(4);
			this.maleradiobutton.Name = "maleradiobutton";
			this.maleradiobutton.Size = new System.Drawing.Size(71, 23);
			this.maleradiobutton.TabIndex = 80;
			this.maleradiobutton.TabStop = true;
			this.maleradiobutton.Text = "Male";
			this.maleradiobutton.UseVisualStyleBackColor = true;
			// 
			// salarytextbox
			// 
			this.salarytextbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.salarytextbox.Location = new System.Drawing.Point(174, 519);
			this.salarytextbox.Margin = new System.Windows.Forms.Padding(4);
			this.salarytextbox.MaxLength = 11;
			this.salarytextbox.Name = "salarytextbox";
			this.salarytextbox.Size = new System.Drawing.Size(181, 30);
			this.salarytextbox.TabIndex = 78;
			// 
			// idtextbox
			// 
			this.idtextbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.idtextbox.Location = new System.Drawing.Point(104, 414);
			this.idtextbox.Margin = new System.Windows.Forms.Padding(4);
			this.idtextbox.MaxLength = 7;
			this.idtextbox.Name = "idtextbox";
			this.idtextbox.Size = new System.Drawing.Size(112, 30);
			this.idtextbox.TabIndex = 77;
			// 
			// lnametextbox
			// 
			this.lnametextbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lnametextbox.Location = new System.Drawing.Point(217, 308);
			this.lnametextbox.Margin = new System.Windows.Forms.Padding(4);
			this.lnametextbox.MaxLength = 13;
			this.lnametextbox.Name = "lnametextbox";
			this.lnametextbox.Size = new System.Drawing.Size(181, 30);
			this.lnametextbox.TabIndex = 76;
			// 
			// minittextbox
			// 
			this.minittextbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.minittextbox.Location = new System.Drawing.Point(240, 260);
			this.minittextbox.Margin = new System.Windows.Forms.Padding(4);
			this.minittextbox.MaxLength = 1;
			this.minittextbox.Name = "minittextbox";
			this.minittextbox.Size = new System.Drawing.Size(45, 30);
			this.minittextbox.TabIndex = 75;
			// 
			// fnametextbox
			// 
			this.fnametextbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fnametextbox.Location = new System.Drawing.Point(217, 210);
			this.fnametextbox.Margin = new System.Windows.Forms.Padding(4);
			this.fnametextbox.MaxLength = 13;
			this.fnametextbox.Name = "fnametextbox";
			this.fnametextbox.Size = new System.Drawing.Size(181, 30);
			this.fnametextbox.TabIndex = 74;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Teal;
			this.label10.Location = new System.Drawing.Point(37, 462);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(131, 32);
			this.label10.TabIndex = 72;
			this.label10.Text = "Gender :";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Teal;
			this.label8.Location = new System.Drawing.Point(38, 411);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(58, 32);
			this.label8.TabIndex = 70;
			this.label8.Text = "ID :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Teal;
			this.label5.Location = new System.Drawing.Point(36, 306);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(169, 32);
			this.label5.TabIndex = 66;
			this.label5.Text = "Last Name :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Teal;
			this.label4.Location = new System.Drawing.Point(37, 516);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 32);
			this.label4.TabIndex = 65;
			this.label4.Text = "Salary :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Teal;
			this.label3.Location = new System.Drawing.Point(36, 257);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(196, 32);
			this.label3.TabIndex = 64;
			this.label3.Text = "Middle Initial :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Teal;
			this.label2.Location = new System.Drawing.Point(36, 210);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(167, 32);
			this.label2.TabIndex = 63;
			this.label2.Text = "First Name :";
			// 
			// studentregister
			// 
			this.studentregister.AutoSize = true;
			this.studentregister.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.studentregister.ForeColor = System.Drawing.Color.DimGray;
			this.studentregister.Location = new System.Drawing.Point(516, 49);
			this.studentregister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.studentregister.Name = "studentregister";
			this.studentregister.Size = new System.Drawing.Size(331, 40);
			this.studentregister.TabIndex = 61;
			this.studentregister.Text = "Add New Instructor";
			this.studentregister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Teal;
			this.panel1.ForeColor = System.Drawing.Color.Teal;
			this.panel1.Location = new System.Drawing.Point(43, 127);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1467, 5);
			this.panel1.TabIndex = 60;
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
			this.returnbutton.Location = new System.Drawing.Point(1, 662);
			this.returnbutton.Margin = new System.Windows.Forms.Padding(4);
			this.returnbutton.Name = "returnbutton";
			this.returnbutton.Size = new System.Drawing.Size(72, 64);
			this.returnbutton.TabIndex = 73;
			this.returnbutton.UseVisualStyleBackColor = false;
			this.returnbutton.Click += new System.EventHandler(this.returnbutton_Click);
			// 
			// usernametextbox
			// 
			this.usernametextbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usernametextbox.Location = new System.Drawing.Point(219, 357);
			this.usernametextbox.Margin = new System.Windows.Forms.Padding(4);
			this.usernametextbox.MaxLength = 13;
			this.usernametextbox.Name = "usernametextbox";
			this.usernametextbox.Size = new System.Drawing.Size(181, 30);
			this.usernametextbox.TabIndex = 92;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Teal;
			this.label6.Location = new System.Drawing.Point(38, 358);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(163, 32);
			this.label6.TabIndex = 91;
			this.label6.Text = "Username :";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(74, 366);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(46, 17);
			this.label7.TabIndex = 90;
			this.label7.Text = "label7";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(72, 218);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 17);
			this.label1.TabIndex = 62;
			this.label1.Text = "label1";
			// 
			// Instructor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(1412, 721);
			this.Controls.Add(this.returnbutton);
			this.Controls.Add(this.usernametextbox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.clearbutton);
			this.Controls.Add(this.savebutton);
			this.Controls.Add(this.instructorlist);
			this.Controls.Add(this.femaleradiobutton);
			this.Controls.Add(this.maleradiobutton);
			this.Controls.Add(this.salarytextbox);
			this.Controls.Add(this.idtextbox);
			this.Controls.Add(this.lnametextbox);
			this.Controls.Add(this.minittextbox);
			this.Controls.Add(this.fnametextbox);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.studentregister);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Instructor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Instructor";
			this.Load += new System.EventHandler(this.Instructor_Load);
			((System.ComponentModel.ISupportInitialize)(this.instructorlist)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button clearbutton;
		private System.Windows.Forms.Button savebutton;
		private System.Windows.Forms.DataGridView instructorlist;
		private System.Windows.Forms.RadioButton femaleradiobutton;
		private System.Windows.Forms.RadioButton maleradiobutton;
		private System.Windows.Forms.TextBox salarytextbox;
		private System.Windows.Forms.TextBox idtextbox;
		private System.Windows.Forms.TextBox lnametextbox;
		private System.Windows.Forms.TextBox minittextbox;
		private System.Windows.Forms.TextBox fnametextbox;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label studentregister;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button returnbutton;
		private System.Windows.Forms.TextBox usernametextbox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn fname;
		private System.Windows.Forms.DataGridViewTextBoxColumn minit;
		private System.Windows.Forms.DataGridViewTextBoxColumn lname;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn uname;
		private System.Windows.Forms.DataGridViewTextBoxColumn gender;
		private System.Windows.Forms.DataGridViewTextBoxColumn salary;
	}
}