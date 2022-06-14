using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace unlockervip.Properties
{
	// Token: 0x02000069 RID: 105
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.1.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600031E RID: 798 RVA: 0x0000E7B6 File Offset: 0x0000C9B6
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600031F RID: 799 RVA: 0x0000E7BD File Offset: 0x0000C9BD
		// (set) Token: 0x06000320 RID: 800 RVA: 0x0000E7CF File Offset: 0x0000C9CF
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Key
		{
			get
			{
				return (string)this["Key"];
			}
			set
			{
				this["Key"] = value;
			}
		}

		// Token: 0x04000318 RID: 792
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
