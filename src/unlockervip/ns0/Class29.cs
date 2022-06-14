using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.Win32.SafeHandles;

namespace ns0
{
	// Token: 0x0200002F RID: 47
	internal class Class29 : IDisposable, Interface1
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x00007BA9 File Offset: 0x00005DA9
		public Interface0 Driver { get; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x00007BB1 File Offset: 0x00005DB1
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x00007BB9 File Offset: 0x00005DB9
		public SafeFileHandle Handle { get; private set; }

		// Token: 0x060001E5 RID: 485 RVA: 0x00007BC2 File Offset: 0x00005DC2
		[CompilerGenerated]
		public IntPtr method_1()
		{
			return this.intptr_0;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00007BCA File Offset: 0x00005DCA
		[CompilerGenerated]
		private void method_2(IntPtr intptr_1)
		{
			this.intptr_0 = intptr_1;
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00007BD3 File Offset: 0x00005DD3
		[CompilerGenerated]
		public AutoResetEvent method_3()
		{
			return this.autoResetEvent_0;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00007BDB File Offset: 0x00005DDB
		[CompilerGenerated]
		private void method_4(AutoResetEvent autoResetEvent_2)
		{
			this.autoResetEvent_0 = autoResetEvent_2;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00007BE4 File Offset: 0x00005DE4
		[CompilerGenerated]
		public AutoResetEvent method_5()
		{
			return this.autoResetEvent_1;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00007BEC File Offset: 0x00005DEC
		[CompilerGenerated]
		private void method_6(AutoResetEvent autoResetEvent_2)
		{
			this.autoResetEvent_1 = autoResetEvent_2;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00007BF5 File Offset: 0x00005DF5
		[CompilerGenerated]
		public EventHandler imethod_0()
		{
			return this.eventHandler_0;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00007BFD File Offset: 0x00005DFD
		[CompilerGenerated]
		public void imethod_1(EventHandler eventHandler_3)
		{
			this.eventHandler_0 = eventHandler_3;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00007C06 File Offset: 0x00005E06
		[CompilerGenerated]
		public EventHandler imethod_2()
		{
			return this.eventHandler_1;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00007C0E File Offset: 0x00005E0E
		[CompilerGenerated]
		public void imethod_3(EventHandler eventHandler_3)
		{
			this.eventHandler_1 = eventHandler_3;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00007C17 File Offset: 0x00005E17
		[CompilerGenerated]
		public EventHandler imethod_4()
		{
			return this.eventHandler_2;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00007C1F File Offset: 0x00005E1F
		[CompilerGenerated]
		public void imethod_5(EventHandler eventHandler_3)
		{
			this.eventHandler_2 = eventHandler_3;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00007C28 File Offset: 0x00005E28
		[CompilerGenerated]
		public object method_7()
		{
			return this.object_0;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00007C30 File Offset: 0x00005E30
		[CompilerGenerated]
		private void method_8(object object_2)
		{
			this.object_0 = object_2;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00007C3C File Offset: 0x00005E3C
		public bool imethod_6()
		{
			return (this.method_3() != null && !this.method_3().SafeWaitHandle.IsInvalid && !this.method_3().SafeWaitHandle.IsClosed) || (this.method_5() != null && !this.method_5().SafeWaitHandle.IsInvalid && !this.method_5().SafeWaitHandle.IsClosed);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00007CA6 File Offset: 0x00005EA6
		[CompilerGenerated]
		public bool imethod_7()
		{
			return this.bool_0;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00007CAE File Offset: 0x00005EAE
		[CompilerGenerated]
		private void method_9(bool bool_1)
		{
			this.bool_0 = bool_1;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002FA8 File Offset: 0x000011A8
		protected Class29()
		{
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00007CB8 File Offset: 0x00005EB8
		public Class29(Interface0 interface0_1)
		{
			this.method_8(new object());
			this.Driver = interface0_1;
			if (this.Driver.Config.method_6().method_2() > 0UL)
			{
				return;
			}
			this.method_2(Marshal.AllocHGlobal(4096));
			if (this.method_1() == IntPtr.Zero)
			{
				throw new InsufficientMemoryException();
			}
			this.Driver.Config.method_6().method_3((ulong)this.method_1().ToInt64());
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00007D44 File Offset: 0x00005F44
		public void imethod_8()
		{
			if (this.imethod_6())
			{
				return;
			}
			IntPtr zero = IntPtr.Zero;
			IntPtr zero2 = IntPtr.Zero;
			Struct10 @struct = new Struct10(this.Driver.Config.method_6().method_4(), 0U);
			Struct10 struct2 = new Struct10(this.Driver.Config.method_6().method_6(), 0U);
			GCHandle gchandle = GCHandle.Alloc(@struct, GCHandleType.Pinned);
			GCHandle gchandle2 = GCHandle.Alloc(struct2, GCHandleType.Pinned);
			Enum15 @enum = (Enum15)Class29.NtOpenEvent(ref zero, 2031619U, gchandle.AddrOfPinnedObject());
			if (@enum > Enum15.Success)
			{
				gchandle.Free();
				gchandle2.Free();
				if (zero != IntPtr.Zero)
				{
					Class29.NtClose(zero);
				}
				if (zero2 != IntPtr.Zero)
				{
					Class29.NtClose(zero2);
				}
				Class16.smethod_2(typeof(Class29), "Failed to open the first event object. [" + @enum.ToString() + "]");
				return;
			}
			@enum = (Enum15)Class29.NtOpenEvent(ref zero2, 2031619U, gchandle2.AddrOfPinnedObject());
			if (@enum <= Enum15.Success)
			{
				gchandle.Free();
				gchandle2.Free();
				this.method_4(new AutoResetEvent(false));
				this.method_3().Close();
				this.method_3().SafeWaitHandle = new SafeWaitHandle(zero, false);
				this.method_6(new AutoResetEvent(false));
				this.method_5().Close();
				this.method_5().SafeWaitHandle = new SafeWaitHandle(zero2, false);
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
				return;
			}
			gchandle.Free();
			gchandle2.Free();
			if (zero != IntPtr.Zero)
			{
				Class29.NtClose(zero);
			}
			if (zero2 != IntPtr.Zero)
			{
				Class29.NtClose(zero2);
			}
			Class16.smethod_2(typeof(Class29), "Failed to open the second event object. [" + @enum.ToString() + "]");
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00007F4C File Offset: 0x0000614C
		public bool imethod_10(uint uint_0)
		{
			object obj = this.method_7();
			bool result;
			lock (obj)
			{
				Marshal.WriteInt32(this.method_1(), (int)uint_0);
				this.method_3().Set();
				result = this.method_5().WaitOne();
				this.method_5().Reset();
			}
			return result;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00007FB8 File Offset: 0x000061B8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool imethod_11<T>(uint uint_0, T gparam_0)
		{
			return this.imethod_12<T>(uint_0, gparam_0, Marshal.SizeOf<T>());
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00007FC8 File Offset: 0x000061C8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool imethod_12<T>(uint uint_0, T gparam_0, int int_0)
		{
			object obj = this.method_7();
			bool result;
			lock (obj)
			{
				IntPtr intPtr = this.method_1();
				IntPtr intptr_ = IntPtr.Add(intPtr, 4);
				Marshal.WriteInt32(intPtr, (int)uint_0);
				if (gparam_0 != null)
				{
					IntPtr intPtr2 = Marshal.AllocHGlobal(int_0);
					Marshal.StructureToPtr<T>(gparam_0, intPtr2, true);
					Class29.CopyMemory(intptr_, intPtr2, (uint)int_0);
					this.method_3().Set();
					Marshal.FreeHGlobal(intPtr2);
				}
				result = this.method_5().WaitOne();
				this.method_5().Reset();
			}
			return result;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00008064 File Offset: 0x00006264
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool imethod_13<T, U>(uint uint_0, T gparam_0, out U gparam_1)
		{
			int int_ = Marshal.SizeOf<T>();
			int int_2 = Marshal.SizeOf<U>();
			return this.imethod_14<T, U>(uint_0, gparam_0, int_, out gparam_1, int_2);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00008088 File Offset: 0x00006288
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool imethod_14<T, U>(uint uint_0, T gparam_0, int int_0, out U gparam_1, int int_1)
		{
			object obj = this.method_7();
			bool result;
			lock (obj)
			{
				IntPtr intPtr = this.method_1();
				IntPtr intPtr2 = IntPtr.Add(intPtr, 4);
				Marshal.WriteInt32(intPtr, (int)uint_0);
				if (gparam_0 != null)
				{
					IntPtr intPtr3 = Marshal.AllocHGlobal(int_0);
					Marshal.StructureToPtr<T>(gparam_0, intPtr3, true);
					Class29.CopyMemory(intPtr2, intPtr3, (uint)int_0);
					this.method_3().Set();
					Marshal.FreeHGlobal(intPtr3);
				}
				result = this.method_5().WaitOne();
				gparam_1 = Marshal.PtrToStructure<U>(intPtr2);
				this.method_5().Reset();
			}
			return result;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00008134 File Offset: 0x00006334
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool method_10<T, U>(uint uint_0, T gparam_0, int int_0, out U gparam_1, int int_1, ref int int_2)
		{
			return this.imethod_14<T, U>(uint_0, gparam_0, int_0, out gparam_1, int_1);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00008144 File Offset: 0x00006344
		public void imethod_9()
		{
			if (this.imethod_6())
			{
				SafeFileHandle handle = this.Handle;
				if (handle != null)
				{
					handle.Close();
				}
				AutoResetEvent autoResetEvent = this.method_3();
				if (autoResetEvent != null)
				{
					autoResetEvent.Close();
				}
				AutoResetEvent autoResetEvent2 = this.method_5();
				if (autoResetEvent2 != null)
				{
					autoResetEvent2.Close();
				}
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
		}

		// Token: 0x06000200 RID: 512 RVA: 0x000081B8 File Offset: 0x000063B8
		public void Dispose()
		{
			if (!this.imethod_7())
			{
				this.method_9(true);
				this.imethod_9();
				SafeFileHandle handle = this.Handle;
				if (handle != null)
				{
					handle.Dispose();
				}
				AutoResetEvent autoResetEvent = this.method_3();
				if (autoResetEvent != null)
				{
					autoResetEvent.Dispose();
				}
				AutoResetEvent autoResetEvent2 = this.method_5();
				if (autoResetEvent2 != null)
				{
					autoResetEvent2.Dispose();
				}
				this.Handle = null;
				this.method_4(null);
				this.method_6(null);
				if (this.method_1() != IntPtr.Zero)
				{
					try
					{
						Marshal.FreeHGlobal(this.method_1());
					}
					catch (Exception)
					{
					}
				}
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
				return;
			}
		}

		// Token: 0x06000201 RID: 513
		[DllImport("ntdll.dll", SetLastError = true)]
		private static extern uint NtOpenEvent(ref IntPtr intptr_1, uint uint_0, IntPtr intptr_2);

		// Token: 0x06000202 RID: 514
		[DllImport("ntdll.dll", SetLastError = true)]
		private static extern uint NtClose(IntPtr intptr_1);

		// Token: 0x06000203 RID: 515
		[DllImport("kernel32.dll")]
		private static extern void CopyMemory(IntPtr intptr_1, IntPtr intptr_2, uint uint_0);

		// Token: 0x06000204 RID: 516 RVA: 0x00008280 File Offset: 0x00006480
		internal static bool smethod_0()
		{
			return Class29.object_1 == null;
		}

		// Token: 0x040000EE RID: 238
		[CompilerGenerated]
		private readonly Interface0 interface0_0;

		// Token: 0x040000EF RID: 239
		[CompilerGenerated]
		private SafeFileHandle safeFileHandle_0;

		// Token: 0x040000F0 RID: 240
		[CompilerGenerated]
		private IntPtr intptr_0;

		// Token: 0x040000F1 RID: 241
		[CompilerGenerated]
		private AutoResetEvent autoResetEvent_0;

		// Token: 0x040000F2 RID: 242
		[CompilerGenerated]
		private AutoResetEvent autoResetEvent_1;

		// Token: 0x040000F3 RID: 243
		[CompilerGenerated]
		private EventHandler eventHandler_0;

		// Token: 0x040000F4 RID: 244
		[CompilerGenerated]
		private EventHandler eventHandler_1;

		// Token: 0x040000F5 RID: 245
		[CompilerGenerated]
		private EventHandler eventHandler_2;

		// Token: 0x040000F6 RID: 246
		[CompilerGenerated]
		private object object_0;

		// Token: 0x040000F7 RID: 247
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x040000F8 RID: 248
		internal static object object_1;
	}
}
