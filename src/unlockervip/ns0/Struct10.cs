using System;
using System.Runtime.InteropServices;

namespace ns0
{
	// Token: 0x02000055 RID: 85
	internal struct Struct10 : IDisposable
	{
		// Token: 0x06000278 RID: 632 RVA: 0x0000A9AC File Offset: 0x00008BAC
		public Struct10(string string_0, uint uint_1)
		{
			this.int_0 = 0;
			this.intptr_0 = IntPtr.Zero;
			this.intptr_1 = IntPtr.Zero;
			this.uint_0 = uint_1;
			this.intptr_2 = IntPtr.Zero;
			this.intptr_3 = IntPtr.Zero;
			this.int_0 = Marshal.SizeOf<Struct10>(this);
			this.method_1(new Struct11(string_0));
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000AA10 File Offset: 0x00008C10
		public Struct11 method_0()
		{
			return (Struct11)Marshal.PtrToStructure(this.intptr_1, typeof(Struct11));
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0000AA2C File Offset: 0x00008C2C
		public void method_1(Struct11 struct11_0)
		{
			bool fDeleteOld;
			if (!(fDeleteOld = (this.intptr_1 != IntPtr.Zero)))
			{
				this.intptr_1 = Marshal.AllocHGlobal(Marshal.SizeOf<Struct11>(struct11_0));
			}
			Marshal.StructureToPtr<Struct11>(struct11_0, this.intptr_1, fDeleteOld);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000AA6B File Offset: 0x00008C6B
		public void Dispose()
		{
			if (this.intptr_1 != IntPtr.Zero)
			{
				Marshal.DestroyStructure(this.intptr_1, typeof(Struct11));
				Marshal.FreeHGlobal(this.intptr_1);
				this.intptr_1 = IntPtr.Zero;
			}
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000AAAA File Offset: 0x00008CAA
		internal static bool smethod_0()
		{
			return Struct10.object_0 == null;
		}

		// Token: 0x0400029F RID: 671
		public int int_0;

		// Token: 0x040002A0 RID: 672
		public IntPtr intptr_0;

		// Token: 0x040002A1 RID: 673
		private IntPtr intptr_1;

		// Token: 0x040002A2 RID: 674
		public uint uint_0;

		// Token: 0x040002A3 RID: 675
		public IntPtr intptr_2;

		// Token: 0x040002A4 RID: 676
		public IntPtr intptr_3;

		// Token: 0x040002A5 RID: 677
		internal static object object_0;
	}
}
