namespace ns0
{
	// Token: 0x02000051 RID: 81
	internal partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000252 RID: 594 RVA: 0x00009DA7 File Offset: 0x00007FA7
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.container_0 != null)
			{
				((global::System.IDisposable)this.container_0).Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00009DC8 File Offset: 0x00007FC8
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.Form1));
			this.Form_Header = new global::System.Windows.Forms.Panel();
			this.siticoneControlBox1 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.Label_Game = new global::ReaLTaiizor.Controls.NightHeaderLabel();
			this.Text_Ready = new global::ReaLTaiizor.Controls.NightHeaderLabel();
			this.toolTip_0 = new global::System.Windows.Forms.ToolTip(this.components);
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.Progress_Scan = new global::ReaLTaiizor.Controls.LostProgressBar();
			this.BTN_Unlockall = new global::Guna.UI2.WinForms.Guna2Button();
			this.label3 = new global::System.Windows.Forms.Label();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.panel4 = new global::System.Windows.Forms.Panel();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.Form_Header.SuspendLayout();
			base.SuspendLayout();
			this.Form_Header.BackColor = global::System.Drawing.Color.Transparent;
			this.Form_Header.Controls.Add(this.label1);
			this.Form_Header.Controls.Add(this.siticoneControlBox1);
			this.Form_Header.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Form_Header.Location = new global::System.Drawing.Point(0, 0);
			this.Form_Header.Name = "Form_Header";
			this.Form_Header.Size = new global::System.Drawing.Size(321, 52);
			this.Form_Header.TabIndex = 171;
			this.Form_Header.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.Label_Title_MouseDown);
			this.Form_Header.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.Label_Title_MouseMove);
			this.Form_Header.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.Label_Title_MouseUp);
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox1.BorderRadius = 10;
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.siticoneControlBox1.HoveredState.FillColor = global::System.Drawing.Color.FromArgb(232, 17, 35);
			this.siticoneControlBox1.HoveredState.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(271, 12);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(38, 32);
			this.siticoneControlBox1.TabIndex = 337;
			this.Label_Game.AutoSize = true;
			this.Label_Game.BackColor = global::System.Drawing.Color.Transparent;
			this.Label_Game.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 6f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label_Game.ForeColor = global::System.Drawing.Color.FromArgb(250, 250, 250);
			this.Label_Game.LeftSideForeColor = global::System.Drawing.Color.FromArgb(250, 250, 250);
			this.Label_Game.Location = new global::System.Drawing.Point(12, 144);
			this.Label_Game.Name = "Label_Game";
			this.Label_Game.RightSideForeColor = global::System.Drawing.Color.FromArgb(170, 171, 176);
			this.Label_Game.Side = global::ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
			this.Label_Game.Size = new global::System.Drawing.Size(26, 14);
			this.Label_Game.TabIndex = 329;
			this.Label_Game.Text = "Game";
			this.Label_Game.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.Label_Game.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
			this.Label_Game.UseCompatibleTextRendering = true;
			this.Text_Ready.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.Text_Ready.BackColor = global::System.Drawing.Color.Transparent;
			this.Text_Ready.Font = new global::System.Drawing.Font("Consolas", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Text_Ready.ForeColor = global::System.Drawing.Color.White;
			this.Text_Ready.LeftSideForeColor = global::System.Drawing.Color.White;
			this.Text_Ready.Location = new global::System.Drawing.Point(62, 53);
			this.Text_Ready.Margin = new global::System.Windows.Forms.Padding(9);
			this.Text_Ready.Name = "Text_Ready";
			this.Text_Ready.RightSideForeColor = global::System.Drawing.Color.FromArgb(170, 171, 176);
			this.Text_Ready.Side = global::ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
			this.Text_Ready.Size = new global::System.Drawing.Size(216, 18);
			this.Text_Ready.TabIndex = 320;
			this.Text_Ready.Text = "Game Found! Preparing to Update...";
			this.Text_Ready.TextAlign = global::System.Drawing.ContentAlignment.BottomCenter;
			this.Text_Ready.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.Text_Ready.UseCompatibleTextRendering = true;
			this.Text_Ready.Click += new global::System.EventHandler(this.Text_Ready_Click);
			this.toolTip_0.AutoPopDelay = 5000;
			this.toolTip_0.BackColor = global::System.Drawing.Color.IndianRed;
			this.toolTip_0.InitialDelay = 100;
			this.toolTip_0.ReshowDelay = 100;
			this.timer_0.Interval = 1500;
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.Progress_Scan.BackColor = global::System.Drawing.Color.FromArgb(45, 45, 48);
			this.Progress_Scan.Color = global::System.Drawing.Color.FromArgb(111, 25, 80);
			this.Progress_Scan.ForeColor = global::System.Drawing.Color.FromArgb(63, 63, 70);
			this.Progress_Scan.Hover = false;
			this.Progress_Scan.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.Progress_Scan.Location = new global::System.Drawing.Point(801, 292);
			this.Progress_Scan.Name = "Progress_Scan";
			this.Progress_Scan.Progress = 0;
			this.Progress_Scan.Size = new global::System.Drawing.Size(224, 23);
			this.Progress_Scan.TabIndex = 334;
			this.Progress_Scan.Text = "lostProgressBar1";
			this.Progress_Scan.Visible = false;
			this.BTN_Unlockall.AutoRoundedCorners = true;
			this.BTN_Unlockall.BorderColor = global::System.Drawing.Color.Red;
			this.BTN_Unlockall.BorderRadius = 32;
			this.BTN_Unlockall.BorderThickness = 2;
			this.BTN_Unlockall.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.BTN_Unlockall.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.BTN_Unlockall.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.BTN_Unlockall.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.BTN_Unlockall.FillColor = global::System.Drawing.Color.Transparent;
			this.BTN_Unlockall.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.BTN_Unlockall.ForeColor = global::System.Drawing.Color.White;
			this.BTN_Unlockall.Location = new global::System.Drawing.Point(12, 74);
			this.BTN_Unlockall.Name = "BTN_Unlockall";
			this.BTN_Unlockall.Size = new global::System.Drawing.Size(297, 67);
			this.BTN_Unlockall.TabIndex = 335;
			this.BTN_Unlockall.Text = "Unlock Everything";
			this.BTN_Unlockall.Click += new global::System.EventHandler(this.guna2Button1_Click);
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.Red;
			this.label3.Location = new global::System.Drawing.Point(9, 55);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(54, 16);
			this.label3.TabIndex = 338;
			this.label3.Text = "Status:";
			this.panel1.BackColor = global::System.Drawing.Color.Red;
			this.panel1.Location = new global::System.Drawing.Point(-90, -18);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(669, 24);
			this.panel1.TabIndex = 343;
			this.panel4.BackColor = global::System.Drawing.Color.Red;
			this.panel4.Location = new global::System.Drawing.Point(-90, 160);
			this.panel4.Name = "panel4";
			this.panel4.Size = new global::System.Drawing.Size(676, 406);
			this.panel4.TabIndex = 345;
			this.panel2.BackColor = global::System.Drawing.Color.Red;
			this.panel2.Location = new global::System.Drawing.Point(315, -41);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(489, 509);
			this.panel2.TabIndex = 346;
			this.panel3.BackColor = global::System.Drawing.Color.Red;
			this.panel3.Location = new global::System.Drawing.Point(-389, -26);
			this.panel3.Name = "panel3";
			this.panel3.Size = new global::System.Drawing.Size(395, 507);
			this.panel3.TabIndex = 347;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.Red;
			this.label1.Location = new global::System.Drawing.Point(9, 12);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(90, 16);
			this.label1.TabIndex = 348;
			this.label1.Text = "VulcanShop";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			base.ClientSize = new global::System.Drawing.Size(321, 166);
			base.Controls.Add(this.BTN_Unlockall);
			base.Controls.Add(this.panel3);
			base.Controls.Add(this.Label_Game);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.panel4);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.Text_Ready);
			base.Controls.Add(this.Progress_Scan);
			base.Controls.Add(this.Form_Header);
			this.DoubleBuffered = true;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form1";
			base.TopMost = true;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			base.Load += new global::System.EventHandler(this.Form1_Load);
			this.Form_Header.ResumeLayout(false);
			this.Form_Header.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400028F RID: 655
		private global::System.ComponentModel.Container container_0;

		// Token: 0x04000290 RID: 656
		public global::System.Windows.Forms.Panel Form_Header;

		// Token: 0x04000291 RID: 657
		public global::ReaLTaiizor.Controls.NightHeaderLabel Text_Ready;

		// Token: 0x04000292 RID: 658
		private global::System.Windows.Forms.ToolTip toolTip_0;

		// Token: 0x04000293 RID: 659
		public global::ReaLTaiizor.Controls.NightHeaderLabel Label_Game;

		// Token: 0x04000294 RID: 660
		public global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000295 RID: 661
		public global::ReaLTaiizor.Controls.LostProgressBar Progress_Scan;

		// Token: 0x04000296 RID: 662
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000297 RID: 663
		public global::Guna.UI2.WinForms.Guna2Button BTN_Unlockall;

		// Token: 0x04000298 RID: 664
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x04000299 RID: 665
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400029A RID: 666
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400029B RID: 667
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x0400029C RID: 668
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x0400029D RID: 669
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x0400029E RID: 670
		private global::System.Windows.Forms.Label label1;
	}
}
