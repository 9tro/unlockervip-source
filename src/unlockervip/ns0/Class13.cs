using System;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json.Linq;

namespace ns0
{
	// Token: 0x02000017 RID: 23
	internal class Class13
	{
		// Token: 0x060000D2 RID: 210 RVA: 0x00004DF3 File Offset: 0x00002FF3
		private static char method_0(string s)
		{
			return s[Class13.random_0.Next(s.Length)];
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00004E0B File Offset: 0x0000300B
		public static string smethod_0(int int_0)
		{
			return new string(Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", int_0).Select(new Func<string, char>(Class13.method_0)).ToArray<char>());
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00004E33 File Offset: 0x00003033
		public static string smethod_1(string string_2)
		{
			return Convert.ToBase64String(Encoding.UTF8.GetBytes(string_2));
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00004E48 File Offset: 0x00003048
		public static string smethod_2(string string_2)
		{
			byte[] bytes = Convert.FromBase64String(string_2);
			return Encoding.UTF8.GetString(bytes);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00004E68 File Offset: 0x00003068
		public static void smethod_3(string string_2, string string_3)
		{
			using (WebClient webClient = new WebClient())
			{
				NameValueCollection nameValueCollection = new NameValueCollection();
				Class10 @class = new Class10();
				nameValueCollection["user"] = string_2;
				nameValueCollection["pass"] = Class13.smethod_1(string_3);
				nameValueCollection["hwid"] = Class13.smethod_1(@class.method_2());
				nameValueCollection["key"] = "ferghyiuyt4fght6j78i7u6yh5gfghjkytr";
				nameValueCollection["toollogin"] = "yes";
				nameValueCollection["tool"] = "CodUnlock";
				try
				{
					byte[] bytes = webClient.UploadValues("https://hyperhaxz.com/api.php", nameValueCollection);
					string @string = Encoding.UTF8.GetString(bytes);
					if (@string.Contains("success"))
					{
						JToken jtoken = JToken.Parse(@string);
						jtoken.Values<JToken>().Children<JToken>().ToArray<JToken>();
						Class13.Class14.string_0 = jtoken.SelectToken("username").ToString();
						Class13.Class14.string_1 = string_3;
						Class13.Class14.string_2 = jtoken.SelectToken("uid").ToString();
						JToken jtoken2 = JToken.Parse(jtoken.SelectToken("Subs").ToString());
						jtoken2.Values<JToken>().Children<JToken>().ToArray<JToken>();
						Class13.Class14.string_4 = jtoken2.SelectToken("Seller").ToString();
						try
						{
							Class13.Class14.string_6 = webClient.DownloadString("https://hyperhaxz.com/Branding/CodTool/" + Class13.Class14.string_4 + "_title.txt").Split(new char[]
							{
								'|'
							});
							Class13.Class14.string_6 = webClient.DownloadString("https://hyperhaxz.com/Branding/CodTool/" + Class13.Class14.string_0 + "_title.txt").Split(new char[]
							{
								'|'
							});
						}
						catch
						{
						}
						return;
					}
					Class13.smethod_5(true, @string);
				}
				catch
				{
				}
			}
			Class13.smethod_5(true, "Failed to login at line 84 in Webauth.cs");
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000506C File Offset: 0x0000326C
		public static void smethod_4(string string_2)
		{
			using (WebClient webClient = new WebClient())
			{
				NameValueCollection nameValueCollection = new NameValueCollection();
				Class10 @class = new Class10();
				nameValueCollection["user"] = Class13.Class14.string_0;
				nameValueCollection["pass"] = Class13.smethod_1(Class13.Class14.string_1);
				nameValueCollection["hwid"] = Class13.smethod_1(@class.method_2());
				nameValueCollection["key"] = "ferghyiuyt4fght6j78i7u6yh5gfghjkytr";
				nameValueCollection["beanz"] = "yes";
				nameValueCollection["tool"] = "CodUnlock";
				nameValueCollection["reason"] = string_2;
				try
				{
					byte[] bytes = webClient.UploadValues("https://hyperhaxz.com/api.php", nameValueCollection);
					Encoding.UTF8.GetString(bytes);
				}
				catch
				{
				}
				Class8.smethod_0();
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000049C7 File Offset: 0x00002BC7
		public static void smethod_5(bool bool_0, string string_2)
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00005150 File Offset: 0x00003350
		public static void smethod_6(string string_2)
		{
			using (WebClient webClient = new WebClient())
			{
				NameValueCollection nameValueCollection = new NameValueCollection();
				Class10 @class = new Class10();
				nameValueCollection["user"] = Class13.Class14.string_0;
				nameValueCollection["pass"] = Class13.smethod_1(Class13.Class14.string_1);
				nameValueCollection["hwid"] = Class13.smethod_1(@class.method_2());
				nameValueCollection["key"] = "ferghyiuyt4fght6j78i7u6yh5gfghjkytr";
				nameValueCollection["tool"] = "CodUnlock";
				nameValueCollection["DiscordID"] = string_2;
				try
				{
					byte[] bytes = webClient.UploadValues("https://hyperhaxz.com/api.php", nameValueCollection);
					Encoding.UTF8.GetString(bytes);
				}
				catch
				{
				}
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000521C File Offset: 0x0000341C
		internal static bool smethod_7()
		{
			return Class13.object_0 == null;
		}

		// Token: 0x0400007D RID: 125
		private static string string_0 = "";

		// Token: 0x0400007E RID: 126
		private static string string_1 = "";

		// Token: 0x0400007F RID: 127
		private static Random random_0 = new Random();

		// Token: 0x04000080 RID: 128
		private static object object_0;

		// Token: 0x02000018 RID: 24
		internal class Class14
		{
			// Token: 0x060000DD RID: 221 RVA: 0x00005246 File Offset: 0x00003446
			internal static bool smethod_0()
			{
				return Class13.Class14.object_0 == null;
			}

			// Token: 0x04000081 RID: 129
			public static string string_0 = "";

			// Token: 0x04000082 RID: 130
			public static string string_1 = "";

			// Token: 0x04000083 RID: 131
			public static string string_2 = "";

			// Token: 0x04000084 RID: 132
			public static string string_3 = "";

			// Token: 0x04000085 RID: 133
			public static string string_4 = "";

			// Token: 0x04000086 RID: 134
			public static string string_5 = "";

			// Token: 0x04000087 RID: 135
			public static string[] string_6 = null;

			// Token: 0x04000088 RID: 136
			internal static object object_0;
		}
	}
}
