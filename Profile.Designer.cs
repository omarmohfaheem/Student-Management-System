
namespace Student_Management_System_Project
{
	partial class Profile
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
			this.loginlabel = new System.Windows.Forms.Label();
			this.checkboxshow = new System.Windows.Forms.CheckBox();
			this.usernametextbox = new System.Windows.Forms.TextBox();
			this.passwordlabel = new System.Windows.Forms.Label();
			this.usernamelabel = new System.Windows.Forms.Label();
			this.passwordtextbox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.newpasswordtextbox = new System.Windows.Forms.TextBox();
			this.newpasscheckbox = new System.Windows.Forms.CheckBox();
			this.addnewuserbutton = new System.Windows.Forms.Button();
			this.returnbutton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// loginlabel
			// 
			this.loginlabel.AutoSize = true;
			this.loginlabel.BackColor = System.Drawing.Color.Transparent;
			this.loginlabel.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginlabel.ForeColor = System.Drawing.Color.DimGray;
			this.loginlabel.Location = new System.Drawing.Point(117, 47);
			this.loginlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.loginlabel.Name = "loginlabel";
			this.loginlabel.Size = new System.Drawing.Size(555, 70);
			this.loginlabel.TabIndex = 20;
			this.loginlabel.Text = "Change Password";
			this.loginlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// checkboxshow
			// 
			this.checkboxshow.AutoSize = true;
			this.checkboxshow.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkboxshow.ForeColor = System.Drawing.Color.DimGray;
			this.checkboxshow.Location = new System.Drawing.Point(599, 275);
			this.checkboxshow.Name = "checkboxshow";
			this.checkboxshow.Size = new System.Drawing.Size(131, 21);
			this.checkboxshow.TabIndex = 117;
			this.checkboxshow.Text = "Show Password";
			this.checkboxshow.UseVisualStyleBackColor = true;
			this.checkboxshow.CheckedChanged += new System.EventHandler(this.checkboxshow_CheckedChanged);
			// 
			// usernametextbox
			// 
			this.usernametextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usernametextbox.ForeColor = System.Drawing.Color.Black;
			this.usernametextbox.Location = new System.Drawing.Point(384, 161);
			this.usernametextbox.Margin = new System.Windows.Forms.Padding(4);
			this.usernametextbox.Name = "usernametextbox";
			this.usernametextbox.Size = new System.Drawing.Size(265, 37);
			this.usernametextbox.TabIndex = 115;
			// 
			// passwordlabel
			// 
			this.passwordlabel.AutoSize = true;
			this.passwordlabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordlabel.ForeColor = System.Drawing.Color.DimGray;
			this.passwordlabel.Location = new System.Drawing.Point(108, 229);
			this.passwordlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.passwordlabel.Name = "passwordlabel";
			this.passwordlabel.Size = new System.Drawing.Size(170, 40);
			this.passwordlabel.TabIndex = 114;
			this.passwordlabel.Text = "Password";
			// 
			// usernamelabel
			// 
			this.usernamelabel.AutoSize = true;
			this.usernamelabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usernamelabel.ForeColor = System.Drawing.Color.DimGray;
			this.usernamelabel.Location = new System.Drawing.Point(108, 156);
			this.usernamelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.usernamelabel.Name = "usernamelabel";
			this.usernamelabel.Size = new System.Drawing.Size(183, 40);
			this.usernamelabel.TabIndex = 113;
			this.usernamelabel.Text = "Username";
			// 
			// passwordtextbox
			// 
			this.passwordtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordtextbox.ForeColor = System.Drawing.Color.Black;
			this.passwordtextbox.Location = new System.Drawing.Point(384, 232);
			this.passwordtextbox.Margin = new System.Windows.Forms.Padding(4);
			this.passwordtextbox.Name = "passwordtextbox";
			this.passwordtextbox.PasswordChar = '●';
			this.passwordtextbox.Size = new System.Drawing.Size(265, 37);
			this.passwordtextbox.TabIndex = 116;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DimGray;
			this.label1.Location = new System.Drawing.Point(108, 298);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(254, 40);
			this.label1.TabIndex = 118;
			this.label1.Text = "New Password";
			// 
			// newpasswordtextbox
			// 
			this.newpasswordtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.newpasswordtextbox.ForeColor = System.Drawing.Color.Black;
			this.newpasswordtextbox.Location = new System.Drawing.Point(384, 303);
			this.newpasswordtextbox.Margin = new System.Windows.Forms.Padding(4);
			this.newpasswordtextbox.Name = "newpasswordtextbox";
			this.newpasswordtextbox.PasswordChar = '●';
			this.newpasswordtextbox.Size = new System.Drawing.Size(265, 37);
			this.newpasswordtextbox.TabIndex = 119;
			// 
			// newpasscheckbox
			// 
			this.newpasscheckbox.AutoSize = true;
			this.newpasscheckbox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.newpasscheckbox.ForeColor = System.Drawing.Color.DimGray;
			this.newpasscheckbox.Location = new System.Drawing.Point(599, 347);
			this.newpasscheckbox.Name = "newpasscheckbox";
			this.newpasscheckbox.Size = new System.Drawing.Size(131, 21);
			this.newpasscheckbox.TabIndex = 120;
			this.newpasscheckbox.Text = "Show Password";
			this.newpasscheckbox.UseVisualStyleBackColor = true;
			this.newpasscheckbox.CheckedChanged += new System.EventHandler(this.newpasscheckbox_CheckedChanged);
			// 
			// addnewuserbutton
			// 
			this.addnewuserbutton.BackColor = System.Drawing.Color.Teal;
			this.addnewuserbutton.FlatAppearance.BorderSize = 0;
			this.addnewuserbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addnewuserbutton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addnewuserbutton.ForeColor = System.Drawing.Color.White;
			this.addnewuserbutton.Location = new System.Drawing.Point(509, 375);
			this.addnewuserbutton.Margin = new System.Windows.Forms.Padding(4);
			this.addnewuserbutton.Name = "addnewuserbutton";
			this.addnewuserbutton.Size = new System.Drawing.Size(265, 52);
			this.addnewuserbutton.TabIndex = 121;
			this.addnewuserbutton.Text = "Change Password";
			this.addnewuserbutton.UseVisualStyleBackColor = false;
			this.addnewuserbutton.Click += new System.EventHandler(this.addnewuserbutton_Click);
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
			this.returnbutton.Location = new System.Drawing.Point(13, 390);
			this.returnbutton.Margin = new System.Windows.Forms.Padding(4);
			this.returnbutton.Name = "returnbutton";
			this.returnbutton.Size = new System.Drawing.Size(80, 144);
			this.returnbutton.TabIndex = 122;
			this.returnbutton.UseVisualStyleBackColor = false;
			this.returnbutton.Click += new System.EventHandler(this.returnbutton_Click);
			// 
			// Profile
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.returnbutton);
			this.Controls.Add(this.addnewuserbutton);
			this.Controls.Add(this.newpasscheckbox);
			this.Controls.Add(this.newpasswordtextbox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.checkboxshow);
			this.Controls.Add(this.usernametextbox);
			this.Controls.Add(this.passwordlabel);
			this.Controls.Add(this.usernamelabel);
			this.Controls.Add(this.passwordtextbox);
			this.Controls.Add(this.loginlabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Profile";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Profile";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label loginlabel;
		private System.Windows.Forms.CheckBox checkboxshow;
		private System.Windows.Forms.TextBox usernametextbox;
		private System.Windows.Forms.Label passwordlabel;
		private System.Windows.Forms.Label usernamelabel;
		private System.Windows.Forms.TextBox passwordtextbox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox newpasswordtextbox;
		private System.Windows.Forms.CheckBox newpasscheckbox;
		private System.Windows.Forms.Button addnewuserbutton;
		private System.Windows.Forms.Button returnbutton;
	}
}