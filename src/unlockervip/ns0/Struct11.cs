using System;
using System.Runtime.InteropServices;

namespace ns0
{
	// Token: 0x02000056 RID: 86
	internal struct Struct11 : IDisposable
	{
		// Token: 0x0600027D RID: 637 RVA: 0x0000AAB4 File Offset: 0x00008CB4
		public Struct11(string string_0)
		{
			this.ushort_0 = (ushort)(string_0.Length * 2);
			this.ushort_1 = this.ushort_0 + 2;
			this.intptr_0 = Marshal.StringToHGlobalUni(string_0);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000AAE0 File Offset: 0x00008CE0
		public void Dispose()
		{
			Marshal.FreeHGlobal(this.intptr_0);
			this.intptr_0 = IntPtr.Zero;
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000AAF8 File Offset: 0x00008CF8
		public override string ToString()
		{
			return Marshal.PtrToStringUni(this.intptr_0);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000AB05 File Offset: 0x00008D05
		internal static bool smethod_0()
		{
			return Struct11.object_0 == null;
		}

		// Token: 0x040002A6 RID: 678
		public ushort ushort_0;

		// Token: 0x040002A7 RID: 679
		public ushort ushort_1;

		// Token: 0x040002A8 RID: 680
		private IntPtr intptr_0;

		// Token: 0x040002A9 RID: 681
		internal static object object_0;
	}
}
