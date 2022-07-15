
namespace Student_Management_System_Project
{
	partial class trans
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
			this.TranscriptDataTable = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.StudentID = new System.Windows.Forms.TextBox();
			this.Drop = new System.Windows.Forms.Button();
			this.addcourse = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.returnbutton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.TranscriptDataTable)).BeginInit();
			this.SuspendLayout();
			// 
			// TranscriptDataTable
			// 
			this.TranscriptDataTable.AllowUserToAddRows = false;
			this.TranscriptDataTable.AllowUserToDeleteRows = false;
			this.TranscriptDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.TranscriptDataTable.BackgroundColor = System.Drawing.Color.Silver;
			this.TranscriptDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TranscriptDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TranscriptDataTable.Location = new System.Drawing.Point(404, 117);
			this.TranscriptDataTable.Margin = new System.Windows.Forms.Padding(4);
			this.TranscriptDataTable.Name = "TranscriptDataTable";
			this.TranscriptDataTable.ReadOnly = true;
			this.TranscriptDataTable.RowHeadersWidth = 51;
			this.TranscriptDataTable.Size = new System.Drawing.Size(634, 370);
			this.TranscriptDataTable.TabIndex = 127;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Teal;
			this.label3.Location = new System.Drawing.Point(13, 179);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(163, 32);
			this.label3.TabIndex = 144;
			this.label3.Text = "Student ID :";
			// 
			// StudentID
			// 
			this.StudentID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StudentID.Location = new System.Drawing.Point(184, 179);
			this.StudentID.Margin = new System.Windows.Forms.Padding(4);
			this.StudentID.MaxLength = 15;
			this.StudentID.Name = "StudentID";
			this.StudentID.Size = new System.Drawing.Size(201, 30);
			this.StudentID.TabIndex = 145;
			// 
			// Drop
			// 
			this.Drop.BackColor = System.Drawing.Color.Teal;
			this.Drop.FlatAppearance.BorderSize = 0;
			this.Drop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Drop.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Drop.ForeColor = System.Drawing.Color.White;
			this.Drop.Location = new System.Drawing.Point(764, 504);
			this.Drop.Margin = new System.Windows.Forms.Padding(4);
			this.Drop.Name = "Drop";
			this.Drop.Size = new System.Drawing.Size(274, 52);
			this.Drop.TabIndex = 146;
			this.Drop.Text = "View Transcript";
			this.Drop.UseVisualStyleBackColor = false;
			this.Drop.Click += new System.EventHandler(this.Drop_Click);
			// 
			// addcourse
			// 
			this.addcourse.AutoSize = true;
			this.addcourse.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addcourse.ForeColor = System.Drawing.Color.DimGray;
			this.addcourse.Location = new System.Drawing.Point(379, 20);
			this.addcourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.addcourse.Name = "addcourse";
			this.addcourse.Size = new System.Drawing.Size(304, 40);
			this.addcourse.TabIndex = 148;
			this.addcourse.Text = "Student Transcript";
			this.addcourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Teal;
			this.panel1.ForeColor = System.Drawing.Color.Teal;
			this.panel1.Location = new System.Drawing.Point(-124, 74);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1368, 6);
			this.panel1.TabIndex = 147;
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
			this.returnbutton.Location = new System.Drawing.Point(1, 513);
			this.returnbutton.Margin = new System.Windows.Forms.Padding(4);
			this.returnbutton.Name = "returnbutton";
			this.returnbutton.Size = new System.Drawing.Size(72, 64);
			this.returnbutton.TabIndex = 149;
			this.returnbutton.UseVisualStyleBackColor = false;
			this.returnbutton.Click += new System.EventHandler(this.returnbutton_Click);
			// 
			// trans
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(1078, 590);
			this.Controls.Add(this.returnbutton);
			this.Controls.Add(this.addcourse);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.Drop);
			this.Controls.Add(this.StudentID);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.TranscriptDataTable);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "trans";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "trans";
			((System.ComponentModel.ISupportInitialize)(this.TranscriptDataTable)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView TranscriptDataTable;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox StudentID;
		private System.Windows.Forms.Button Drop;
		private System.Windows.Forms.Label addcourse;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button returnbutton;
	}
}