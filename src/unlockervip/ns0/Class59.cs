using System;

namespace ns0
{
	// Token: 0x02000035 RID: 53
	internal class Class59
	{
		// Token: 0x06000227 RID: 551 RVA: 0x00008F3E File Offset: 0x0000713E
		internal static RuntimeTypeHandle smethod_0(int token)
		{
			return Class59.moduleHandle_0.GetRuntimeTypeHandleFromMetadataToken(token);
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00008F4B File Offset: 0x0000714B
		internal static RuntimeFieldHandle smethod_1(int token)
		{
			return Class59.moduleHandle_0.GetRuntimeFieldHandleFromMetadataToken(token);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00008F58 File Offset: 0x00007158
		internal static bool smethod_2()
		{
			return Class59.object_0 == null;
		}

		// Token: 0x04000113 RID: 275
		internal static ModuleHandle moduleHandle_0 = typeof(Class59).Assembly.GetModules()[0].ModuleHandle;

		// Token: 0x04000114 RID: 276
		private static object object_0;
	}
}
