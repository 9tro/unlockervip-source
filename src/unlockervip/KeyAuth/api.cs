using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;

namespace KeyAuth
{
	// Token: 0x0200005A RID: 90
	public class api
	{
		// Token: 0x06000283 RID: 643 RVA: 0x0000AB28 File Offset: 0x00008D28
		public api(string name, string ownerid, string secret, string version)
		{
			if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(ownerid) || string.IsNullOrWhiteSpace(secret) || string.IsNullOrWhiteSpace(version))
			{
				api.error("Application not setup correctly. Please watch video link found in Program.cs");
				Environment.Exit(0);
			}
			this.name = name;
			this.ownerid = ownerid;
			this.secret = secret;
			this.version = version;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000ABBC File Offset: 0x00008DBC
		public void init()
		{
			this.enckey = encryption.sha256(encryption.iv_key());
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("init"));
			nameValueCollection["ver"] = encryption.encrypt(this.version, this.secret, text);
			nameValueCollection["hash"] = api.checksum(Process.GetCurrentProcess().MainModule.FileName);
			nameValueCollection["enckey"] = encryption.encrypt(this.enckey, this.secret, text);
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			if (text2 == "KeyAuth_Invalid")
			{
				api.error("Application not found");
				Environment.Exit(0);
			}
			text2 = encryption.decrypt(text2, this.secret, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				this.load_app_data(response_structure.appinfo);
				this.sessionid = response_structure.sessionid;
				this.initzalized = true;
				return;
			}
			if (response_structure.message == "invalidver")
			{
				this.app_data.downloadLink = response_structure.download;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000285 RID: 645 RVA: 0x0000AD3D File Offset: 0x00008F3D
		public static bool IsDebugRelease
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0000AD40 File Offset: 0x00008F40
		public void Checkinit()
		{
			if (!this.initzalized)
			{
				if (api.IsDebugRelease)
				{
					api.error("Not initialized Check if KeyAuthApp.init() does exist");
					return;
				}
				api.error("Please initialize first");
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000AD68 File Offset: 0x00008F68
		public void register(string username, string pass, string key)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("register"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
			nameValueCollection["pass"] = encryption.encrypt(pass, this.enckey, text);
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000AEC4 File Offset: 0x000090C4
		public void login(string username, string pass)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("login"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
			nameValueCollection["pass"] = encryption.encrypt(pass, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000B008 File Offset: 0x00009208
		public void upgrade(string username, string key)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("upgrade"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			response_structure.success = false;
			this.load_response_struct(response_structure);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000B128 File Offset: 0x00009328
		public void license(string key)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("license"));
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000B254 File Offset: 0x00009454
		public void check()
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("check"));
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure data = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(data);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000B32C File Offset: 0x0000952C
		public void setvar(string var, string data)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("setvar"));
			nameValueCollection["var"] = encryption.encrypt(var, this.enckey, text);
			nameValueCollection["data"] = encryption.encrypt(data, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure data2 = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(data2);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000B434 File Offset: 0x00009634
		public string getvar(string var)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("getvar"));
			nameValueCollection["var"] = encryption.encrypt(var, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				return response_structure.response;
			}
			return null;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000B534 File Offset: 0x00009734
		public void ban()
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("ban"));
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure data = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(data);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000B60C File Offset: 0x0000980C
		public string var(string varid)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("var"));
			nameValueCollection["varid"] = encryption.encrypt(varid, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				return response_structure.message;
			}
			return null;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000B71C File Offset: 0x0000991C
		public List<api.msg> chatget(string channelname)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatget"));
			nameValueCollection["channel"] = encryption.encrypt(channelname, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				return response_structure.messages;
			}
			return null;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000B81C File Offset: 0x00009A1C
		public bool chatsend(string msg, string channelname)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatsend"));
			nameValueCollection["message"] = encryption.encrypt(msg, this.enckey, text);
			nameValueCollection["channel"] = encryption.encrypt(channelname, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			return response_structure.success;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0000B930 File Offset: 0x00009B30
		public bool checkblack()
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("checkblacklist"));
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			return response_structure.success;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000BA3C File Offset: 0x00009C3C
		public string webhook(string webid, string param, string body = "", string conttype = "")
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("webhook"));
			nameValueCollection["webid"] = encryption.encrypt(webid, this.enckey, text);
			nameValueCollection["params"] = encryption.encrypt(param, this.enckey, text);
			nameValueCollection["body"] = encryption.encrypt(body, this.enckey, text);
			nameValueCollection["conttype"] = encryption.encrypt(conttype, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				return response_structure.response;
			}
			return null;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0000BB84 File Offset: 0x00009D84
		public byte[] download(string fileid)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("file"));
			nameValueCollection["fileid"] = encryption.encrypt(fileid, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				return encryption.str_to_byte_arr(response_structure.contents);
			}
			return null;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0000BC88 File Offset: 0x00009E88
		public void log(string message)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("log"));
			nameValueCollection["pcuser"] = encryption.encrypt(Environment.UserName, this.enckey, text);
			nameValueCollection["message"] = encryption.encrypt(message, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			api.req(nameValueCollection);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0000BD70 File Offset: 0x00009F70
		public static string checksum(string filename)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				using (FileStream fileStream = File.OpenRead(filename))
				{
					result = BitConverter.ToString(md.ComputeHash(fileStream)).Replace("-", "").ToLowerInvariant();
				}
			}
			return result;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0000BDE0 File Offset: 0x00009FE0
		public static void error(string message)
		{
			Process.Start(new ProcessStartInfo("cmd.exe", "/c start cmd /C \"color b && title Error && echo " + message + " && timeout /t 5\"")
			{
				CreateNoWindow = true,
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				UseShellExecute = false
			});
			Environment.Exit(0);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000BE30 File Offset: 0x0000A030
		private static string req(NameValueCollection post_data)
		{
			string result;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					byte[] bytes = webClient.UploadValues("https://keyauth.win/api/1.0/", post_data);
					result = Encoding.Default.GetString(bytes);
				}
			}
			catch (WebException ex)
			{
				if (((HttpWebResponse)ex.Response).StatusCode == (HttpStatusCode)429)
				{
					api.error("You're connecting too fast to loader, slow down.");
					Environment.Exit(0);
					result = "";
				}
				else
				{
					api.error("Connection failure. Please try again, or contact us for help.");
					Environment.Exit(0);
					result = "";
				}
			}
			return result;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0000BECC File Offset: 0x0000A0CC
		private void load_app_data(api.app_data_structure data)
		{
			this.app_data.numUsers = data.numUsers;
			this.app_data.numOnlineUsers = data.numOnlineUsers;
			this.app_data.numKeys = data.numKeys;
			this.app_data.version = data.version;
			this.app_data.customerPanelLink = data.customerPanelLink;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0000BF30 File Offset: 0x0000A130
		private void load_user_data(api.user_data_structure data)
		{
			this.user_data.username = data.username;
			this.user_data.ip = data.ip;
			this.user_data.hwid = data.hwid;
			this.user_data.createdate = data.createdate;
			this.user_data.lastlogin = data.lastlogin;
			this.user_data.subscriptions = data.subscriptions;
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000BFA4 File Offset: 0x0000A1A4
		public string expirydaysleft()
		{
			this.Checkinit();
			DateTime d = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			d = d.AddSeconds((double)long.Parse(this.user_data.subscriptions[0].expiry)).ToLocalTime();
			TimeSpan timeSpan = d - DateTime.Now;
			return Convert.ToString(timeSpan.Days.ToString() + " Days " + timeSpan.Hours.ToString() + " Hours Left");
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000C034 File Offset: 0x0000A234
		private void load_response_struct(api.response_structure data)
		{
			this.response.success = data.success;
			this.response.message = data.message;
		}

		// Token: 0x040002BB RID: 699
		public string name;

		// Token: 0x040002BC RID: 700
		public string ownerid;

		// Token: 0x040002BD RID: 701
		public string secret;

		// Token: 0x040002BE RID: 702
		public string version;

		// Token: 0x040002BF RID: 703
		private string sessionid;

		// Token: 0x040002C0 RID: 704
		private string enckey;

		// Token: 0x040002C1 RID: 705
		private bool initzalized;

		// Token: 0x040002C2 RID: 706
		public api.app_data_class app_data = new api.app_data_class();

		// Token: 0x040002C3 RID: 707
		public api.user_data_class user_data = new api.user_data_class();

		// Token: 0x040002C4 RID: 708
		public api.response_class response = new api.response_class();

		// Token: 0x040002C5 RID: 709
		private json_wrapper response_decoder = new json_wrapper(new api.response_structure());

		// Token: 0x0200005B RID: 91
		[DataContract]
		private class response_structure
		{
			// Token: 0x1700000F RID: 15
			// (get) Token: 0x0600029D RID: 669 RVA: 0x0000C058 File Offset: 0x0000A258
			// (set) Token: 0x0600029E RID: 670 RVA: 0x0000C060 File Offset: 0x0000A260
			[DataMember]
			public bool success { get; set; }

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x0600029F RID: 671 RVA: 0x0000C069 File Offset: 0x0000A269
			// (set) Token: 0x060002A0 RID: 672 RVA: 0x0000C071 File Offset: 0x0000A271
			[DataMember]
			public string sessionid { get; set; }

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x060002A1 RID: 673 RVA: 0x0000C07A File Offset: 0x0000A27A
			// (set) Token: 0x060002A2 RID: 674 RVA: 0x0000C082 File Offset: 0x0000A282
			[DataMember]
			public string contents { get; set; }

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x060002A3 RID: 675 RVA: 0x0000C08B File Offset: 0x0000A28B
			// (set) Token: 0x060002A4 RID: 676 RVA: 0x0000C093 File Offset: 0x0000A293
			[DataMember]
			public string response { get; set; }

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x060002A5 RID: 677 RVA: 0x0000C09C File Offset: 0x0000A29C
			// (set) Token: 0x060002A6 RID: 678 RVA: 0x0000C0A4 File Offset: 0x0000A2A4
			[DataMember]
			public string message { get; set; }

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x060002A7 RID: 679 RVA: 0x0000C0AD File Offset: 0x0000A2AD
			// (set) Token: 0x060002A8 RID: 680 RVA: 0x0000C0B5 File Offset: 0x0000A2B5
			[DataMember]
			public string download { get; set; }

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x060002A9 RID: 681 RVA: 0x0000C0BE File Offset: 0x0000A2BE
			// (set) Token: 0x060002AA RID: 682 RVA: 0x0000C0C6 File Offset: 0x0000A2C6
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.user_data_structure info { get; set; }

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x060002AB RID: 683 RVA: 0x0000C0CF File Offset: 0x0000A2CF
			// (set) Token: 0x060002AC RID: 684 RVA: 0x0000C0D7 File Offset: 0x0000A2D7
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.app_data_structure appinfo { get; set; }

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x060002AD RID: 685 RVA: 0x0000C0E0 File Offset: 0x0000A2E0
			// (set) Token: 0x060002AE RID: 686 RVA: 0x0000C0E8 File Offset: 0x0000A2E8
			[DataMember]
			public List<api.msg> messages { get; set; }
		}

		// Token: 0x0200005C RID: 92
		public class msg
		{
			// Token: 0x17000018 RID: 24
			// (get) Token: 0x060002B0 RID: 688 RVA: 0x0000C0F1 File Offset: 0x0000A2F1
			// (set) Token: 0x060002B1 RID: 689 RVA: 0x0000C0F9 File Offset: 0x0000A2F9
			public string message { get; set; }

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x060002B2 RID: 690 RVA: 0x0000C102 File Offset: 0x0000A302
			// (set) Token: 0x060002B3 RID: 691 RVA: 0x0000C10A File Offset: 0x0000A30A
			public string author { get; set; }

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x060002B4 RID: 692 RVA: 0x0000C113 File Offset: 0x0000A313
			// (set) Token: 0x060002B5 RID: 693 RVA: 0x0000C11B File Offset: 0x0000A31B
			public string timestamp { get; set; }
		}

		// Token: 0x0200005D RID: 93
		[DataContract]
		private class user_data_structure
		{
			// Token: 0x1700001B RID: 27
			// (get) Token: 0x060002B7 RID: 695 RVA: 0x0000C124 File Offset: 0x0000A324
			// (set) Token: 0x060002B8 RID: 696 RVA: 0x0000C12C File Offset: 0x0000A32C
			[DataMember]
			public string username { get; set; }

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x060002B9 RID: 697 RVA: 0x0000C135 File Offset: 0x0000A335
			// (set) Token: 0x060002BA RID: 698 RVA: 0x0000C13D File Offset: 0x0000A33D
			[DataMember]
			public string ip { get; set; }

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x060002BB RID: 699 RVA: 0x0000C146 File Offset: 0x0000A346
			// (set) Token: 0x060002BC RID: 700 RVA: 0x0000C14E File Offset: 0x0000A34E
			[DataMember]
			public string hwid { get; set; }

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x060002BD RID: 701 RVA: 0x0000C157 File Offset: 0x0000A357
			// (set) Token: 0x060002BE RID: 702 RVA: 0x0000C15F File Offset: 0x0000A35F
			[DataMember]
			public string createdate { get; set; }

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x060002BF RID: 703 RVA: 0x0000C168 File Offset: 0x0000A368
			// (set) Token: 0x060002C0 RID: 704 RVA: 0x0000C170 File Offset: 0x0000A370
			[DataMember]
			public string lastlogin { get; set; }

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x060002C1 RID: 705 RVA: 0x0000C179 File Offset: 0x0000A379
			// (set) Token: 0x060002C2 RID: 706 RVA: 0x0000C181 File Offset: 0x0000A381
			[DataMember]
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x0200005E RID: 94
		[DataContract]
		private class app_data_structure
		{
			// Token: 0x17000021 RID: 33
			// (get) Token: 0x060002C4 RID: 708 RVA: 0x0000C18A File Offset: 0x0000A38A
			// (set) Token: 0x060002C5 RID: 709 RVA: 0x0000C192 File Offset: 0x0000A392
			[DataMember]
			public string numUsers { get; set; }

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x060002C6 RID: 710 RVA: 0x0000C19B File Offset: 0x0000A39B
			// (set) Token: 0x060002C7 RID: 711 RVA: 0x0000C1A3 File Offset: 0x0000A3A3
			[DataMember]
			public string numOnlineUsers { get; set; }

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x060002C8 RID: 712 RVA: 0x0000C1AC File Offset: 0x0000A3AC
			// (set) Token: 0x060002C9 RID: 713 RVA: 0x0000C1B4 File Offset: 0x0000A3B4
			[DataMember]
			public string numKeys { get; set; }

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x060002CA RID: 714 RVA: 0x0000C1BD File Offset: 0x0000A3BD
			// (set) Token: 0x060002CB RID: 715 RVA: 0x0000C1C5 File Offset: 0x0000A3C5
			[DataMember]
			public string version { get; set; }

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x060002CC RID: 716 RVA: 0x0000C1CE File Offset: 0x0000A3CE
			// (set) Token: 0x060002CD RID: 717 RVA: 0x0000C1D6 File Offset: 0x0000A3D6
			[DataMember]
			public string customerPanelLink { get; set; }

			// Token: 0x17000026 RID: 38
			// (get) Token: 0x060002CE RID: 718 RVA: 0x0000C1DF File Offset: 0x0000A3DF
			// (set) Token: 0x060002CF RID: 719 RVA: 0x0000C1E7 File Offset: 0x0000A3E7
			[DataMember]
			public string downloadLink { get; set; }
		}

		// Token: 0x0200005F RID: 95
		public class app_data_class
		{
			// Token: 0x17000027 RID: 39
			// (get) Token: 0x060002D1 RID: 721 RVA: 0x0000C1F0 File Offset: 0x0000A3F0
			// (set) Token: 0x060002D2 RID: 722 RVA: 0x0000C1F8 File Offset: 0x0000A3F8
			public string numUsers { get; set; }

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x060002D3 RID: 723 RVA: 0x0000C201 File Offset: 0x0000A401
			// (set) Token: 0x060002D4 RID: 724 RVA: 0x0000C209 File Offset: 0x0000A409
			public string numOnlineUsers { get; set; }

			// Token: 0x17000029 RID: 41
			// (get) Token: 0x060002D5 RID: 725 RVA: 0x0000C212 File Offset: 0x0000A412
			// (set) Token: 0x060002D6 RID: 726 RVA: 0x0000C21A File Offset: 0x0000A41A
			public string numKeys { get; set; }

			// Token: 0x1700002A RID: 42
			// (get) Token: 0x060002D7 RID: 727 RVA: 0x0000C223 File Offset: 0x0000A423
			// (set) Token: 0x060002D8 RID: 728 RVA: 0x0000C22B File Offset: 0x0000A42B
			public string version { get; set; }

			// Token: 0x1700002B RID: 43
			// (get) Token: 0x060002D9 RID: 729 RVA: 0x0000C234 File Offset: 0x0000A434
			// (set) Token: 0x060002DA RID: 730 RVA: 0x0000C23C File Offset: 0x0000A43C
			public string customerPanelLink { get; set; }

			// Token: 0x1700002C RID: 44
			// (get) Token: 0x060002DB RID: 731 RVA: 0x0000C245 File Offset: 0x0000A445
			// (set) Token: 0x060002DC RID: 732 RVA: 0x0000C24D File Offset: 0x0000A44D
			public string downloadLink { get; set; }
		}

		// Token: 0x02000060 RID: 96
		public class user_data_class
		{
			// Token: 0x1700002D RID: 45
			// (get) Token: 0x060002DE RID: 734 RVA: 0x0000C256 File Offset: 0x0000A456
			// (set) Token: 0x060002DF RID: 735 RVA: 0x0000C25E File Offset: 0x0000A45E
			public string username { get; set; }

			// Token: 0x1700002E RID: 46
			// (get) Token: 0x060002E0 RID: 736 RVA: 0x0000C267 File Offset: 0x0000A467
			// (set) Token: 0x060002E1 RID: 737 RVA: 0x0000C26F File Offset: 0x0000A46F
			public string ip { get; set; }

			// Token: 0x1700002F RID: 47
			// (get) Token: 0x060002E2 RID: 738 RVA: 0x0000C278 File Offset: 0x0000A478
			// (set) Token: 0x060002E3 RID: 739 RVA: 0x0000C280 File Offset: 0x0000A480
			public string hwid { get; set; }

			// Token: 0x17000030 RID: 48
			// (get) Token: 0x060002E4 RID: 740 RVA: 0x0000C289 File Offset: 0x0000A489
			// (set) Token: 0x060002E5 RID: 741 RVA: 0x0000C291 File Offset: 0x0000A491
			public string createdate { get; set; }

			// Token: 0x17000031 RID: 49
			// (get) Token: 0x060002E6 RID: 742 RVA: 0x0000C29A File Offset: 0x0000A49A
			// (set) Token: 0x060002E7 RID: 743 RVA: 0x0000C2A2 File Offset: 0x0000A4A2
			public string lastlogin { get; set; }

			// Token: 0x17000032 RID: 50
			// (get) Token: 0x060002E8 RID: 744 RVA: 0x0000C2AB File Offset: 0x0000A4AB
			// (set) Token: 0x060002E9 RID: 745 RVA: 0x0000C2B3 File Offset: 0x0000A4B3
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x02000061 RID: 97
		public class Data
		{
			// Token: 0x17000033 RID: 51
			// (get) Token: 0x060002EB RID: 747 RVA: 0x0000C2BC File Offset: 0x0000A4BC
			// (set) Token: 0x060002EC RID: 748 RVA: 0x0000C2C4 File Offset: 0x0000A4C4
			public string subscription { get; set; }

			// Token: 0x17000034 RID: 52
			// (get) Token: 0x060002ED RID: 749 RVA: 0x0000C2CD File Offset: 0x0000A4CD
			// (set) Token: 0x060002EE RID: 750 RVA: 0x0000C2D5 File Offset: 0x0000A4D5
			public string expiry { get; set; }

			// Token: 0x17000035 RID: 53
			// (get) Token: 0x060002EF RID: 751 RVA: 0x0000C2DE File Offset: 0x0000A4DE
			// (set) Token: 0x060002F0 RID: 752 RVA: 0x0000C2E6 File Offset: 0x0000A4E6
			public string timeleft { get; set; }
		}

		// Token: 0x02000062 RID: 98
		public class response_class
		{
			// Token: 0x17000036 RID: 54
			// (get) Token: 0x060002F2 RID: 754 RVA: 0x0000C2EF File Offset: 0x0000A4EF
			// (set) Token: 0x060002F3 RID: 755 RVA: 0x0000C2F7 File Offset: 0x0000A4F7
			public bool success { get; set; }

			// Token: 0x17000037 RID: 55
			// (get) Token: 0x060002F4 RID: 756 RVA: 0x0000C300 File Offset: 0x0000A500
			// (set) Token: 0x060002F5 RID: 757 RVA: 0x0000C308 File Offset: 0x0000A508
			public string message { get; set; }
		}
	}
}
