using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace ns0
{
	// Token: 0x0200002E RID: 46
	internal class Class28 : IDisposable, Interface1
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00007914 File Offset: 0x00005B14
		public Interface0 Driver { get; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x0000791C File Offset: 0x00005B1C
		// (set) Token: 0x060001CA RID: 458 RVA: 0x00007924 File Offset: 0x00005B24
		public SafeFileHandle Handle { get; private set; }

		// Token: 0x060001CB RID: 459 RVA: 0x0000792D File Offset: 0x00005B2D
		[CompilerGenerated]
		public EventHandler imethod_0()
		{
			return this.eventHandler_0;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00007935 File Offset: 0x00005B35
		[CompilerGenerated]
		public void imethod_1(EventHandler eventHandler_3)
		{
			this.eventHandler_0 = eventHandler_3;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0000793E File Offset: 0x00005B3E
		[CompilerGenerated]
		public EventHandler imethod_2()
		{
			return this.eventHandler_1;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00007946 File Offset: 0x00005B46
		[CompilerGenerated]
		public void imethod_3(EventHandler eventHandler_3)
		{
			this.eventHandler_1 = eventHandler_3;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0000794F File Offset: 0x00005B4F
		[CompilerGenerated]
		public EventHandler imethod_4()
		{
			return this.eventHandler_2;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00007957 File Offset: 0x00005B57
		[CompilerGenerated]
		public void imethod_5(EventHandler eventHandler_3)
		{
			this.eventHandler_2 = eventHandler_3;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00007960 File Offset: 0x00005B60
		public bool imethod_6()
		{
			return this.Handle != null && !this.Handle.IsInvalid && !this.Handle.IsClosed;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00007987 File Offset: 0x00005B87
		[CompilerGenerated]
		public bool imethod_7()
		{
			return this.bool_0;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0000798F File Offset: 0x00005B8F
		[CompilerGenerated]
		private void method_1(bool bool_1)
		{
			this.bool_0 = bool_1;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00002FA8 File Offset: 0x000011A8
		protected Class28()
		{
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00007998 File Offset: 0x00005B98
		public Class28(Interface0 interface0_1)
		{
			this.Driver = interface0_1;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x000079A8 File Offset: 0x00005BA8
		public void imethod_8()
		{
			if (this.imethod_6())
			{
				this.imethod_9();
			}
			this.Handle = Class18.CreateFile(this.Driver.Config.method_4(), FileAccess.ReadWrite, FileShare.ReadWrite, IntPtr.Zero, FileMode.Open, 0U, IntPtr.Zero);
			if (this.imethod_6() && this.imethod_0() != null)
			{
				try
				{
					this.imethod_0()(this, EventArgs.Empty);
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00007A24 File Offset: 0x00005C24
		public bool imethod_10(uint uint_0)
		{
			return Class28.smethod_0(this.Handle, uint_0, null, 0, null, 0);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00007A36 File Offset: 0x00005C36
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool imethod_11<T>(uint uint_0, T gparam_0)
		{
			return this.imethod_12<T>(uint_0, gparam_0, Marshal.SizeOf<T>());
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00007A45 File Offset: 0x00005C45
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool imethod_12<T>(uint uint_0, T gparam_0, int int_0)
		{
			return Class28.smethod_0(this.Handle, uint_0, gparam_0, int_0, null, 0);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00007A5C File Offset: 0x00005C5C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool imethod_13<T, U>(uint uint_0, T gparam_0, out U gparam_1)
		{
			return this.imethod_14<T, U>(uint_0, gparam_0, Marshal.SizeOf<T>(), out gparam_1, Marshal.SizeOf<U>());
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00007A71 File Offset: 0x00005C71
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool imethod_14<T, U>(uint uint_0, T gparam_0, int int_0, out U gparam_1, int int_1)
		{
			gparam_1 = default(U);
			return Class28.smethod_0(this.Handle, uint_0, gparam_0, int_0, gparam_1, int_1);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00007A9C File Offset: 0x00005C9C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool method_2<T, U>(uint uint_0, T gparam_0, int int_0, out U gparam_1, int int_1, ref int int_2)
		{
			gparam_1 = default(U);
			return Class28.DeviceIoControl(this.Handle, uint_0, gparam_0, int_0, gparam_1, int_1, ref int_2, IntPtr.Zero);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00007AD0 File Offset: 0x00005CD0
		public void imethod_9()
		{
			if (this.imethod_6())
			{
				this.Handle.Close();
				if (this.imethod_2() != null)
				{
					try
					{
						this.imethod_2()(this, EventArgs.Empty);
					}
					catch (Exception)
					{
					}
				}
			}
			this.Handle = null;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00007B28 File Offset: 0x00005D28
		public void Dispose()
		{
			if (this.imethod_7())
			{
				return;
			}
			this.method_1(true);
			this.imethod_9();
			if (this.imethod_4() != null)
			{
				try
				{
					this.imethod_4()(this, EventArgs.Empty);
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00007B7C File Offset: 0x00005D7C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool smethod_0(SafeFileHandle safeFileHandle_1, uint uint_0, object object_1, int int_0, object object_2, int int_1)
		{
			int num = 0;
			return Class28.DeviceIoControl(safeFileHandle_1, uint_0, object_1, int_0, object_2, int_1, ref num, IntPtr.Zero);
		}

		// Token: 0x060001E0 RID: 480
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool DeviceIoControl(SafeFileHandle safeFileHandle_1, uint uint_0, [MarshalAs(UnmanagedType.AsAny)] [In] [Out] object object_1, int int_0, [MarshalAs(UnmanagedType.AsAny)] [In] [Out] object object_2, int int_1, ref int int_2, IntPtr intptr_0);

		// Token: 0x060001E1 RID: 481 RVA: 0x00007B9F File Offset: 0x00005D9F
		internal static bool smethod_1()
		{
			return Class28.object_0 == null;
		}

		// Token: 0x040000E5 RID: 229
		[CompilerGenerated]
		private readonly Interface0 interface0_0;

		// Token: 0x040000E6 RID: 230
		[CompilerGenerated]
		private SafeFileHandle safeFileHandle_0;

		// Token: 0x040000E7 RID: 231
		[CompilerGenerated]
		private EventHandler eventHandler_0;

		// Token: 0x040000E8 RID: 232
		[CompilerGenerated]
		private EventHandler eventHandler_1;

		// Token: 0x040000E9 RID: 233
		[CompilerGenerated]
		private EventHandler eventHandler_2;

		// Token: 0x040000EA RID: 234
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x040000EB RID: 235
		private static object object_0;
	}
}
