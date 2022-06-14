using System;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.Win32.SafeHandles;

namespace ns0
{
	// Token: 0x0200002B RID: 43
	internal class Class25 : IDisposable, Interface0
	{
		// Token: 0x06000198 RID: 408 RVA: 0x000073FB File Offset: 0x000055FB
		[CompilerGenerated]
		public Interface1 imethod_0()
		{
			return this.interface1_0;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00007403 File Offset: 0x00005603
		[CompilerGenerated]
		internal Interface2 method_0()
		{
			return this.interface2_0;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000740B File Offset: 0x0000560B
		[CompilerGenerated]
		private void method_1(Interface2 interface2_1)
		{
			this.interface2_0 = interface2_1;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00007414 File Offset: 0x00005614
		// (set) Token: 0x0600019C RID: 412 RVA: 0x0000741C File Offset: 0x0000561C
		public Class26 Config { get; private set; }

		// Token: 0x0600019D RID: 413 RVA: 0x00007425 File Offset: 0x00005625
		[CompilerGenerated]
		public EventHandler imethod_1()
		{
			return this.eventHandler_0;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000742D File Offset: 0x0000562D
		[CompilerGenerated]
		public void imethod_2(EventHandler eventHandler_3)
		{
			this.eventHandler_0 = eventHandler_3;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00007436 File Offset: 0x00005636
		[CompilerGenerated]
		public EventHandler imethod_3()
		{
			return this.eventHandler_1;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0000743E File Offset: 0x0000563E
		[CompilerGenerated]
		public void imethod_4(EventHandler eventHandler_3)
		{
			this.eventHandler_1 = eventHandler_3;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00007447 File Offset: 0x00005647
		[CompilerGenerated]
		public EventHandler imethod_5()
		{
			return this.eventHandler_2;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0000744F File Offset: 0x0000564F
		[CompilerGenerated]
		public void imethod_6(EventHandler eventHandler_3)
		{
			this.eventHandler_2 = eventHandler_3;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00007458 File Offset: 0x00005658
		[CompilerGenerated]
		public bool imethod_7()
		{
			return this.bool_0;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00007460 File Offset: 0x00005660
		[CompilerGenerated]
		private void method_3(bool bool_2)
		{
			this.bool_0 = bool_2;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00007469 File Offset: 0x00005669
		[CompilerGenerated]
		public bool imethod_8()
		{
			return this.bool_1;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00007471 File Offset: 0x00005671
		[CompilerGenerated]
		private void method_4(bool bool_2)
		{
			this.bool_1 = bool_2;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002FA8 File Offset: 0x000011A8
		protected Class25()
		{
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000747C File Offset: 0x0000567C
		public Class25(Class26 class26_1, string string_0 = null)
		{
			this.method_5(class26_1, string_0);
			switch (class26_1.IoMethod)
			{
			case (Enum28)0:
				this.interface1_0 = null;
				return;
			case (Enum28)1:
				this.interface1_0 = new Class28(this);
				return;
			case (Enum28)2:
				this.interface1_0 = new Class29(this);
				return;
			default:
				throw new ArgumentException("Invalid IoMethod specified", "IoMethod");
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x000074E4 File Offset: 0x000056E4
		public void method_5(Class26 class26_1, string string_0 = null)
		{
			if (class26_1 == null)
			{
				throw new ArgumentNullException("Config");
			}
			this.Config = class26_1;
			if (string.IsNullOrEmpty(class26_1.method_0()))
			{
				throw new Exception("Config->ServiceName is null or empty");
			}
			if (class26_1.IoMethod == (Enum28)1 && string.IsNullOrEmpty(class26_1.method_4()))
			{
				throw new Exception("Config->SymbolicLink is null or empty");
			}
			if (!string.IsNullOrEmpty(string_0))
			{
				this.method_6(string_0);
			}
			if (this.Config.LoadMethod != (Enum27)0)
			{
				throw new ArgumentException("Invalid LoadMethod specified", "LoadMethod");
			}
			this.method_1(new Class30());
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00007576 File Offset: 0x00005776
		public void method_6(string string_0)
		{
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentNullException("Path");
			}
			if (this.Config.LoadMethod != (Enum27)0)
			{
				throw new ArgumentException("Invalid LoadMethod specified", "LoadMethod");
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x000075A8 File Offset: 0x000057A8
		public bool imethod_9()
		{
			if (!this.method_0().imethod_2(this))
			{
				Class16.smethod_2(typeof(Class25), "Failed to create the driver at Load().");
				return false;
			}
			if (!Class25.smethod_0(this.Config.method_4(), (Enum28)1) && !this.method_0().imethod_3())
			{
				Class16.smethod_2(typeof(Class25), "Failed to load the driver at Load().");
				return false;
			}
			this.method_3(true);
			if (this.imethod_0().imethod_6())
			{
				this.imethod_0().imethod_9();
			}
			this.imethod_0().imethod_8();
			if (!this.imethod_0().imethod_6())
			{
				Class16.smethod_2(typeof(Class25), "Failed to open the symbolic file.");
			}
			if (this.imethod_1() != null)
			{
				try
				{
					this.imethod_1()(this, EventArgs.Empty);
				}
				catch (Exception)
				{
				}
			}
			return true;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000768C File Offset: 0x0000588C
		public bool imethod_10()
		{
			if (this.imethod_0().imethod_6())
			{
				this.imethod_0().imethod_9();
			}
			if (!this.method_0().imethod_4())
			{
				Class16.smethod_2(typeof(Class25), "Failed to unload the driver at Unload().");
				return false;
			}
			if (this.method_0().imethod_5())
			{
				this.method_3(false);
				if (this.imethod_3() != null)
				{
					try
					{
						this.imethod_3()(this, EventArgs.Empty);
					}
					catch (Exception)
					{
					}
				}
				return true;
			}
			Class16.smethod_2(typeof(Class25), "Failed to delete the driver at Unload().");
			return false;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00007730 File Offset: 0x00005930
		public void Dispose()
		{
			if (!this.imethod_8())
			{
				this.method_4(true);
				try
				{
					if (!this.imethod_10())
					{
						Class16.smethod_2(typeof(Class25), "Failed to unload the driver at Dispose().");
					}
				}
				catch (Exception ex)
				{
					Class16.smethod_2(typeof(Class25), ex.GetType().Name + ", " + ex.Message);
				}
				Interface1 @interface = this.imethod_0();
				if (@interface != null)
				{
					@interface.Dispose();
				}
				if (this.imethod_5() != null)
				{
					try
					{
						this.imethod_5()(this, EventArgs.Empty);
					}
					catch (Exception)
					{
					}
				}
				return;
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000077E8 File Offset: 0x000059E8
		public static bool smethod_0(string string_0, Enum28 enum28_0 = (Enum28)1)
		{
			if (enum28_0 == (Enum28)1)
			{
				SafeFileHandle safeFileHandle = Class18.CreateFile(string_0, FileAccess.ReadWrite, FileShare.ReadWrite, IntPtr.Zero, FileMode.Open, 0U, IntPtr.Zero);
				bool result = safeFileHandle != null && !safeFileHandle.IsInvalid;
				if (safeFileHandle != null)
				{
					safeFileHandle.Close();
				}
				return result;
			}
			if (enum28_0 != (Enum28)2)
			{
				throw new ArgumentException();
			}
			return false;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00007832 File Offset: 0x00005A32
		internal static bool smethod_1()
		{
			return Class25.object_0 == null;
		}

		// Token: 0x040000CC RID: 204
		[CompilerGenerated]
		private readonly Interface1 interface1_0;

		// Token: 0x040000CD RID: 205
		[CompilerGenerated]
		private Interface2 interface2_0;

		// Token: 0x040000CE RID: 206
		[CompilerGenerated]
		private Class26 class26_0;

		// Token: 0x040000CF RID: 207
		[CompilerGenerated]
		private EventHandler eventHandler_0;

		// Token: 0x040000D0 RID: 208
		[CompilerGenerated]
		private EventHandler eventHandler_1;

		// Token: 0x040000D1 RID: 209
		[CompilerGenerated]
		private EventHandler eventHandler_2;

		// Token: 0x040000D2 RID: 210
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x040000D3 RID: 211
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x040000D4 RID: 212
		private static object object_0;
	}
}
