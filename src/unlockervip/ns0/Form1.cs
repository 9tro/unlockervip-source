using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using ReaLTaiizor.Controls;
using Siticone.UI.WinForms;

namespace ns0
{
	// Token: 0x02000051 RID: 81
	internal partial class Form1 : Form
	{
		// Token: 0x0600023F RID: 575 RVA: 0x000096F8 File Offset: 0x000078F8
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000240 RID: 576 RVA: 0x000097D5 File Offset: 0x000079D5
		private void Label_Title_MouseDown(object sender, MouseEventArgs e)
		{
			this.bool_0 = true;
			this.point_0 = e.Location;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x000097EA File Offset: 0x000079EA
		private void Label_Title_MouseUp(object sender, MouseEventArgs e)
		{
			this.bool_0 = false;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x000097F4 File Offset: 0x000079F4
		private void Label_Title_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.bool_0)
			{
				base.Location = new Point(base.Location.X - this.point_0.X + e.X, base.Location.Y - this.point_0.Y + e.Y);
				base.Update();
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000985C File Offset: 0x00007A5C
		private void Btn_Close_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000244 RID: 580 RVA: 0x000049C7 File Offset: 0x00002BC7
		private void method_0()
		{
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00009864 File Offset: 0x00007A64
		public static void smethod_0()
		{
			Form1.bool_1 = false;
			byte[] array = new byte[]
			{
				72,
				131,
				196,
				8,
				72,
				139,
				92,
				36,
				48,
				72,
				139,
				116,
				36,
				56,
				72,
				131,
				196,
				32,
				95,
				72,
				199,
				192,
				1,
				0,
				0,
				0,
				195
			};
			Form1.byte_0 = new byte[27];
			if (!Class31.bool_3)
			{
				if (Class31.bool_4)
				{
					Form1.ulong_0 = Class0.class0_0.method_18(Class0.class0_0.method_1() + Class32.ulong_0, false);
				}
			}
			else
			{
				Form1.ulong_0 = Class0.class0_0.method_18(Class0.class0_0.method_1() + Class32.ulong_1, false);
			}
			byte[] array2 = Class0.class0_0.method_13(Form1.ulong_0, 96, false);
			Class0.class0_0.method_30(Form1.ulong_1, array2, false);
			ulong num = Class0.class0_0.method_24(new ulong[]
			{
				Form1.ulong_1 + (ulong)((long)array2.Length)
			});
			byte[] bytes = BitConverter.GetBytes(num);
			Class0.class0_0.method_30(num, array, false);
			Class0.class0_0.method_30(Form1.ulong_1 + 8UL, bytes, false);
			if (Class31.bool_3)
			{
				Class0.class0_0.method_35(Class0.class0_0.method_1() + Class32.ulong_1, (long)Form1.ulong_1, false);
			}
			else if (Class31.bool_4)
			{
				Class0.class0_0.method_35(Class0.class0_0.method_1() + Class32.ulong_0, (long)Form1.ulong_1, false);
			}
			Class8.Class9.smethod_0("Everything Unlocked", "Success", 5000);
			Form1.bool_1 = true;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x000099BA File Offset: 0x00007BBA
		private void Form1_Load(object sender, EventArgs e)
		{
			Control.CheckForIllegalCrossThreadCalls = false;
			Control.CheckForIllegalCrossThreadCalls = false;
			Control.CheckForIllegalCrossThreadCalls = false;
			Control.CheckForIllegalCrossThreadCalls = false;
			Control.CheckForIllegalCrossThreadCalls = false;
			string[] string_ = Class13.Class14.string_6;
			Form1.object_0 = this;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x000099E8 File Offset: 0x00007BE8
		private void method_1()
		{
			byte[] array = new byte[1];
			Class0.class0_0.method_30(0UL, array, false);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00009A0A File Offset: 0x00007C0A
		private void BTN_Unlockall_Click(object sender, EventArgs e)
		{
			if (Form1.bool_1)
			{
				Form1.smethod_0();
			}
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00009A18 File Offset: 0x00007C18
		private void BTN_CamoSwap_Click(object sender, EventArgs e)
		{
			this.method_2();
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00009A20 File Offset: 0x00007C20
		public void method_2()
		{
			if (!Form1.bool_7)
			{
				Class0 class0_ = Class0.class0_0;
				ulong[] array = new ulong[]
				{
					0UL,
					256UL,
					8UL,
					16UL,
					172UL,
					80UL,
					2316UL,
					7UL
				};
				array[0] = Class0.class0_0.method_1() + Class32.ulong_2;
				Class32.ulong_2 = class0_.method_24(array);
				Class32.ulong_3 = Class0.class0_0.method_24(new ulong[]
				{
					Class0.class0_0.method_1() + Class32.ulong_3,
					472UL,
					0UL,
					59UL
				});
				Class32.ulong_4 = Class32.ulong_2 + 582097UL;
				Class32.ulong_5 = Class32.ulong_3 + 15039UL;
				Class32.ulong_6 = Class32.ulong_2 + 2882UL;
				Class32.ulong_7 = Class32.ulong_3 + 11164UL;
				string a = Class0.class0_0.method_25(Class32.ulong_2, 8, false);
				string a2 = Class0.class0_0.method_25(Class32.ulong_3, 8, false);
				string a3 = Class0.class0_0.method_25(Class32.ulong_4, 18, false);
				string a4 = Class0.class0_0.method_25(Class32.ulong_5, 18, false);
				string a5 = Class0.class0_0.method_25(Class32.ulong_6, 11, false);
				string a6 = Class0.class0_0.method_25(Class32.ulong_7, 11, false);
				if (a != "camo_01a" && a2 != "camo_01a" && a3 != "camo_mp_t9tier1_01" && a4 != "camo_mp_t9tier1_01" && a5 != "s4_camo_01a" && a6 != "s4_camo_01a")
				{
					Class8.Class9.smethod_0("Looks like we couldn't do that\n Try going to the weapon menu first!", "Uh-Oh", 10000);
				}
				else
				{
					Form1.bool_7 = true;
				}
			}
			if (!Form1.bool_7)
			{
				Class8.Class9.smethod_0("Please goto your classes first", "That's a bug", 5000);
			}
			else
			{
				Class8.Class9.smethod_0("Your camos have been swapped", "Sucess", 2000);
			}
			if (!Form1.bool_7)
			{
				Class8.Class9.smethod_0("If you are @ your classes and getting this message...\nGoto your classes and try again \nRestart the Game\nUpdate Time Maybe?", "Something fucked up!", 5000);
			}
		}

		// Token: 0x0600024B RID: 587 RVA: 0x000049C7 File Offset: 0x00002BC7
		private void Text_Swapper_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00009C14 File Offset: 0x00007E14
		private void timer_0_Tick(object sender, EventArgs e)
		{
			if (this.Progress_Scan.Progress < 100)
			{
				if (this.Progress_Scan.Progress < 80)
				{
					LostProgressBar progress_Scan = this.Progress_Scan;
					int progress = progress_Scan.Progress;
					progress_Scan.Progress = progress + 1;
				}
				else
				{
					this.Progress_Scan.Progress += 5;
				}
				if (this.Progress_Scan.Progress == 100)
				{
					if (Form1.bool_3 && Form1.bool_4 && Form1.bool_5 && Form1.bool_6)
					{
						this.method_2();
					}
					this.timer_0.Stop();
					this.Progress_Scan.Progress = 0;
					this.Progress_Scan.Visible = false;
					this.Text_Ready.ForeColor = Color.White;
					this.Text_Ready.Text = "Tool is Updated and Ready!";
				}
			}
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00009CE0 File Offset: 0x00007EE0
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (Form1.bool_3 && Form1.bool_4 && Form1.bool_5 && Form1.bool_6)
			{
				Class0.class0_0.method_42(Class32.ulong_2, "camo_01a", false);
				Class0.class0_0.method_42(Class32.ulong_3, "camo_01a", false);
				Class0.class0_0.method_42(Class32.ulong_4, "camo_mp_t9tier1_01", false);
				Class0.class0_0.method_42(Class32.ulong_5, "camo_mp_t9tier1_01", false);
				Class0.class0_0.method_42(Class32.ulong_6, "s4_camo_01a", false);
				Class0.class0_0.method_42(Class32.ulong_7, "s4_camo_01a", false);
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00009D90 File Offset: 0x00007F90
		internal static bool smethod_1()
		{
			return Form1.object_1 == null;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00009A0A File Offset: 0x00007C0A
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			if (Form1.bool_1)
			{
				Form1.smethod_0();
			}
		}

		// Token: 0x06000250 RID: 592 RVA: 0x000049C7 File Offset: 0x00002BC7
		private void Text_Ready_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00009D9A File Offset: 0x00007F9A
		private void button1_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/gnQWvmRsDn");
		}

		// Token: 0x0400027E RID: 638
		private bool bool_0;

		// Token: 0x0400027F RID: 639
		private Point point_0;

		// Token: 0x04000280 RID: 640
		public static Form1 object_0;

		// Token: 0x04000281 RID: 641
		public static bool bool_1 = true;

		// Token: 0x04000282 RID: 642
		public static byte[] byte_0 = new byte[1];

		// Token: 0x04000283 RID: 643
		public static ulong ulong_0 = 0UL;

		// Token: 0x04000284 RID: 644
		public static ulong ulong_1 = 0UL;

		// Token: 0x04000285 RID: 645
		public static bool bool_2 = false;

		// Token: 0x04000286 RID: 646
		public static bool bool_3 = false;

		// Token: 0x04000287 RID: 647
		public static bool bool_4 = false;

		// Token: 0x04000288 RID: 648
		public static bool bool_5 = false;

		// Token: 0x04000289 RID: 649
		public static bool bool_6 = false;

		// Token: 0x0400028A RID: 650
		public static bool bool_7 = false;

		// Token: 0x0400028B RID: 651
		private string[] string_0 = new string[]
		{
			"camo_mp_t9mastery_gold",
			"camo_mp_t9mastery_diamond",
			"camo_mp_t9mastery_darkmatter",
			"s4_camo_11a",
			"s4_camo_11b",
			"s4_camo_11c"
		};

		// Token: 0x0400028C RID: 652
		private string[] string_1 = new string[]
		{
			"camo_11a",
			"camo_11b",
			"camo_11c",
			"camo_11d",
			"s4_camo_11a",
			"s4_camo_11b",
			"s4_camo_11c"
		};

		// Token: 0x0400028D RID: 653
		private string[] string_2 = new string[]
		{
			"camo_11a",
			"camo_11b",
			"camo_11c",
			"camo_11d",
			"camo_mp_t9mastery_gold",
			"camo_mp_t9mastery_diamond",
			"camo_mp_t9mastery_darkmatter"
		};

		// Token: 0x0400028E RID: 654
		internal static object object_1;
	}
}
