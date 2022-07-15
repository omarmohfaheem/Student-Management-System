
namespace Student_Management_System_Project
{
	partial class ManageActivity
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
			this.stuidcombbox = new System.Windows.Forms.ComboBox();
			this.activitytypecombbox = new System.Windows.Forms.ComboBox();
			this.stunametextbox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.leavebutton = new System.Windows.Forms.Button();
			this.activitybtn = new System.Windows.Forms.Button();
			this.managestds = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.studac = new System.Windows.Forms.DataGridView();
			this.returnbutton = new System.Windows.Forms.Button();
			this.warn = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.studac)).BeginInit();
			this.SuspendLayout();
			// 
			// stuidcombbox
			// 
			this.stuidcombbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.stuidcombbox.FormattingEnabled = true;
			this.stuidcombbox.Items.AddRange(new object[] {
            "Freshman",
            "Sophomore",
            "Junior",
            "Senior"});
			this.stuidcombbox.Location = new System.Drawing.Point(210, 115);
			this.stuidcombbox.Name = "stuidcombbox";
			this.stuidcombbox.Size = new System.Drawing.Size(161, 26);
			this.stuidcombbox.TabIndex = 105;
			this.stuidcombbox.SelectedIndexChanged += new System.EventHandler(this.stuidcombbox_SelectedIndexChanged);
			// 
			// activitytypecombbox
			// 
			this.activitytypecombbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.activitytypecombbox.FormattingEnabled = true;
			this.activitytypecombbox.Location = new System.Drawing.Point(210, 193);
			this.activitytypecombbox.Name = "activitytypecombbox";
			this.activitytypecombbox.Size = new System.Drawing.Size(161, 26);
			this.activitytypecombbox.TabIndex = 104;
			// 
			// stunametextbox
			// 
			this.stunametextbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.stunametextbox.Location = new System.Drawing.Point(211, 154);
			this.stunametextbox.MaxLength = 13;
			this.stunametextbox.Name = "stunametextbox";
			this.stunametextbox.ReadOnly = true;
			this.stunametextbox.Size = new System.Drawing.Size(160, 26);
			this.stunametextbox.TabIndex = 96;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Teal;
			this.label5.Location = new System.Drawing.Point(45, 193);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(99, 25);
			this.label5.TabIndex = 90;
			this.label5.Text = "Activity :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Teal;
			this.label3.Location = new System.Drawing.Point(45, 113);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(127, 25);
			this.label3.TabIndex = 88;
			this.label3.Text = "Student ID :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Teal;
			this.label2.Location = new System.Drawing.Point(45, 153);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(169, 25);
			this.label2.TabIndex = 87;
			this.label2.Text = "Student Name :";
			// 
			// leavebutton
			// 
			this.leavebutton.BackColor = System.Drawing.Color.Teal;
			this.leavebutton.FlatAppearance.BorderSize = 0;
			this.leavebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.leavebutton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.leavebutton.ForeColor = System.Drawing.Color.White;
			this.leavebutton.Location = new System.Drawing.Point(277, 310);
			this.leavebutton.Name = "leavebutton";
			this.leavebutton.Size = new System.Drawing.Size(177, 42);
			this.leavebutton.TabIndex = 107;
			this.leavebutton.Text = "Leave Activity";
			this.leavebutton.UseVisualStyleBackColor = false;
			this.leavebutton.Click += new System.EventHandler(this.leavebutton_Click);
			// 
			// activitybtn
			// 
			this.activitybtn.BackColor = System.Drawing.Color.Teal;
			this.activitybtn.FlatAppearance.BorderSize = 0;
			this.activitybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.activitybtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.activitybtn.ForeColor = System.Drawing.Color.White;
			this.activitybtn.Location = new System.Drawing.Point(277, 256);
			this.activitybtn.Name = "activitybtn";
			this.activitybtn.Size = new System.Drawing.Size(177, 42);
			this.activitybtn.TabIndex = 106;
			this.activitybtn.Text = "Join an Activity";
			this.activitybtn.UseVisualStyleBackColor = false;
			this.activitybtn.Click += new System.EventHandler(this.activitybtn_Click);
			// 
			// managestds
			// 
			this.managestds.AutoSize = true;
			this.managestds.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.managestds.ForeColor = System.Drawing.Color.DimGray;
			this.managestds.Location = new System.Drawing.Point(383, 15);
			this.managestds.Name = "managestds";
			this.managestds.Size = new System.Drawing.Size(229, 32);
			this.managestds.TabIndex = 110;
			this.managestds.Text = "Student Activites";
			this.managestds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Teal;
			this.panel1.ForeColor = System.Drawing.Color.Teal;
			this.panel1.Location = new System.Drawing.Point(-70, 57);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1150, 4);
			this.panel1.TabIndex = 109;
			// 
			// studac
			// 
			this.studac.AllowUserToAddRows = false;
			this.studac.AllowUserToDeleteRows = false;
			this.studac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.studac.BackgroundColor = System.Drawing.Color.Silver;
			this.studac.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.studac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.studac.Location = new System.Drawing.Point(485, 98);
			this.studac.Name = "studac";
			this.studac.ReadOnly = true;
			this.studac.Size = new System.Drawing.Size(457, 286);
			this.studac.TabIndex = 113;
			this.studac.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studac_CellContentClick);
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
			this.returnbutton.Location = new System.Drawing.Point(0, 454);
			this.returnbutton.Name = "returnbutton";
			this.returnbutton.Size = new System.Drawing.Size(54, 52);
			this.returnbutton.TabIndex = 114;
			this.returnbutton.UseVisualStyleBackColor = false;
			this.returnbutton.Click += new System.EventHandler(this.returnbutton_Click);
			// 
			// warn
			// 
			this.warn.AutoSize = true;
			this.warn.ForeColor = System.Drawing.Color.Red;
			this.warn.Location = new System.Drawing.Point(321, 366);
			this.warn.Name = "warn";
			this.warn.Size = new System.Drawing.Size(158, 13);
			this.warn.TabIndex = 123;
			this.warn.Text = "*Check Student ID and Activity*";
			// 
			// ManageActivity
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(993, 503);
			this.Controls.Add(this.warn);
			this.Controls.Add(this.returnbutton);
			this.Controls.Add(this.studac);
			this.Controls.Add(this.managestds);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.leavebutton);
			this.Controls.Add(this.activitybtn);
			this.Controls.Add(this.stuidcombbox);
			this.Controls.Add(this.activitytypecombbox);
			this.Controls.Add(this.stunametextbox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ManageActivity";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ManageActivity";
			this.Load += new System.EventHandler(this.ManageActivity_Load);
			((System.ComponentModel.ISupportInitialize)(this.studac)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ComboBox stuidcombbox;
		private System.Windows.Forms.ComboBox activitytypecombbox;
		private System.Windows.Forms.TextBox stunametextbox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button leavebutton;
		private System.Windows.Forms.Button activitybtn;
		private System.Windows.Forms.Label managestds;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView studac;
		private System.Windows.Forms.Button returnbutton;
		private System.Windows.Forms.Label warn;
	}
}