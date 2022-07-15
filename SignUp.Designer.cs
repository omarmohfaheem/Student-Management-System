
namespace Student_Management_System_Project
{
	partial class SignUp
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
			this.passwordlabel = new System.Windows.Forms.Label();
			this.usernamelabel = new System.Windows.Forms.Label();
			this.passwordtextbox = new System.Windows.Forms.TextBox();
			this.loginpanel = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.loginlabel = new System.Windows.Forms.Label();
			this.signupbutton = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.exitbutton = new System.Windows.Forms.Button();
			this.checkboxshow = new System.Windows.Forms.CheckBox();
			this.loginpanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// usernametextbox
			// 
			this.usernametextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usernametextbox.ForeColor = System.Drawing.Color.Black;
			this.usernametextbox.Location = new System.Drawing.Point(573, 192);
			this.usernametextbox.Name = "usernametextbox";
			this.usernametextbox.Size = new System.Drawing.Size(200, 31);
			this.usernametextbox.TabIndex = 34;
			// 
			// passwordlabel
			// 
			this.passwordlabel.AutoSize = true;
			this.passwordlabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordlabel.ForeColor = System.Drawing.Color.DimGray;
			this.passwordlabel.Location = new System.Drawing.Point(411, 249);
			this.passwordlabel.Name = "passwordlabel";
			this.passwordlabel.Size = new System.Drawing.Size(138, 32);
			this.passwordlabel.TabIndex = 33;
			this.passwordlabel.Text = "Password";
			// 
			// usernamelabel
			// 
			this.usernamelabel.AutoSize = true;
			this.usernamelabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usernamelabel.ForeColor = System.Drawing.Color.DimGray;
			this.usernamelabel.Location = new System.Drawing.Point(411, 189);
			this.usernamelabel.Name = "usernamelabel";
			this.usernamelabel.Size = new System.Drawing.Size(147, 32);
			this.usernamelabel.TabIndex = 32;
			this.usernamelabel.Text = "Username";
			// 
			// passwordtextbox
			// 
			this.passwordtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordtextbox.ForeColor = System.Drawing.Color.Black;
			this.passwordtextbox.Location = new System.Drawing.Point(573, 252);
			this.passwordtextbox.Name = "passwordtextbox";
			this.passwordtextbox.PasswordChar = '●';
			this.passwordtextbox.Size = new System.Drawing.Size(200, 31);
			this.passwordtextbox.TabIndex = 35;
			// 
			// loginpanel
			// 
			this.loginpanel.BackColor = System.Drawing.Color.Teal;
			this.loginpanel.Controls.Add(this.pictureBox1);
			this.loginpanel.Controls.Add(this.loginlabel);
			this.loginpanel.Location = new System.Drawing.Point(-1, -6);
			this.loginpanel.Name = "loginpanel";
			this.loginpanel.Size = new System.Drawing.Size(342, 587);
			this.loginpanel.TabIndex = 39;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Student_Management_System_Project.Properties.Resources.output_onlinepngtools__3_;
			this.pictureBox1.Location = new System.Drawing.Point(103, 70);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(153, 150);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// loginlabel
			// 
			this.loginlabel.AutoSize = true;
			this.loginlabel.BackColor = System.Drawing.Color.Transparent;
			this.loginlabel.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginlabel.ForeColor = System.Drawing.Color.White;
			this.loginlabel.Location = new System.Drawing.Point(-2, 223);
			this.loginlabel.Name = "loginlabel";
			this.loginlabel.Size = new System.Drawing.Size(342, 168);
			this.loginlabel.TabIndex = 1;
			this.loginlabel.Text = "Student\r\nManagement\r\nSystem";
			this.loginlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// signupbutton
			// 
			this.signupbutton.BackColor = System.Drawing.Color.Teal;
			this.signupbutton.FlatAppearance.BorderSize = 0;
			this.signupbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.signupbutton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.signupbutton.ForeColor = System.Drawing.Color.White;
			this.signupbutton.Location = new System.Drawing.Point(661, 323);
			this.signupbutton.Name = "signupbutton";
			this.signupbutton.Size = new System.Drawing.Size(200, 42);
			this.signupbutton.TabIndex = 40;
			this.signupbutton.Text = "Create New User";
			this.signupbutton.UseVisualStyleBackColor = false;
			this.signupbutton.Click += new System.EventHandler(this.signupbutton_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::Student_Management_System_Project.Properties.Resources.sign_up;
			this.pictureBox2.Location = new System.Drawing.Point(546, 47);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(227, 128);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 41;
			this.pictureBox2.TabStop = false;
			// 
			// exitbutton
			// 
			this.exitbutton.BackColor = System.Drawing.Color.Silver;
			this.exitbutton.FlatAppearance.BorderSize = 0;
			this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exitbutton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exitbutton.ForeColor = System.Drawing.Color.White;
			this.exitbutton.Image = global::Student_Management_System_Project.Properties.Resources.output_onlinepngtools__4_;
			this.exitbutton.Location = new System.Drawing.Point(870, 0);
			this.exitbutton.Name = "exitbutton";
			this.exitbutton.Size = new System.Drawing.Size(33, 36);
			this.exitbutton.TabIndex = 38;
			this.exitbutton.UseVisualStyleBackColor = false;
			this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
			// 
			// checkboxshow
			// 
			this.checkboxshow.AutoSize = true;
			this.checkboxshow.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkboxshow.ForeColor = System.Drawing.Color.DimGray;
			this.checkboxshow.Location = new System.Drawing.Point(752, 289);
			this.checkboxshow.Name = "checkboxshow";
			this.checkboxshow.Size = new System.Drawing.Size(109, 19);
			this.checkboxshow.TabIndex = 42;
			this.checkboxshow.Text = "Show Password";
			this.checkboxshow.UseVisualStyleBackColor = true;
			this.checkboxshow.CheckedChanged += new System.EventHandler(this.checkboxshow_CheckedChanged);
			// 
			// SignUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(905, 576);
			this.Controls.Add(this.checkboxshow);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.signupbutton);
			this.Controls.Add(this.loginpanel);
			this.Controls.Add(this.exitbutton);
			this.Controls.Add(this.usernametextbox);
			this.Controls.Add(this.passwordlabel);
			this.Controls.Add(this.usernamelabel);
			this.Controls.Add(this.passwordtextbox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "SignUp";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SignUp";
			this.loginpanel.ResumeLayout(false);
			this.loginpanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox usernametextbox;
		private System.Windows.Forms.Label passwordlabel;
		private System.Windows.Forms.Label usernamelabel;
		private System.Windows.Forms.TextBox passwordtextbox;
		private System.Windows.Forms.Button exitbutton;
		private System.Windows.Forms.Panel loginpanel;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label loginlabel;
		private System.Windows.Forms.Button signupbutton;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.CheckBox checkboxshow;
	}
}