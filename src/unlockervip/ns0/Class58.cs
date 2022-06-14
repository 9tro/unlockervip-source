using System;
using System.Reflection;

namespace ns0
{
	// Token: 0x02000033 RID: 51
	internal class Class58
	{
		// Token: 0x0600021F RID: 543 RVA: 0x00008EB0 File Offset: 0x000070B0
		internal static void smethod_0(int typemdt)
		{
			Type type = Class58.module_0.ResolveType(33554432 + typemdt);
			foreach (FieldInfo fieldInfo in type.GetFields())
			{
				MethodInfo method = (MethodInfo)Class58.module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
				fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
			}
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00008F19 File Offset: 0x00007119
		internal static bool smethod_1()
		{
			return Class58.object_0 == null;
		}

		// Token: 0x04000111 RID: 273
		internal static Module module_0 = typeof(Class58).Assembly.ManifestModule;

		// Token: 0x04000112 RID: 274
		private static object object_0;

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x06000224 RID: 548
		internal delegate void Delegate4(object o);
	}
}
