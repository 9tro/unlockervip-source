using System;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.Win32.SafeHandles;

namespace ns0
{
	// Token: 0x02000020 RID: 32
	internal static class Class18
	{
		// Token: 0x060000F5 RID: 245
		[DllImport("ntdll.dll", SetLastError = true)]
		internal static extern uint NtCreateSection(ref IntPtr intptr_0, uint uint_0, IntPtr intptr_1, ref ulong ulong_0, uint uint_1, uint uint_2, IntPtr intptr_2);

		// Token: 0x060000F6 RID: 246
		[DllImport("ntdll.dll", SetLastError = true)]
		internal static extern uint NtOpenSection(ref IntPtr intptr_0, uint uint_0, IntPtr intptr_1);

		// Token: 0x060000F7 RID: 247
		[DllImport("ntdll.dll", SetLastError = true)]
		internal static extern uint NtMapViewOfSection(IntPtr intptr_0, IntPtr intptr_1, ref IntPtr intptr_2, UIntPtr uintptr_0, UIntPtr uintptr_1, out ulong ulong_0, out uint uint_0, uint uint_1, uint uint_2, uint uint_3);

		// Token: 0x060000F8 RID: 248
		[DllImport("ntdll.dll", SetLastError = true)]
		internal static extern uint NtCreateEvent(ref IntPtr intptr_0, uint uint_0, IntPtr intptr_1, uint uint_1, bool bool_0);

		// Token: 0x060000F9 RID: 249
		[DllImport("ntdll.dll", SetLastError = true)]
		internal static extern uint NtOpenEvent(ref IntPtr intptr_0, uint uint_0, IntPtr intptr_1);

		// Token: 0x060000FA RID: 250
		[DllImport("ntdll.dll", SetLastError = true)]
		internal static extern uint NtClose(IntPtr intptr_0);

		// Token: 0x060000FB RID: 251
		[DllImport("kernel32.dll")]
		internal static extern void CopyMemory(IntPtr intptr_0, IntPtr intptr_1, uint uint_0);

		// Token: 0x060000FC RID: 252
		[DllImport("kernel32.dll")]
		internal static extern IntPtr LoadLibrary(string string_0);

		// Token: 0x060000FD RID: 253
		[DllImport("kernel32.dll")]
		internal static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_0);

		// Token: 0x060000FE RID: 254
		[DllImport("kernel32.dll")]
		internal static extern bool FreeLibrary(IntPtr intptr_0);

		// Token: 0x060000FF RID: 255
		[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		internal static extern IntPtr OpenSCManagerW(string string_0, string string_1, uint uint_0);

		// Token: 0x06000100 RID: 256
		[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		internal static extern IntPtr CreateService(IntPtr intptr_0, string string_0, string string_1, uint uint_0, uint uint_1, uint uint_2, uint uint_3, string string_2, string string_3, string string_4, string string_5, string string_6, string string_7);

		// Token: 0x06000101 RID: 257
		[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		internal static extern IntPtr OpenService(IntPtr intptr_0, string string_0, uint uint_0);

		// Token: 0x06000102 RID: 258
		[DllImport("advapi32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool DeleteService(IntPtr intptr_0);

		// Token: 0x06000103 RID: 259
		[DllImport("advapi32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CloseServiceHandle(IntPtr intptr_0);

		// Token: 0x06000104 RID: 260
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[SuppressUnmanagedCodeSecurity]
		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CloseHandle(IntPtr intptr_0);

		// Token: 0x06000105 RID: 261
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		internal static extern SafeFileHandle CreateFile(string string_0, [MarshalAs(UnmanagedType.U4)] FileAccess fileAccess_0, [MarshalAs(UnmanagedType.U4)] FileShare fileShare_0, IntPtr intptr_0, [MarshalAs(UnmanagedType.U4)] FileMode fileMode_0, [MarshalAs(UnmanagedType.U4)] uint uint_0, IntPtr intptr_1);

		// Token: 0x06000106 RID: 262 RVA: 0x0000559D File Offset: 0x0000379D
		internal static uint smethod_0(uint uint_0, uint uint_1, uint uint_2, uint uint_3)
		{
			return uint_0 << 16 | uint_3 << 14 | uint_1 << 2 | uint_2;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000055AE File Offset: 0x000037AE
		internal static bool smethod_1()
		{
			return Class18.object_0 == null;
		}

		// Token: 0x04000092 RID: 146
		private static object object_0;
	}
}
