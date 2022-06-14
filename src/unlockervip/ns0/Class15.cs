using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ns0
{
	// Token: 0x02000019 RID: 25
	internal class Class15
	{
		// Token: 0x060000E0 RID: 224
		[DllImport("wtsapi32.dll")]
		private static extern IntPtr WTSOpenServer([MarshalAs(UnmanagedType.LPStr)] string string_0);

		// Token: 0x060000E1 RID: 225
		[DllImport("wtsapi32.dll")]
		private static extern void WTSCloseServer(IntPtr intptr_0);

		// Token: 0x060000E2 RID: 226
		[DllImport("wtsapi32.dll")]
		private static extern int WTSEnumerateSessions(IntPtr intptr_0, [MarshalAs(UnmanagedType.U4)] int int_0, [MarshalAs(UnmanagedType.U4)] int int_1, ref IntPtr intptr_1, [MarshalAs(UnmanagedType.U4)] ref int int_2);

		// Token: 0x060000E3 RID: 227
		[DllImport("wtsapi32.dll")]
		private static extern void WTSFreeMemory(IntPtr intptr_0);

		// Token: 0x060000E4 RID: 228
		[DllImport("wtsapi32.dll")]
		private static extern bool WTSQuerySessionInformation(IntPtr intptr_0, int int_0, Class15.Enum11 enum11_0, out IntPtr intptr_1, out uint uint_0);

		// Token: 0x060000E5 RID: 229 RVA: 0x000052A0 File Offset: 0x000034A0
		public static int smethod_0(string string_0)
		{
			IntPtr intptr_ = IntPtr.Zero;
			new List<string>();
			intptr_ = Class15.WTSOpenServer(string_0);
			int num = 0;
			try
			{
				IntPtr zero = IntPtr.Zero;
				IntPtr zero2 = IntPtr.Zero;
				IntPtr zero3 = IntPtr.Zero;
				int num2 = 0;
				bool flag = Class15.WTSEnumerateSessions(intptr_, 0, 1, ref zero, ref num2) != 0;
				int offset = Marshal.SizeOf(typeof(Class15.Struct8));
				IntPtr intPtr = zero;
				uint num3 = 0U;
				if (flag)
				{
					for (int i = 0; i < num2; i++)
					{
						Class15.Struct8 @struct = (Class15.Struct8)Marshal.PtrToStructure(intPtr, typeof(Class15.Struct8));
						intPtr += offset;
						Class15.WTSQuerySessionInformation(intptr_, @struct.int_0, (Class15.Enum11)5, out zero2, out num3);
						Class15.WTSQuerySessionInformation(intptr_, @struct.int_0, (Class15.Enum11)7, out zero3, out num3);
						if (Marshal.PtrToStringAnsi(zero2) != "")
						{
							num++;
						}
						Class15.WTSFreeMemory(zero2);
						Class15.WTSFreeMemory(zero3);
					}
					Class15.WTSFreeMemory(zero);
				}
			}
			finally
			{
				Class15.WTSCloseServer(intptr_);
			}
			return num;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000053A0 File Offset: 0x000035A0
		internal static bool smethod_1()
		{
			return Class15.object_0 == null;
		}

		// Token: 0x04000089 RID: 137
		internal static object object_0;

		// Token: 0x0200001A RID: 26
		private struct Struct8
		{
			// Token: 0x0400008A RID: 138
			public int int_0;

			// Token: 0x0400008B RID: 139
			[MarshalAs(UnmanagedType.LPStr)]
			public string string_0;

			// Token: 0x0400008C RID: 140
			public Class15.Enum12 enum12_0;
		}

		// Token: 0x0200001B RID: 27
		internal enum Enum11
		{

		}

		// Token: 0x0200001C RID: 28
		internal enum Enum12
		{

		}
	}
}
