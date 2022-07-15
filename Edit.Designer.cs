
namespace Student_Management_System_Project
{
	partial class Edit
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
			this.usernametextbox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.checkboxshow = new System.Windows.Forms.CheckBox();
			this.passwordlabel = new System.Windows.Forms.Label();
			this.passwordtextbox = new System.Windows.Forms.TextBox();
			this.Drop = new System.Windows.Forms.Button();
			this.addcourse = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.returnbutton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// usernametextbox
			// 
			this.usernametextbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usernametextbox.Location = new System.Drawing.Point(298, 156);
			this.usernametextbox.Margin = new System.Windows.Forms.Padding(4);
			this.usernametextbox.MaxLength = 13;
			this.usernametextbox.Name = "usernametextbox";
			this.usernametextbox.Size = new System.Drawing.Size(181, 30);
			this.usernametextbox.TabIndex = 102;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Teal;
			this.label6.Location = new System.Drawing.Point(60, 154);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(230, 32);
			this.label6.TabIndex = 101;
			this.label6.Text = "New Username :";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(96, 162);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(46, 17);
			this.label7.TabIndex = 100;
			this.label7.Text = "label7";
			// 
			// checkboxshow
			// 
			this.checkboxshow.AutoSize = true;
			this.checkboxshow.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkboxshow.ForeColor = System.Drawing.Color.DimGray;
			this.checkboxshow.Location = new System.Drawing.Point(349, 242);
			this.checkboxshow.Name = "checkboxshow";
			this.checkboxshow.Size = new System.Drawing.Size(131, 21);
			this.checkboxshow.TabIndex = 120;
			this.checkboxshow.Text = "Show Password";
			this.checkboxshow.UseVisualStyleBackColor = true;
			this.checkboxshow.CheckedChanged += new System.EventHandler(this.checkboxshow_CheckedChanged);
			// 
			// passwordlabel
			// 
			this.passwordlabel.AutoSize = true;
			this.passwordlabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordlabel.ForeColor = System.Drawing.Color.Teal;
			this.passwordlabel.Location = new System.Drawing.Point(60, 201);
			this.passwordlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.passwordlabel.Name = "passwordlabel";
			this.passwordlabel.Size = new System.Drawing.Size(225, 34);
			this.passwordlabel.TabIndex = 118;
			this.passwordlabel.Text = "New Password :";
			// 
			// passwordtextbox
			// 
			this.passwordtextbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordtextbox.Location = new System.Drawing.Point(298, 205);
			this.passwordtextbox.Margin = new System.Windows.Forms.Padding(4);
			this.passwordtextbox.MaxLength = 13;
			this.passwordtextbox.Name = "passwordtextbox";
			this.passwordtextbox.PasswordChar = '●';
			this.passwordtextbox.Size = new System.Drawing.Size(181, 30);
			this.passwordtextbox.TabIndex = 121;
			// 
			// Drop
			// 
			this.Drop.BackColor = System.Drawing.Color.Teal;
			this.Drop.FlatAppearance.BorderSize = 0;
			this.Drop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Drop.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Drop.ForeColor = System.Drawing.Color.White;
			this.Drop.Location = new System.Drawing.Point(181, 295);
			this.Drop.Margin = new System.Windows.Forms.Padding(4);
			this.Drop.Name = "Drop";
			this.Drop.Size = new System.Drawing.Size(282, 52);
			this.Drop.TabIndex = 141;
			this.Drop.Text = "Edit Information";
			this.Drop.UseVisualStyleBackColor = false;
			this.Drop.Click += new System.EventHandler(this.Drop_Click);
			// 
			// addcourse
			// 
			this.addcourse.AutoSize = true;
			this.addcourse.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addcourse.ForeColor = System.Drawing.Color.DimGray;
			this.addcourse.Location = new System.Drawing.Point(259, 28);
			this.addcourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.addcourse.Name = "addcourse";
			this.addcourse.Size = new System.Drawing.Size(185, 40);
			this.addcourse.TabIndex = 143;
			this.addcourse.Text = "Edit Profile";
			this.addcourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Teal;
			this.panel1.ForeColor = System.Drawing.Color.Teal;
			this.panel1.Location = new System.Drawing.Point(-251, 72);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1368, 6);
			this.panel1.TabIndex = 142;
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
			this.returnbutton.Location = new System.Drawing.Point(13, 469);
			this.returnbutton.Margin = new System.Windows.Forms.Padding(4);
			this.returnbutton.Name = "returnbutton";
			this.returnbutton.Size = new System.Drawing.Size(72, 47);
			this.returnbutton.TabIndex = 147;
			this.returnbutton.UseVisualStyleBackColor = false;
			this.returnbutton.Click += new System.EventHandler(this.returnbutton_Click);
			// 
			// Edit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(691, 548);
			this.Controls.Add(this.returnbutton);
			this.Controls.Add(this.addcourse);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.Drop);
			this.Controls.Add(this.passwordtextbox);
			this.Controls.Add(this.checkboxshow);
			this.Controls.Add(this.passwordlabel);
			this.Controls.Add(this.usernametextbox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Edit";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Edit";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox usernametextbox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckBox checkboxshow;
		private System.Windows.Forms.Label passwordlabel;
		private System.Windows.Forms.TextBox passwordtextbox;
		private System.Windows.Forms.Button Drop;
		private System.Windows.Forms.Label addcourse;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button returnbutton;
	}
}