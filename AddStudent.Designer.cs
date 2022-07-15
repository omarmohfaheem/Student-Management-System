
namespace Student_Management_System_Project
{
	partial class AddStudent
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
			this.classcombobox = new System.Windows.Forms.ComboBox();
			this.depnamecombobox = new System.Windows.Forms.ComboBox();
			this.dobstudent = new System.Windows.Forms.DateTimePicker();
			this.femaleradiobutton = new System.Windows.Forms.RadioButton();
			this.maleradiobutton = new System.Windows.Forms.RadioButton();
			this.phonetextbox = new System.Windows.Forms.TextBox();
			this.idtextbox = new System.Windows.Forms.TextBox();
			this.lnametextbox = new System.Windows.Forms.TextBox();
			this.minittextbox = new System.Windows.Forms.TextBox();
			this.fnametextbox = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.clearbutton = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.newstds = new System.Windows.Forms.DataGridView();
			this.Fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.minit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label11 = new System.Windows.Forms.Label();
			this.addcourse = new System.Windows.Forms.Label();
			this.returnbutton = new System.Windows.Forms.Button();
			this.savebutton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.newstds)).BeginInit();
			this.SuspendLayout();
			// 
			// classcombobox
			// 
			this.classcombobox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.classcombobox.FormattingEnabled = true;
			this.classcombobox.Items.AddRange(new object[] {
            "Freshman",
            "Sophomore",
            "Junior",
            "Senior"});
			this.classcombobox.Location = new System.Drawing.Point(137, 534);
			this.classcombobox.Margin = new System.Windows.Forms.Padding(4);
			this.classcombobox.Name = "classcombobox";
			this.classcombobox.Size = new System.Drawing.Size(160, 31);
			this.classcombobox.TabIndex = 80;
			// 
			// depnamecombobox
			// 
			this.depnamecombobox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.depnamecombobox.FormattingEnabled = true;
			this.depnamecombobox.Location = new System.Drawing.Point(221, 485);
			this.depnamecombobox.Margin = new System.Windows.Forms.Padding(4);
			this.depnamecombobox.Name = "depnamecombobox";
			this.depnamecombobox.Size = new System.Drawing.Size(160, 31);
			this.depnamecombobox.TabIndex = 79;
			// 
			// dobstudent
			// 
			this.dobstudent.Cursor = System.Windows.Forms.Cursors.Default;
			this.dobstudent.CustomFormat = "yyyy-MM-dd";
			this.dobstudent.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dobstudent.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dobstudent.Location = new System.Drawing.Point(221, 385);
			this.dobstudent.Margin = new System.Windows.Forms.Padding(4);
			this.dobstudent.MaxDate = new System.DateTime(2022, 2, 1, 0, 0, 0, 0);
			this.dobstudent.Name = "dobstudent";
			this.dobstudent.Size = new System.Drawing.Size(168, 30);
			this.dobstudent.TabIndex = 78;
			this.dobstudent.Value = new System.DateTime(2021, 12, 29, 0, 0, 0, 0);
			// 
			// femaleradiobutton
			// 
			this.femaleradiobutton.AutoSize = true;
			this.femaleradiobutton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.femaleradiobutton.ForeColor = System.Drawing.Color.Teal;
			this.femaleradiobutton.Location = new System.Drawing.Point(255, 343);
			this.femaleradiobutton.Margin = new System.Windows.Forms.Padding(4);
			this.femaleradiobutton.Name = "femaleradiobutton";
			this.femaleradiobutton.Size = new System.Drawing.Size(91, 23);
			this.femaleradiobutton.TabIndex = 77;
			this.femaleradiobutton.TabStop = true;
			this.femaleradiobutton.Text = "Female";
			this.femaleradiobutton.UseVisualStyleBackColor = true;
			// 
			// maleradiobutton
			// 
			this.maleradiobutton.AutoSize = true;
			this.maleradiobutton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.maleradiobutton.ForeColor = System.Drawing.Color.Teal;
			this.maleradiobutton.Location = new System.Drawing.Point(171, 343);
			this.maleradiobutton.Margin = new System.Windows.Forms.Padding(4);
			this.maleradiobutton.Name = "maleradiobutton";
			this.maleradiobutton.Size = new System.Drawing.Size(71, 23);
			this.maleradiobutton.TabIndex = 76;
			this.maleradiobutton.TabStop = true;
			this.maleradiobutton.Text = "Male";
			this.maleradiobutton.UseVisualStyleBackColor = true;
			// 
			// phonetextbox
			// 
			this.phonetextbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.phonetextbox.Location = new System.Drawing.Point(152, 436);
			this.phonetextbox.Margin = new System.Windows.Forms.Padding(4);
			this.phonetextbox.MaxLength = 11;
			this.phonetextbox.Name = "phonetextbox";
			this.phonetextbox.Size = new System.Drawing.Size(141, 30);
			this.phonetextbox.TabIndex = 75;
			this.phonetextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phonetextbox_KeyPress);
			// 
			// idtextbox
			// 
			this.idtextbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.idtextbox.Location = new System.Drawing.Point(95, 288);
			this.idtextbox.Margin = new System.Windows.Forms.Padding(4);
			this.idtextbox.MaxLength = 7;
			this.idtextbox.Name = "idtextbox";
			this.idtextbox.Size = new System.Drawing.Size(125, 30);
			this.idtextbox.TabIndex = 74;
			this.idtextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idtextbox_KeyPress);
			// 
			// lnametextbox
			// 
			this.lnametextbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lnametextbox.Location = new System.Drawing.Point(208, 238);
			this.lnametextbox.Margin = new System.Windows.Forms.Padding(4);
			this.lnametextbox.MaxLength = 13;
			this.lnametextbox.Name = "lnametextbox";
			this.lnametextbox.Size = new System.Drawing.Size(181, 30);
			this.lnametextbox.TabIndex = 73;
			this.lnametextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lnametextbox_KeyPress);
			// 
			// minittextbox
			// 
			this.minittextbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.minittextbox.Location = new System.Drawing.Point(240, 190);
			this.minittextbox.Margin = new System.Windows.Forms.Padding(4);
			this.minittextbox.MaxLength = 1;
			this.minittextbox.Name = "minittextbox";
			this.minittextbox.Size = new System.Drawing.Size(36, 30);
			this.minittextbox.TabIndex = 72;
			this.minittextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minittextbox_KeyPress);
			// 
			// fnametextbox
			// 
			this.fnametextbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fnametextbox.Location = new System.Drawing.Point(208, 140);
			this.fnametextbox.Margin = new System.Windows.Forms.Padding(4);
			this.fnametextbox.MaxLength = 13;
			this.fnametextbox.Name = "fnametextbox";
			this.fnametextbox.Size = new System.Drawing.Size(181, 30);
			this.fnametextbox.TabIndex = 71;
			this.fnametextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fnametextbox_KeyPress);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Teal;
			this.label10.Location = new System.Drawing.Point(27, 337);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(131, 32);
			this.label10.TabIndex = 70;
			this.label10.Text = "Gender :";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Teal;
			this.label9.Location = new System.Drawing.Point(27, 534);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(92, 32);
			this.label9.TabIndex = 69;
			this.label9.Text = "Year :";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Teal;
			this.label8.Location = new System.Drawing.Point(27, 288);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(58, 32);
			this.label8.TabIndex = 68;
			this.label8.Text = "ID :";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Teal;
			this.label7.Location = new System.Drawing.Point(27, 485);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(194, 32);
			this.label7.TabIndex = 67;
			this.label7.Text = "Department : ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Teal;
			this.label6.Location = new System.Drawing.Point(27, 386);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(189, 32);
			this.label6.TabIndex = 66;
			this.label6.Text = "Date of Birth :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Teal;
			this.label5.Location = new System.Drawing.Point(27, 239);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(169, 32);
			this.label5.TabIndex = 65;
			this.label5.Text = "Last Name :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Teal;
			this.label4.Location = new System.Drawing.Point(27, 436);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 32);
			this.label4.TabIndex = 64;
			this.label4.Text = "Phone :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Teal;
			this.label3.Location = new System.Drawing.Point(27, 190);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(196, 32);
			this.label3.TabIndex = 63;
			this.label3.Text = "Middle Initial :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Teal;
			this.label2.Location = new System.Drawing.Point(27, 140);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(167, 32);
			this.label2.TabIndex = 62;
			this.label2.Text = "First Name :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(63, 148);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 17);
			this.label1.TabIndex = 61;
			this.label1.Text = "label1";
			// 
			// clearbutton
			// 
			this.clearbutton.BackColor = System.Drawing.Color.Teal;
			this.clearbutton.FlatAppearance.BorderSize = 0;
			this.clearbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.clearbutton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clearbutton.ForeColor = System.Drawing.Color.White;
			this.clearbutton.Location = new System.Drawing.Point(1057, 656);
			this.clearbutton.Margin = new System.Windows.Forms.Padding(4);
			this.clearbutton.Name = "clearbutton";
			this.clearbutton.Size = new System.Drawing.Size(100, 52);
			this.clearbutton.TabIndex = 82;
			this.clearbutton.Text = "Clear";
			this.clearbutton.UseVisualStyleBackColor = false;
			this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Teal;
			this.panel1.ForeColor = System.Drawing.Color.Teal;
			this.panel1.Location = new System.Drawing.Point(33, 63);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1368, 6);
			this.panel1.TabIndex = 83;
			// 
			// newstds
			// 
			this.newstds.AllowUserToAddRows = false;
			this.newstds.AllowUserToDeleteRows = false;
			this.newstds.BackgroundColor = System.Drawing.Color.Silver;
			this.newstds.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.newstds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.newstds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fname,
            this.minit,
            this.lname,
            this.id,
            this.gender,
            this.dob,
            this.phone,
            this.dept,
            this.year});
			this.newstds.Location = new System.Drawing.Point(464, 140);
			this.newstds.Margin = new System.Windows.Forms.Padding(4);
			this.newstds.Name = "newstds";
			this.newstds.ReadOnly = true;
			this.newstds.RowHeadersWidth = 51;
			this.newstds.Size = new System.Drawing.Size(933, 486);
			this.newstds.TabIndex = 84;
			// 
			// Fname
			// 
			this.Fname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Fname.HeaderText = "First Name";
			this.Fname.MinimumWidth = 6;
			this.Fname.Name = "Fname";
			this.Fname.ReadOnly = true;
			// 
			// minit
			// 
			this.minit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.minit.HeaderText = "Middle Initial";
			this.minit.MinimumWidth = 6;
			this.minit.Name = "minit";
			this.minit.ReadOnly = true;
			// 
			// lname
			// 
			this.lname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.lname.HeaderText = "Last Name";
			this.lname.MinimumWidth = 6;
			this.lname.Name = "lname";
			this.lname.ReadOnly = true;
			// 
			// id
			// 
			this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.id.HeaderText = "ID";
			this.id.MinimumWidth = 6;
			this.id.Name = "id";
			this.id.ReadOnly = true;
			// 
			// gender
			// 
			this.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.gender.HeaderText = "Gender";
			this.gender.MinimumWidth = 6;
			this.gender.Name = "gender";
			this.gender.ReadOnly = true;
			// 
			// dob
			// 
			this.dob.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dob.HeaderText = "Date of Birth";
			this.dob.MinimumWidth = 6;
			this.dob.Name = "dob";
			this.dob.ReadOnly = true;
			// 
			// phone
			// 
			this.phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.phone.HeaderText = "Phone";
			this.phone.MinimumWidth = 6;
			this.phone.Name = "phone";
			this.phone.ReadOnly = true;
			// 
			// dept
			// 
			this.dept.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dept.HeaderText = "Department";
			this.dept.MinimumWidth = 6;
			this.dept.Name = "dept";
			this.dept.ReadOnly = true;
			// 
			// year
			// 
			this.year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.year.HeaderText = "Year";
			this.year.MinimumWidth = 6;
			this.year.Name = "year";
			this.year.ReadOnly = true;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.DimGray;
			this.label11.Location = new System.Drawing.Point(749, 90);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(361, 40);
			this.label11.TabIndex = 86;
			this.label11.Text = "New Added Students";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// addcourse
			// 
			this.addcourse.AutoSize = true;
			this.addcourse.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addcourse.ForeColor = System.Drawing.Color.DimGray;
			this.addcourse.Location = new System.Drawing.Point(603, 11);
			this.addcourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.addcourse.Name = "addcourse";
			this.addcourse.Size = new System.Drawing.Size(218, 40);
			this.addcourse.TabIndex = 29;
			this.addcourse.Text = "Add Student";
			this.addcourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			this.returnbutton.Location = new System.Drawing.Point(-4, 665);
			this.returnbutton.Margin = new System.Windows.Forms.Padding(4);
			this.returnbutton.Name = "returnbutton";
			this.returnbutton.Size = new System.Drawing.Size(71, 69);
			this.returnbutton.TabIndex = 85;
			this.returnbutton.UseVisualStyleBackColor = false;
			this.returnbutton.Click += new System.EventHandler(this.returnbutton_Click);
			// 
			// savebutton
			// 
			this.savebutton.BackColor = System.Drawing.Color.Teal;
			this.savebutton.FlatAppearance.BorderSize = 0;
			this.savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.savebutton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.savebutton.ForeColor = System.Drawing.Color.White;
			this.savebutton.Image = global::Student_Management_System_Project.Properties.Resources.output_onlinepngtools__8_;
			this.savebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.savebutton.Location = new System.Drawing.Point(899, 656);
			this.savebutton.Margin = new System.Windows.Forms.Padding(4);
			this.savebutton.Name = "savebutton";
			this.savebutton.Size = new System.Drawing.Size(151, 52);
			this.savebutton.TabIndex = 81;
			this.savebutton.Text = "Save";
			this.savebutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.savebutton.UseVisualStyleBackColor = false;
			this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
			// 
			// AddStudent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(1431, 722);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.returnbutton);
			this.Controls.Add(this.newstds);
			this.Controls.Add(this.addcourse);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.clearbutton);
			this.Controls.Add(this.savebutton);
			this.Controls.Add(this.classcombobox);
			this.Controls.Add(this.depnamecombobox);
			this.Controls.Add(this.dobstudent);
			this.Controls.Add(this.femaleradiobutton);
			this.Controls.Add(this.maleradiobutton);
			this.Controls.Add(this.phonetextbox);
			this.Controls.Add(this.idtextbox);
			this.Controls.Add(this.lnametextbox);
			this.Controls.Add(this.minittextbox);
			this.Controls.Add(this.fnametextbox);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "AddStudent";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddStudent";
			this.Load += new System.EventHandler(this.AddStudent_Load);
			((System.ComponentModel.ISupportInitialize)(this.newstds)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox classcombobox;
		private System.Windows.Forms.ComboBox depnamecombobox;
		private System.Windows.Forms.DateTimePicker dobstudent;
		private System.Windows.Forms.RadioButton femaleradiobutton;
		private System.Windows.Forms.RadioButton maleradiobutton;
		private System.Windows.Forms.TextBox phonetextbox;
		private System.Windows.Forms.TextBox idtextbox;
		private System.Windows.Forms.TextBox lnametextbox;
		private System.Windows.Forms.TextBox minittextbox;
		private System.Windows.Forms.TextBox fnametextbox;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button clearbutton;
		private System.Windows.Forms.Button savebutton;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView newstds;
		private System.Windows.Forms.Button returnbutton;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fname;
		private System.Windows.Forms.DataGridViewTextBoxColumn minit;
		private System.Windows.Forms.DataGridViewTextBoxColumn lname;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn gender;
		private System.Windows.Forms.DataGridViewTextBoxColumn dob;
		private System.Windows.Forms.DataGridViewTextBoxColumn phone;
		private System.Windows.Forms.DataGridViewTextBoxColumn dept;
		private System.Windows.Forms.DataGridViewTextBoxColumn year;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label addcourse;
	}
}