using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x0200001D RID: 29
	internal static class Class16
	{
		// Token: 0x060000E8 RID: 232 RVA: 0x000049C7 File Offset: 0x00002BC7
		[Conditional("DEBUG")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void smethod_0(Type type_0, object object_1)
		{
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000049C7 File Offset: 0x00002BC7
		[Conditional("DEBUG")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void smethod_1(Type type_0, object object_1)
		{
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000053AA File Offset: 0x000035AA
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void smethod_2(Type type_0, string string_0)
		{
			Trace.WriteLine("[ ERROR ] " + type_0.Name + " : " + string_0);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000053C7 File Offset: 0x000035C7
		internal static bool smethod_3()
		{
			return Class16.object_0 == null;
		}

		// Token: 0x0400008F RID: 143
		private static object object_0;
	}
}
