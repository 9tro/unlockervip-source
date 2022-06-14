using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ns0;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;
using unlockervip;
using unlockervip.Properties;

namespace KeyAuth
{
	// Token: 0x02000065 RID: 101
	public partial class Login : Form
	{
		// Token: 0x06000303 RID: 771
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x06000304 RID: 772 RVA: 0x0000C6F6 File Offset: 0x0000A8F6
		public Login()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(Login.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x06000305 RID: 773 RVA: 0x0000C72D File Offset: 0x0000A92D
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0000C738 File Offset: 0x0000A938
		private void Login_Load(object sender, EventArgs e)
		{
			Login.KeyAuthApp.init();
			this.LoginKey.Text = Settings.Default.Key;
			if (Login.KeyAuthApp.response.message == "invalidver")
			{
				if (!string.IsNullOrEmpty(Login.KeyAuthApp.app_data.downloadLink))
				{
					DialogResult dialogResult = MessageBox.Show("Yes to open file in browser\nNo to download file automatically", "Auto update", MessageBoxButtons.YesNo);
					if (dialogResult != DialogResult.Yes)
					{
						if (dialogResult != DialogResult.No)
						{
							MessageBox.Show("Invalid option");
							Environment.Exit(0);
						}
						else
						{
							WebClient webClient = new WebClient();
							string executablePath = Application.ExecutablePath;
							webClient.DownloadFile(Login.KeyAuthApp.app_data.downloadLink, executablePath);
							Process.Start(executablePath);
							Process.Start(new ProcessStartInfo
							{
								Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
								WindowStyle = ProcessWindowStyle.Hidden,
								CreateNoWindow = true,
								FileName = "cmd.exe"
							});
							Environment.Exit(0);
						}
					}
					else
					{
						Process.Start(Login.KeyAuthApp.app_data.downloadLink);
						Environment.Exit(0);
					}
				}
				MessageBox.Show("Version of this program does not match the one online. Furthermore, the download link online isn't set. You will need to manually obtain the download link from the developer");
				Environment.Exit(0);
			}
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0000C868 File Offset: 0x0000AA68
		private void LoginBtn_Click(object sender, EventArgs e)
		{
			Login.KeyAuthApp.login(this.username.Text, this.password.Text);
			if (Login.KeyAuthApp.response.success)
			{
				Class6.smethod_0();
				base.Hide();
				return;
			}
			this.status.Text = "Status: " + Login.KeyAuthApp.response.message;
		}

		// Token: 0x06000308 RID: 776 RVA: 0x000049C7 File Offset: 0x00002BC7
		private void key_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0000C8D6 File Offset: 0x0000AAD6
		private void key_Enter(object sender, EventArgs e)
		{
			if (this.LoginKey.Text == "Key")
			{
				this.LoginKey.Text = "";
			}
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0000C900 File Offset: 0x0000AB00
		private void key_Leave(object sender, EventArgs e)
		{
			if (this.LoginKey.Text == "")
			{
				this.LoginKey.Text = "Key";
				this.LoginKey.ForeColor = Color.FromArgb(125, 137, 149);
			}
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0000C950 File Offset: 0x0000AB50
		private void instructions_Click(object sender, EventArgs e)
		{
			MessageBox.Show("1) turn of all anti virus and disable all anti cheats,                    2) run drivers (with game closed),                                                 3) open warzone and click inject,                                                  4) click unlock all at main menu,                                                 Dev=minerdallas", "Instructions", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0000C968 File Offset: 0x0000AB68
		private void RgstrBtn_Click(object sender, EventArgs e)
		{
			Login.KeyAuthApp.register(this.username.Text, this.password.Text, this.LoginKey.Text);
			if (Login.KeyAuthApp.response.success)
			{
				Class6.smethod_0();
				base.Hide();
				return;
			}
			this.status.Text = "Status: " + Login.KeyAuthApp.response.message;
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0000C9E1 File Offset: 0x0000ABE1
		private void siticoneRoundedButton1_Click(object sender, EventArgs e)
		{
			new info().Show();
			base.Hide();
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0000C9F4 File Offset: 0x0000ABF4
		private void siticoneRoundedButton2_Click(object sender, EventArgs e)
			{
				Class6.smethod_0();
				base.Hide();
				return;
			}

		// Token: 0x0600030F RID: 783 RVA: 0x0000CA62 File Offset: 0x0000AC62
		private void siticoneControlBox2_Click(object sender, EventArgs e)
		{
			Process.Start("explorer.exe", "https://discord.gg/PfmYuNDWEB");
		}

		// Token: 0x040002F1 RID: 753
		private static string name = "VulcanShop";

		// Token: 0x040002F2 RID: 754
		private static string ownerid = "AUKCrAYTwL";

		// Token: 0x040002F3 RID: 755
		private static string secret = "f3e7d5e3ca10ba4798b856784609446fefd4b10dc38ea11077231be188e2ace5";

		// Token: 0x040002F4 RID: 756
		private static string version = "24.0";

		// Token: 0x040002F5 RID: 757
		public static api KeyAuthApp = new api(Login.name, Login.ownerid, Login.secret, Login.version);
	}
}
