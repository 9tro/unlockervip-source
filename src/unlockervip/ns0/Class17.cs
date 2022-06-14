using System;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.ServiceProcess;
using Microsoft.Win32;

namespace ns0
{
	// Token: 0x0200001E RID: 30
	[ServiceControllerPermission(SecurityAction.Demand, PermissionAccess = ServiceControllerPermissionAccess.Control)]
	internal static class Class17
	{
		// Token: 0x060000EC RID: 236 RVA: 0x000053D4 File Offset: 0x000035D4
		internal static IntPtr smethod_0(string string_0, string string_1, Enum19 enum19_0, Enum22 enum22_0, Enum21 enum21_0, Enum20 enum20_0, FileSystemInfo fileSystemInfo_0)
		{
			IntPtr intPtr = Class18.OpenSCManagerW(null, null, 983103U);
			if (intPtr == IntPtr.Zero)
			{
				return IntPtr.Zero;
			}
			IntPtr intPtr2 = Class18.CreateService(intPtr, string_0, string_1, (uint)enum19_0, (uint)enum22_0, (uint)enum21_0, (uint)enum20_0, fileSystemInfo_0.FullName, null, null, null, null, null);
			Class18.CloseServiceHandle(intPtr);
			if (intPtr2 == IntPtr.Zero)
			{
				return IntPtr.Zero;
			}
			return intPtr2;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00005438 File Offset: 0x00003638
		internal static IntPtr smethod_1(string string_0, Enum19 enum19_0)
		{
			IntPtr intPtr = Class18.OpenSCManagerW(null, null, 983103U);
			if (!(intPtr != IntPtr.Zero))
			{
				return IntPtr.Zero;
			}
			IntPtr result = Class18.OpenService(intPtr, string_0, (uint)enum19_0);
			Class18.CloseServiceHandle(intPtr);
			return result;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00005474 File Offset: 0x00003674
		internal static IntPtr smethod_2(string string_0, string string_1, Enum19 enum19_0, Enum22 enum22_0, Enum21 enum21_0, Enum20 enum20_0, FileSystemInfo fileSystemInfo_0)
		{
			IntPtr intPtr = Class17.smethod_0(string_0, string_1, enum19_0, enum22_0, enum21_0, enum20_0, fileSystemInfo_0);
			if (intPtr == IntPtr.Zero)
			{
				return Class17.smethod_1(string_0, enum19_0);
			}
			return intPtr;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000054A8 File Offset: 0x000036A8
		internal static bool smethod_3(string string_0)
		{
			IntPtr intPtr = Class17.smethod_1(string_0, (Enum19)983551U);
			if (intPtr != IntPtr.Zero)
			{
				Class18.CloseServiceHandle(intPtr);
				return true;
			}
			return false;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000054D8 File Offset: 0x000036D8
		internal static bool smethod_4(string string_0, Func<ServiceController, bool> func_0 = null)
		{
			if (func_0 != null && ServiceController.GetServices().Any(func_0))
			{
				return true;
			}
			using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\", RegistryRights.EnumerateSubKeys))
			{
				if (registryKey.GetSubKeyNames().Any((string s) => s == string_0))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00005554 File Offset: 0x00003754
		internal static bool smethod_5(IntPtr intptr_0)
		{
			if (intptr_0 == IntPtr.Zero)
			{
				throw new ArgumentException("Handle is invalid at Delete(Handle).", "Handle");
			}
			if (!Class18.DeleteService(intptr_0))
			{
				return false;
			}
			Class18.CloseServiceHandle(intptr_0);
			return true;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00005585 File Offset: 0x00003785
		internal static bool smethod_6()
		{
			return Class17.object_0 == null;
		}

		// Token: 0x04000090 RID: 144
		internal static object object_0;
	}
}
