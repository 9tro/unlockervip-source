using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;

namespace ns0
{
	// Token: 0x02000031 RID: 49
	internal class Class31
	{
		// Token: 0x06000215 RID: 533 RVA: 0x000049C7 File Offset: 0x00002BC7
		public void method_0()
		{
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00008704 File Offset: 0x00006904
		private void method_1()
		{
			Form1.object_0.Text_Ready.ForeColor = Color.Orange;
			Form1.object_0.Text_Ready.Text = "Tool is Updating.";
			ulong num = Class0.class0_0.method_53(Class0.class0_0.method_1(), Class0.class0_0.method_1() + Class0.class0_0.method_3(), new byte[]
			{
				51,
				byte.MaxValue,
				72,
				141,
				21,
				0,
				0,
				0,
				0,
				72,
				137,
				5,
				0,
				0,
				0,
				0,
				72,
				141,
				13
			}, "zzzzz????zzz????zzz", (Class0.Enum8)64U, 1UL) + 12UL;
			if (Class0.class0_0.method_11(num))
			{
				int num2 = Class0.class0_0.method_17(num, false);
				if (!Class31.bool_3)
				{
					if (Class31.bool_4)
					{
						Class32.ulong_0 = num + (ulong)((long)num2) + 4UL - Class0.class0_0.method_1();
					}
				}
				else
				{
					Class32.ulong_1 = num + (ulong)((long)num2) + 4UL - Class0.class0_0.method_1();
				}
			}
			else
			{
				Class13.smethod_5(true, "Could not find unlock all sig");
			}
			Form1.object_0.Text_Ready.ForeColor = Color.Green;
			Form1.object_0.Text_Ready.Text = "Tool is Updated and Ready";
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00008810 File Offset: 0x00006A10
		public void method_2()
		{
			new Form1();
			if (!Form1.bool_3 && !Form1.bool_4 && !Form1.bool_5 && !Form1.bool_6)
			{
				ulong num = Class0.class0_0.method_53(1099511627776UL, 4398046511104UL, new byte[]
				{
					48,
					0,
					99,
					97,
					109,
					111,
					95,
					48,
					49,
					97,
					0
				}, "", (Class0.Enum8)4U, 1UL) + 2UL;
				if (Class0.class0_0.method_11(num))
				{
					Class32.ulong_2 = num;
					Form1.bool_3 = true;
					if (Form1.object_0.Progress_Scan.Progress < 20)
					{
						Form1.object_0.Progress_Scan.Progress = 20;
					}
					Form1.object_0.Text_Ready.ForeColor = Color.Orange;
					Form1.object_0.Text_Ready.Text = "Found some Chickens!";
				}
				ulong ulong_ = Class0.class0_0.method_53(1099511627776UL, 4398046511104UL, new byte[]
				{
					111,
					115,
					47,
					99,
					97,
					109,
					111,
					95,
					48,
					49,
					97,
					0
				}, "", (Class0.Enum8)4U, 1UL) + 3UL;
				if (Class0.class0_0.method_11(ulong_))
				{
					Class32.ulong_3 = ulong_;
					Form1.bool_4 = true;
					if (Form1.object_0.Progress_Scan.Progress < 40)
					{
						Form1.object_0.Progress_Scan.Progress = 40;
					}
					Form1.object_0.Text_Ready.ForeColor = Color.White;
					Form1.object_0.Text_Ready.Text = "Mixing special sauce!";
				}
				ulong ulong_2 = Class0.class0_0.method_53(1099511627776UL, 4398046511104UL, new byte[]
				{
					99,
					97,
					109,
					111,
					95,
					109,
					112,
					95,
					116,
					57,
					116,
					105,
					101,
					114,
					49,
					95,
					48,
					49,
					0,
					0,
					0,
					0,
					0,
					0,
					0,
					0,
					0,
					0
				}, "xxxxxxxxxxxxxxxxxxx????????x", (Class0.Enum8)4U, 1UL);
				if (Class0.class0_0.method_11(ulong_2))
				{
					Class32.ulong_3 = ulong_2;
					Form1.bool_5 = true;
					if (Form1.object_0.Progress_Scan.Progress < 60)
					{
						Form1.object_0.Progress_Scan.Progress = 60;
					}
					Form1.object_0.Text_Ready.ForeColor = Color.Red;
					Form1.object_0.Text_Ready.Text = "Preparing your order...";
				}
				ulong num2 = Class0.class0_0.method_53(1099511627776UL, 4398046511104UL, new byte[]
				{
					47,
					99,
					97,
					109,
					111,
					95,
					109,
					112,
					95,
					116,
					57,
					116,
					105,
					101,
					114,
					49,
					95,
					48,
					49,
					0
				}, "", (Class0.Enum8)4U, 1UL);
				if (Class0.class0_0.method_11(num2))
				{
					Class32.ulong_5 = num2;
					Form1.bool_6 = true;
					if (Form1.object_0.Progress_Scan.Progress < 80)
					{
						Form1.object_0.Progress_Scan.Progress = 80;
					}
					Form1.object_0.Text_Ready.ForeColor = Color.White;
					Form1.object_0.Text_Ready.Text = "Enjoy!";
				}
			}
			if (Form1.bool_3 && Form1.bool_4 && Form1.bool_5 && Form1.bool_6)
			{
				Form1.bool_2 = true;
				return;
			}
			Form1.object_0.Text_Ready.ForeColor = Color.Red;
			Form1.object_0.Text_Ready.Text = "FAILED TO UPDATE!";
			Class8.Class9.smethod_0("Please try that again, make sure you are not at the main menu!", "Failed to Update", 5000);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00008B20 File Offset: 0x00006D20
		public void method_3()
		{
			for (;;)
			{
				Process[] processesByName = Process.GetProcessesByName("ModernWarfare");
				Process[] processesByName2 = Process.GetProcessesByName("Vanguard");
				if (processesByName2.Length != 0)
				{
					Class6.form1_0.Show();
					Class31.bool_3 = true;
					Form1.object_0.Label_Game.Text = "Vanguard Detected";
					while (processesByName2[0].StartTime.AddSeconds(30.0) > DateTime.Now)
					{
						Form1.object_0.Text_Ready.ForeColor = Color.White;
						Form1.object_0.Text_Ready.Text = "Game Found! Preparing to Update...";
					}
					if (Class0.class0_0 == null || processesByName2[0].Id != (int)Class0.class0_0.method_5())
					{
						Class0.class0_0 = new Class0();
						if (Class0.class0_0.method_10("Vanguard"))
						{
							Form1.ulong_1 = Class0.class0_0.method_46();
						}
						else
						{
							Class13.smethod_5(true, "Backup driver loading failed");
						}
						Class6.form1_0.Visible = true;
						Form1.object_0.Height = 112;
						Class6.form1_0.Visible = false;
						Class6.form1_0.Visible = true;
						while (Form1.object_0 == null)
						{
						}
						this.method_1();
						Class31.bool_0 = true;
					}
				}
				else if (processesByName.Length == 0)
				{
					Class31.bool_0 = false;
					Class31.bool_3 = false;
					Class31.bool_4 = false;
					Form1.object_0.BTN_Unlockall.Enabled = false;
					if (Class0.class0_0 != null)
					{
						Form1.object_0.Text_Ready.ForeColor = Color.Yellow;
						Form1.object_0.Text_Ready.Text = "Please Re-Launch Vanguard or Warzone!";
						Form1.object_0.Label_Game.Text = "???";
					}
					else
					{
						Class8.Class9.smethod_0("Please Launch Vanguard OR Warzone", "1LOCKED\0\0ModernWarfare | Warzone | Vanguard Unlocker", 15000);
					}
					while (Process.GetProcessesByName("ModernWarfare").Length == 0 && Process.GetProcessesByName("Vanguard").Length == 0)
					{
						Thread.Sleep(500);
					}
					Form1.object_0.BTN_Unlockall.Enabled = true;
				}
				else
				{
					Class6.form1_0.Show();
					Class31.bool_4 = true;
					Form1.object_0.Label_Game.Text = "Call Of Duty WZ/MW Found!!";
					while (processesByName[0].StartTime.AddSeconds(30.0) > DateTime.Now)
					{
						Form1.object_0.Text_Ready.ForeColor = Color.White;
						Form1.object_0.Text_Ready.Text = "Game Found! Preparing to Update...";
					}
					if (Class0.class0_0 == null || processesByName[0].Id != (int)Class0.class0_0.method_5())
					{
						Class0.class0_0 = new Class0();
						if (Class0.class0_0.method_10("ModernWarfare"))
						{
							Form1.ulong_1 = Class0.class0_0.method_46();
						}
						else
						{
							Class13.smethod_5(true, "Backup driver loading failed");
						}
						Class6.form1_0.Visible = true;
						Form1.object_0.Height = 303;
						Class6.form1_0.Visible = false;
						Class6.form1_0.Visible = true;
						while (Form1.object_0 == null)
						{
						}
						this.method_1();
						Class31.bool_0 = true;
					}
				}
				Thread.Sleep(1000);
			}
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00008E2C File Offset: 0x0000702C
		public void method_4()
		{
			while (!Form1.bool_1)
			{
			}
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00008E35 File Offset: 0x00007035
		internal static bool smethod_0()
		{
			return Class31.object_0 == null;
		}

		// Token: 0x04000100 RID: 256
		public static bool bool_0;

		// Token: 0x04000101 RID: 257
		public static bool bool_1;

		// Token: 0x04000102 RID: 258
		public static bool bool_2;

		// Token: 0x04000103 RID: 259
		public static bool bool_3;

		// Token: 0x04000104 RID: 260
		public static bool bool_4;

		// Token: 0x04000105 RID: 261
		internal static object object_0;
	}
}
