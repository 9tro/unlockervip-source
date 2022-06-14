namespace KeyAuth
{
	// Token: 0x02000065 RID: 101
	public partial class Login : global::System.Windows.Forms.Form
	{
		// Token: 0x06000310 RID: 784 RVA: 0x0000CA74 File Offset: 0x0000AC74
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0000CA9C File Offset: 0x0000AC9C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Siticone.UI.AnimatorNS.Animation animation = new global::Siticone.UI.AnimatorNS.Animation();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::KeyAuth.Login));
			this.siticoneDragControl1 = new global::Siticone.UI.WinForms.SiticoneDragControl(this.components);
			this.siticoneTransition1 = new global::Siticone.UI.WinForms.SiticoneTransition();
			this.label1 = new global::System.Windows.Forms.Label();
			this.LoginKey = new global::Siticone.UI.WinForms.SiticoneRoundedTextBox();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.panel4 = new global::System.Windows.Forms.Panel();
			this.panel5 = new global::System.Windows.Forms.Panel();
			this.RgstrBtn = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.status = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.siticoneRoundedButton1 = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.siticoneRoundedButton2 = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.password = new global::Siticone.UI.WinForms.SiticoneRoundedTextBox();
			this.username = new global::Siticone.UI.WinForms.SiticoneRoundedTextBox();
			this.siticoneControlBox2 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.siticoneShadowForm = new global::Siticone.UI.WinForms.SiticoneShadowForm(this.components);
			this.backgroundWorker1 = new global::System.ComponentModel.BackgroundWorker();
			this.bindingSource1 = new global::System.Windows.Forms.BindingSource(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.bindingSource1).BeginInit();
			base.SuspendLayout();
			this.siticoneDragControl1.TargetControl = this;
			this.siticoneTransition1.AnimationType = global::Siticone.UI.AnimatorNS.AnimationType.Rotate;
			this.siticoneTransition1.Cursor = null;
			animation.AnimateOnlyDifferences = true;
			animation.BlindCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation2.BlindCoeff");
			animation.LeafCoeff = 0f;
			animation.MaxTime = 1f;
			animation.MinTime = 0f;
			animation.MosaicCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation2.MosaicCoeff");
			animation.MosaicShift = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation2.MosaicShift");
			animation.MosaicSize = 0;
			animation.Padding = new global::System.Windows.Forms.Padding(50);
			animation.RotateCoeff = 1f;
			animation.RotateLimit = 0f;
			animation.ScaleCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation2.ScaleCoeff");
			animation.SlideCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation2.SlideCoeff");
			animation.TimeCoeff = 0f;
			animation.TransparencyCoeff = 1f;
			this.siticoneTransition1.DefaultAnimation = animation;
			this.label1.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label1.Font = new global::System.Drawing.Font("Segoe UI Light", 10f);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(-1, 136);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(0, 19);
			this.label1.TabIndex = 22;
			this.LoginKey.AllowDrop = true;
			this.LoginKey.BackColor = global::System.Drawing.Color.Transparent;
			this.LoginKey.BorderColor = global::System.Drawing.Color.Red;
			this.LoginKey.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.siticoneTransition1.SetDecoration(this.LoginKey, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.LoginKey.DefaultText = "Key";
			this.LoginKey.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.LoginKey.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.LoginKey.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.LoginKey.DisabledState.Parent = this.LoginKey;
			this.LoginKey.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.LoginKey.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.LoginKey.FocusedState.BorderColor = global::System.Drawing.Color.Red;
			this.LoginKey.FocusedState.Parent = this.LoginKey;
			this.LoginKey.HoveredState.BorderColor = global::System.Drawing.Color.Red;
			this.LoginKey.HoveredState.Parent = this.LoginKey;
			this.LoginKey.Location = new global::System.Drawing.Point(55, 328);
			this.LoginKey.Margin = new global::System.Windows.Forms.Padding(4);
			this.LoginKey.Name = "LoginKey";
			this.LoginKey.PasswordChar = '\0';
			this.LoginKey.PlaceholderText = "";
			this.LoginKey.SelectedText = "";
			this.LoginKey.ShadowDecoration.Parent = this.LoginKey;
			this.LoginKey.Size = new global::System.Drawing.Size(270, 35);
			this.LoginKey.TabIndex = 32;
			this.LoginKey.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.LoginKey.TextChanged += new global::System.EventHandler(this.key_TextChanged);
			this.LoginKey.Enter += new global::System.EventHandler(this.key_Enter);
			this.LoginKey.Leave += new global::System.EventHandler(this.key_Leave);
			this.panel2.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel2.BackColor = global::System.Drawing.Color.Red;
			this.siticoneTransition1.SetDecoration(this.panel2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.panel2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new global::System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(386, 6);
			this.panel2.TabIndex = 41;
			this.panel3.BackColor = global::System.Drawing.Color.Red;
			this.siticoneTransition1.SetDecoration(this.panel3, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.panel3.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new global::System.Drawing.Point(0, 506);
			this.panel3.Name = "panel3";
			this.panel3.Size = new global::System.Drawing.Size(386, 6);
			this.panel3.TabIndex = 42;
			this.panel4.BackColor = global::System.Drawing.Color.Red;
			this.siticoneTransition1.SetDecoration(this.panel4, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.panel4.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.panel4.Location = new global::System.Drawing.Point(380, 6);
			this.panel4.Name = "panel4";
			this.panel4.Size = new global::System.Drawing.Size(6, 500);
			this.panel4.TabIndex = 43;
			this.panel5.BackColor = global::System.Drawing.Color.Red;
			this.siticoneTransition1.SetDecoration(this.panel5, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.panel5.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.panel5.Location = new global::System.Drawing.Point(0, 6);
			this.panel5.Name = "panel5";
			this.panel5.Size = new global::System.Drawing.Size(6, 500);
			this.panel5.TabIndex = 44;
			this.RgstrBtn.BackColor = global::System.Drawing.Color.Transparent;
			this.RgstrBtn.BorderColor = global::System.Drawing.Color.Red;
			this.RgstrBtn.BorderThickness = 1;
			this.RgstrBtn.CheckedState.Parent = this.RgstrBtn;
			this.RgstrBtn.CustomImages.Parent = this.RgstrBtn;
			this.siticoneTransition1.SetDecoration(this.RgstrBtn, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.RgstrBtn.FillColor = global::System.Drawing.Color.Red;
			this.RgstrBtn.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.RgstrBtn.ForeColor = global::System.Drawing.Color.White;
			this.RgstrBtn.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.RgstrBtn.HoveredState.Parent = this.RgstrBtn;
			this.RgstrBtn.Location = new global::System.Drawing.Point(193, 370);
			this.RgstrBtn.Name = "RgstrBtn";
			this.RgstrBtn.ShadowDecoration.Parent = this.RgstrBtn;
			this.RgstrBtn.Size = new global::System.Drawing.Size(132, 40);
			this.RgstrBtn.TabIndex = 51;
			this.RgstrBtn.Text = "Register";
			this.RgstrBtn.Click += new global::System.EventHandler(this.RgstrBtn_Click);
			this.status.AutoSize = false;
			this.status.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.status, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.status.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.status.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.status.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.status.Location = new global::System.Drawing.Point(6, 454);
			this.status.Margin = new global::System.Windows.Forms.Padding(2);
			this.status.Name = "status";
			this.status.Size = new global::System.Drawing.Size(374, 52);
			this.status.TabIndex = 52;
			this.status.Text = "Status: Awaiting login";
			this.status.TextAlignment = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.siticoneRoundedButton1.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneRoundedButton1.BorderColor = global::System.Drawing.Color.Red;
			this.siticoneRoundedButton1.BorderThickness = 1;
			this.siticoneRoundedButton1.CheckedState.Parent = this.siticoneRoundedButton1;
			this.siticoneRoundedButton1.CustomImages.Parent = this.siticoneRoundedButton1;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneRoundedButton1.FillColor = global::System.Drawing.Color.Red;
			this.siticoneRoundedButton1.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedButton1.ForeColor = global::System.Drawing.Color.White;
			this.siticoneRoundedButton1.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.siticoneRoundedButton1.HoveredState.Parent = this.siticoneRoundedButton1;
			this.siticoneRoundedButton1.Location = new global::System.Drawing.Point(73, 416);
			this.siticoneRoundedButton1.Name = "siticoneRoundedButton1";
			this.siticoneRoundedButton1.ShadowDecoration.Parent = this.siticoneRoundedButton1;
			this.siticoneRoundedButton1.Size = new global::System.Drawing.Size(237, 36);
			this.siticoneRoundedButton1.TabIndex = 55;
			this.siticoneRoundedButton1.Text = "Information";
			this.siticoneRoundedButton1.Click += new global::System.EventHandler(this.siticoneRoundedButton1_Click);
			this.siticoneRoundedButton2.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneRoundedButton2.BorderColor = global::System.Drawing.Color.Red;
			this.siticoneRoundedButton2.BorderThickness = 1;
			this.siticoneRoundedButton2.CheckedState.Parent = this.siticoneRoundedButton2;
			this.siticoneRoundedButton2.CustomImages.Parent = this.siticoneRoundedButton2;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneRoundedButton2.FillColor = global::System.Drawing.Color.Red;
			this.siticoneRoundedButton2.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedButton2.ForeColor = global::System.Drawing.Color.White;
			this.siticoneRoundedButton2.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.siticoneRoundedButton2.HoveredState.Parent = this.siticoneRoundedButton2;
			this.siticoneRoundedButton2.Location = new global::System.Drawing.Point(55, 370);
			this.siticoneRoundedButton2.Name = "siticoneRoundedButton2";
			this.siticoneRoundedButton2.ShadowDecoration.Parent = this.siticoneRoundedButton2;
			this.siticoneRoundedButton2.Size = new global::System.Drawing.Size(132, 40);
			this.siticoneRoundedButton2.TabIndex = 56;
			this.siticoneRoundedButton2.Text = "Login";
			this.siticoneRoundedButton2.Click += new global::System.EventHandler(this.siticoneRoundedButton2_Click);
			this.password.AllowDrop = true;
			this.password.BackColor = global::System.Drawing.Color.Transparent;
			this.password.BorderColor = global::System.Drawing.Color.Red;
			this.password.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.siticoneTransition1.SetDecoration(this.password, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.password.DefaultText = "Password";
			this.password.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.password.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.password.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.password.DisabledState.Parent = this.password;
			this.password.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.password.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.password.FocusedState.BorderColor = global::System.Drawing.Color.Red;
			this.password.FocusedState.Parent = this.password;
			this.password.HoveredState.BorderColor = global::System.Drawing.Color.Red;
			this.password.HoveredState.Parent = this.password;
			this.password.Location = new global::System.Drawing.Point(55, 285);
			this.password.Margin = new global::System.Windows.Forms.Padding(4);
			this.password.Name = "password";
			this.password.PasswordChar = '\0';
			this.password.PlaceholderText = "";
			this.password.SelectedText = "";
			this.password.ShadowDecoration.Parent = this.password;
			this.password.Size = new global::System.Drawing.Size(270, 35);
			this.password.TabIndex = 57;
			this.password.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.password.UseSystemPasswordChar = true;
			this.username.AllowDrop = true;
			this.username.BackColor = global::System.Drawing.Color.Transparent;
			this.username.BorderColor = global::System.Drawing.Color.Red;
			this.username.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.siticoneTransition1.SetDecoration(this.username, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.username.DefaultText = "Username";
			this.username.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.username.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.username.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.username.DisabledState.Parent = this.username;
			this.username.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.username.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.username.FocusedState.BorderColor = global::System.Drawing.Color.Red;
			this.username.FocusedState.Parent = this.username;
			this.username.HoveredState.BorderColor = global::System.Drawing.Color.Red;
			this.username.HoveredState.Parent = this.username;
			this.username.Location = new global::System.Drawing.Point(55, 242);
			this.username.Margin = new global::System.Windows.Forms.Padding(4);
			this.username.Name = "username";
			this.username.PasswordChar = '\0';
			this.username.PlaceholderText = "";
			this.username.SelectedText = "";
			this.username.ShadowDecoration.Parent = this.username;
			this.username.Size = new global::System.Drawing.Size(270, 35);
			this.username.TabIndex = 58;
			this.username.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.siticoneControlBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox2.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox2.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("siticoneControlBox2.BackgroundImage");
			this.siticoneControlBox2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.siticoneControlBox2.BorderColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox2.BorderRadius = 10;
			this.siticoneTransition1.SetDecoration(this.siticoneControlBox2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneControlBox2.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox2.HoveredState.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox2.HoveredState.IconColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.IconColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox2.Location = new global::System.Drawing.Point(6, 458);
			this.siticoneControlBox2.Name = "siticoneControlBox2";
			this.siticoneControlBox2.PressedColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox2.ShadowDecoration.Color = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.Size = new global::System.Drawing.Size(57, 47);
			this.siticoneControlBox2.TabIndex = 59;
			this.siticoneControlBox2.Click += new global::System.EventHandler(this.siticoneControlBox2_Click);
			this.pictureBox1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.siticoneTransition1.SetDecoration(this.pictureBox1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(6, 6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(374, 446);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 60;
			this.pictureBox1.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = global::System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			base.ClientSize = new global::System.Drawing.Size(386, 512);
			base.Controls.Add(this.siticoneControlBox2);
			base.Controls.Add(this.username);
			base.Controls.Add(this.password);
			base.Controls.Add(this.siticoneRoundedButton2);
			base.Controls.Add(this.siticoneRoundedButton1);
			base.Controls.Add(this.status);
			base.Controls.Add(this.RgstrBtn);
			base.Controls.Add(this.panel5);
			base.Controls.Add(this.panel4);
			base.Controls.Add(this.panel3);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.LoginKey);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.pictureBox1);
			this.siticoneTransition1.SetDecoration(this, global::Siticone.UI.AnimatorNS.DecorationType.BottomMirror);
			this.DoubleBuffered = true;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Login";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Loader";
			base.Load += new global::System.EventHandler(this.Login_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.bindingSource1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040002F6 RID: 758
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040002F7 RID: 759
		private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x040002F8 RID: 760
		private global::Siticone.UI.WinForms.SiticoneTransition siticoneTransition1;

		// Token: 0x040002F9 RID: 761
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040002FA RID: 762
		private global::Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;

		// Token: 0x040002FB RID: 763
		private global::Siticone.UI.WinForms.SiticoneRoundedTextBox LoginKey;

		// Token: 0x040002FC RID: 764
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x040002FD RID: 765
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x040002FE RID: 766
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x040002FF RID: 767
		private global::System.Windows.Forms.Panel panel5;

		// Token: 0x04000300 RID: 768
		private global::System.Windows.Forms.BindingSource bindingSource1;

		// Token: 0x04000301 RID: 769
		private global::System.ComponentModel.BackgroundWorker backgroundWorker1;

		// Token: 0x04000302 RID: 770
		private global::Siticone.UI.WinForms.SiticoneRoundedButton RgstrBtn;

		// Token: 0x04000303 RID: 771
		private global::Siticone.UI.WinForms.SiticoneLabel status;

		// Token: 0x04000304 RID: 772
		private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton1;

		// Token: 0x04000305 RID: 773
		private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton2;

		// Token: 0x04000306 RID: 774
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

		// Token: 0x04000307 RID: 775
		private global::Siticone.UI.WinForms.SiticoneRoundedTextBox username;

		// Token: 0x04000308 RID: 776
		private global::Siticone.UI.WinForms.SiticoneRoundedTextBox password;

		// Token: 0x04000309 RID: 777
		private global::System.Windows.Forms.PictureBox pictureBox1;
	}
}
