using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using unlockervip.Properties;

namespace ns0
{
	// Token: 0x02000038 RID: 56
	internal class Class8
	{
		// Token: 0x06000235 RID: 565 RVA: 0x000092B4 File Offset: 0x000074B4
		public static void smethod_0()
		{
			Class12.thread_0.Abort();
			Process.Start(new ProcessStartInfo
			{
				Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Class12.string_0 + "\"",
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = "cmd.exe"
			});
			Application.Exit();
			Environment.Exit(1);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00009314 File Offset: 0x00007514
		public static void smethod_1()
		{
			try
			{
				FileInfo fileInfo_ = new FileInfo("C:\\Windows\\System32\\drivers\\wmiacpi.sys");
				Class26 @class = new Class26();
				@class.method_1(Class0.string_0);
				@class.method_5("\\\\.\\\\" + Class0.string_0);
				@class.method_3(fileInfo_);
				@class.LoadMethod = (Enum27)0;
				Class25 class2 = new Class25(@class, null);
				if (!Class25.smethod_0(class2.Config.method_4(), class2.Config.IoMethod))
				{
					string text = Path.GetTempPath();
					if (text.EndsWith("\\"))
					{
						text = text.Remove(text.Length - 1, 1);
					}
					if (Directory.Exists(text + "\\Tool_Hub"))
					{
						if (File.Exists(text + "\\Tool_Hub\\ㅤ"))
						{
							try
							{
								File.Delete(text + "\\Tool_Hub\\ㅤ");
							}
							catch
							{
								MessageBox.Show("Error Loading Driver! Please Restart PC and try again.");
							}
						}
						if (File.Exists(text + "\\Tool_Hub\\NN.exe"))
						{
							try
							{
								File.Delete(text + "\\Tool_Hub\\NN.exe");
							}
							catch
							{
								MessageBox.Show("Error Loading Driver! Please Restart PC and try again.");
							}
						}
						File.WriteAllBytes(text + "\\Tool_Hub\\N.sys", Resources._11ㅤ);
						File.WriteAllBytes(text + "\\Tool_Hub\\NN.exe", Resources._111ㅤㅤ);
						try
						{
							Process process = new Process();
							process.StartInfo.FileName = "cmd.exe";
							process.StartInfo.RedirectStandardInput = true;
							process.StartInfo.RedirectStandardOutput = true;
							process.StartInfo.CreateNoWindow = true;
							process.StartInfo.UseShellExecute = false;
							process.StartInfo.Verb = "runas";
							process.Start();
							process.StandardInput.WriteLine("cd /d" + text + "\\Tool_Hub");
							process.StandardInput.WriteLine("NN.exe /i");
							process.StandardInput.WriteLine("NN.exe /l " + text + "\\Tool_Hub\\N.sys");
							process.StandardInput.WriteLine("NN.exe /u");
							process.StandardInput.Flush();
							process.StandardInput.Close();
							process.WaitForExit();
							string text2 = process.StandardOutput.ReadToEnd();
							if (!text2.Contains("N.sys loaded."))
							{
								MessageBox.Show("Driver Failed To Load At Injection Phase.");
								Class13.smethod_5(false, text2);
							}
							File.Delete(text + "\\Tool_Hub\\NN.exe");
							File.Move(text + "\\Tool_Hub\\N.sys", text + "\\Tool_Hub\\ㅤ");
							File.SetAttributes(text + "\\Tool_Hub\\ㅤ", FileAttributes.Hidden);
							goto IL_280;
						}
						catch
						{
							MessageBox.Show("Error Mapping Driver! Please Restart PC and try again.");
							goto IL_280;
						}
					}
					Directory.CreateDirectory(text + "\\Tool_Hub");
				}
				IL_280:;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				MessageBox.Show("Major Error Loading Driver! Please Restart PC and try again.");
				Class13.smethod_5(true, "Driver failed to load at TrryLoadDriver()");
			}
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0000962C File Offset: 0x0000782C
		internal static bool smethod_2()
		{
			return Class8.object_0 == null;
		}

		// Token: 0x04000119 RID: 281
		private static object object_0;

		// Token: 0x02000039 RID: 57
		internal class Class9
		{
			// Token: 0x06000239 RID: 569 RVA: 0x00009638 File Offset: 0x00007838
			private Class9(string string_1, string string_2, int int_0)
			{
				this.string_0 = string_2;
				this.timer_0 = new System.Threading.Timer(new TimerCallback(this.method_0), null, int_0, -1);
				using (this.timer_0)
				{
					MessageBox.Show(string_1, string_2);
				}
			}

			// Token: 0x0600023A RID: 570 RVA: 0x00009698 File Offset: 0x00007898
			public static void smethod_0(string string_1, string string_2, int int_0)
			{
				new Class8.Class9(string_1, string_2, int_0);
			}

			// Token: 0x0600023B RID: 571 RVA: 0x000096A4 File Offset: 0x000078A4
			private void method_0(object object_1)
			{
				IntPtr intPtr = Class8.Class9.FindWindow("#32770", this.string_0);
				if (intPtr != IntPtr.Zero)
				{
					Class8.Class9.SendMessage(intPtr, 16U, IntPtr.Zero, IntPtr.Zero);
				}
				this.timer_0.Dispose();
			}

			// Token: 0x0600023C RID: 572
			[DllImport("user32.dll", SetLastError = true)]
			private static extern IntPtr FindWindow(string string_1, string string_2);

			// Token: 0x0600023D RID: 573
			[DllImport("user32.dll", CharSet = CharSet.Auto)]
			private static extern IntPtr SendMessage(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

			// Token: 0x0600023E RID: 574 RVA: 0x000096ED File Offset: 0x000078ED
			internal static bool smethod_1()
			{
				return Class8.Class9.object_0 == null;
			}

			// Token: 0x0400011A RID: 282
			private System.Threading.Timer timer_0;

			// Token: 0x0400011B RID: 283
			private string string_0;

			// Token: 0x0400011C RID: 284
			private static object object_0;
		}
	}
}
