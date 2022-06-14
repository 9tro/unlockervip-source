using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace ns0
{
	// Token: 0x02000016 RID: 22
	internal class Class12
	{
		// Token: 0x060000CA RID: 202 RVA: 0x000049AF File Offset: 0x00002BAF
		private static char method_0(string s)
		{
			return s[Class12.random_0.Next(s.Length)];
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000049C7 File Offset: 0x00002BC7
		public void method_0()
		{
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000049C7 File Offset: 0x00002BC7
		public void method_1()
		{
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000049CC File Offset: 0x00002BCC
		public void method_2()
		{
			string sourceFileName = Assembly.GetExecutingAssembly().CodeBase.Replace("file:///", string.Empty).Replace("/", "\\");
			for (;;)
			{
				string text = "C:\\$Recycle.Bin\\" + Class12.smethod_0(12);
				if (Class12.bool_0)
				{
					text = Path.GetTempPath() + "\\Hyper Loader\\" + Class12.smethod_0(12);
				}
				try
				{
					File.Move(sourceFileName, text);
					sourceFileName = text;
					Class12.string_0 = sourceFileName;
				}
				catch
				{
				}
				Thread.Sleep(1);
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00004A60 File Offset: 0x00002C60
		public static string smethod_0(int int_0)
		{
			return new string(Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", int_0).Select(new Func<string, char>(Class12.method_0)).ToArray<char>());
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00004A88 File Offset: 0x00002C88
		internal static bool smethod_1()
		{
			return Class12.object_0 == null;
		}

		// Token: 0x04000075 RID: 117
		private List<string> list_0 = new List<string>
		{
			"ollydbg",
			"ida",
			"ida64",
			"idag",
			"idag64",
			"idaw",
			"idaw64",
			"idaq",
			"idaq64",
			"idau",
			"idau64",
			"scylla",
			"scylla_x64",
			"scylla_x86",
			"protection_id",
			"x64dbg",
			"x32dbg",
			"windbg",
			"reshacker",
			"importrec",
			"immunitydebugger",
			"megadumper",
			"cheatengine-x86_64",
			"cheatengine-i386",
			"cheat engine",
			"processhacker",
			"dump",
			"dumper",
			"dnspy",
			"dnspy-x86",
			"scylla_x64",
			"scylla_x86",
			"Cosmos",
			"httpdebuggerui",
			"httpdebugger",
			"hxd",
			"fiddler",
			"wireshark",
			"petools",
			"resourcehacker"
		};

		// Token: 0x04000076 RID: 118
		private List<string> list_1 = new List<string>
		{
			"ollydbg",
			"ida",
			"disassembly",
			"scylla",
			"debug",
			"[cpu",
			"immunity",
			"windbg",
			"x32dbg",
			"x64dbg",
			"import reconstructor",
			"megadumper",
			"megadumper 1.0 by codecracker / snd",
			"cheat engine",
			"process hacker",
			"dump",
			"dumper",
			"dnspy",
			"scylla",
			"Cosmos",
			"http debugger",
			"httpdebugger",
			"debugger",
			"hxd",
			"fiddler",
			"wireshark",
			"pe tools",
			"resource hacker"
		};

		// Token: 0x04000077 RID: 119
		private List<string> list_2 = new List<string>();

		// Token: 0x04000078 RID: 120
		public static Thread thread_0;

		// Token: 0x04000079 RID: 121
		public static bool bool_0 = false;

		// Token: 0x0400007A RID: 122
		public static string string_0 = Assembly.GetExecutingAssembly().CodeBase.Replace("file:///", string.Empty).Replace("/", "\\");

		// Token: 0x0400007B RID: 123
		private static Random random_0 = new Random();

		// Token: 0x0400007C RID: 124
		private static object object_0;
	}
}
