using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.ServiceProcess;

namespace ns0
{
	// Token: 0x02000030 RID: 48
	[ServiceControllerPermission(SecurityAction.Demand, PermissionAccess = ServiceControllerPermissionAccess.Control)]
	internal sealed class Class30 : Interface2
	{
		// Token: 0x06000205 RID: 517 RVA: 0x0000828A File Offset: 0x0000648A
		[CompilerGenerated]
		public bool imethod_0()
		{
			return this.bool_0;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00008292 File Offset: 0x00006492
		[CompilerGenerated]
		private void method_0(bool bool_2)
		{
			this.bool_0 = bool_2;
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000829B File Offset: 0x0000649B
		[CompilerGenerated]
		public bool imethod_1()
		{
			return this.bool_1;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x000082A3 File Offset: 0x000064A3
		[CompilerGenerated]
		private void method_1(bool bool_2)
		{
			this.bool_1 = bool_2;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000209 RID: 521 RVA: 0x000082AC File Offset: 0x000064AC
		// (set) Token: 0x0600020A RID: 522 RVA: 0x000082B4 File Offset: 0x000064B4
		public Class25 Driver { get; private set; }

		// Token: 0x0600020B RID: 523 RVA: 0x000082BD File Offset: 0x000064BD
		[CompilerGenerated]
		public IntPtr method_2()
		{
			return this.intptr_0;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x000082C5 File Offset: 0x000064C5
		[CompilerGenerated]
		private void method_3(IntPtr intptr_1)
		{
			this.intptr_0 = intptr_1;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x000082CE File Offset: 0x000064CE
		[CompilerGenerated]
		public ServiceController method_4()
		{
			return this.serviceController_0;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x000082D6 File Offset: 0x000064D6
		[CompilerGenerated]
		private void method_5(ServiceController serviceController_1)
		{
			this.serviceController_0 = serviceController_1;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x000082E0 File Offset: 0x000064E0
		public bool imethod_2(Class25 class25_1)
		{
			Class26 config = class25_1.Config;
			if (this.imethod_0())
			{
				throw new Exception("Service is already created");
			}
			if (config == null)
			{
				throw new ArgumentNullException("Config");
			}
			this.Driver = class25_1;
			if (class25_1 == null)
			{
				throw new ArgumentNullException("Driver", "Driver is null");
			}
			this.method_3(Class17.smethod_2(config.method_0(), config.method_0(), (Enum19)983551U, (Enum22)1U, (Enum21)3U, (Enum20)1, config.method_2()));
			if (!(this.method_2() == IntPtr.Zero))
			{
				this.method_5(new ServiceController(config.method_0()));
				this.method_0(true);
				return true;
			}
			return false;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00008384 File Offset: 0x00006584
		public bool imethod_3()
		{
			if (!this.imethod_0())
			{
				throw new Exception("Service is not created.");
			}
			if (this.imethod_1())
			{
				return true;
			}
			if (this.method_4().Status != ServiceControllerStatus.Running)
			{
				try
				{
					this.method_4().Start();
				}
				catch (InvalidOperationException ex)
				{
					Class16.smethod_2(typeof(Class30), ex.GetType().Name + ", " + ex.Message);
					return false;
				}
				catch (Win32Exception ex2)
				{
					if (!ex2.Message.Contains("signature"))
					{
						Class16.smethod_2(typeof(Class30), ex2.GetType().Name + ", " + ex2.Message);
					}
					else
					{
						Class16.smethod_2(typeof(Class30), "The driver is not signed, unable to load it using the service manager.");
					}
					return false;
				}
				catch (Exception ex3)
				{
					Class16.smethod_2(typeof(Class30), ex3.GetType().Name + ", " + ex3.Message);
					return false;
				}
				bool result;
				try
				{
					this.method_4().WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(10.0));
					goto IL_164;
				}
				catch (System.TimeoutException)
				{
					Class16.smethod_2(typeof(Class30), "Failed to start the service in 10 seconds.");
					goto IL_164;
				}
				catch (Exception ex4)
				{
					Class16.smethod_2(typeof(Class30), ex4.GetType().Name + ", " + ex4.Message);
					result = false;
				}
				return result;
			}
			IL_164:
			this.method_1(true);
			return true;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00008540 File Offset: 0x00006740
		public bool imethod_4()
		{
			if (!this.imethod_0())
			{
				throw new Exception("Service is not created.");
			}
			if (!this.imethod_1())
			{
				return true;
			}
			if (this.method_4().CanStop)
			{
				try
				{
					this.method_4().Stop();
				}
				catch (Exception ex)
				{
					Class16.smethod_2(typeof(Class30), ex.GetType().Name + ", " + ex.Message);
					return false;
				}
				this.method_1(false);
				bool result;
				try
				{
					this.method_4().WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(10.0));
					goto IL_D7;
				}
				catch (System.TimeoutException)
				{
					Class16.smethod_2(typeof(Class30), "Failed to stop the service in 10 seconds.");
					goto IL_D7;
				}
				catch (Exception ex2)
				{
					Class16.smethod_2(typeof(Class30), ex2.GetType().Name + ", " + ex2.Message);
					result = false;
				}
				return result;
				IL_D7:
				this.method_1(false);
				return true;
			}
			Class16.smethod_2(typeof(Class30), "Driver not stopped !");
			return false;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000866C File Offset: 0x0000686C
		public bool imethod_5()
		{
			if (!this.imethod_0())
			{
				throw new Exception("Service is not created.");
			}
			if (this.imethod_1() && !this.imethod_4())
			{
				return false;
			}
			if (this.method_4() != null)
			{
				this.method_4().Dispose();
			}
			if (this.method_2() != IntPtr.Zero)
			{
				if (!Class17.smethod_5(this.method_2()))
				{
					Class16.smethod_2(typeof(Class30), "Unable to delete the service using the native api.");
				}
				this.method_3(IntPtr.Zero);
			}
			this.method_0(false);
			return true;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x000086F7 File Offset: 0x000068F7
		internal static bool smethod_0()
		{
			return Class30.object_0 == null;
		}

		// Token: 0x040000FA RID: 250
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x040000FB RID: 251
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x040000FC RID: 252
		[CompilerGenerated]
		private Class25 class25_0;

		// Token: 0x040000FD RID: 253
		[CompilerGenerated]
		private IntPtr intptr_0;

		// Token: 0x040000FE RID: 254
		[CompilerGenerated]
		private ServiceController serviceController_0;

		// Token: 0x040000FF RID: 255
		private static object object_0;
	}
}
