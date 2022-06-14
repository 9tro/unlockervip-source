using System;
using System.Collections.Generic;
using System.Globalization;
using System.Management;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace ns0
{
	// Token: 0x02000014 RID: 20
	internal class Class10
	{
		// Token: 0x060000BD RID: 189 RVA: 0x00004504 File Offset: 0x00002704
		public static string smethod_0(string string_1, string string_2)
		{
			string text = "";
			foreach (ManagementBaseObject managementBaseObject in new ManagementClass(string_1).GetInstances())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				if (text == "")
				{
					try
					{
						text = managementObject[string_2].ToString();
						break;
					}
					catch
					{
					}
				}
			}
			return text;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00004588 File Offset: 0x00002788
		[CompilerGenerated]
		public string method_0()
		{
			return this.string_0;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00004590 File Offset: 0x00002790
		[CompilerGenerated]
		private void method_1(string string_1)
		{
			this.string_0 = string_1;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000459C File Offset: 0x0000279C
		~Class10()
		{
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000045C4 File Offset: 0x000027C4
		public string method_2()
		{
			string[] value = new string[]
			{
				this.method_3(Class10.Class11.string_3)
			};
			string result;
			this.method_1(result = this.method_5(string.Join(string.Empty, value)));
			return result;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00004600 File Offset: 0x00002800
		private string method_3(string[] string_1)
		{
			StringBuilder stringBuilder = new StringBuilder();
			string queryString = this.method_4(string_1);
			using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", queryString))
			{
				using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
				{
					foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
					{
						using (managementBaseObject)
						{
							for (int i = 1; i < string_1.Length; i++)
							{
								stringBuilder.Append(managementBaseObject[string_1[i]]);
							}
						}
					}
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000046DC File Offset: 0x000028DC
		private string method_4(string[] string_1)
		{
			StringBuilder stringBuilder = new StringBuilder();
			string str = string.Empty;
			stringBuilder.Append("SELECT ");
			for (int i = 0; i < string_1.Length; i++)
			{
				if (i != 0)
				{
					stringBuilder.Append((i >= string_1.Length - 1) ? (string_1[i] + " ") : (string_1[i] + ", "));
				}
				else
				{
					str = string_1[i];
				}
			}
			stringBuilder.Append("FROM " + str);
			return stringBuilder.ToString();
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000475C File Offset: 0x0000295C
		private string method_5(string string_1)
		{
			string result;
			using (SHA1CryptoServiceProvider sha1CryptoServiceProvider = new SHA1CryptoServiceProvider())
			{
				byte[] ilist_ = sha1CryptoServiceProvider.ComputeHash(Encoding.Default.GetBytes(string_1));
				result = this.method_6(ilist_);
			}
			return result;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000047A8 File Offset: 0x000029A8
		private string method_6(IList<byte> ilist_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < ilist_0.Count; i++)
			{
				byte b = ilist_0[i];
				int num = (int)(b & 15);
				int num2 = b >> 4 & 15;
				if (num2 > 9)
				{
					stringBuilder.Append(((char)(num2 - 10 + 65)).ToString(CultureInfo.InvariantCulture));
				}
				else
				{
					stringBuilder.Append(num2.ToString(CultureInfo.InvariantCulture));
				}
				if (num > 9)
				{
					stringBuilder.Append(((char)(num - 10 + 65)).ToString(CultureInfo.InvariantCulture));
				}
				else
				{
					stringBuilder.Append(num.ToString(CultureInfo.InvariantCulture));
				}
				if (i + 1 != ilist_0.Count && (i + 1) % 2 == 0)
				{
					stringBuilder.Append("-");
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00004876 File Offset: 0x00002A76
		internal static bool smethod_1()
		{
			return Class10.object_0 == null;
		}

		// Token: 0x0400006C RID: 108
		[CompilerGenerated]
		private string string_0 = string.Empty;

		// Token: 0x0400006D RID: 109
		internal static object object_0;

		// Token: 0x02000015 RID: 21
		private static class Class11
		{
			// Token: 0x060000C8 RID: 200 RVA: 0x00004893 File Offset: 0x00002A93
			internal static bool smethod_0()
			{
				return Class10.Class11.object_0 == null;
			}

			// Token: 0x0400006E RID: 110
			public static readonly string[] string_0 = new string[]
			{
				"Win32_BaseBoard",
				"Name",
				"Manufacturer",
				"Version"
			};

			// Token: 0x0400006F RID: 111
			public static readonly string[] string_1 = new string[]
			{
				"Win32_VideoController",
				"Name",
				"DeviceID",
				"DriverVersion"
			};

			// Token: 0x04000070 RID: 112
			public static readonly string[] string_2 = new string[]
			{
				"Win32_CDROMDrive",
				"Name",
				"Manufacturer",
				"DeviceID"
			};

			// Token: 0x04000071 RID: 113
			public static readonly string[] string_3 = new string[]
			{
				"Win32_Processor",
				"Name",
				"Manufacturer",
				"ProcessorId"
			};

			// Token: 0x04000072 RID: 114
			public static readonly string[] string_4 = new string[]
			{
				"Win32_DiskDrive",
				"Name",
				"Manufacturer",
				"Model"
			};

			// Token: 0x04000073 RID: 115
			public static readonly string[] string_5 = new string[]
			{
				"Win32_BIOS",
				"Name",
				"Manufacturer",
				"Version"
			};

			// Token: 0x04000074 RID: 116
			internal static object object_0;
		}
	}
}
